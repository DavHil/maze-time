Public Class Einstellungen

    Dim titel As String = Datenbank.Einstellungen_Titel

    Dim G As Graphics
    Dim MyFont = New Font("Arial", 8)
    Dim MyPen = New Pen(Brushes.White, 3)

    Dim PB_Schliessen As New PictureBox
    Dim PB_Minimieren As New PictureBox

    Dim PB_Facebook As New PictureBox
    Dim PB_Twitter As New PictureBox
    Dim PB_YouTube As New PictureBox
    Dim PB_Google_Plus As New PictureBox
    Dim PB_Zurueck As New PictureBox


    Private Sub Form1_Load(sender As Object, e As EventArgs)
        With Me
            .FormBorderStyle = FormBorderStyle.None
            .Width = Datenbank.Einstellungen_Breite
            .Height = Datenbank.Einstellungen_Höhe
            .BackColor = Datenbank.Einstellungen_Hintergrundfarbe
            .ForeColor = Datenbank.Einstellungen_Schriftfarbe
            .Text = titel
            .ControlBox = False
            .MaximizeBox = False
            .MinimizeBox = False
            .BackgroundImage = Datenbank.Einstellungen_Hintergrundgrafik
            .AutoSizeMode = AutoSizeMode.GrowAndShrink
            .StartPosition = FormStartPosition.CenterScreen
            .WindowState = FormWindowState.Normal
            '.Icon = My.Resources
        End With
        init()
    End Sub

    Private Sub init()
        PB_Schliessen_Erstellen()
        PB_Minimieren_Erstellen()
        PB_Facebook_Erstellen()
        PB_Twitter_Erstellen()
        PB_YouTube_Erstellen()
        PB_Google_Plus_Erstellen()
        PB_Zurueck_Erstellen()

        tp_Seite1.Text = "Allgemein"
        tp_Seite2.Text = "Grafik"
        tp_Seite3.Text = "Extras"

        Debug_Modus()
        lade_checked()
        Aufloesung_PB()

    End Sub

#Region "Launcher Überschrift"
    Private Sub Launcher_Paint(sender As Object, e As PaintEventArgs)

        G = e.Graphics

        With G
            .DrawString(Datenbank.Einstellungen_Titel, MyFont, Brushes.White, 12, 10)
            .DrawString(Datenbank.Spiel_Version, MyFont, Brushes.White, 485, 10)
        End With

        With e.Graphics
            .SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            .TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
            .PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            .InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear
            .CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        End With

    End Sub
#End Region

