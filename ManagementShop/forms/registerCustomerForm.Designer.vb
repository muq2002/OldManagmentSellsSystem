<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerCustomerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registerCustomerForm))
        Me.Splitter3 = New System.Windows.Forms.Splitter()
        Me.BtnClearCostumer = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnDeleteCostumer = New System.Windows.Forms.Button()
        Me.BtnEditCostumer = New System.Windows.Forms.Button()
        Me.BtnAddCostumer = New System.Windows.Forms.Button()
        Me.TextCostumerDate = New System.Windows.Forms.TextBox()
        Me.TextCostumerNote = New System.Windows.Forms.TextBox()
        Me.TextCostumerPhoneNmuber = New System.Windows.Forms.TextBox()
        Me.TextCostumerName = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DGV_Costumer = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabControlBody = New System.Windows.Forms.TabControl()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.GroupBox5.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.DGV_Costumer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControlBody.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter3
        '
        Me.Splitter3.Location = New System.Drawing.Point(4, 42)
        Me.Splitter3.Name = "Splitter3"
        Me.Splitter3.Size = New System.Drawing.Size(3, 904)
        Me.Splitter3.TabIndex = 20
        Me.Splitter3.TabStop = False
        '
        'BtnClearCostumer
        '
        Me.BtnClearCostumer.Location = New System.Drawing.Point(436, 495)
        Me.BtnClearCostumer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClearCostumer.Name = "BtnClearCostumer"
        Me.BtnClearCostumer.Size = New System.Drawing.Size(120, 54)
        Me.BtnClearCostumer.TabIndex = 19
        Me.BtnClearCostumer.Text = "تفريغ  الخانات"
        Me.BtnClearCostumer.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Splitter3)
        Me.GroupBox5.Controls.Add(Me.BtnClearCostumer)
        Me.GroupBox5.Controls.Add(Me.BtnDeleteCostumer)
        Me.GroupBox5.Controls.Add(Me.BtnEditCostumer)
        Me.GroupBox5.Controls.Add(Me.BtnAddCostumer)
        Me.GroupBox5.Controls.Add(Me.TextCostumerDate)
        Me.GroupBox5.Controls.Add(Me.TextCostumerNote)
        Me.GroupBox5.Controls.Add(Me.TextCostumerPhoneNmuber)
        Me.GroupBox5.Controls.Add(Me.TextCostumerName)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Size = New System.Drawing.Size(932, 951)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "تسجيل الزبائن"
        '
        'BtnDeleteCostumer
        '
        Me.BtnDeleteCostumer.Location = New System.Drawing.Point(436, 431)
        Me.BtnDeleteCostumer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnDeleteCostumer.Name = "BtnDeleteCostumer"
        Me.BtnDeleteCostumer.Size = New System.Drawing.Size(120, 54)
        Me.BtnDeleteCostumer.TabIndex = 18
        Me.BtnDeleteCostumer.Text = "حذف"
        Me.BtnDeleteCostumer.UseVisualStyleBackColor = True
        '
        'BtnEditCostumer
        '
        Me.BtnEditCostumer.Location = New System.Drawing.Point(648, 495)
        Me.BtnEditCostumer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnEditCostumer.Name = "BtnEditCostumer"
        Me.BtnEditCostumer.Size = New System.Drawing.Size(112, 54)
        Me.BtnEditCostumer.TabIndex = 17
        Me.BtnEditCostumer.Text = "تعديل"
        Me.BtnEditCostumer.UseVisualStyleBackColor = True
        '
        'BtnAddCostumer
        '
        Me.BtnAddCostumer.Location = New System.Drawing.Point(648, 431)
        Me.BtnAddCostumer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddCostumer.Name = "BtnAddCostumer"
        Me.BtnAddCostumer.Size = New System.Drawing.Size(112, 54)
        Me.BtnAddCostumer.TabIndex = 16
        Me.BtnAddCostumer.Text = "اضافة"
        Me.BtnAddCostumer.UseVisualStyleBackColor = True
        '
        'TextCostumerDate
        '
        Me.TextCostumerDate.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextCostumerDate.Location = New System.Drawing.Point(444, 338)
        Me.TextCostumerDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextCostumerDate.Name = "TextCostumerDate"
        Me.TextCostumerDate.ReadOnly = True
        Me.TextCostumerDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextCostumerDate.Size = New System.Drawing.Size(316, 44)
        Me.TextCostumerDate.TabIndex = 11
        Me.TextCostumerDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCostumerNote
        '
        Me.TextCostumerNote.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextCostumerNote.Location = New System.Drawing.Point(444, 229)
        Me.TextCostumerNote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextCostumerNote.Multiline = True
        Me.TextCostumerNote.Name = "TextCostumerNote"
        Me.TextCostumerNote.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextCostumerNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextCostumerNote.Size = New System.Drawing.Size(316, 101)
        Me.TextCostumerNote.TabIndex = 10
        '
        'TextCostumerPhoneNmuber
        '
        Me.TextCostumerPhoneNmuber.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextCostumerPhoneNmuber.Location = New System.Drawing.Point(444, 175)
        Me.TextCostumerPhoneNmuber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextCostumerPhoneNmuber.Name = "TextCostumerPhoneNmuber"
        Me.TextCostumerPhoneNmuber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextCostumerPhoneNmuber.Size = New System.Drawing.Size(316, 44)
        Me.TextCostumerPhoneNmuber.TabIndex = 9
        Me.TextCostumerPhoneNmuber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCostumerName
        '
        Me.TextCostumerName.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TextCostumerName.Location = New System.Drawing.Point(444, 122)
        Me.TextCostumerName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextCostumerName.Name = "TextCostumerName"
        Me.TextCostumerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextCostumerName.Size = New System.Drawing.Size(316, 44)
        Me.TextCostumerName.TabIndex = 8
        Me.TextCostumerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(813, 226)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 37)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "ملاحظة"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(782, 180)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 37)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "رقم الهاتف"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(774, 343)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(121, 37)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "تاريخ الاضافة"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(789, 126)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 37)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "اسم الزبون"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(4, 5)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox8)
        Me.SplitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer2.Size = New System.Drawing.Size(1908, 951)
        Me.SplitContainer2.SplitterDistance = 932
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DGV_Costumer)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox8.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Size = New System.Drawing.Size(970, 951)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "سجل الزبائن"
        '
        'DGV_Costumer
        '
        Me.DGV_Costumer.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DGV_Costumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Costumer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Costumer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGV_Costumer.Location = New System.Drawing.Point(4, 42)
        Me.DGV_Costumer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DGV_Costumer.Name = "DGV_Costumer"
        Me.DGV_Costumer.Size = New System.Drawing.Size(962, 904)
        Me.DGV_Costumer.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 45)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1916, 961)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "تسجيل الزبائن"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabControlBody
        '
        Me.TabControlBody.Controls.Add(Me.TabPage1)
        Me.TabControlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlBody.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TabControlBody.Location = New System.Drawing.Point(0, 40)
        Me.TabControlBody.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControlBody.Name = "TabControlBody"
        Me.TabControlBody.RightToLeftLayout = True
        Me.TabControlBody.SelectedIndex = 0
        Me.TabControlBody.Size = New System.Drawing.Size(1924, 1010)
        Me.TabControlBody.TabIndex = 19
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label36.Font = New System.Drawing.Font("Cairo", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(1479, 0)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(394, 37)
        Me.Label36.TabIndex = 7
        Me.Label36.Text = "برنامج  المبيعات - الاصدار الاول : سجل المبيعات"
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
        'PictureLogo
        '
        Me.PictureLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(1873, 0)
        Me.PictureLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureLogo.Name = "PictureLogo"
        Me.PictureLogo.Size = New System.Drawing.Size(51, 40)
        Me.PictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureLogo.TabIndex = 5
        Me.PictureLogo.TabStop = False
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Gainsboro
        Me.PanelTitle.Controls.Add(Me.Label36)
        Me.PanelTitle.Controls.Add(Me.PictureExit)
        Me.PanelTitle.Controls.Add(Me.PictureLogo)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1924, 40)
        Me.PanelTitle.TabIndex = 18
        '
        'registerCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1924, 1050)
        Me.Controls.Add(Me.TabControlBody)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "registerCustomerForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "registerCustomerForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.DGV_Costumer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControlBody.ResumeLayout(False)
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Splitter3 As System.Windows.Forms.Splitter
    Friend WithEvents BtnClearCostumer As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDeleteCostumer As System.Windows.Forms.Button
    Friend WithEvents BtnEditCostumer As System.Windows.Forms.Button
    Friend WithEvents BtnAddCostumer As System.Windows.Forms.Button
    Friend WithEvents TextCostumerDate As System.Windows.Forms.TextBox
    Friend WithEvents TextCostumerNote As System.Windows.Forms.TextBox
    Friend WithEvents TextCostumerPhoneNmuber As System.Windows.Forms.TextBox
    Friend WithEvents TextCostumerName As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Costumer As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabControlBody As System.Windows.Forms.TabControl
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents PictureExit As System.Windows.Forms.PictureBox
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
End Class
