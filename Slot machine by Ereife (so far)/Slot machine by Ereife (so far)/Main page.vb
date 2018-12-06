

Public Class Main_page
    Public pics As New Hashtable
    Public listOfImages As New ImageList
    Public blurryImages As New ImageList
    Public d As Integer = 1
    Public finalResult(2) As Integer
    Public imagesetas() As Integer = {1111, 1111, 111}

    ' subroutine to load all the paths into images with their values
    Sub setup()

        Randomize()
        listOfImages.ImageSize = New Size(256, 256)

        Dim folder As String = "N:\Slot machine by Ereife (so far)\res"
        pics.Add(0, folder + "\skull.png")

        pics.Add(1, folder + "\cherry.png")

        pics.Add(2, folder + "\orange.png")
        pics.Add(3, folder + "\pear.png")
        pics.Add(4, folder + "\Bell.png")

        For x = 0 To 4
            listOfImages.Images.Add(x, Image.FromFile(pics(x)))
            blurryImages.Images.Add(x, Image.FromFile(pics(x)))
        Next
    End Sub



    Private Sub Main_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setup()



    End Sub
   



    Sub imageSetter(ByVal box As Integer, ByVal picture As Image)
        Select Case box
            Case 0
                slotOne.Image = picture
            Case 1
                slotTwo.Image = picture
            Case 2
                slotThree.Image = picture
        End Select
    End Sub



    ' functions used for the spinning
    Sub results()
        For x = 0 To 2
            finalResult(x) = Math.Floor(Rnd() * 5)


        Next
    End Sub


    Sub spin()
        results()
        Dim a As Integer = d Mod 5
        Timer1.Enabled = False

        d += 1

        Select Case d
            Case Is < 80
                For x = 0 To 2
                    imageSetter(x, blurryImages.Images(a))

                Next


            Case Is > 94
                For x = 0 To 2
                    If Not imageSetAs(x) = finalResult(x) Then
                        If a = finalResult(x) Then
                            imageSetAs(x) = a
                            imageSetter(x, listOfImages.Images(a))
                        End If
                    End If

                Next



            Case Else
                For x = 0 To 2
                    imageSetter(x, listOfImages.Images(a))

                Next







        End Select










        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If d < 101 Then
            Timer1.Interval = d
            spin()
        Else
            Timer1.Stop()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        d = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer1.Stop()
    End Sub
End Class

