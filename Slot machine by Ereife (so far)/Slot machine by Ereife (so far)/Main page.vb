' used for the calc function for sorting
Imports System.Linq

Public Class Main_page
    ' total money
    Public money As Decimal = 1
    ' gets a hashtable with the image locations and matches them with a number
    Public pics As New Hashtable
    ' real list of images for easy access
    Public listOfImages As New ImageList
    ' same as list of images, but blurry for the effect
    Public blurryImages As New ImageList
    ' the universal counter for what should happen at what point during a spin
    Public d As Integer = 200
    ' where the results of the spin are stored
    Public finalResult(2) As Integer
    Public rand As New Random



    'is done when the page starts, even before it is shown
    Private Sub Main_page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setup() ' runs the setub subroutine
        colorChanging.Interval = 1000
        colorChanging.Start()
        moneybox.Text = (String.Format("{0:c}", money)) ' displays the initial money amount of £1
    End Sub

    ' calculates how much money is made
    Function calc(ByVal results() As Integer)
        ' string for checking if all the numbers are equal
        Dim toCheck As String = ""
        ' adds each number to the string for if they are all the same
        For Each value As Integer In results
            toCheck += CStr(value)
        Next

        ' if they are all 0 - the skull, it should end the game
        Select Case toCheck ' select case is basically a massive if statement
            Case "000"
                Return -money
            Case "444" ' if they are all 4, the bell, they win £5
                Return 5 ' when returns it ends the function, so no carring through

            Case Else

                ' if they are all the same, with the remaing possibilities (none of them are special)
                ' they win £1
                If results.All(Function(i) i.Equals(results(0))) Then
                    Return +1
                End If
        End Select


        ' if two are the same they win 50p
        For x = 0 To 2
            Dim buffer As Integer = x
            If toCheck.Count(Function(c As Char) c = toCheck.Chars(buffer)) = 2 Then
                Return 0.5
            End If
        Next


        ' if two are skulls they lose a £1
        If toCheck.Count(Function(c As Char) c = "0") = 2 Then
            Return -1
        End If



       

        






        Return 0
    End Function


    ' subroutine to load all the paths into images with their values
    Sub setup()
        ' randomizes for the random results generator
        Randomize()
        ' sets the clear images to the maximum quality
        listOfImages.ImageSize = New Size(256, 256)
        blurryImages.ImageSize = New Size(48, 48)
        ' this is the folder where the items are stores- we really need to change this name
        Dim folder As String = "N:\Slot machine by Ereife (so far)\res"
        ' the individual items
        pics.Add(0, folder + "\skull.png")
        pics.Add(1, folder + "\cherry.png")
        pics.Add(2, folder + "\orange.png")
        pics.Add(3, folder + "\pear.png")
        pics.Add(4, folder + "\Bell.png")
        ' adds them to both image lists
        For x = 0 To 4
            listOfImages.Images.Add(x, Image.FromFile(pics(x)))
            blurryImages.Images.Add(x, Image.FromFile(pics(x))) ' blurry images is low quality by default, so there is no need to change the quality
        Next
        Button1.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        Button1.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
    End Sub






    ' the image setter, to avoid repetition of the different picture boxes
    Sub imageSetter(ByVal box As Integer, ByVal picture As Image)
        Select Case box ' so 0 is the one on the left, 1 is the middle one, and 2 is the one on the right
            Case 0
                slotOne.Image = picture
            Case 1
                slotTwo.Image = picture
            Case 2
                slotThree.Image = picture
        End Select
    End Sub



    ' functions used for the spinning- all the ones below here

    ' overview of how this works

    ' 1. the spin button is pressed and d is set to 1. The final results are calculated using the result subroutine
    ' 20p is also taken away from the balance
    ' unless d is 200, the button does nothing - so the duration of the spin

    ' 2. the timer starts ticking, and on every tick calls the spin function

    ' 3. if d is less than 80 the blurry images are shown

    ' 4. the timer continues ticking

    ' 5. when  80< d > 99 then the clear images are shown but randomly

    ' 6. on the 99th tick, the timer stops, the final results are displayed

    ' 7. the money is calculated and then added or taken away

    ' 8. the button is reactivated and then can be pressed again

    '_________________________________________________________________________________________
    ' what we need-
    ' - a check is they have enough money to spin
    ' a prompt for whether they could like to quit, or continue
    ' lever animation?








    ' randomly generates the final result- the chance of winning anything is extremely low
    Sub results()
        For x = 0 To 2
            ' there are 0 - 4 values and rnd is always less then one so rounding down is 0 to 4
            finalResult(x) = CInt(Math.Floor(Rnd() * 5))
        Next


    End Sub

    ' the function run to create the effect of a spinning "animation"
    Sub spin()


        ' a is d mod 5, so it is a value 0 to 4
        Dim a As Integer = d Mod 5
        ' disables the timer, so everthing here actually has time to run
        Timer1.Enabled = False
        ' adds one to d, so that the spin progresses
        d += 1

        ' if d = ?
        Select Case d
            Case Is < 80 ' if it less than 80, just cycles through all the values in order, and in unison
                For x = 0 To 2
                    ' displays the blurry images, for the "effect"
                    imageSetter(x, blurryImages.Images(a))

                Next


            Case Is > 99 ' at the end d > 99
                For x = 0 To 2



                    ' sets all the images to the final result
                    imageSetter(x, listOfImages.Images(finalResult(x)))
                    ' adds the winnings using the calc function
                Next
                Dim gain As Decimal = calc(finalResult)
                money += calc(finalResult)
                If gain < 0 Then
                    MessageBox.Show("You just lost " & String.Format("{0:c}", gain * -1D))
                Else
                    MessageBox.Show("You just won " & String.Format("{0:c}", gain))
                End If
                My.Computer.Audio.Play("n:\slot machine by ereife (so far)\res" + "\background.wav", AudioPlayMode.BackgroundLoop)
                ' sets d to 200 to re-activate the spin button
                d = 200








            Case Else ' if all the above are wrong (so d = 81 to 98)
                For x = 0 To 2
                    ' just randomly shuffles through the images seperatly for each image box
                    ' using the clear images, for effect
                    imageSetter(x, listOfImages.Images(CStr(Math.Floor(Rnd() * 5))))
                Next







        End Select









        ' enables the timer so it can continue to count
        Timer1.Enabled = True


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' every tick (so every "d" milliseconds) (as long as it is enabled)
        moneybox.Text = (String.Format("{0:c}", money)) ' displays the current amount of money
        If d < 100 Then ' if d < 100 (inteval less than 100ms) it will continue to spin
            Timer1.Interval = d ' sets the interval to whatever d is
            spin() ' calls the spin function
        Else
            Timer1.Stop() ' if d is more than 99 the timer will stop, giving timer for all the actions will be done

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' button only works when the all after spinning operations have been done and d is 200
        ' if not, the button will do nothing
        If money >= 0.2 Then
            If d = 200 Then
                My.Computer.Audio.Play("n:\slot machine by ereife (so far)\res\spinSound.wav")
                ' calls the results to generate the final values
                results()
                ' starts timer one to begin the spiining
                Timer1.Start()
                ' takes away 20p for the sping
                money -= 0.2
                d = 1 ' sets the univeral counter, and timer interval to 1

            End If
        Else
            MessageBox.Show("You are broke", "GAME OVER", MessageBoxButtons.OK)
            MainMenu.WindowState = FormWindowState.Normal
            Me.Close()
        End If

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If d = 200 Then
            Dim RESults As Integer = MessageBox.Show("DO YOU WANT TO TAKE YOUR MONEY AND QUIT", "LEAVING", MessageBoxButtons.OKCancel)
            If RESults = DialogResult.OK Then
                MessageBox.Show("YOU WON: " & String.Format("{0:c}", money), "Leaving", MessageBoxButtons.OK)
                MainMenu.WindowState = FormWindowState.Normal
                Me.Close()
            End If
        End If
       
    End Sub


    Private Sub colorChanging_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorChanging.Tick
        Button1.BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        Button1.ForeColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
        BackColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256))
    End Sub
End Class



