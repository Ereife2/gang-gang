<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_page
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
        Me.components = New System.ComponentModel.Container
        Me.slotOne = New System.Windows.Forms.PictureBox
        Me.slotTwo = New System.Windows.Forms.PictureBox
        Me.slotThree = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.moneybox = New System.Windows.Forms.RichTextBox
        Me.colorChanging = New System.Windows.Forms.Timer(Me.components)
        CType(Me.slotOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slotTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slotThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'slotOne
        '
        Me.slotOne.Location = New System.Drawing.Point(26, 78)
        Me.slotOne.Name = "slotOne"
        Me.slotOne.Size = New System.Drawing.Size(154, 137)
        Me.slotOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slotOne.TabIndex = 0
        Me.slotOne.TabStop = False
        '
        'slotTwo
        '
        Me.slotTwo.Location = New System.Drawing.Point(186, 78)
        Me.slotTwo.Name = "slotTwo"
        Me.slotTwo.Size = New System.Drawing.Size(154, 137)
        Me.slotTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slotTwo.TabIndex = 1
        Me.slotTwo.TabStop = False
        '
        'slotThree
        '
        Me.slotThree.Location = New System.Drawing.Point(346, 78)
        Me.slotThree.Name = "slotThree"
        Me.slotThree.Size = New System.Drawing.Size(154, 137)
        Me.slotThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slotThree.TabIndex = 2
        Me.slotThree.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Button1.Location = New System.Drawing.Point(185, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 104)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SPIN!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(567, 487)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Button2.Location = New System.Drawing.Point(26, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 64)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "WITHDRAW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'moneybox
        '
        Me.moneybox.Font = New System.Drawing.Font("Showcard Gothic", 28.0!)
        Me.moneybox.Location = New System.Drawing.Point(26, 27)
        Me.moneybox.Name = "moneybox"
        Me.moneybox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.moneybox.Size = New System.Drawing.Size(215, 45)
        Me.moneybox.TabIndex = 8
        Me.moneybox.Text = ""
        '
        'colorChanging
        '
        '
        'Main_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 342)
        Me.Controls.Add(Me.moneybox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.slotThree)
        Me.Controls.Add(Me.slotTwo)
        Me.Controls.Add(Me.slotOne)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Main_page"
        Me.Text = "Main_page"
        CType(Me.slotOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slotTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slotThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents slotOne As System.Windows.Forms.PictureBox
    Friend WithEvents slotTwo As System.Windows.Forms.PictureBox
    Friend WithEvents slotThree As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents moneybox As System.Windows.Forms.RichTextBox
    Friend WithEvents colorChanging As System.Windows.Forms.Timer
End Class
