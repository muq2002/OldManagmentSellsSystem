Imports System.Data
Imports System.Configuration

Public Class registerCustomerForm

    Dim getCustomerTable As DataTable
    Dim myCustomer As New Customer


    Dim CurrentUser As String = My.Settings.CurrentUser
    Dim PermissonCurrent As String = My.Settings.CurrentPer

    Private Sub registerCustomerForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        convertUSDForm.Hide()
        formMain.Show()
    End Sub
    Private Sub registerCustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  Fetch Data
        getCustomerTable = myCustomer.getCustomerTableUpdate()
        DGV_Costumer.DataSource = getCustomerTable

        layoutOfDGVCustomer()
    End Sub


    '
    '
    ' Forms Layout and Design
    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub

    ' DataGirdView Layouts and Specification 

    Sub layoutOfDGVCustomer()
        ' Require Design
        DGV_Costumer.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ' Costumer From
        TextCostumerDate.Text = Date.Now
        DGV_Costumer.Columns(0).Width = 30
        DGV_Costumer.Columns(1).Width = 200
        DGV_Costumer.Columns(2).Width = 80
        DGV_Costumer.Columns(3).Width = 150
        DGV_Costumer.Columns(4).Width = 80
    End Sub

    Private Sub DGV_Costumer_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_Costumer.SelectionChanged
        Try
            If DGV_Costumer.CurrentRow IsNot Nothing And Not IsDBNull(DGV_Costumer.CurrentRow.Cells(0).Value) Then
                updateControlsWhenMovingDGVCustomer()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub DGV_Costumer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Costumer.CellClick
        Try
            If DGV_Costumer.CurrentRow IsNot Nothing And Not IsDBNull(DGV_Costumer.CurrentRow.Cells(0).Value) Then
                updateControlsWhenMovingDGVCustomer()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Sub updateControlsWhenMovingDGVCustomer()
        TextCostumerName.Text = DGV_Costumer.CurrentRow.Cells(1).Value
        TextCostumerPhoneNmuber.Text = DGV_Costumer.CurrentRow.Cells(2).Value
        TextCostumerNote.Text = DGV_Costumer.CurrentRow.Cells(3).Value
        TextCostumerDate.Text = DGV_Costumer.CurrentRow.Cells(4).Value
    End Sub



    '
    '
    '
    ' Controls of Customer page
    Private Sub BtnAddCostumer_Click(sender As Object, e As EventArgs) Handles BtnAddCostumer.Click

        If TextCostumerName.Text.Trim = "" And TextCostumerDate.Text = "" Then
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح"
            formMyMessageBox.ShowDialog()
            Return
        End If


        If myCustomer.isDuplicateCustomerTable(TextCostumerName.Text, getCustomerTable) = 0 Then

            ' Set notes and phone number if user don't have to avoid null value in database
            If TextCostumerNote.Text.Trim = "" Then TextCostumerNote.Text = "لايوجد"
            If TextCostumerPhoneNmuber.Text.Trim = "" Then TextCostumerPhoneNmuber.Text = "لايوحد"


            myCustomer.addCustomer(TextCostumerName.Text, TextCostumerPhoneNmuber.Text,
                          TextCostumerNote.Text, TextCostumerDate.Text,
                          CurrentUser)
            getCustomerTable = myCustomer.getCustomerTableUpdate()
            DGV_Costumer.DataSource = getCustomerTable

            clearCustomerDataWorker()
        Else
            formMyMessageBox.TextMesssage.Text = "اسم السلعة او كود السلعة موجود"
            formMyMessageBox.ShowDialog()
        End If

    End Sub



    Private Sub BtnDeleteCostumer_Click(sender As Object, e As EventArgs) Handles BtnDeleteCostumer.Click

        If DGV_Costumer.CurrentRow IsNot Nothing And Not IsDBNull(DGV_Costumer.CurrentRow.Cells(0).Value) Then

            formMyMessageBox.TextMesssage.Text = "هل انت متأكد من حذف هذا الزبون ؟"
            formMyMessageBox.BtnNo.Visible = True : formMyMessageBox.BtnYes.Visible = True
            formMyMessageBox.ShowDialog()
            If Not formMyMessageBox.ValueButton Then : Return : End If

            myCustomer.deleteCustomer(DGV_Costumer.CurrentRow.Cells(0).Value)

            getCustomerTable = myCustomer.getCustomerTableUpdate()
            DGV_Costumer.DataSource = getCustomerTable

            clearCustomerDataWorker()

        End If
    End Sub

    Private Sub BtnEditCostumer_Click(sender As Object, e As EventArgs) Handles BtnEditCostumer.Click
        If checkNullTextBoxs() Then
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح"
            formMyMessageBox.ShowDialog()
            Return
        End If

        If DGV_Costumer.CurrentRow IsNot Nothing And
            Not IsDBNull(DGV_Costumer.CurrentRow.Cells(0).Value) Then

            If TextCostumerNote.Text.Trim = "" Then TextCostumerNote.Text = "لايوجد"
            If TextCostumerPhoneNmuber.Text.Trim = "" Then TextCostumerPhoneNmuber.Text = "لايوحد"

            myCustomer.updateCustomer(TextCostumerName.Text, TextCostumerPhoneNmuber.Text,
                                      TextCostumerNote.Text, TextCostumerDate.Text,
                                      DGV_Costumer.CurrentRow.Cells(0).Value)

            getCustomerTable = myCustomer.getCustomerTableUpdate()
            DGV_Costumer.DataSource = getCustomerTable

            clearCustomerDataWorker()

        End If

    End Sub

    Private Sub BtnClearCostumer_Click(sender As Object, e As EventArgs) Handles BtnClearCostumer.Click
        clearCustomerDataWorker()
    End Sub
    '
    '
    ' Make you write number only
    Private Sub TextCostumerPhoneNmuber_KeyDown(sender As Object, e As KeyEventArgs)
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

End Class

Module customerFormTools
    Function checkNullTextBoxs()
        If registerCustomerForm.TextCostumerName.Text.Trim <> "" And registerCustomerForm.TextCostumerPhoneNmuber.Text <> "" And
            registerCustomerForm.TextCostumerNote.Text <> "" And registerCustomerForm.TextCostumerDate.Text <> "" Then : Return False : End If
        Return True
    End Function
    Sub clearCustomerDataWorker()
        For Each c As Control In registerCustomerForm.GroupBox5.Controls
            If TypeOf c Is TextBox Then
                c.Text = ""
            End If
        Next
        registerCustomerForm.TextCostumerDate.Text = Date.Now.ToShortDateString
        registerCustomerForm.TextCostumerName.Select()
    End Sub
End Module