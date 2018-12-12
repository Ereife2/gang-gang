Public Class MainMenu



    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MAIN MENU image
        Dim folder As String = "N:\slot machine by ereife (so far)\res"
        PictureBox1.Image = Image.FromFile(folder + "\pngtree.png")
        My.Computer.Audio.Play(folder + "\background.wav", AudioPlayMode.BackgroundLoop)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'getting from menu to game when they click the button
        Main_page.Show()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
   

End Class