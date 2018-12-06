Public Class Menu
    Public d As Integer = 0
    Public pics As New Hashtable
    Public listOfImages As New ImageList
    Public blurryImages As New ImageList
    ' subroutine to load all the paths into images with their values
    Sub setup()
        BackColor = Color.BlanchedAlmond
        listOfImages.ImageSize() = New Size(256, 256)

        Dim folder As String = "N:\Slot machine by Ereife (so far)\res"
        pics.Add(0, folder + "\skull.png")

        pics.Add(1, folder + "\cherry.png")

        pics.Add(2, folder + "\orange.png")
        pics.Add(3, folder + "\pear.png")
        pics.Add(4, folder + "\Bell.png")

        For x = 0 To 4
            listOfImages.Images.Add(x + 1, Image.FromFile(pics(x)))
            blurryImages.Images.Add(x + 1, Image.FromFile(pics(x)))
        Next





    End Sub


    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setup()

        Timer1.Start()

        
    End Sub

    Private Sub a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.Click
        Main_page.Show()
    End Sub


    Sub change()
        Timer1.Enabled = False
        If d = 0 Then
            d = blurryImages.Images.Count
        End If
        d -= 1

        a.Image = blurryImages.Images(d)
        Timer1.Enabled = True
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        change()
    End Sub
End Class