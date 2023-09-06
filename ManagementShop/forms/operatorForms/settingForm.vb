
Public Class settingForm
    Dim Access As New DatabaseEngine
    Dim myUser As User
    Dim getProductTable As DataTable

    Dim getLoginTable As DataTable
    Dim getTableLoginTable As DataTable
    Dim getRegisterSellingTable As DataTable

    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        getLoginTable = myUser.getLoginTableUpdate()
        getTableLoginTable = Access.GetTable("select ID as [*], Username as [اسم المستخدم], InnerDate as [تاريخ تسجيل الدخول], OuterDate as [تاريخ تسجيل الخروج]  from TableLogin")
        getRegisterSellingTable = Access.GetTable("select ID as [*], AddedBy as [اسم المستخدم], NameCostumer as [اسم الزبون], NameProduct as [اسم السلعة], PriceProductSelling as [سعر السلعة], QunaityProduct as [الكمية], PayOff as [الخصم], WaySelling as [طريقة الدفع] , DateSelling as [تاريخ  البيع] from RegSelling where [DeleteState]='No'")


        DGV_AddUsers.DataSource = getLoginTable
        DGV_LoginTable.DataSource = getTableLoginTable
        DGV_SpyUser.DataSource = getRegisterSellingTable

        ' LOAD UERANMES
        ComboUsername.DataSource = Access.GetTable("select Username from Login")
        ComboUsername.DisplayMember = "Username"
        ComboUsername.ValueMember = "Username"


        LoadLayoutOfDataGirdView()



        TextSerialNubmer.Text = My.Settings.SerialNumber
        TextActiveNumber.Text = My.Settings.ActiveNumber
        TextActiveDate.Text = My.Settings.DateActive

    End Sub

    Private Sub Setting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        ' Save setting if while update
        My.Settings.ShopAddress = TextShopAddress.Text
        My.Settings.ShopPhone = TextShopPhone.Text
        My.Settings.ShopLogo = TextShopImagePath.Text
        My.Settings.TypeCurrenty = ComboCurrecyType.Text
        My.Settings.ShortHandCurrenty = TextShortcutCurrently.Text


        My.Settings.Save()

        ' Return current state
        formMain.Show()
        convertUSDForm.Hide()
    End Sub


    ' Controls in Setting Form
    Private Sub AddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        Dim Check As Boolean = True


        If isFieldsNull() Then
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح "
            formMyMessageBox.ShowDialog()
            Return
        End If

        For L As Integer = 0 To DGV_AddUsers.Rows.Count - 1
            If TextAddUsername.Text = DGV_AddUsers.Rows(L).Cells(1).Value Then
                Check = False
                Exit For
            End If
        Next
        'If myUser.isDuplicateLoginTable(TextAddUsername.Text, getLoginTable) Then
        '    formMyMessageBox.TextMesssage.Text = "اسم المستخدم موجود بالفعل "
        '    formMyMessageBox.ShowDialog()
        '    Return
        'End If
        Dim CounterTable As DataTable = Access.GetTable("select * from Login")



        clearData()

        DGV_AddUsers.DataSource = getLoginTable
        TextAddUsername.Select()


    End Sub
    Sub clearData()
        TextAddUsername.Text = ""
        TextAddPassword.Text = ""
    End Sub
    Function isFieldsNull()
        If TextAddUsername.Text.Trim <> "" And
            TextAddPassword.Text.Trim <> "" And ComboPermissonUser.Text.Trim <> "" And
            DTP_ExpirePermisson.Text.Trim <> "" Then : Return False : End If
        Return True
    End Function
    Private Sub RemoveUser_Click(sender As Object, e As EventArgs) Handles BtnRemoveUser.Click
        If DGV_AddUsers.CurrentRow IsNot Nothing And Not IsDBNull(DGV_AddUsers.CurrentRow.Cells(0).Value) Then
            If DGV_AddUsers.CurrentRow.Cells(0).Value <> "" Then
                Access.RunCommand("delete from Login where ID=" & DGV_AddUsers.CurrentRow.Cells(0).Value)
                DGV_AddUsers.DataSource = getLoginTable
                TextAddUsername.Text = ""
                TextAddPassword.Text = ""
                ' Select Username Field
                TextAddUsername.Select()
            End If
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If CheckUsingDateAndTime.Checked Then
            DGV_SpyUser.DataSource = Access.GetTable("select ID as [*], AddedBy as [اسم المستخدم], NameCostumer as [اسم الزبون], NameProduct as [اسم السلعة], PriceProductSelling as [سعر السلعة], QunaityProduct as [الكمية], PayOff as [الخصم], WaySelling as [طريقة الدفع] , DateSelling as [تاريخ  البيع] from RegSelling Where [AddedBy] LIKE'%" & ComboUsername.Text & "%' And [DateSelling] Like'%" & DTP_SearchUsername.Text & "%' And [DeleteState]='No' ")
        Else
            DGV_SpyUser.DataSource = Access.GetTable("select ID as [*], AddedBy as [اسم المستخدم], NameCostumer as [اسم الزبون], NameProduct as [اسم السلعة], PriceProductSelling as [سعر السلعة], QunaityProduct as [الكمية], PayOff as [الخصم], WaySelling as [طريقة الدفع] , DateSelling as [تاريخ  البيع] from RegSelling Where [AddedBy] LIKE'%" & ComboUsername.Text & "%' and [DeleteState]='No' ")
        End If
        TextTotalWorking.Text = DGV_SpyUser.Rows.Count - 1
        LoadAccounting()
    End Sub

    Private Sub BtnAddImageLogo_Click(sender As Object, e As EventArgs)
        Dim OFD As New OpenFileDialog()
        OFD.Title = "اختر صورة كشعار للمحل"
        If OFD.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'TextShopImagePath.Text = OFD.FileName
        End If
    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub


    Public Sub LoadAccounting()
        Dim GotPriceAsUnLive As DataTable = Access.GetTable("select PriceProductSelling from RegSelling Where [WaySelling]='بالاجل' And [AddedBy] LIKE'%" & ComboUsername.Text & "%'")

        For Each Data As DataRow In GotPriceAsUnLive.Rows
            TextTotalGotMoneyUnLIve.Text += Val(Data.Item(0).ToString)
        Next
        Dim GotPrice, GotPayOff As Long
        For L As Integer = 0 To DGV_SpyUser.Rows.Count - 2
            GotPrice += Val(DGV_SpyUser.Rows(L).Cells(4).Value * DGV_SpyUser.Rows(L).Cells(5).Value)
            GotPayOff += Val(DGV_SpyUser.Rows(L).Cells(6).Value)
        Next
        TextTotalMoney.Text = GotPrice
        TextTotalGotMoneyLive.Text = Val(GotPrice - GotPayOff) - TextTotalGotMoneyUnLIve.Text
        TextTotalGotMoneyPayOff.Text = GotPayOff
    End Sub

    Public Sub LoadLayoutOfDataGirdView()
        ' Layout of DGV_User table
        DGV_AddUsers.Columns(0).Width = 30
        DGV_AddUsers.Columns(1).Width = 150
        DGV_AddUsers.Columns(2).Width = 130
        DGV_AddUsers.Columns(4).Width = 130
        TextAddUsername.Select()

        ' Layout of DGV_login table
        DGV_LoginTable.Columns(0).Width = 40
        DGV_LoginTable.Columns(1).Width = 130
        DGV_LoginTable.Columns(2).Width = 150
        DGV_LoginTable.Columns(3).Width = 150

        ' Layout of Spy user table
        DGV_SpyUser.Columns(0).Width = 30
        DGV_SpyUser.Columns(3).Width = 80
        DGV_SpyUser.Columns(4).Width = 80
        DGV_SpyUser.Columns(5).Width = 55
        DGV_SpyUser.Columns(6).Width = 50
        DGV_SpyUser.Columns(7).Width = 60
    End Sub

End Class

Module SettingTools

End Module