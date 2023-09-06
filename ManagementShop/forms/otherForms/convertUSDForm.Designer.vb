<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class convertUSDForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(convertUSDForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.Title = New System.Windows.Forms.Label()
        Me.LabelOne = New System.Windows.Forms.Label()
        Me.LabelTow = New System.Windows.Forms.Label()
        Me.TextThree = New System.Windows.Forms.TextBox()
        Me.TextOne = New System.Windows.Forms.TextBox()
        Me.TextTwo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.PictureExit)
        Me.Panel1.Controls.Add(Me.Title)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(474, 23)
        Me.Panel1.TabIndex = 0
        '
        'PictureExit
        '
        Me.PictureExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureExit.Image = CType(resources.GetObject("PictureExit.Image"), System.Drawing.Image)
        Me.PictureExit.Location = New System.Drawing.Point(450, 0)
        Me.PictureExit.Name = "PictureExit"
        Me.PictureExit.Size = New System.Drawing.Size(24, 23)
        Me.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureExit.TabIndex = 7
        Me.PictureExit.TabStop = False
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.Title.Location = New System.Drawing.Point(395, 0)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(49, 24)
        Me.Title.TabIndex = 4
        Me.Title.Text = "تفاصيل"
        '
        'LabelOne
        '
        Me.LabelOne.AutoSize = True
        Me.LabelOne.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.LabelOne.Location = New System.Drawing.Point(379, 41)
        Me.LabelOne.Name = "LabelOne"
        Me.LabelOne.Size = New System.Drawing.Size(78, 24)
        Me.LabelOne.TabIndex = 1
        Me.LabelOne.Text = "السعر الحالي"
        '
        'LabelTow
        '
        Me.LabelTow.AutoSize = True
        Me.LabelTow.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.LabelTow.Location = New System.Drawing.Point(384, 86)
        Me.LabelTow.Name = "LabelTow"
        Me.LabelTow.Size = New System.Drawing.Size(73, 24)
        Me.LabelTow.TabIndex = 2
        Me.LabelTow.Text = "عدد  البيانات"
        '
        'TextThree
        '
        Me.TextThree.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextThree.Location = New System.Drawing.Point(192, 78)
        Me.TextThree.Name = "TextThree"
        Me.TextThree.ReadOnly = True
        Me.TextThree.Size = New System.Drawing.Size(182, 32)
        Me.TextThree.TabIndex = 3
        Me.TextThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextOne
        '
        Me.TextOne.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextOne.Location = New System.Drawing.Point(192, 38)
        Me.TextOne.Name = "TextOne"
        Me.TextOne.ReadOnly = True
        Me.TextOne.Size = New System.Drawing.Size(182, 32)
        Me.TextOne.TabIndex = 0
        Me.TextOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextTwo
        '
        Me.TextTwo.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextTwo.Location = New System.Drawing.Point(4, 38)
        Me.TextTwo.Name = "TextTwo"
        Me.TextTwo.ReadOnly = True
        Me.TextTwo.Size = New System.Drawing.Size(182, 32)
        Me.TextTwo.TabIndex = 6
        Me.TextTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DetailsMath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 139)
        Me.Controls.Add(Me.TextTwo)
        Me.Controls.Add(Me.TextOne)
        Me.Controls.Add(Me.TextThree)
        Me.Controls.Add(Me.LabelOne)
        Me.Controls.Add(Me.LabelTow)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DetailsMath"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureExit As System.Windows.Forms.PictureBox
    Friend WithEvents Title As System.Windows.Forms.Label
    Friend WithEvents LabelOne As System.Windows.Forms.Label
    Friend WithEvents LabelTow As System.Windows.Forms.Label
    Friend WithEvents TextThree As System.Windows.Forms.TextBox
    Friend WithEvents TextOne As System.Windows.Forms.TextBox
    Friend WithEvents TextTwo As System.Windows.Forms.TextBox
End Class
