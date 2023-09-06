
Public Class formMain

    Dim CurrentUser As String = My.Settings.CurrentUser ' Select Current User 
    Dim PermissonCurrent As String = My.Settings.CurrentPer ' Select current permisson of logged users 
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabShopName.Text = My.Settings.ShopName
        LabTime.Text = Date.Now()

        ' To show and update time.
        Timer1.Start()
    End Sub
    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Check serial number and activation number for user
        Dim Access As New DatabaseEngine
        If My.Settings.ActiveNumber <> "" And My.Settings.SerialNumber <> "" Then
            If My.Settings.Logged = False Then
                ' Add Session for this user 
                settingForm.DGV_AddUsers.DataSource = Access.GetTable("select ID as [*], Username as [اسم المستخدم], Password as [كلمة المرور], Permission as [الصلاحية],ExpirePermisson as [نفاذ الصلاحية]  from Login")
                ' Check if the program has accounts history
                If settingForm.DGV_AddUsers.Rows.Count - 1 > 0 Then
                    formLogin.Show()
                End If
            End If
            Application.DoEvents()
        Else
            ' Activation problems 
            Me.Hide()
            FormActivition.ShowDialog()
        End If
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Reset all values of form 
        My.Settings.CurrentUser = ""
        My.Settings.CurrentPass = ""
        My.Settings.CurrentPer = ""
        My.Settings.Logged = False

        Dim MyDataBase As New DatabaseEngine
        settingForm.DGV_LoginTable.DataSource = MyDataBase.GetTable("select ID as [*], Username as [اسم المستخدم], InnerDate as [تاريخ تسجيل الدخول], OuterDate as [تاريخ تسجيل الخروج]  from TableLogin")
        MyDataBase.RunCommand("update TableLogin set [OuterDate]='" & Date.Now & "' where ID=" & settingForm.DGV_LoginTable.RowCount - 1)
        MyDataBase.DisposeConnection()

        My.Settings.Save()
    End Sub


    ' Other layouts and settings
    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Application.Exit()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LabTime.Text = Date.Now()
    End Sub


    ' Menu and Tools
    Private Sub registerProductPicture_Click(sender As Object, e As EventArgs) Handles registerProductPicture.Click
        registerProductForm.Show()
        convertUSDForm.Show()
        Me.Hide()
    End Sub
    Private Sub PictureSelling_Click(sender As Object, e As EventArgs) Handles PictureSelling.Click
        sellingProductForm.Show()
        convertUSDForm.Show()
        Me.Hide()
    End Sub
    Private Sub PictureCustomer_Click(sender As Object, e As EventArgs) Handles PictureCustomer.Click
        registerCustomerForm.Show()
        'FormDetailsMath.Show()
        Me.Hide()
    End Sub


    Private Sub PictureDebt_Click(sender As Object, e As EventArgs) Handles PictureDebt.Click
        debtProductForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureCounting_Click(sender As Object, e As EventArgs) Handles PictureCounting.Click
        ' Ask permsision ?
        'If My.Settings.CurrentPer = "الكل" Then
        FormWaitStatic.Show()
        FormCounting.Show()
        Me.Hide()
        'End If
    End Sub
    Private Sub PictureSetting_Click(sender As Object, e As EventArgs) Handles PictureSetting.Click
        '  If My.Settings.CurrentPer = "الكل" Then
        settingForm.Show()
        Me.Hide()
        '  End If
    End Sub


End Class
