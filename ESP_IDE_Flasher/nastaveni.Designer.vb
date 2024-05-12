<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nastaveni
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(nastaveni))
        Me.com_port = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.StatusLabel1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ssid1 = New System.Windows.Forms.TextBox()
        Me.pass1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pass2 = New System.Windows.Forms.TextBox()
        Me.ssid2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pass3 = New System.Windows.Forms.TextBox()
        Me.ssid3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pass4 = New System.Windows.Forms.TextBox()
        Me.ssid4 = New System.Windows.Forms.TextBox()
        Me.hostname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sda = New System.Windows.Forms.TextBox()
        Me.scl = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.open_cfg = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'com_port
        '
        Me.com_port.Location = New System.Drawing.Point(3, 679)
        Me.com_port.Name = "com_port"
        Me.com_port.Size = New System.Drawing.Size(72, 20)
        Me.com_port.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1, 388)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(319, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Uložit nastavení do desky"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.ReadTimeout = 2000
        Me.SerialPort1.WriteTimeout = 2000
        '
        'StatusLabel1
        '
        Me.StatusLabel1.ForeColor = System.Drawing.Color.White
        Me.StatusLabel1.Location = New System.Drawing.Point(0, 471)
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(320, 18)
        Me.StatusLabel1.TabIndex = 23
        Me.StatusLabel1.Text = "Status"
        Me.StatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 441)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(317, 25)
        Me.ProgressBar1.TabIndex = 22
        '
        'ssid1
        '
        Me.ssid1.Location = New System.Drawing.Point(2, 155)
        Me.ssid1.Name = "ssid1"
        Me.ssid1.Size = New System.Drawing.Size(158, 20)
        Me.ssid1.TabIndex = 24
        Me.ssid1.Text = "Nazev_vasi_domaci_wifi"
        '
        'pass1
        '
        Me.pass1.Location = New System.Drawing.Point(162, 155)
        Me.pass1.Name = "pass1"
        Me.pass1.Size = New System.Drawing.Size(158, 20)
        Me.pass1.TabIndex = 25
        Me.pass1.Text = "Heslo_k_vasi_domaci_wifi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nazev wifi 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(159, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Heslo 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(159, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Heslo 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Nazev wifi 2:"
        '
        'pass2
        '
        Me.pass2.Location = New System.Drawing.Point(162, 197)
        Me.pass2.Name = "pass2"
        Me.pass2.Size = New System.Drawing.Size(158, 20)
        Me.pass2.TabIndex = 29
        '
        'ssid2
        '
        Me.ssid2.Location = New System.Drawing.Point(2, 197)
        Me.ssid2.Name = "ssid2"
        Me.ssid2.Size = New System.Drawing.Size(158, 20)
        Me.ssid2.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(159, 223)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Heslo 3:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Nazev wifi 3:"
        '
        'pass3
        '
        Me.pass3.Location = New System.Drawing.Point(162, 239)
        Me.pass3.Name = "pass3"
        Me.pass3.Size = New System.Drawing.Size(158, 20)
        Me.pass3.TabIndex = 33
        '
        'ssid3
        '
        Me.ssid3.Location = New System.Drawing.Point(2, 239)
        Me.ssid3.Name = "ssid3"
        Me.ssid3.Size = New System.Drawing.Size(158, 20)
        Me.ssid3.TabIndex = 32
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(159, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Heslo 4:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Nazev wifi 4:"
        '
        'pass4
        '
        Me.pass4.Location = New System.Drawing.Point(162, 281)
        Me.pass4.Name = "pass4"
        Me.pass4.Size = New System.Drawing.Size(158, 20)
        Me.pass4.TabIndex = 37
        '
        'ssid4
        '
        Me.ssid4.Location = New System.Drawing.Point(2, 281)
        Me.ssid4.Name = "ssid4"
        Me.ssid4.Size = New System.Drawing.Size(158, 20)
        Me.ssid4.TabIndex = 36
        '
        'hostname
        '
        Me.hostname.Location = New System.Drawing.Point(2, 79)
        Me.hostname.Name = "hostname"
        Me.hostname.Size = New System.Drawing.Size(317, 20)
        Me.hostname.TabIndex = 40
        Me.hostname.Text = "esp32ide"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(0, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Jméno desky (Hostname pomocí mDNS)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(116, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Hostname"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(140, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 20)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Wifi"
        '
        'sda
        '
        Me.sda.Location = New System.Drawing.Point(89, 347)
        Me.sda.Name = "sda"
        Me.sda.Size = New System.Drawing.Size(50, 20)
        Me.sda.TabIndex = 44
        Me.sda.Text = "19"
        '
        'scl
        '
        Me.scl.Location = New System.Drawing.Point(251, 347)
        Me.scl.Name = "scl"
        Me.scl.Size = New System.Drawing.Size(50, 20)
        Me.scl.TabIndex = 45
        Me.scl.Text = "23"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(2, 350)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "SDA Pin (Data) :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(163, 350)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "SCL Pin (Clock) :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(111, 318)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 20)
        Me.Label15.TabIndex = 48
        Me.Label15.Text = "Oled display"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1, 492)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(319, 122)
        Me.TextBox1.TabIndex = 49
        '
        'Button3
        '
        Me.Button3.Image = Global.ESP_IDE_Flasher.My.Resources.Resources.Save_icon
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(162, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(158, 24)
        Me.Button3.TabIndex = 51
        Me.Button3.Text = "Uložit nastavení"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'open_cfg
        '
        Me.open_cfg.Image = Global.ESP_IDE_Flasher.My.Resources.Resources.open_file_icon
        Me.open_cfg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.open_cfg.Location = New System.Drawing.Point(2, 2)
        Me.open_cfg.Name = "open_cfg"
        Me.open_cfg.Size = New System.Drawing.Size(158, 24)
        Me.open_cfg.TabIndex = 50
        Me.open_cfg.Text = "Otevřít nastavení"
        Me.open_cfg.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'nastaveni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(321, 615)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.open_cfg)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.scl)
        Me.Controls.Add(Me.sda)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.hostname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pass4)
        Me.Controls.Add(Me.ssid4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pass3)
        Me.Controls.Add(Me.ssid3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pass2)
        Me.Controls.Add(Me.ssid2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pass1)
        Me.Controls.Add(Me.ssid1)
        Me.Controls.Add(Me.StatusLabel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.com_port)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "nastaveni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Nastavení desky"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents com_port As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents StatusLabel1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ssid1 As System.Windows.Forms.TextBox
    Friend WithEvents pass1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pass2 As System.Windows.Forms.TextBox
    Friend WithEvents ssid2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pass3 As System.Windows.Forms.TextBox
    Friend WithEvents ssid3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pass4 As System.Windows.Forms.TextBox
    Friend WithEvents ssid4 As System.Windows.Forms.TextBox
    Friend WithEvents hostname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sda As System.Windows.Forms.TextBox
    Friend WithEvents scl As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents open_cfg As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
