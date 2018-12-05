

Public Class Main_page
    Public pics As New Hashtable
    Public listOfImages As New ImageList
    Public d As Integer = 1
    ' subroutine to load all the paths into images with their values
    Sub setup()
        Randomize()
        listOfImages.ImageSize = New Size(256, 256)
        Dim folder As String = "N:\Slot machine by Ereife (so far)\res"
        pics.Add(0, folder + "\skull.png")

        pics.Add(1, folder + "\cherry.png")
        pics.Add(2, folder + "\lemon.png")
        pics.Add(3, folder + "\orange.png")
        pics.Add(4, folder + "\pear.png")
        pics.Add(5, folder + "\Bell.png")

        For x = 0 To 5
            listOfImages.Images.Add(x, Image.FromFile(pics(x)))
        Next
    End Sub



    Private Sub Main_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setup()



    End Sub
   







    ' functions used for the spinning
    Sub a()

    End Sub


    Sub spin()
        Dim a As Integer = d Mod 6
        Timer1.Enabled = False
      
        d += 1

        slotOne.Image = listOfImages.Images(CStr(Math.Floor(Rnd() * 6)))
        slotTwo.Image = listOfImages.Images(CStr(Math.Floor(Rnd() * 6)))
        slotThree.Image = listOfImages.Images(CStr(Math.Floor(Rnd() * 6)))
        Timer1.Enabled = True

       

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If d < 250 Then
            Timer1.Interval = d
            spin()
        Else
            Timer1.Stop()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
End Class

