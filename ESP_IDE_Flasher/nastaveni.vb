Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Text.RegularExpressions

Public Class nastaveni

    Dim corrected As Integer = 0
    Dim err As Integer = 0

    Public Sub Nastav_status(ByVal status As String, progresbar_val As Integer)
        ProgressBar1.Value = progresbar_val
        ProgressBar1.Refresh()
        StatusLabel1.Text = status
        StatusLabel1.Refresh()
        Application.DoEvents()
    End Sub


    Public Function Correct_chars(ByVal Text As String) As String
        Dim out As String = ""

        Dim Diakritika As String = " ÀÁÂÃÄÅÇÈÉÊËÌÍÎÏÑÒÓÔÕÖÙÚÛÜÝßàáâãäåçèéêëìíîïñòóôõöùúûüýÿĀāĂăĄąĆćĈĉĊċČčĎďĐđĒēĔĕĖėĘęĚěĜĝĞğĠġĢģĤĥĦħĨĩĪīĬĭĮįİıĶķĸĹĺĻļĽľĿŀŁłŃńŅņŇňŉŊŋŌōŎŏŐőŔŕŖŗŘřŚśŜŝŞşŠšŢţŤťŦŧŨũŪūŬŭŮůŰűŲųŴŵŶŷŸŹźŻżŽžſ".ToCharArray()
        Dim neDiakritika As String = "_AAAAAACEEEEIIIINOOOOOUUUUYsaaaaaaceeeeiiiinooooouuuuyyAaAaAaCcCcCcCcDdDdEeEeEeEeEeGgGgGgGgHhHhIiIiIiIiIiKkkLlLlLlLlLlNnNnNnNnNOoOoOoRrRrRrSsSsSsSsTtTtTtUuUuUuUuUuUuWwYyYZzZzZzs".ToCharArray()

        For Each c As Char In Text
            If (Diakritika.Contains(c)) Then
                out = out & neDiakritika(Diakritika.IndexOf(c))
                corrected += 1
            Else
                out = out & c
            End If
        Next

        Return out
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        corrected = 0
        err = -1

        hostname.Text = Correct_chars(hostname.Text)

        ssid1.Text = Correct_chars(ssid1.Text)
        ssid2.Text = Correct_chars(ssid2.Text)
        ssid3.Text = Correct_chars(ssid3.Text)
        ssid4.Text = Correct_chars(ssid4.Text)

        pass1.Text = Correct_chars(pass1.Text)
        pass2.Text = Correct_chars(pass2.Text)
        pass3.Text = Correct_chars(pass3.Text)
        pass4.Text = Correct_chars(pass4.Text)

        If IsNumeric(sda.Text) = False Then
            corrected += 1
            MsgBox("Pin pro SDA není číslo.", MsgBoxStyle.Information)
        End If

        If IsNumeric(scl.Text) = False Then
            corrected += 1
            MsgBox("Pin pro SCL není číslo.", MsgBoxStyle.Information)
        End If





        If corrected > 0 Then
            MsgBox("Některá pole obsahují nepovolené znaky, které byli automaticky opraveny, zkontrolujte jejich správnost a operaci opakujte", MsgBoxStyle.Information)
        Else


            MsgBox("Nyní můžete přestat držet tlačítko BOOT. Proveďte reset desky a počkejte dokud se nastavení nedokončí.", MsgBoxStyle.Information)


            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter("last_config.cfg", False)

            file.Write(hostname.Text & ";")

            file.Write(ssid1.Text & ";")
            file.Write(pass1.Text & ";")

            file.Write(ssid2.Text & ";")
            file.Write(pass2.Text & ";")


            file.Write(ssid3.Text & ";")
            file.Write(pass3.Text & ";")

            file.Write(ssid4.Text & ";")
            file.Write(pass4.Text & ";")

            file.Write(sda.Text & ";")
            file.Write(scl.Text & ";")

            file.Write("#")
            file.Close()


            Nastav_status("Otevírám sériový port", 0)


            For i = 0 To 20
                Try
                    SerialPort1.PortName = com_port.Text
                    SerialPort1.Open()
                    err = 0
                    Nastav_status("Sériový port otevřen", 0)
                    Exit For
                Catch ex As Exception
                    Threading.Thread.Sleep(500)
                End Try
            Next


            

            If err = 0 Then

                ProgressBar1.Maximum = 9

                Nastav_status("Čekám na odpověď od desky", 0)

                TextBox1.Text = ""

                Dim in_data As String


                For i = 0 To 4
                    Threading.Thread.Sleep(500)
                    Application.DoEvents()
                    TextBox1.Text = TextBox1.Text & SerialPort1.ReadExisting
                Next

                For i = 0 To 20

                    TextBox1.Text = TextBox1.Text & SerialPort1.ReadExisting
                    REM SerialPort1.DiscardInBuffer()

                    Try
                        SerialPort1.Write(vbNewLine)
                        Nastav_status("Odpověď přijata", 0)
                    Catch ex As Exception
                        Nastav_status("Deska neodpovídá", 0)
                    End Try

                    Threading.Thread.Sleep(2000)

                    in_data = SerialPort1.ReadExisting
                    TextBox1.Text = TextBox1.Text & in_data

                    TextBox1.Refresh()
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()

                    If TextBox1.Text.EndsWith(">>> " & vbNewLine & ">>> " & vbNewLine & ">>> ") Then
                        Nastav_status("Deska připravena", 1)
                        Exit For
                    End If
                Next





                Threading.Thread.Sleep(500)

                Nastav_status("Ukládám nastavení wifi", 2)

                SerialPort1.Write("f = open('wifi.cfg', 'w')" & vbNewLine)

                If ssid1.Text.Length > 1 And pass1.Text.Length > 1 Then
                    SerialPort1.Write("f.write('" & ssid1.Text & ";" & pass1.Text & "\r')" & vbNewLine)
                End If

                If ssid2.Text.Length > 1 And pass2.Text.Length > 1 Then
                    SerialPort1.Write("f.write('" & ssid2.Text & ";" & pass2.Text & "\r')" & vbNewLine)
                End If

                If ssid3.Text.Length > 1 And pass3.Text.Length > 1 Then
                    SerialPort1.Write("f.write('" & ssid3.Text & ";" & pass3.Text & "\r')" & vbNewLine)
                End If

                If ssid4.Text.Length > 1 And pass4.Text.Length > 1 Then
                    SerialPort1.Write("f.write('" & ssid4.Text & ";" & pass4.Text & "\r')" & vbNewLine)
                End If

                SerialPort1.Write("f.close()" & vbNewLine)



                Threading.Thread.Sleep(1500)

                in_data = SerialPort1.ReadExisting
                TextBox1.Text = TextBox1.Text & in_data

                Nastav_status("Nastavení wifi uloženo", 3)





                If hostname.Text.Length > 1 Then
                    For i = 0 To 5
                        TextBox1.Text = TextBox1.Text & SerialPort1.ReadExisting
                        REM SerialPort1.DiscardInBuffer()

                        SerialPort1.Write(vbNewLine)
                        Threading.Thread.Sleep(1000)

                        in_data = SerialPort1.ReadExisting
                        TextBox1.Text = TextBox1.Text & in_data

                        Nastav_status(StatusLabel1.Text & ".", 3)

                        TextBox1.Refresh()
                        TextBox1.SelectionStart = TextBox1.Text.Length
                        TextBox1.ScrollToCaret()

                        If in_data.Contains(">>>") Then
                            Nastav_status("Ukládám nastavení názvu desky", 4)
                            Exit For
                        End If
                    Next

                    SerialPort1.Write("f = open('hostname.cfg', 'w')" & vbNewLine)
                    SerialPort1.Write("f.write('" & hostname.Text & "')" & vbNewLine)
                    SerialPort1.Write("f.close()" & vbNewLine)

                    Threading.Thread.Sleep(1500)

                    in_data = SerialPort1.ReadExisting
                    TextBox1.Text = TextBox1.Text & in_data

                    TextBox1.Refresh()
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()

                    Nastav_status("Název desky uložen", 4)
                Else
                    Nastav_status("Hostname nebyl zadán, vynechávám úlohu", 4)
                End If







                If sda.Text.Length > 0 And scl.Text.Length > 0 Then
                    For i = 0 To 5
                        TextBox1.Text = TextBox1.Text & SerialPort1.ReadExisting

                        SerialPort1.Write(vbNewLine)
                        Threading.Thread.Sleep(1000)

                        in_data = SerialPort1.ReadExisting
                        TextBox1.Text = TextBox1.Text & in_data

                        Nastav_status("Čekání na odpověď desky", 5)

                        TextBox1.Refresh()
                        TextBox1.SelectionStart = TextBox1.Text.Length
                        TextBox1.ScrollToCaret()

                        If in_data.Contains(">>>") Then
                            Nastav_status("Ukládám nastavení I2C pro OLED", 6)
                            Exit For
                        End If
                    Next

                    SerialPort1.Write("f = open('oled.cfg', 'w')" & vbNewLine)
                    SerialPort1.Write("f.write('OLED_SDA=" & sda.Text & "\rOLED_SCL=" & scl.Text & "\r')" & vbNewLine)
                    SerialPort1.Write("f.close()" & vbNewLine)

                    Threading.Thread.Sleep(1500)

                    in_data = SerialPort1.ReadExisting
                    TextBox1.Text = TextBox1.Text & in_data

                    TextBox1.Refresh()
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()

                    Nastav_status("Konfigurace OLED uložena", 7)
                Else
                    Nastav_status("Konfigurace OLED nebyla specifikována", 7)
                End If

                Nastav_status("Restartuji desku", 8)
                SerialPort1.Write("reset()" & vbNewLine)
                Threading.Thread.Sleep(2000)


                For i = 0 To 15
                    TextBox1.Text = TextBox1.Text & SerialPort1.ReadExisting
                    REM SerialPort1.DiscardInBuffer()

                    SerialPort1.Write(vbNewLine)
                    Threading.Thread.Sleep(2000)

                    in_data = SerialPort1.ReadExisting
                    TextBox1.Text = TextBox1.Text & in_data

                    TextBox1.Refresh()
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()

                    If in_data.Contains(">>>") Then
                        Nastav_status("Nastavení desky úspěšně dokončeno", 9)
                        MsgBox("Nastavení desky bylo úspěšně uloženo.", MsgBoxStyle.Information)
                        Exit For
                    End If
                Next


                SerialPort1.Close()

            Else
                MsgBox("Nepodařilo se otevřít sériový port " & com_port.Text & ".", MsgBoxStyle.Information)
            End If

        End If


    End Sub

    Private Sub nastaveni_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ESP_IDE_Flasher.Form1.Show()
        ESP_IDE_Flasher.Form1.BringToFront()
    End Sub

    Private Sub nastaveni_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ESP_IDE_Flasher.Form1.Show()
        ESP_IDE_Flasher.Form1.BringToFront()
    End Sub

    Private Sub nastaveni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText("last_config.cfg")

            If fileReader.Split(";")(11) = "#" Then
                Nastav_status("Načtení nastavení proběhlo úspěšně.", 0)
                REM MsgBox("Obnovení posledního nastavení proběhlo úspěšně.", MsgBoxStyle.Information)

                hostname.Text = fileReader.Split(";")(0)

                ssid1.Text = fileReader.Split(";")(1)
                pass1.Text = fileReader.Split(";")(2)

                ssid2.Text = fileReader.Split(";")(3)
                pass2.Text = fileReader.Split(";")(4)

                ssid3.Text = fileReader.Split(";")(5)
                pass3.Text = fileReader.Split(";")(6)

                ssid4.Text = fileReader.Split(";")(7)
                pass4.Text = fileReader.Split(";")(8)

                sda.Text = fileReader.Split(";")(9)
                scl.Text = fileReader.Split(";")(10)

            End If

        Catch ex As Exception
            Nastav_status("Chyba obnovení posledního nastavení.", 0)
        End Try

    End Sub

    Private Sub open_cfg_Click(sender As Object, e As EventArgs) Handles open_cfg.Click

        OpenFileDialog1.Title = "Zvolte soubor s nastavením"
        OpenFileDialog1.InitialDirectory = ""
        OpenFileDialog1.Filter = "nsatavení|*.cfg"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Do things here, the path is stored in openFileDialog1.Filename
            'If no files were selected, openFileDialog1.Filename is "" 
            If OpenFileDialog1.FileName.Length > 4 Then

                Try
                    Dim fileReader As String
                    fileReader = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

                    If fileReader.Split(";")(11) = "#" Then

                        REM MsgBox("Obnovení posledního nastavení proběhlo úspěšně.", MsgBoxStyle.Information)

                        hostname.Text = fileReader.Split(";")(0)

                        ssid1.Text = fileReader.Split(";")(1)
                        pass1.Text = fileReader.Split(";")(2)

                        ssid2.Text = fileReader.Split(";")(3)
                        pass2.Text = fileReader.Split(";")(4)

                        ssid3.Text = fileReader.Split(";")(5)
                        pass3.Text = fileReader.Split(";")(6)

                        ssid4.Text = fileReader.Split(";")(7)
                        pass4.Text = fileReader.Split(";")(8)

                        sda.Text = fileReader.Split(";")(9)
                        scl.Text = fileReader.Split(";")(10)

                        Nastav_status("Načtení nastavení proběhlo úspěšně.", 0)
                    End If


                Catch ex As Exception
                    Nastav_status("Chyba ńačtení nastavení.", 0)
                End Try

            End If
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()

        saveFileDialog1.Filter = "nastavení (*.cfg)|*.cfg"
        saveFileDialog1.InitialDirectory = ""

        Try
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                myStream = saveFileDialog1.OpenFile()

                Dim writer As New StreamWriter(myStream)

                writer.Write(hostname.Text & ";")

                writer.Write(ssid1.Text & ";")
                writer.Write(pass1.Text & ";")

                writer.Write(ssid2.Text & ";")
                writer.Write(pass2.Text & ";")


                writer.Write(ssid3.Text & ";")
                writer.Write(pass3.Text & ";")

                writer.Write(ssid4.Text & ";")
                writer.Write(pass4.Text & ";")

                writer.Write(sda.Text & ";")
                writer.Write(scl.Text & ";")

                writer.Write("#")
                writer.Close()

                myStream.Close()

                Nastav_status("Nastavení uloženo.", 0)
            End If

        Catch ex As Exception
            Nastav_status("Nastala chyba při uložení souboru.", 0)
        End Try
    End Sub
End Class