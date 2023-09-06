Public Class sellingProductForm
    Dim codeQR As New codeQRProcess()
    Dim mySellingProduct As SellingProduct
    Dim Access As DatabaseEngine
    Dim CurrentUser As String = My.Settings.CurrentUser
    Dim PermissonCurrent As String = My.Settings.CurrentPer

    Dim getProductTable As New DataTable
    Dim getCustomerTable As New DataTable
    Dim getRegisterSellingTable As New DataTable
    ' Processing on form
    Private Sub sellingProdcutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getRegisterSellingTable = Access.GetTable("select ID as [*], NameCostumer as [اسم الزبون], NameProduct as [اسم السلعة], PriceProductSelling as [سعر البيع], QunaityProduct as [الكمية], PayOff as [الخصم], WaySelling as [طريقة الدفع] ,DateSelling as [تاريخ  البيع], AddedBy as [مدخل البيان] from RegSelling  where [DeleteState]='No' order by ID")
        getProductTable = Access.GetTable("select NameProduct,CodeProduct from RegPrice where [DeleteState]='No' order by ID")
        getCustomerTable = Access.GetTable("select NameCostumer from Costumer where [DeleteState]='No'  order by ID")

        ' QR Code Load
        PictureAddRQCode.Image = codeQR.createCode("0")
        PictureRegRQCode.Image = codeQR.createCode("0")
        TextAddProductCode.Focus()

        TextAddProductDate.Text = Date.Now
        TextRegProductDate.Text = Date.Now



        ' Fetch Data
        ' Load Name Costumer
        TextRegProductCostumerName.DataSource = getCustomerTable
        TextRegProductCostumerName.ValueMember = "NameCostumer"
        TextRegProductCostumerName.DisplayMember = "NameCostumer"

        TextManageCostumerName.DataSource = getCustomerTable
        TextManageCostumerName.ValueMember = "NameCostumer"
        TextManageCostumerName.DisplayMember = "NameCostumer"



        ' Load Name Product
        TextRegProductName.DataSource = getProductTable
        TextRegProductName.ValueMember = "CodeProduct"
        TextRegProductName.DisplayMember = "NameProduct"

        ' Load Product Manage
        TextManageProductName.DataSource = getProductTable
        TextManageProductName.ValueMember = "CodeProduct"
        TextManageProductName.DisplayMember = "NameProduct"
        TextRegProductCode.Select()

        ' Load Management Table
        DGV_ManageSelling.DataSource = getRegisterSellingTable
        layoutOfDataGirdView()

        Timer1.Start()
    End Sub



    ' Layout of form
    Public Sub layoutOfDataGirdView()

        ' Require Design
        DGV_Price.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DGV_ManageSelling.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DGV_PrintBill.Height = 240
        DGV_PrintBill.Columns(3).Width = 60
        DGV_PrintBill.Columns(4).Width = 60

        ' DGV_ManageSelling
        DGV_ManageSelling.Columns(0).Width = 30
        DGV_ManageSelling.Columns(4).Width = 60
        DGV_ManageSelling.Columns(3).Width = 60
        DGV_ManageSelling.Columns(6).Width = 50
        DGV_ManageSelling.Columns(5).Width = 60
        DGV_ManageSelling.Columns(8).Width = 93
    End Sub

    ' Controls of forms
    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub
    Private Sub sellingProdcutForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        convertUSDForm.Hide()
        formMain.Show()
        Timer1.Stop()
    End Sub
    ' Here code for Selling product 
    '
    '
    ' Selling Products Tab
    Private Sub DGV_Price_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Price.SelectionChanged
        Try
            If DGV_Price.CurrentRow IsNot Nothing And Not IsDBNull(DGV_Price.CurrentRow.Cells(0).Value) Then
                updateControlsWhenMovingDGVPrice()
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' Update All TextBox While Click
    Private Sub DGV_Price_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Price.CellClick
        If DGV_Price.CurrentRow IsNot Nothing And Not IsDBNull(DGV_Price.CurrentRow.Cells(0).Value) Then
            updateControlsWhenMovingDGVPrice()
        End If
    End Sub
    Public Sub updateControlsWhenMovingDGVPrice()
        TextAddProductID.Text = DGV_Price.CurrentRow.Cells(0).Value
        TextAddProductCode.Text = DGV_Price.CurrentRow.Cells(1).Value
        TextAddProductName.Text = DGV_Price.CurrentRow.Cells(2).Value

        TextAddProductPrice.Text = DGV_Price.CurrentRow.Cells(3).Value
        TextAddProductPriceBuying.Text = DGV_Price.CurrentRow.Cells(4).Value
        TextAddProductQunaity.Text = DGV_Price.CurrentRow.Cells(5).Value
        TextAddProductDate.Text = DGV_Price.CurrentRow.Cells(6).Value

        convertUSDForm.TextOne.Text = DGV_Price.CurrentRow.Cells(3).Value * DGV_Price.CurrentRow.Cells(4).Value
        convertUSDForm.TextThree.Text = DGV_Price.RowCount - 1
    End Sub


    ' Selling Product Tab : Controls Textbox

    Private Sub TextRegProductCode_TextChanged(sender As Object, e As EventArgs) Handles TextRegProductCode.TextChanged
        PictureRegRQCode.Image = codeQR.createCode(TextRegProductCode.Text)


        ' Query to find price and qty of product here and i need to  improve
        TextRegProductPrice.Text = mySellingProduct.getNameProduct(TextRegProductCode.Text)
        TextRegProductName.Text = mySellingProduct.getPriceProduct(TextRegProductCode.Text)


        If mySellingProduct.isPayOffAcceptance(TextRegProductCode.Text) Then
            TextRegProductPayOff.ReadOnly = True
        Else
            TextRegProductPayOff.ReadOnly = False
        End If


    End Sub
    Private Sub TextRegProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextRegProductName.SelectedIndexChanged
        TextRegProductCode.Text = TextRegProductName.SelectedValue.ToString

        TextRegProductPrice.Text = mySellingProduct.getPriceProduct(TextRegProductCode.Text)
        TextRegProductPriceIDQ.Text = Val(mySellingProduct.getPriceProduct(TextRegProductCode.Text)) * 1250 & " IQD"


        If mySellingProduct.isPayOffAcceptance(TextRegProductCode.Text) Then
            TextRegProductPayOff.ReadOnly = True
        Else
            TextRegProductPayOff.ReadOnly = False
        End If

    End Sub
    Private Sub TextRegProductPayOff_TextChanged(sender As Object, e As EventArgs) Handles TextRegProductPayOff.TextChanged
        If Val(TextRegProductPayOff.Text) >= Val(TextRegProductPrice.Text) Then
            TextRegProductPayOff.Text = "0"
        End If
    End Sub

    ' Selling Product Tab : Controls buttons
    Private Sub AddBill_Click(sender As Object, e As EventArgs) Handles AddBill.Click
        If TextRegProductCode.Text <> "" And TextRegProductName.Text <> "" Then
            Dim Total As Object = (Val(TextRegProductPrice.Text * TextRegProductQunaity.Text) - Val(TextRegProductPayOff.Text))
            Dim Row() As Object = {DGV_PrintBill.Rows.Count, TextRegProductName.Text, TextRegProductPrice.Text, TextRegProductQunaity.Text, TextRegProductPayOff.Text, ComboWaySelling.Text, Total}
            TextTotalCostBill.Text += Total
            If ComboWaySelling.Text <> "نقدا" Then
                TextTotalCostBillRemain.Text += Total
            End If
            DGV_PrintBill.Rows.Add(Row)
        Else
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح"
            formMyMessageBox.ShowDialog()
        End If
    End Sub
    Private Sub DeleteBill_Click(sender As Object, e As EventArgs) Handles DeleteBill.Click
        Try

            If Not DGV_PrintBill.CurrentRow IsNot Nothing And
                IsDBNull(DGV_PrintBill.CurrentRow.Cells(0).Value) Then : Return : End If

            formMyMessageBox.TextMesssage.Text = "هل انت متأكد من حذف هذا السلعة ؟"
            formMyMessageBox.BtnNo.Visible = True : formMyMessageBox.BtnYes.Visible = True
            formMyMessageBox.ShowDialog()
            If Not formMyMessageBox.ValueButton Then : Return : End If

            ' Remove product from  data grid view printer 
            TextTotalCostBill.Text -= DGV_PrintBill.CurrentRow.Cells(6).Value
            DGV_PrintBill.Rows.RemoveAt(DGV_PrintBill.CurrentRow.Index)

            ' numerate product in bill  
            For L As Integer = 0 To DGV_PrintBill.Rows.Count - 1
                If Not IsDBNull(DGV_PrintBill.Rows(L).Cells(0).Value) Then
                    If DGV_PrintBill.Rows.Count - 1 <> L Then
                        DGV_PrintBill.Rows(L).Cells(0).Value = (L + 1)
                    End If
                End If
            Next


        Catch ex As Exception

        End Try

    End Sub
    Private Sub PrintBill_Click(sender As Object, e As EventArgs) Handles PrintBill.Click

        'If DGV_PrintBill.Rows.Count - 1 = 0 Then
        '    formMyMessageBox.TextMesssage.Text = "لا توجد فاتورة لطباعتها"
        '    formMyMessageBox.ShowDialog()
        '    Return
        'End If

        For L As Long = 0 To DGV_PrintBill.Rows.Count - 2
            'Dim CounterTable As DataTable = Access.GetTable("select * from RegSelling")
            'Access.RunCommand("insert into RegSelling values(" & CounterTable.Rows.Count + 1 & ",'" & DGV_PrintBill.Rows(L).Cells(1).Value & "','" & DGV_PrintBill.Rows(L).Cells(2).Value & "','" & DGV_PrintBill.Rows(L).Cells(3).Value & "','" & TextRegProductCostumerName.Text & "','" & TextRegProductDate.Text & "','" & DGV_PrintBill.Rows(L).Cells(5).Value & "','" & DGV_PrintBill.Rows(L).Cells(4).Value & "','" & CurrentUser & "','No')")
        Next
        formReporter.PrintBill()


        'DGV_PrintBill.Rows.Clear()
        TextTotalCostBill.Text = "0"
        TextTotalCostBillRemain.Text = "0"

    End Sub



    ' Here Code for Management Tab
    '
    '
    ' Management Selling Tab
    Private Sub DGV_ManageSelling_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_ManageSelling.SelectionChanged
        Try
            If DGV_ManageSelling.CurrentRow IsNot Nothing And Not IsDBNull(DGV_ManageSelling.CurrentRow.Cells(0).Value) Then
                updateControlsWhenMovingOnDGVManagementSelling()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGV_ManageSelling_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_ManageSelling.CellClick
        Try
            If DGV_ManageSelling.CurrentRow IsNot Nothing And Not IsDBNull(DGV_ManageSelling.CurrentRow.Cells(0).Value) Then
                updateControlsWhenMovingOnDGVManagementSelling()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub updateControlsWhenMovingOnDGVManagementSelling()
        TextManageCostumerName.Text = DGV_ManageSelling.CurrentRow.Cells(1).Value
        TextManageProductName.Text = DGV_ManageSelling.CurrentRow.Cells(2).Value
        TextManageProductWaySelling.Text = DGV_ManageSelling.CurrentRow.Cells(6).Value

        TextManageProductPrice.Text = DGV_ManageSelling.CurrentRow.Cells(3).Value
        TextManageProductQanuity.Text = DGV_ManageSelling.CurrentRow.Cells(4).Value
        TextManageProductPayOff.Text = DGV_ManageSelling.CurrentRow.Cells(5).Value

        convertUSDForm.TextOne.Text = DGV_ManageSelling.CurrentRow.Cells(3).Value * DGV_ManageSelling.CurrentRow.Cells(4).Value
        convertUSDForm.TextThree.Text = DGV_ManageSelling.RowCount - 1
        TextManageProductAddBy.Text = DGV_ManageSelling.CurrentRow.Cells(8).Value.ToString.Replace(">", vbNewLine)
    End Sub


    ' Management Selling Tab : Controls 
    Private Sub TextManageProductClearData_Click(sender As Object, e As EventArgs) Handles TextManageProductClearData.Click
        For Each c As Control In GroupBox6.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub

    Private Sub TextManageProductDelete_Click(sender As Object, e As EventArgs) Handles TextManageProductDelete.Click
        If TextManageCostumerName.Text.Trim <> "" Then
            If DGV_ManageSelling.CurrentRow IsNot Nothing And Not IsDBNull(DGV_ManageSelling.CurrentRow.Cells(0).Value) Then
                formMyMessageBox.TextMesssage.Text = "هل انت متأكد من حذف هذا السلعة ؟"
                formMyMessageBox.BtnNo.Visible = True : formMyMessageBox.BtnYes.Visible = True
                formMyMessageBox.ShowDialog()
                If formMyMessageBox.ValueButton Then
                    Access.RunCommand("Update RegSelling Set [DeleteState]= 'Yes' where ID=" & DGV_ManageSelling.CurrentRow.Cells(0).Value)

                    DGV_ManageSelling.DataSource = Access.GetTable("select ID as [*], NameCostumer as [اسم الزبون], NameProduct as [اسم السلعة], PriceProduct as [سعر السلعة], QunaityProduct as [الكمية], PayOff as [الخصم], WaySelling as [طريقة الدفع] ,DateSelling as [تاريخ  البيع], AddedBy as [مدخل البيان] from RegSelling where [DeleteState]='No' order by ID")
                    For Each c As Control In GroupBox6.Controls
                        If TypeOf c Is TextBox Then
                            c.Text = ""
                        End If
                    Next

                End If
            End If
        End If
    End Sub

    Private Sub TextManageProductEdit_Click(sender As Object, e As EventArgs) Handles TextManageProductEdit.Click

        If isNullFields() Then
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح"
            formMyMessageBox.ShowDialog()
            Return
        End If

        If Not DGV_ManageSelling.CurrentRow IsNot Nothing And
            IsDBNull(DGV_ManageSelling.CurrentRow.Cells(0).Value) Then : Return : End If


        If DGV_ManageSelling.CurrentRow.Cells(8).Value <> "" Then
            Access.RunCommand("update RegSelling set  [NameCostumer] = '" & TextManageCostumerName.Text & "', [NameProduct]='" & TextManageProductName.Text & "', [QunaityProduct]='" & TextManageProductQanuity.Text & "', [PayOff]=' " & TextManageProductPayOff.Text & "', [WaySelling]='" & TextManageProductWaySelling.Text & "', [AddedBy]='" & DGV_ManageSelling.CurrentRow.Cells(8).Value & " > " & CurrentUser & "' where [DeleteState]= 'No' and ID=" & DGV_ManageSelling.CurrentRow.Cells(0).Value)
        Else
            Access.RunCommand("update RegSelling set  [NameCostumer] = '" & TextManageCostumerName.Text & "', [NameProduct]='" & TextManageProductName.Text & "', [QunaityProduct]='" & TextManageProductQanuity.Text & "', [PayOff]=' " & TextManageProductPayOff.Text & "', [WaySelling]='" & TextManageProductWaySelling.Text & "', [AddedBy]='" & CurrentUser & "' where  [DeleteState]= 'No' and ID=" & DGV_ManageSelling.CurrentRow.Cells(0).Value)
        End If

        DGV_ManageSelling.DataSource = Access.GetTable("select ID as [*], NameCostumer as [اسم الزبون], NameProduct as [اسم السلعة], PriceProduct as [سعر السلعة], QunaityProduct as [الكمية], PayOff as [الخصم], WaySelling as [طريقة الدفع] ,DateSelling as [تاريخ  البيع], AddedBy as [مدخل البيان] from RegSelling  where [DeleteState]='No' order by ID")



    End Sub

    Sub clearData()
        For Each c As Control In GroupBox6.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Function isNullFields()
        If TextManageCostumerName.Text.Trim <> "" And TextManageProductPrice.Text <> "" And
            TextManageProductPayOff.Text <> "" And TextManageProductQanuity.Text <> "" Then : Return False : End If

        Return True
    End Function

    ' Calculate Price and Total Price from qty 
    Private Sub TextAddProductPrice_TextChanged(sender As Object, e As EventArgs) Handles TextAddProductQunaity.TextChanged, TextAddProductPriceBuying.TextChanged, TextAddProductPrice.TextChanged
        TextAddProductProfits.Text = Val(TextAddProductPriceBuying.Text) - Val(TextAddProductPrice.Text)
        TextAddProductProfitsTotal.Text = Val(TextAddProductProfits.Text) * Val(TextAddProductQunaity.Text)

        TextAddProductPriceIQD.Text = Val(TextAddProductPrice.Text) * 1250 & " IQD"
        TextAddProductPriceBuyingIQD.Text = Val(TextAddProductPriceBuying.Text) * 1250 & " IQD"
        TextAddProductProfitsIQD.Text = Val(TextAddProductProfits.Text) * 1250 & " IQD"
        TextAddProductProfitsTotalIQD.Text = Val(TextAddProductProfitsTotal.Text) * 1250 & " IQD"
    End Sub

    ' Make sure all Input in price and pay off ... is number 
    Private Sub WriteNumberOnly_KeyDown(sender As Object, e As KeyEventArgs) Handles TextAddProductQunaity.KeyDown, TextAddProductPrice.KeyDown, TextRegProductQunaity.KeyDown, TextRegProductPrice.KeyDown
        Select Case e.KeyCode
            Case Keys.D0 To Keys.D9
                If (e.Modifiers And Keys.Shift) = Keys.Shift Then
                    ' Ignore special characters e.g. Shift+1  
                    e.SuppressKeyPress = True
                End If
            Case Keys.Back, Keys.Delete
            Case Keys.Left To Keys.Down
            Case Keys.NumPad0 To Keys.NumPad9
            Case Else
                e.SuppressKeyPress = True
        End Select
    End Sub
    ' Update Time Each
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextAddProductDate.Text = Date.Now.ToString
        TextRegProductDate.Text = Date.Now.ToString
    End Sub
    ' Remove Perivous Data from convert price from.
    Private Sub TabControlBody_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlBody.SelectedIndexChanged
        convertUSDForm.TextOne.Text = "" : convertUSDForm.TextTwo.Text = "" : convertUSDForm.TextThree.Text = ""
    End Sub

End Class