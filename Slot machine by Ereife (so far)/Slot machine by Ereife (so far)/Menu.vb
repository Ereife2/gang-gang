Public Class Menu
    'The interval between spins
    Public d As Integer = 0
    'Sets locations with a value
    Public pics As New Hashtable
    'The images without any blur effects
    Public listOfImages As New ImageList
    'Images with blurry effects
    Public blurryImages As New ImageList
    ' subroutine to load all the paths into images with their values
    Sub setup()
        'Changes background color
        BackColor = Color.BlanchedAlmond
        'Removes blur filter
        listOfImages.ImageSize() = New Size(256, 256)
        'Declares a variable to locate the project
        Dim folder As String = "N:\Slot machine by Ereife (so far)\res"
        'Adds an image to the graphical user interface
        pics.Add(0, folder + "\skull.png")
        pics.Add(1, folder + "\cherry.png")
        pics.Add(2, folder + "\orange.png")
        pics.Add(3, folder + "\pear.png")
        pics.Add(4, folder + "\Bell.png")
        'Transfer images from hashtable to graphical user interface
        For x = 0 To 4
            listOfImages.Images.Add(x + 1, Image.FromFile(pics(x)))
            blurryImages.Images.Add(x + 1, Image.FromFile(pics(x)))
        Next





    End Sub

    'Starts the spinning animation
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setup()

        Timer1.Start()


    End Sub
    'Shows menu page
    Private Sub a_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a.Click
        Main_page.Show()
    End Sub

    '
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