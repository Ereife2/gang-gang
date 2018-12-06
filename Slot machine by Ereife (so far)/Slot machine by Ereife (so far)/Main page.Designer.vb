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
        Me.lever = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.slotOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slotTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slotThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lever, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'slotOne
        '
        Me.slotOne.Location = New System.Drawing.Point(108, 173)
        Me.slotOne.Name = "slotOne"
        Me.slotOne.Size = New System.Drawing.Size(132, 127)
        Me.slotOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slotOne.TabIndex = 0
        Me.slotOne.TabStop = False
        '
        'slotTwo
        '
        Me.slotTwo.Location = New System.Drawing.Point(246, 173)
        Me.slotTwo.Name = "slotTwo"
        Me.slotTwo.Size = New System.Drawing.Size(132, 127)
        Me.slotTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slotTwo.TabIndex = 1
        Me.slotTwo.TabStop = False
        '
        'slotThree
        '
        Me.slotThree.Location = New System.Drawing.Point(384, 173)
        Me.slotThree.Name = "slotThree"
        Me.slotThree.Size = New System.Drawing.Size(132, 127)
        Me.slotThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.slotThree.TabIndex = 2
        Me.slotThree.TabStop = False
        '
        'lever
        '
        Me.lever.Location = New System.Drawing.Point(522, 173)
        Me.lever.Name = "lever"
        Me.lever.Size = New System.Drawing.Size(87, 127)
        Me.lever.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lever.TabIndex = 3
        Me.lever.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(145, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 589)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lever)
        Me.Controls.Add(Me.slotThree)
        Me.Controls.Add(Me.slotTwo)
        Me.Controls.Add(Me.slotOne)
        Me.Name = "Main_page"
        Me.Text = "Main_page"
        CType(Me.slotOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slotTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slotThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lever, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents slotOne As System.Windows.Forms.PictureBox
    Friend WithEvents slotTwo As System.Windows.Forms.PictureBox
    Friend WithEvents slotThree As System.Windows.Forms.PictureBox
    Friend WithEvents lever As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
