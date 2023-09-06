<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMyMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMyMessageBox))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextMesssage = New System.Windows.Forms.TextBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnNo)
        Me.Panel1.Controls.Add(Me.BtnYes)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextMesssage)
        Me.Panel1.Controls.Add(Me.PanelTitle)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 164)
        Me.Panel1.TabIndex = 0
        '
        'BtnNo
        '
        Me.BtnNo.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.BtnNo.Location = New System.Drawing.Point(12, 123)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(76, 31)
        Me.BtnNo.TabIndex = 25
        Me.BtnNo.Text = "لا"
        Me.BtnNo.UseVisualStyleBackColor = True
        Me.BtnNo.Visible = False
        '
        'BtnYes
        '
        Me.BtnYes.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.BtnYes.Location = New System.Drawing.Point(94, 123)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(75, 31)
        Me.BtnYes.TabIndex = 24
        Me.BtnYes.Text = "نعم"
        Me.BtnYes.UseVisualStyleBackColor = True
        Me.BtnYes.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(398, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(95, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'TextMesssage
        '
        Me.TextMesssage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextMesssage.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextMesssage.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextMesssage.Location = New System.Drawing.Point(6, 41)
        Me.TextMesssage.Multiline = True
        Me.TextMesssage.Name = "TextMesssage"
        Me.TextMesssage.ReadOnly = True
        Me.TextMesssage.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextMesssage.Size = New System.Drawing.Size(386, 76)
        Me.TextMesssage.TabIndex = 23
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelTitle.Controls.Add(Me.PictureExit)
        Me.PanelTitle.Controls.Add(Me.PictureLogo)
        Me.PanelTitle.Controls.Add(Me.Label36)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(507, 26)
        Me.PanelTitle.TabIndex = 21
        '
        'PictureExit
        '
        Me.PictureExit.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureExit.Image = CType(resources.GetObject("PictureExit.Image"), System.Drawing.Image)
        Me.PictureExit.Location = New System.Drawing.Point(0, 0)
        Me.PictureExit.Name = "PictureExit"
        Me.PictureExit.Size = New System.Drawing.Size(24, 26)
        Me.PictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureExit.TabIndex = 6
        Me.PictureExit.TabStop = False
        '
        'PictureLogo
        '
        Me.PictureLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(473, 0)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(34, 26)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 5
        Me.PictureLogo.TabStop = False
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Cairo", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(266, 2)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(212, 24)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "برنامج  المبيعات - الاصدار الاول : تحذير "
        '
        'MyMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 164)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MyMessageBox"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnNo As System.Windows.Forms.Button
    Friend WithEvents BtnYes As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextMesssage As System.Windows.Forms.TextBox
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents PictureExit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
End Class
