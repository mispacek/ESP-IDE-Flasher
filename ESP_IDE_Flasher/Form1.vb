Imports System.IO
Imports System.Text
Imports System.Net
Imports System.Text.RegularExpressions

Public Class Form1
    Dim tool_filename As String = "esptool.exe"
    Dim flash_process
    Dim dictionary As New Dictionary(Of String, String)


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            System.IO.File.WriteAllBytes(tool_filename, My.Resources.esptool)
        Catch ex As Exception
            StatusLabel1.Text = "Problém s uložením ESPTOOL.exe na disk"
            StatusLabel1.Refresh()
        End Try


        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            com_select.Items.Add(sp)
            com_select.Text = sp
        Next

        StatusLabel1.Text = "Načítám dostupné verze"

        Try
            Dim address As String = "http://iotserver.cz/ide/flash/variants.txt"
            Dim client As WebClient = New WebClient()
            Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
            TextBox1.Text = reader.ReadToEnd

            Dim num As Integer = 0

            num = TextBox1.Text.Split(";").Length
            ProgressBar1.Maximum = num


            For i = 0 To num - 2 Step 2
                dictionary.Add((TextBox1.Text.Split(";")(i)).Trim, (TextBox1.Text.Split(";")(i + 1)).Trim)
                ComboBox1.Items.Add(TextBox1.Text.Split(";")(i))
                ComboBox1.Text = TextBox1.Text.Split(";")(i)
                ProgressBar1.Value = i
                ProgressBar1.Refresh()
                StatusLabel1.Text = "Načítám dostupné verze:" & TextBox1.Text.Split(";")(i)
                StatusLabel1.Refresh()
            Next

            ProgressBar1.Value = num
            ProgressBar1.Refresh()
            StatusLabel1.Text = "Online seznam dostupných verzí aktualizován"
            StatusLabel1.Refresh()
            TextBox1.Text = ""

        Catch ex As Exception
            ComboBox1.Text = "Chyba při načítání online verzí"
        End Try

    End Sub


    Private Sub Flash_image_to_ESP(ByVal filename As String)
        REM Pokus o smazání FLASH paměti
        Try

            MsgBox("Pokud má deska tlačítko BOOT, nyní je pořeba ho stisknout a držet, provést reset desky a stále držet tlačítko boot, dokud se flashování nedokončí.", MsgBoxStyle.Information)

            Me.Height = 654

            StatusLabel1.Text = "Mazání FLASH paměti"
            StatusLabel1.Refresh()

            For i = 0 To 5
                Threading.Thread.Sleep(500)
                Application.DoEvents()
            Next

            Dim erase_process As New Process

            erase_process.StartInfo.FileName = tool_filename
            erase_process.StartInfo.Arguments = "--port " & com_select.Text & " --baud " & Baudrate_combo.Text & " erase_flash"
            erase_process.StartInfo.RedirectStandardOutput = True
            erase_process.StartInfo.RedirectStandardError = True
            erase_process.StartInfo.UseShellExecute = False
            erase_process.StartInfo.CreateNoWindow = True

            erase_process = Process.Start(erase_process.StartInfo)

            TextBox1.Text = ""

            ProgressBar1.Value = 20
            ProgressBar1.Refresh()

            While Not erase_process.StandardOutput.EndOfStream
                TextBox1.Text = TextBox1.Text & Chr(erase_process.StandardOutput.Read)
                TextBox1.Refresh()
                TextBox1.SelectionStart = TextBox1.Text.Length
                TextBox1.ScrollToCaret()
                My.Application.DoEvents()
            End While

            Me.Update()
            Me.Refresh()
            My.Application.DoEvents()


            erase_process.WaitForExit()

            ProgressBar1.Value = 30
            ProgressBar1.Refresh()





            REM Pokud se podařilo smazat paměť - Pokračovat ve flashování
            If TextBox1.Text.Contains("Chip erase completed successfully") Then

                StatusLabel1.Text = "Mazání proběhlo úspěšně"
                StatusLabel1.Refresh()


                Dim flash_write_process As New Process

                flash_write_process.StartInfo.FileName = tool_filename
                flash_write_process.StartInfo.Arguments = "--port " & com_select.Text & " --baud " & Baudrate_combo.Text & " write_flash 0x0000 " & ControlChars.Quote & filename & ControlChars.Quote
                flash_write_process.StartInfo.RedirectStandardOutput = True
                flash_write_process.StartInfo.RedirectStandardError = True
                flash_write_process.StartInfo.UseShellExecute = False
                flash_write_process.StartInfo.CreateNoWindow = True

                flash_write_process = Process.Start(flash_write_process.StartInfo)

                TextBox1.Text = ""

                While Not flash_write_process.StandardOutput.EndOfStream
                    TextBox1.Text = TextBox1.Text & flash_write_process.StandardOutput.ReadLine & vbNewLine
                    TextBox1.Refresh()
                    TextBox1.SelectionStart = TextBox1.Text.Length
                    TextBox1.ScrollToCaret()
                    Me.Update()
                    Me.Refresh()
                    My.Application.DoEvents()

                    Try
                        Dim procenta As String
                        If TextBox1.Text.Length > 300 Then
                            procenta = TextBox1.Text.Substring(TextBox1.Text.Length - 10)
                            Console.WriteLine(procenta)

                            Dim i As Integer = procenta.IndexOf("(")
                            Dim f As String = procenta.Substring(i + 1, procenta.IndexOf(")", i + 1) - i - 1)
                            StatusLabel1.Text = "Nahrávání programu " & f
                            StatusLabel1.Refresh()


                            ProgressBar1.Value = Integer.Parse(Regex.Replace(f, "[^\d]", "")) + 30
                            ProgressBar1.Refresh()

                        End If
                    Catch ex As Exception
                    End Try

                End While

                flash_write_process.WaitForExit()

                StatusLabel1.Text = "Nahrávání programu dokončeno"
                StatusLabel1.Refresh()
                ProgressBar1.Value = 150
                ProgressBar1.Refresh()


                Dim result As DialogResult = MessageBox.Show("Flashování proběhlo úspěšně.Přejete si nastavit WIFI, název desky a Piny pro připojení OLED displaye?", "Pokračovat v nastavení desky?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then
                    nastaveni.com_port.Text = com_select.Text
                    nastaveni.ShowDialog()
                End If



            Else
                MsgBox("Nastal problém při mazání paměti!" & vbNewLine & "Mazání paměti neproběhlo úspěšně.", MsgBoxStyle.Exclamation)
                StatusLabel1.Text = "Nastal problém při mazání paměti!"
                StatusLabel1.Refresh()

            End If

        Catch ex As Exception
            StatusLabel1.Text = "Nastal problém při flashovani desky"
            StatusLabel1.Refresh()
            ProgressBar1.Value = 0
            ProgressBar1.Refresh()
        End Try

    End Sub




    Private Sub DownloadButton1_Click(sender As Object, e As EventArgs) Handles DownloadButton1.Click
        ProgressBar1.Maximum = 150
        ProgressBar1.Value = 0
        ProgressBar1.Refresh()

        REM Stahování souboru
        Try

            StatusLabel1.Text = "Stahuji soubor " & dictionary(ComboBox1.Text.Trim)
            StatusLabel1.Refresh()

            My.Computer.Network.DownloadFile("http://iotserver.cz/ide/flash/" & dictionary(ComboBox1.Text.Trim), dictionary(ComboBox1.Text.Trim), String.Empty, String.Empty, True, 300000, True)

            StatusLabel1.Text = "Soubor " & dictionary(ComboBox1.Text.Trim) & " byl úspěšně stažen"
            StatusLabel1.Refresh()

            ProgressBar1.Value = 10
            ProgressBar1.Refresh()

            Flash_image_to_ESP(dictionary(ComboBox1.Text.Trim))

        Catch ex As Exception
            StatusLabel1.Text = "Chyba při stahování zvolené verze"
            StatusLabel1.Refresh()
        End Try


    End Sub

    Private Sub FlashLocalButton2_Click(sender As Object, e As EventArgs) Handles FlashLocalButton2.Click

        ProgressBar1.Maximum = 150
        ProgressBar1.Value = 0
        ProgressBar1.Refresh()

        OpenFileDialog1.Title = "Zvolte firmware který chcete nahrát"
        OpenFileDialog1.InitialDirectory = ""
        OpenFileDialog1.Filter = "image|*.img|bin|*.bin|Všechny soubory|*.*"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Do things here, the path is stored in openFileDialog1.Filename
            'If no files were selected, openFileDialog1.Filename is "" 
            If OpenFileDialog1.FileName.Length > 4 Then
                Console.WriteLine(OpenFileDialog1.FileName)

                ProgressBar1.Maximum = 150
                ProgressBar1.Value = 20
                ProgressBar1.Refresh()

                Flash_image_to_ESP(OpenFileDialog1.FileName)
            End If


        End If


    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles Refresh_btn.Click
        com_select.Items.Clear()

        For Each sp As String In My.Computer.Ports.SerialPortNames
            com_select.Items.Add(sp)
            com_select.Text = sp
        Next
    End Sub


    Private Sub Open_config_Click(sender As Object, e As EventArgs) Handles Open_config.Click
        nastaveni.com_port.Text = com_select.Text
        nastaveni.Show()
    End Sub
End Class