#Region "PB_Schliessen"
    Private Sub PB_Schliessen_Erstellen()
        With PB_Schliessen
            .Location = New Point(768, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_close_op
        End With
        AddHandler PB_Schliessen.Click, AddressOf PB_Schliessen_Click
        AddHandler PB_Schliessen.MouseEnter, AddressOf PB_Schliessen_MouseEnter
        AddHandler PB_Schliessen.MouseLeave, AddressOf PB_Schliessen_MouseLeave
        Controls.Add(PB_Schliessen)
        PB_Schliessen.Parent = Me
    End Sub

    Private Sub PB_Schliessen_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
    Private Sub PB_Schliessen_MouseEnter(sender As Object, e As EventArgs)
        PB_Schliessen.Image = My.Resources.button_close_mp
    End Sub

    Private Sub PB_Schliessen_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Schliessen.Parent = Me
        PB_Schliessen.Image = My.Resources.button_close_op
    End Sub
#End Region

#Region "PB_Mini"
    Private Sub PB_Minimieren_Erstellen()
        With PB_Minimieren
            .Location = New Point(740, 4)
            .Size = New Size(Datenbank.Launcher_Windows_Buttons, Datenbank.Launcher_Windows_Buttons)
            .Image = My.Resources.button_minim_op
        End With
        AddHandler PB_Minimieren.Click, AddressOf PB_Minimieren_Click
        AddHandler PB_Minimieren.MouseEnter, AddressOf PB_Minimieren_MouseEnter
        AddHandler PB_Minimieren.MouseLeave, AddressOf PB_Minimieren_MouseLeave
        Controls.Add(PB_Minimieren)
        PB_Minimieren.Parent = Me
    End Sub

    Private Sub PB_Minimieren_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub PB_Minimieren_MouseEnter(sender As Object, e As EventArgs)
        PB_Minimieren.Image = My.Resources.button_minim_mp
    End Sub

    Private Sub PB_Minimieren_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Minimieren.Parent = Me
        PB_Minimieren.Image = My.Resources.button_minim_op
    End Sub
#End Region


#Region "PB_Facebook"
    Private Sub PB_Facebook_Erstellen()
        With PB_Facebook
            .Location = New Point(686, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_facebook_op
        End With
        AddHandler PB_Facebook.Click, AddressOf PB_Facebook_Click
        AddHandler PB_Facebook.MouseEnter, AddressOf PB_Facebook_MouseEnter
        AddHandler PB_Facebook.MouseLeave, AddressOf PB_Facebook_MouseLeave
        Controls.Add(PB_Facebook)
        PB_Facebook.Parent = Me
    End Sub

    Private Sub PB_Facebook_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Facebook_MouseEnter(sender As Object, e As EventArgs)
        PB_Facebook.Image = My.Resources.sbutton_facebook_mp
    End Sub

    Private Sub PB_Facebook_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Facebook.Parent = Me
        PB_Facebook.Image = My.Resources.sbutton_facebook_op
    End Sub
#End Region

#Region "PB_Twitter"
    Private Sub PB_Twitter_Erstellen()
        With PB_Twitter
            .Location = New Point(714, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_twitter_op
        End With
        AddHandler PB_Twitter.Click, AddressOf PB_Twitter_Click
        AddHandler PB_Twitter.MouseEnter, AddressOf PB_Twitter_MouseEnter
        AddHandler PB_Twitter.MouseLeave, AddressOf PB_Twitter_MouseLeave
        Controls.Add(PB_Twitter)
        PB_Twitter.Parent = Me
    End Sub

    Private Sub PB_Twitter_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Twitter_MouseEnter(sender As Object, e As EventArgs)
        PB_Twitter.Image = My.Resources.sbutton_twitter_mp
    End Sub

    Private Sub PB_Twitter_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Twitter.Parent = Me
        PB_Twitter.Image = My.Resources.sbutton_twitter_op
    End Sub
#End Region

#Region "YouTube"
    Private Sub PB_YouTube_Erstellen()
        With PB_YouTube
            .Location = New Point(742, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_youtube_op
        End With
        AddHandler PB_YouTube.Click, AddressOf PB_YouTube_Click
        AddHandler PB_YouTube.MouseEnter, AddressOf PB_YouTube_MouseEnter
        AddHandler PB_YouTube.MouseLeave, AddressOf PB_YouTube_MouseLeave
        Controls.Add(PB_YouTube)
        PB_YouTube.Parent = Me
    End Sub

    Private Sub PB_YouTube_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_YouTube_MouseEnter(sender As Object, e As EventArgs)
        PB_YouTube.Image = My.Resources.sbutton_youtube_mp
    End Sub

    Private Sub PB_YouTube_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_YouTube.Parent = Me
        PB_YouTube.Image = My.Resources.sbutton_youtube_op
    End Sub
#End Region

#Region "PB_Google+"
    Private Sub PB_Google_Plus_Erstellen()
        With PB_Google_Plus
            .Location = New Point(770, 48)
            .Size = New Size(Datenbank.Launcher_Social_Media_Buttons, Datenbank.Launcher_Social_Media_Buttons)
            .Image = My.Resources.sbutton_google_op
        End With
        AddHandler PB_Google_Plus.Click, AddressOf PB_Google_Plus_Click
        AddHandler PB_Google_Plus.MouseEnter, AddressOf PB_Google_Plus_MouseEnter
        AddHandler PB_Google_Plus.MouseLeave, AddressOf PB_Google_Plus_MouseLeave
        Controls.Add(PB_Google_Plus)
        PB_Google_Plus.Parent = Me
    End Sub

    Private Sub PB_Google_Plus_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub PB_Google_Plus_MouseEnter(sender As Object, e As EventArgs)
        PB_Google_Plus.Image = My.Resources.sbutton_google_mp
    End Sub

    Private Sub PB_Google_Plus_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Google_Plus.Parent = Me
        PB_Google_Plus.Image = My.Resources.sbutton_google_op
    End Sub
#End Region

#Region "PB_Zurueck"
    Private Sub PB_Zurueck_Erstellen()
        With PB_Zurueck
            .Location = New Point(651, 533)
            .Size = Datenbank.Launcher_Zurueck
            .Image = My.Resources.button_back_op
        End With
        AddHandler PB_Zurueck.Click, AddressOf PB_Zurueck_Click
        AddHandler PB_Zurueck.MouseEnter, AddressOf PB_Zurueck_MouseEnter
        AddHandler PB_Zurueck.MouseLeave, AddressOf PB_Zurueck_MouseLeave
        Controls.Add(PB_Zurueck)
        PB_Zurueck.Parent = Me
    End Sub

    Private Sub PB_Zurueck_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub PB_Zurueck_MouseEnter(sender As Object, e As EventArgs)
        PB_Zurueck.Image = My.Resources.button_back_mp
    End Sub

    Private Sub PB_Zurueck_MouseLeave(sender As System.Object, e As System.EventArgs)
        PB_Zurueck.Parent = Me
        PB_Zurueck.Image = My.Resources.button_back_op
    End Sub
#End Region


    Private Sub lade_checked()
        Lade_Debug_Checked()
        Lade_Update_Checked()
        Lade_Musik_Checked()
        Lade_Sounds_Checked()
        Lade_Aufloesung_Checked()
        Aktueller_Spielepfad()
    End Sub

    Private Sub Debug_Modus()

        If Datenbank.Spiel_Debug_Modus = True Then

        Else

        End If

    End Sub

#Region "DebugModus"
    Private Sub Lade_Debug_Checked()
        CheckBoxDebug.Checked = Datenbank.Spiel_Debug_Modus
    End Sub

    Private Sub CheckBoxDebug_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDebug.CheckedChanged

    End Sub

#End Region
#Region "Update"
    Private Sub Lade_Update_Checked()
        CheckBoxUpdate.Checked = Datenbank.Spiel_AutoUpdate
    End Sub

    Private Sub CheckBoxUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxUpdate.CheckedChanged

    End Sub
#End Region

#Region "MusikModus"

    Private Sub Lade_Musik_Checked()
        CheckBoxMusik.Checked = Datenbank.Spiel_Musik
    End Sub

    Private Sub CheckBoxMusik_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxMusik.CheckedChanged

    End Sub

    Private Sub musik_mode()
        If Datenbank.Spiel_Musik = True Then
            My.Computer.Audio.Play(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/sounds/" & Datenbank.Launcher_Titel_Song & ".wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
#End Region

#Region "SoundModus"

    Private Sub Lade_Sounds_Checked()
        CheckBoxMusik.Checked = Datenbank.Spiel_Musik
    End Sub

    Private Sub CheckBoxSounds_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CheckBoxSounds.CheckedChanged

    End Sub

    Private Sub Sounds_mode()
        If Datenbank.Spiel_Sounds = True Then
            My.Computer.Audio.Play(Datenbank.Spiel_Pfad & Datenbank.Spiel_Pfad_Spiel & "/sounds/sounds/" & Datenbank.Launcher_Titel_Song & ".wav", AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
#End Region

#Region "Spiele Pfad"

    Private Sub Aktueller_Spielepfad()
        TxtBoxPfad.Text = Datenbank.Spiel_Pfad
    End Sub

    Private Sub BChangePfad_Click(sender As System.Object, e As System.EventArgs) Handles BChangePfad.Click

    End Sub

#End Region

#Region "Hintergrundfarbe"
    Private Sub BChangeBackColor_Click(sender As System.Object, e As System.EventArgs) Handles BChangeBackColor.Click

    End Sub

    Private Sub BDefaultBackColor_Click(sender As System.Object, e As System.EventArgs) Handles BDefaultBackColor.Click
        Datenbank.Launcher_Hintergrundfarbe = Datenbank.Spiel_Hintergrundfarbe
        Launcher.BackColor = Datenbank.Spiel_Hintergrundfarbe
        Me.BackColor = Datenbank.Spiel_Hintergrundfarbe
        MsgBox("Hintergrundfarbe wurde geändert !", MsgBoxStyle.Information)
    End Sub
#End Region

#Region "Schriftfarbe"
    Private Sub BChangeForeColor_Click(sender As System.Object, e As System.EventArgs) Handles BChangeForeColor.Click

    End Sub

    Private Sub BDefaultForeColor_Click(sender As System.Object, e As System.EventArgs) Handles BDefaultForeColor.Click
        Datenbank.Launcher_Schriftfarbe = Datenbank.Spiel_Schriftfarbe
        Launcher.ForeColor = Datenbank.Spiel_Schriftfarbe
        Me.ForeColor = Datenbank.Spiel_Schriftfarbe
        MsgBox("Schriftfarbe wurde geändert !", MsgBoxStyle.Information)
    End Sub
#End Region

#Region "Auflösung"

    Private Sub Aufloesung_PB()
        PB_1080p.Image = My.Resources.hd_1080
        PB_720p.Image = My.Resources.hd_720
        PB_600p.Image = My.Resources.hd_ready
    End Sub

    Private Sub Lade_Aufloesung_Checked()

        rb_Vollbild.Checked = Datenbank.Spiel_Vollbild
        rb_VollbildFenster.Checked = Datenbank.Spiel_Fenstervollbild
        rb_Fenster.Checked = Datenbank.Spiel_Fenster

        If Datenbank.Spielwelt_Breite = 1920 And Datenbank.Spielwelt_Höhe = 1080 Then
            RB_1080p.Checked = True
            RB_720p.Checked = False
            RB_600p.Checked = False
        ElseIf Datenbank.Spielwelt_Breite = 1280 And Datenbank.Spielwelt_Höhe = 720 Then
            RB_1080p.Checked = False
            RB_720p.Checked = True
            RB_600p.Checked = False
        ElseIf Datenbank.Spielwelt_Breite = 800 And Datenbank.Spielwelt_Höhe = 600 Then
            RB_1080p.Checked = False
            RB_720p.Checked = False
            RB_600p.Checked = True
        End If

    End Sub

    Private Sub BChangeSize_Click(sender As Object, e As EventArgs) Handles BChangeSize.Click

    End Sub

    Private Sub tp_Seite1_Click(sender As Object, e As EventArgs) Handles tp_Seite1.Click

    End Sub
#End Region

End Class