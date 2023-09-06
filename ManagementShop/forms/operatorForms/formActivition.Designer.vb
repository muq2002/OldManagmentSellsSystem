<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActivition
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormActivition))
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextShopName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnActive = New System.Windows.Forms.Button()
        Me.TextActiveNumber = New System.Windows.Forms.TextBox()
        Me.TextSerialNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureLogo
        '
        Me.PictureLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictureLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(348, 715)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 0
        Me.PictureLogo.TabStop = False
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelTitle.Controls.Add(Me.PictureExit)
        Me.PanelTitle.Controls.Add(Me.PictureBox1)
        Me.PanelTitle.Controls.Add(Me.Label36)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(348, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(873, 40)
        Me.PanelTitle.TabIndex = 16
        '
        'PictureExit
        '
        Me.PictureExit.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureExit.Image = CType(resources.GetObject("PictureExit.Image"), System.Drawing.Image)
        Me.PictureExit.Location = New System.Drawing.Point(0, 0)
        Me.PictureExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureExit.Name = "PictureExit"
        Me.PictureExit.Size = New System.Drawing.Size(36, 40)
        Me.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureExit.TabIndex = 6
        Me.PictureExit.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(822, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Cairo", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(424, 0)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(389, 37)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "برنامج  المبيعات - الاصدار الاول : تنشيط البرنامج"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextShopName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BtnActive)
        Me.Panel1.Controls.Add(Me.TextActiveNumber)
        Me.Panel1.Controls.Add(Me.TextSerialNumber)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(348, 40)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(873, 675)
        Me.Panel1.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cairo Light", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(608, 635)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 37)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "جميع الحقوق المحفوظة لدى "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cairo", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(670, 598)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(201, 37)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "هاتف : 07800126600"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cairo", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(549, 561)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(313, 37)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "برمجة وتصميم : مقتدى جبار فرهود"
        '
        'TextShopName
        '
        Me.TextShopName.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextShopName.Location = New System.Drawing.Point(18, 269)
        Me.TextShopName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextShopName.Name = "TextShopName"
        Me.TextShopName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextShopName.Size = New System.Drawing.Size(690, 44)
        Me.TextShopName.TabIndex = 26
        Me.TextShopName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.Label6.Location = New System.Drawing.Point(760, 274)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 37)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "اسم المحل"
        '
        'BtnActive
        '
        Me.BtnActive.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.BtnActive.Location = New System.Drawing.Point(308, 403)
        Me.BtnActive.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnActive.Name = "BtnActive"
        Me.BtnActive.Size = New System.Drawing.Size(112, 49)
        Me.BtnActive.TabIndex = 24
        Me.BtnActive.Text = "تقعيل"
        Me.BtnActive.UseVisualStyleBackColor = True
        '
        'TextActiveNumber
        '
        Me.TextActiveNumber.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextActiveNumber.Location = New System.Drawing.Point(18, 131)
        Me.TextActiveNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextActiveNumber.Name = "TextActiveNumber"
        Me.TextActiveNumber.ReadOnly = True
        Me.TextActiveNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextActiveNumber.Size = New System.Drawing.Size(690, 44)
        Me.TextActiveNumber.TabIndex = 23
        Me.TextActiveNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextSerialNumber
        '
        Me.TextSerialNumber.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextSerialNumber.Location = New System.Drawing.Point(18, 202)
        Me.TextSerialNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextSerialNumber.Name = "TextSerialNumber"
        Me.TextSerialNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextSerialNumber.Size = New System.Drawing.Size(690, 44)
        Me.TextSerialNumber.TabIndex = 22
        Me.TextSerialNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.Label2.Location = New System.Drawing.Point(748, 206)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 37)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "رقم التفعيل"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.Label1.Location = New System.Drawing.Point(730, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 37)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "رقم التسلسلي"
        '
        'FormActivition
        '
        Me.AcceptButton = Me.BtnActive
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1221, 715)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PictureLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormActivition"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "برنامج المبيعات - تنشيط البرنامج"
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents PictureExit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextShopName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnActive As System.Windows.Forms.Button
    Friend WithEvents TextActiveNumber As System.Windows.Forms.TextBox
    Friend WithEvents TextSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
