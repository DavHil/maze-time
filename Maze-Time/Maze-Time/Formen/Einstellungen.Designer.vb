<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rb_Fenster = New System.Windows.Forms.RadioButton()
        Me.BChangeSize = New System.Windows.Forms.Button()
        Me.PB_600p = New System.Windows.Forms.PictureBox()
        Me.PB_720p = New System.Windows.Forms.PictureBox()
        Me.PB_1080p = New System.Windows.Forms.PictureBox()
        Me.RB_600p = New System.Windows.Forms.RadioButton()
        Me.RB_720p = New System.Windows.Forms.RadioButton()
        Me.ColorDialogBackColor = New System.Windows.Forms.ColorDialog()
        Me.RB_1080p = New System.Windows.Forms.RadioButton()
        Me.BDefaultForeColor = New System.Windows.Forms.Button()
        Me.BChangeForeColor = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BDefaultBackColor = New System.Windows.Forms.Button()
        Me.BChangeBackColor = New System.Windows.Forms.Button()
        Me.tp_Seite3 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ColorDialogForeColor = New System.Windows.Forms.ColorDialog()
        Me.rb_VollbildFenster = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tp_Seite1 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxUpdate = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxSounds = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxMusik = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BChangePfad = New System.Windows.Forms.Button()
        Me.TxtBoxPfad = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDebug = New System.Windows.Forms.CheckBox()
        Me.tp_Seite2 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rb_Vollbild = New System.Windows.Forms.RadioButton()
        CType(Me.PB_600p, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_720p, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_1080p, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tp_Seite1.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tp_Seite2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'rb_Fenster
        '
        Me.rb_Fenster.AutoSize = True
        Me.rb_Fenster.Location = New System.Drawing.Point(261, 19)
        Me.rb_Fenster.Name = "rb_Fenster"
        Me.rb_Fenster.Size = New System.Drawing.Size(92, 17)
        Me.rb_Fenster.TabIndex = 2
        Me.rb_Fenster.TabStop = True
        Me.rb_Fenster.Text = "FensterModus"
        Me.rb_Fenster.UseVisualStyleBackColor = True
        '
        'BChangeSize
        '
        Me.BChangeSize.ForeColor = System.Drawing.Color.Black
        Me.BChangeSize.Location = New System.Drawing.Point(6, 153)
        Me.BChangeSize.Name = "BChangeSize"
        Me.BChangeSize.Size = New System.Drawing.Size(388, 23)
        Me.BChangeSize.TabIndex = 3
        Me.BChangeSize.Text = "Auflösung speichern"
        Me.BChangeSize.UseVisualStyleBackColor = True
        '
        'PB_600p
        '
        Me.PB_600p.Location = New System.Drawing.Point(316, 56)
        Me.PB_600p.Name = "PB_600p"
        Me.PB_600p.Size = New System.Drawing.Size(32, 32)
        Me.PB_600p.TabIndex = 5
        Me.PB_600p.TabStop = False
        '
        'PB_720p
        '
        Me.PB_720p.Location = New System.Drawing.Point(192, 56)
        Me.PB_720p.Name = "PB_720p"
        Me.PB_720p.Size = New System.Drawing.Size(32, 32)
        Me.PB_720p.TabIndex = 4
        Me.PB_720p.TabStop = False
        '
        'PB_1080p
        '
        Me.PB_1080p.Location = New System.Drawing.Point(52, 56)
        Me.PB_1080p.Name = "PB_1080p"
        Me.PB_1080p.Size = New System.Drawing.Size(32, 32)
        Me.PB_1080p.TabIndex = 3
        Me.PB_1080p.TabStop = False
        '
        'RB_600p
        '
        Me.RB_600p.AutoSize = True
        Me.RB_600p.Location = New System.Drawing.Point(289, 24)
        Me.RB_600p.Name = "RB_600p"
        Me.RB_600p.Size = New System.Drawing.Size(72, 17)
        Me.RB_600p.TabIndex = 2
        Me.RB_600p.TabStop = True
        Me.RB_600p.Text = "800 x 600"
        Me.RB_600p.UseVisualStyleBackColor = True
        '
        'RB_720p
        '
        Me.RB_720p.AutoSize = True
        Me.RB_720p.Location = New System.Drawing.Point(162, 24)
        Me.RB_720p.Name = "RB_720p"
        Me.RB_720p.Size = New System.Drawing.Size(78, 17)
        Me.RB_720p.TabIndex = 1
        Me.RB_720p.TabStop = True
        Me.RB_720p.Text = "1280 x 720"
        Me.RB_720p.UseVisualStyleBackColor = True
        '
        'RB_1080p
        '
        Me.RB_1080p.AutoSize = True
        Me.RB_1080p.Location = New System.Drawing.Point(30, 24)
        Me.RB_1080p.Name = "RB_1080p"
        Me.RB_1080p.Size = New System.Drawing.Size(84, 17)
        Me.RB_1080p.TabIndex = 0
        Me.RB_1080p.TabStop = True
        Me.RB_1080p.Text = "1920 x 1080"
        Me.RB_1080p.UseVisualStyleBackColor = True
        '
        'BDefaultForeColor
        '
        Me.BDefaultForeColor.ForeColor = System.Drawing.Color.Black
        Me.BDefaultForeColor.Location = New System.Drawing.Point(6, 53)
        Me.BDefaultForeColor.Name = "BDefaultForeColor"
        Me.BDefaultForeColor.Size = New System.Drawing.Size(285, 23)
        Me.BDefaultForeColor.TabIndex = 2
        Me.BDefaultForeColor.Text = "Farbe zurücksetzen"
        Me.BDefaultForeColor.UseVisualStyleBackColor = True
        '
        'BChangeForeColor
        '
        Me.BChangeForeColor.ForeColor = System.Drawing.Color.Black
        Me.BChangeForeColor.Location = New System.Drawing.Point(6, 24)
        Me.BChangeForeColor.Name = "BChangeForeColor"
        Me.BChangeForeColor.Size = New System.Drawing.Size(285, 23)
        Me.BChangeForeColor.TabIndex = 1
        Me.BChangeForeColor.Text = "Farbe ändern"
        Me.BChangeForeColor.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.BDefaultBackColor)
        Me.GroupBox3.Controls.Add(Me.BChangeBackColor)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(297, 90)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hintergrund-Farbe"
        '
        'BDefaultBackColor
        '
        Me.BDefaultBackColor.ForeColor = System.Drawing.Color.Black
        Me.BDefaultBackColor.Location = New System.Drawing.Point(6, 53)
        Me.BDefaultBackColor.Name = "BDefaultBackColor"
        Me.BDefaultBackColor.Size = New System.Drawing.Size(285, 23)
        Me.BDefaultBackColor.TabIndex = 2
        Me.BDefaultBackColor.Text = "Farbe zurücksetzen"
        Me.BDefaultBackColor.UseVisualStyleBackColor = True
        '
        'BChangeBackColor
        '
        Me.BChangeBackColor.ForeColor = System.Drawing.Color.Black
        Me.BChangeBackColor.Location = New System.Drawing.Point(6, 24)
        Me.BChangeBackColor.Name = "BChangeBackColor"
        Me.BChangeBackColor.Size = New System.Drawing.Size(285, 23)
        Me.BChangeBackColor.TabIndex = 1
        Me.BChangeBackColor.Text = "Farbe ändern"
        Me.BChangeBackColor.UseVisualStyleBackColor = True
        '
        'tp_Seite3
        '
        Me.tp_Seite3.Location = New System.Drawing.Point(4, 22)
        Me.tp_Seite3.Name = "tp_Seite3"
        Me.tp_Seite3.Size = New System.Drawing.Size(768, 429)
        Me.tp_Seite3.TabIndex = 2
        Me.tp_Seite3.Text = "TabPage1"
        Me.tp_Seite3.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.BDefaultForeColor)
        Me.GroupBox6.Controls.Add(Me.BChangeForeColor)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(6, 106)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(297, 90)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Schrift-Farbe"
        '
        'rb_VollbildFenster
        '
        Me.rb_VollbildFenster.AutoSize = True
        Me.rb_VollbildFenster.Location = New System.Drawing.Point(125, 19)
        Me.rb_VollbildFenster.Name = "rb_VollbildFenster"
        Me.rb_VollbildFenster.Size = New System.Drawing.Size(128, 17)
        Me.rb_VollbildFenster.TabIndex = 1
        Me.rb_VollbildFenster.TabStop = True
        Me.rb_VollbildFenster.Text = "Vollbild FensterModus"
        Me.rb_VollbildFenster.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tp_Seite1)
        Me.TabControl1.Controls.Add(Me.tp_Seite2)
        Me.TabControl1.Controls.Add(Me.tp_Seite3)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(776, 455)
        Me.TabControl1.TabIndex = 1
        '
        'tp_Seite1
        '
        Me.tp_Seite1.Controls.Add(Me.GroupBox9)
        Me.tp_Seite1.Controls.Add(Me.GroupBox4)
        Me.tp_Seite1.Controls.Add(Me.GroupBox5)
        Me.tp_Seite1.Controls.Add(Me.GroupBox2)
        Me.tp_Seite1.Controls.Add(Me.GroupBox1)
        Me.tp_Seite1.Location = New System.Drawing.Point(4, 22)
        Me.tp_Seite1.Name = "tp_Seite1"
        Me.tp_Seite1.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Seite1.Size = New System.Drawing.Size(768, 429)
        Me.tp_Seite1.TabIndex = 0
        Me.tp_Seite1.Text = "TabPage1"
        Me.tp_Seite1.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.White
        Me.GroupBox9.Controls.Add(Me.CheckBoxUpdate)
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(6, 323)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(297, 75)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Auto Update"
        '
        'CheckBoxUpdate
        '
        Me.CheckBoxUpdate.AutoSize = True
        Me.CheckBoxUpdate.Location = New System.Drawing.Point(7, 35)
        Me.CheckBoxUpdate.Name = "CheckBoxUpdate"
        Me.CheckBoxUpdate.Size = New System.Drawing.Size(182, 17)
        Me.CheckBoxUpdate.TabIndex = 0
        Me.CheckBoxUpdate.Text = "Auto Update funktion aktivieren?"
        Me.CheckBoxUpdate.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.CheckBoxSounds)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(6, 166)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(297, 75)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sounds"
        '
        'CheckBoxSounds
        '
        Me.CheckBoxSounds.AutoSize = True
        Me.CheckBoxSounds.Location = New System.Drawing.Point(7, 31)
        Me.CheckBoxSounds.Name = "CheckBoxSounds"
        Me.CheckBoxSounds.Size = New System.Drawing.Size(180, 17)
        Me.CheckBoxSounds.TabIndex = 0
        Me.CheckBoxSounds.Text = "Sollen die Sounds Aktiviert sein?"
        Me.CheckBoxSounds.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.CheckBoxMusik)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(6, 87)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(297, 75)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Hintergrund Musik"
        '
        'CheckBoxMusik
        '
        Me.CheckBoxMusik.AutoSize = True
        Me.CheckBoxMusik.Location = New System.Drawing.Point(7, 31)
        Me.CheckBoxMusik.Name = "CheckBoxMusik"
        Me.CheckBoxMusik.Size = New System.Drawing.Size(160, 17)
        Me.CheckBoxMusik.TabIndex = 0
        Me.CheckBoxMusik.Text = "Soll die Musik Aktiviert sein?"
        Me.CheckBoxMusik.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.BChangePfad)
        Me.GroupBox2.Controls.Add(Me.TxtBoxPfad)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(6, 246)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 75)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Spiele Pfad"
        '
        'BChangePfad
        '
        Me.BChangePfad.ForeColor = System.Drawing.Color.Black
        Me.BChangePfad.Location = New System.Drawing.Point(6, 47)
        Me.BChangePfad.Name = "BChangePfad"
        Me.BChangePfad.Size = New System.Drawing.Size(285, 23)
        Me.BChangePfad.TabIndex = 1
        Me.BChangePfad.Text = "Speichern"
        Me.BChangePfad.UseVisualStyleBackColor = True
        '
        'TxtBoxPfad
        '
        Me.TxtBoxPfad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxPfad.Location = New System.Drawing.Point(6, 23)
        Me.TxtBoxPfad.Multiline = True
        Me.TxtBoxPfad.Name = "TxtBoxPfad"
        Me.TxtBoxPfad.Size = New System.Drawing.Size(285, 20)
        Me.TxtBoxPfad.TabIndex = 0
        Me.TxtBoxPfad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.CheckBoxDebug)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 75)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dev/Debug Mode"
        '
        'CheckBoxDebug
        '
        Me.CheckBoxDebug.AutoSize = True
        Me.CheckBoxDebug.BackColor = System.Drawing.Color.White
        Me.CheckBoxDebug.Location = New System.Drawing.Point(7, 31)
        Me.CheckBoxDebug.Name = "CheckBoxDebug"
        Me.CheckBoxDebug.Size = New System.Drawing.Size(194, 17)
        Me.CheckBoxDebug.TabIndex = 0
        Me.CheckBoxDebug.Text = "Soll der Debug mode Aktiviert sein?"
        Me.CheckBoxDebug.UseVisualStyleBackColor = False
        '
        'tp_Seite2
        '
        Me.tp_Seite2.Controls.Add(Me.GroupBox7)
        Me.tp_Seite2.Controls.Add(Me.GroupBox6)
        Me.tp_Seite2.Controls.Add(Me.GroupBox3)
        Me.tp_Seite2.Location = New System.Drawing.Point(4, 22)
        Me.tp_Seite2.Name = "tp_Seite2"
        Me.tp_Seite2.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_Seite2.Size = New System.Drawing.Size(768, 429)
        Me.tp_Seite2.TabIndex = 1
        Me.tp_Seite2.Text = "TabPage2"
        Me.tp_Seite2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.GroupBox8)
        Me.GroupBox7.Controls.Add(Me.BChangeSize)
        Me.GroupBox7.Controls.Add(Me.PB_600p)
        Me.GroupBox7.Controls.Add(Me.PB_720p)
        Me.GroupBox7.Controls.Add(Me.PB_1080p)
        Me.GroupBox7.Controls.Add(Me.RB_600p)
        Me.GroupBox7.Controls.Add(Me.RB_720p)
        Me.GroupBox7.Controls.Add(Me.RB_1080p)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(332, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(400, 190)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Auflösung"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.rb_Fenster)
        Me.GroupBox8.Controls.Add(Me.rb_VollbildFenster)
        Me.GroupBox8.Controls.Add(Me.rb_Vollbild)
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(6, 94)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(388, 53)
        Me.GroupBox8.TabIndex = 5
        Me.GroupBox8.TabStop = False
        '
        'rb_Vollbild
        '
        Me.rb_Vollbild.AutoSize = True
        Me.rb_Vollbild.Location = New System.Drawing.Point(22, 19)
        Me.rb_Vollbild.Name = "rb_Vollbild"
        Me.rb_Vollbild.Size = New System.Drawing.Size(93, 17)
        Me.rb_Vollbild.TabIndex = 0
        Me.rb_Vollbild.TabStop = True
        Me.rb_Vollbild.Text = "Vollbild-Modus"
        Me.rb_Vollbild.UseVisualStyleBackColor = True
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Einstellungen"
        Me.Text = "Einstellungen"
        CType(Me.PB_600p, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_720p, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_1080p, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tp_Seite1.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tp_Seite2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rb_Fenster As RadioButton
    Friend WithEvents BChangeSize As Button
    Friend WithEvents PB_600p As PictureBox
    Friend WithEvents PB_720p As PictureBox
    Friend WithEvents PB_1080p As PictureBox
    Friend WithEvents RB_600p As RadioButton
    Friend WithEvents RB_720p As RadioButton
    Friend WithEvents ColorDialogBackColor As ColorDialog
    Friend WithEvents RB_1080p As RadioButton
    Friend WithEvents BDefaultForeColor As Button
    Friend WithEvents BChangeForeColor As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BDefaultBackColor As Button
    Friend WithEvents BChangeBackColor As Button
    Friend WithEvents tp_Seite3 As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ColorDialogForeColor As ColorDialog
    Friend WithEvents rb_VollbildFenster As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tp_Seite1 As TabPage
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents CheckBoxUpdate As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CheckBoxSounds As CheckBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CheckBoxMusik As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BChangePfad As Button
    Friend WithEvents TxtBoxPfad As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxDebug As CheckBox
    Friend WithEvents tp_Seite2 As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents rb_Vollbild As RadioButton
End Class
