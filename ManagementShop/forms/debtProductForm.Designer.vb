<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class debtProductForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(debtProductForm))
        Me.PictureLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.PictureExit = New System.Windows.Forms.PictureBox()
        Me.registerProductTable = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ablitiyOfPayOffNo = New System.Windows.Forms.RadioButton()
        Me.ablitiyOfPayOffYes = New System.Windows.Forms.RadioButton()
        Me.clearDataButton = New System.Windows.Forms.Button()
        Me.deleteProductButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.payingPriceProduct = New System.Windows.Forms.TextBox()
        Me.sellingPriceProduct = New System.Windows.Forms.TextBox()
        Me.nameProduct = New System.Windows.Forms.TextBox()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.quantiyProdcut = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.codePictureProduct = New System.Windows.Forms.PictureBox()
        Me.editProductButton = New System.Windows.Forms.Button()
        Me.addProductButton = New System.Windows.Forms.Button()
        Me.codeProduct = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabPageRegisterSelling = New System.Windows.Forms.TabPage()
        Me.TabControlBody = New System.Windows.Forms.TabControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelTitle.SuspendLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.registerProductTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.codePictureProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabPageRegisterSelling.SuspendLayout()
        Me.TabControlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureLogo
        '
        Me.PictureLogo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureLogo.Image = CType(resources.GetObject("PictureLogo.Image"), System.Drawing.Image)
        Me.PictureLogo.Location = New System.Drawing.Point(1851, 0)
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
        Me.PanelTitle.Size = New System.Drawing.Size(1902, 40)
        Me.PanelTitle.TabIndex = 20
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label36.Font = New System.Drawing.Font("Cairo", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(1458, 0)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(393, 37)
        Me.Label36.TabIndex = 7
        Me.Label36.Text = "برنامج  المبيعات - الاصدار الاول : سجل المنتجات"
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
        'registerProductTable
        '
        Me.registerProductTable.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.registerProductTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.registerProductTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.registerProductTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.registerProductTable.Location = New System.Drawing.Point(4, 42)
        Me.registerProductTable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.registerProductTable.Name = "registerProductTable"
        Me.registerProductTable.Size = New System.Drawing.Size(951, 848)
        Me.registerProductTable.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.registerProductTable)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(959, 895)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "سجل المنتجات"
        '
        'ablitiyOfPayOffNo
        '
        Me.ablitiyOfPayOffNo.AutoSize = True
        Me.ablitiyOfPayOffNo.Location = New System.Drawing.Point(610, 463)
        Me.ablitiyOfPayOffNo.Name = "ablitiyOfPayOffNo"
        Me.ablitiyOfPayOffNo.Size = New System.Drawing.Size(55, 41)
        Me.ablitiyOfPayOffNo.TabIndex = 37
        Me.ablitiyOfPayOffNo.TabStop = True
        Me.ablitiyOfPayOffNo.Text = "لا"
        Me.ablitiyOfPayOffNo.UseVisualStyleBackColor = True
        '
        'ablitiyOfPayOffYes
        '
        Me.ablitiyOfPayOffYes.AutoSize = True
        Me.ablitiyOfPayOffYes.Location = New System.Drawing.Point(689, 463)
        Me.ablitiyOfPayOffYes.Name = "ablitiyOfPayOffYes"
        Me.ablitiyOfPayOffYes.Size = New System.Drawing.Size(73, 41)
        Me.ablitiyOfPayOffYes.TabIndex = 36
        Me.ablitiyOfPayOffYes.TabStop = True
        Me.ablitiyOfPayOffYes.Text = "نعم"
        Me.ablitiyOfPayOffYes.UseVisualStyleBackColor = True
        '
        'clearDataButton
        '
        Me.clearDataButton.Location = New System.Drawing.Point(446, 595)
        Me.clearDataButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.clearDataButton.Name = "clearDataButton"
        Me.clearDataButton.Size = New System.Drawing.Size(112, 49)
        Me.clearDataButton.TabIndex = 35
        Me.clearDataButton.Text = "تفريغ"
        Me.clearDataButton.UseVisualStyleBackColor = True
        '
        'deleteProductButton
        '
        Me.deleteProductButton.Location = New System.Drawing.Point(650, 595)
        Me.deleteProductButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.deleteProductButton.Name = "deleteProductButton"
        Me.deleteProductButton.Size = New System.Drawing.Size(112, 49)
        Me.deleteProductButton.TabIndex = 34
        Me.deleteProductButton.Text = "حذف"
        Me.deleteProductButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(791, 331)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 37)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "سعر البيع "
        '
        'payingPriceProduct
        '
        Me.payingPriceProduct.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.payingPriceProduct.Location = New System.Drawing.Point(446, 328)
        Me.payingPriceProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.payingPriceProduct.Name = "payingPriceProduct"
        Me.payingPriceProduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.payingPriceProduct.Size = New System.Drawing.Size(316, 44)
        Me.payingPriceProduct.TabIndex = 32
        Me.payingPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'sellingPriceProduct
        '
        Me.sellingPriceProduct.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.sellingPriceProduct.Location = New System.Drawing.Point(446, 274)
        Me.sellingPriceProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sellingPriceProduct.Name = "sellingPriceProduct"
        Me.sellingPriceProduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sellingPriceProduct.Size = New System.Drawing.Size(316, 44)
        Me.sellingPriceProduct.TabIndex = 31
        Me.sellingPriceProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'nameProduct
        '
        Me.nameProduct.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.nameProduct.Location = New System.Drawing.Point(446, 141)
        Me.nameProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nameProduct.Multiline = True
        Me.nameProduct.Name = "nameProduct"
        Me.nameProduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nameProduct.Size = New System.Drawing.Size(316, 123)
        Me.nameProduct.TabIndex = 30
        Me.nameProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(4, 42)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 1055)
        Me.Splitter2.TabIndex = 29
        Me.Splitter2.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(803, 463)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(70, 37)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "الخصم"
        '
        'quantiyProdcut
        '
        Me.quantiyProdcut.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.quantiyProdcut.Location = New System.Drawing.Point(446, 393)
        Me.quantiyProdcut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.quantiyProdcut.Name = "quantiyProdcut"
        Me.quantiyProdcut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.quantiyProdcut.Size = New System.Drawing.Size(316, 44)
        Me.quantiyProdcut.TabIndex = 14
        Me.quantiyProdcut.Text = "1"
        Me.quantiyProdcut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(782, 393)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 37)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "كمية السلعة"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.Label9.Location = New System.Drawing.Point(118, 371)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 37)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "كود السلعة"
        '
        'codePictureProduct
        '
        Me.codePictureProduct.Location = New System.Drawing.Point(42, 77)
        Me.codePictureProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.codePictureProduct.Name = "codePictureProduct"
        Me.codePictureProduct.Size = New System.Drawing.Size(243, 289)
        Me.codePictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.codePictureProduct.TabIndex = 16
        Me.codePictureProduct.TabStop = False
        '
        'editProductButton
        '
        Me.editProductButton.Location = New System.Drawing.Point(446, 536)
        Me.editProductButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.editProductButton.Name = "editProductButton"
        Me.editProductButton.Size = New System.Drawing.Size(112, 49)
        Me.editProductButton.TabIndex = 17
        Me.editProductButton.Text = "تعديل"
        Me.editProductButton.UseVisualStyleBackColor = True
        '
        'addProductButton
        '
        Me.addProductButton.Location = New System.Drawing.Point(650, 536)
        Me.addProductButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.addProductButton.Name = "addProductButton"
        Me.addProductButton.Size = New System.Drawing.Size(112, 49)
        Me.addProductButton.TabIndex = 16
        Me.addProductButton.Text = "تسجيل"
        Me.addProductButton.UseVisualStyleBackColor = True
        '
        'codeProduct
        '
        Me.codeProduct.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.codeProduct.Location = New System.Drawing.Point(446, 79)
        Me.codeProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.codeProduct.Name = "codeProduct"
        Me.codeProduct.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.codeProduct.Size = New System.Drawing.Size(316, 44)
        Me.codeProduct.TabIndex = 10
        Me.codeProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(791, 277)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 37)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "سعر السلعة"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(791, 144)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 37)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "اسم السلعة"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(791, 85)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 37)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "كود السلعة"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ablitiyOfPayOffNo)
        Me.GroupBox4.Controls.Add(Me.ablitiyOfPayOffYes)
        Me.GroupBox4.Controls.Add(Me.clearDataButton)
        Me.GroupBox4.Controls.Add(Me.deleteProductButton)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.payingPriceProduct)
        Me.GroupBox4.Controls.Add(Me.sellingPriceProduct)
        Me.GroupBox4.Controls.Add(Me.nameProduct)
        Me.GroupBox4.Controls.Add(Me.Splitter2)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.quantiyProdcut)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.codePictureProduct)
        Me.GroupBox4.Controls.Add(Me.editProductButton)
        Me.GroupBox4.Controls.Add(Me.addProductButton)
        Me.GroupBox4.Controls.Add(Me.codeProduct)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(921, 1102)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "تسجيل المنتجات"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 5)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1886, 895)
        Me.SplitContainer1.SplitterDistance = 921
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 1
        '
        'TabPageRegisterSelling
        '
        Me.TabPageRegisterSelling.Controls.Add(Me.SplitContainer1)
        Me.TabPageRegisterSelling.Location = New System.Drawing.Point(4, 45)
        Me.TabPageRegisterSelling.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageRegisterSelling.Name = "TabPageRegisterSelling"
        Me.TabPageRegisterSelling.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPageRegisterSelling.Size = New System.Drawing.Size(1894, 905)
        Me.TabPageRegisterSelling.TabIndex = 1
        Me.TabPageRegisterSelling.Text = "تسجيل المنتجات"
        Me.TabPageRegisterSelling.UseVisualStyleBackColor = True
        '
        'TabControlBody
        '
        Me.TabControlBody.Controls.Add(Me.TabPageRegisterSelling)
        Me.TabControlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlBody.Font = New System.Drawing.Font("Cairo", 9.749999!)
        Me.TabControlBody.Location = New System.Drawing.Point(0, 40)
        Me.TabControlBody.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControlBody.Name = "TabControlBody"
        Me.TabControlBody.RightToLeftLayout = True
        Me.TabControlBody.SelectedIndex = 0
        Me.TabControlBody.Size = New System.Drawing.Size(1902, 954)
        Me.TabControlBody.TabIndex = 21
        '
        'debtProductForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 994)
        Me.Controls.Add(Me.TabControlBody)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "debtProductForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "debtProductForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        CType(Me.PictureExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.registerProductTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.codePictureProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabPageRegisterSelling.ResumeLayout(False)
        Me.TabControlBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureLogo As System.Windows.Forms.PictureBox
    Friend WithEvents PanelTitle As System.Windows.Forms.Panel
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents PictureExit As System.Windows.Forms.PictureBox
    Friend WithEvents registerProductTable As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ablitiyOfPayOffNo As System.Windows.Forms.RadioButton
    Friend WithEvents ablitiyOfPayOffYes As System.Windows.Forms.RadioButton
    Friend WithEvents clearDataButton As System.Windows.Forms.Button
    Friend WithEvents deleteProductButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents payingPriceProduct As System.Windows.Forms.TextBox
    Friend WithEvents sellingPriceProduct As System.Windows.Forms.TextBox
    Friend WithEvents nameProduct As System.Windows.Forms.TextBox
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents quantiyProdcut As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents codePictureProduct As System.Windows.Forms.PictureBox
    Friend WithEvents editProductButton As System.Windows.Forms.Button
    Friend WithEvents addProductButton As System.Windows.Forms.Button
    Friend WithEvents codeProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TabPageRegisterSelling As System.Windows.Forms.TabPage
    Friend WithEvents TabControlBody As System.Windows.Forms.TabControl
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
