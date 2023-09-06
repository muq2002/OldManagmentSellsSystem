Public Class registerProductForm
    Dim myProduct As Product
    Dim getProductTable As DataTable

    Dim CurrentUser As String = My.Settings.CurrentUser
    Dim PermissonCurrent As String = My.Settings.CurrentPer
    Private Sub registerProductForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getProductTable = myProduct.getProductTableUpdate()
        registerProductTable.DataSource = getProductTable

    End Sub
    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
        'formMain.Show()
    End Sub

    'Add Product and Edit or Updata Product And Remove In Register Price
    Private Sub AddProduct_Click(sender As Object, e As EventArgs) Handles addProductButton.Click

        If isNullFields() Then
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح"
            formMyMessageBox.ShowDialog()
            Return
        End If

        If myProduct.isRepeativeProducts(codeProduct.Text, nameProduct.Text) Then
            formMyMessageBox.TextMesssage.Text = "اسم السلعة او كود السلعة موجود"
            formMyMessageBox.ShowDialog()
            Return
        End If



        myProduct.insertProduct(
            codeProduct.Text,
            nameProduct.Text,
            payingPriceProduct.Text,
            sellingPriceProduct.Text,
            quantiyProdcut.Text,
            currentUser:="test",
            abilityOfPayOff:=ablitiyOfPayOffYes.Checked
        )

        getProductTable = myProduct.getProductTableUpdate()
        registerProductTable.DataSource = getProductTable

        clearData()


    End Sub
    Private Sub EditProduct_Click(sender As Object, e As EventArgs) Handles editProductButton.Click
        If isNullFields() Then
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح"
            formMyMessageBox.ShowDialog()
            Return
        End If

        If Not registerProductTable.CurrentRow IsNot Nothing And
             IsDBNull(registerProductTable.CurrentRow.Cells(0).Value) Then : Return : End If

        myProduct.updateProduct(
            codeProduct.Text,
            nameProduct.Text,
            payingPriceProduct.Text,
            sellingPriceProduct.Text,
            quantiyProdcut.Text,
            productId:=registerProductTable.CurrentRow.Cells(0).Value,
            abilityOfPayOff:=ablitiyOfPayOffYes.Checked
        )

        getProductTable = myProduct.getProductTableUpdate()
        registerProductTable.DataSource = getProductTable

        clearData()
    End Sub
    Private Sub RemoveProduct_Click(sender As Object, e As EventArgs) Handles deleteProductButton.Click

        formMyMessageBox.TextMesssage.Text = "هل انت متأكد من حذف هذا السلعة ؟"
        formMyMessageBox.BtnNo.Visible = True : formMyMessageBox.BtnYes.Visible = True
        formMyMessageBox.ShowDialog()

        If Not formMyMessageBox.ValueButton Then : Return : End If

        If Not registerProductTable.CurrentRow IsNot Nothing And
            IsDBNull(registerProductTable.CurrentRow.Cells(0).Value) Then : Return : End If

        myProduct.removeProduct(registerProductTable.CurrentRow.Cells(0).Value)

        getProductTable = myProduct.getProductTableUpdate()
        registerProductTable.DataSource = getProductTable

        clearData()

    End Sub

    Function isNullFields()
        If codeProduct.Text.Trim <> "" And nameProduct.Text <> "" And
            sellingPriceProduct.Text <> "" And payingPriceProduct.Text <> "" And
            quantiyProdcut.Text <> "" Then : Return False : End If

        Return True

    End Function
    Sub clearData()
        For Each c As Control In GroupBox4.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        codeProduct.Select()
    End Sub


End Class