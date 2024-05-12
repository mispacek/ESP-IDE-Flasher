<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.StatusLabel1 = New System.Windows.Forms.Label()
        Me.com_select = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Baudrate_combo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Open_config = New System.Windows.Forms.Button()
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.FlashLocalButton2 = New System.Windows.Forms.Button()
        Me.DownloadButton1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1, 162)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(318, 23)
        Me.ComboBox1.TabIndex = 16
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1, 460)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(318, 155)
        Me.TextBox1.TabIndex = 17
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 414)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(317, 25)
        Me.ProgressBar1.TabIndex = 20
        Me.ProgressBar1.Value = 25
        '
        'StatusLabel1
        '
        Me.StatusLabel1.ForeColor = System.Drawing.Color.White
        Me.StatusLabel1.Location = New System.Drawing.Point(0, 442)
        Me.StatusLabel1.Name = "StatusLabel1"
        Me.StatusLabel1.Size = New System.Drawing.Size(320, 18)
        Me.StatusLabel1.TabIndex = 21
        Me.StatusLabel1.Text = "Status"
        Me.StatusLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'com_select
        '
        Me.com_select.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.com_select.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.com_select.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.com_select.FormattingEnabled = True
        Me.com_select.Location = New System.Drawing.Point(28, 199)
        Me.com_select.Name = "com_select"
        Me.com_select.Size = New System.Drawing.Size(81, 24)
        Me.com_select.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-1, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Port:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'Baudrate_combo
        '
        Me.Baudrate_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Baudrate_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Baudrate_combo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Baudrate_combo.FormattingEnabled = True
        Me.Baudrate_combo.Items.AddRange(New Object() {"74880", "115200", "230400", "460800", "921600", "1500000"})
        Me.Baudrate_combo.Location = New System.Drawing.Point(236, 198)
        Me.Baudrate_combo.Name = "Baudrate_combo"
        Me.Baudrate_combo.Size = New System.Drawing.Size(81, 24)
        Me.Baudrate_combo.TabIndex = 25
        Me.Baudrate_combo.Text = "921600"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(182, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Baudrate:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Open_config
        '
        Me.Open_config.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Open_config.Image = Global.ESP_IDE_Flasher.My.Resources.Resources.settings_icon
        Me.Open_config.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Open_config.Location = New System.Drawing.Point(1, 348)
        Me.Open_config.Name = "Open_config"
        Me.Open_config.Size = New System.Drawing.Size(318, 46)
        Me.Open_config.TabIndex = 27
        Me.Open_config.Text = "         Nastavit WIFI, Hostname a PINy pro OLED"
        Me.Open_config.UseVisualStyleBackColor = True
        '
        'Refresh_btn
        '
        Me.Refresh_btn.Image = Global.ESP_IDE_Flasher.My.Resources.Resources.refresh_icon
        Me.Refresh_btn.Location = New System.Drawing.Point(112, 198)
        Me.Refresh_btn.Margin = New System.Windows.Forms.Padding(0)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(26, 25)
        Me.Refresh_btn.TabIndex = 23
        Me.Refresh_btn.UseVisualStyleBackColor = True
        '
        'FlashLocalButton2
        '
        Me.FlashLocalButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FlashLocalButton2.Image = Global.ESP_IDE_Flasher.My.Resources.Resources.open_file_icon__1_
        Me.FlashLocalButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FlashLocalButton2.Location = New System.Drawing.Point(1, 292)
        Me.FlashLocalButton2.Name = "FlashLocalButton2"
        Me.FlashLocalButton2.Size = New System.Drawing.Size(318, 46)
        Me.FlashLocalButton2.TabIndex = 19
        Me.FlashLocalButton2.Text = "       Vybrat a nainstalovat image z počítače"
        Me.FlashLocalButton2.UseVisualStyleBackColor = True
        '
        'DownloadButton1
        '
        Me.DownloadButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DownloadButton1.Image = Global.ESP_IDE_Flasher.My.Resources.Resources.Network_Download_icon__1_
        Me.DownloadButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DownloadButton1.Location = New System.Drawing.Point(1, 236)
        Me.DownloadButton1.Name = "DownloadButton1"
        Me.DownloadButton1.Size = New System.Drawing.Size(318, 46)
        Me.DownloadButton1.TabIndex = 18
        Me.DownloadButton1.Text = "       Stáhnout a naistalovat firmware do ESP"
        Me.DownloadButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.ESP_IDE_Flasher.My.Resources.Resources.logo_v3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 160)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 458)
        Me.Controls.Add(Me.Open_config)
        Me.Controls.Add(Me.Baudrate_combo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.com_select)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Refresh_btn)
        Me.Controls.Add(Me.StatusLabel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.FlashLocalButton2)
        Me.Controls.Add(Me.DownloadButton1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESP32 Micropython IDE - Instalátor V1.2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DownloadButton1 As System.Windows.Forms.Button
    Friend WithEvents FlashLocalButton2 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents StatusLabel1 As System.Windows.Forms.Label
    Friend WithEvents com_select As System.Windows.Forms.ComboBox
    Friend WithEvents Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Baudrate_combo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Open_config As System.Windows.Forms.Button

End Class
