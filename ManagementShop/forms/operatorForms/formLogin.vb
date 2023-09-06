Public Class formLogin
    Dim Access As New DatabaseEngine
    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        formMain.Hide()
    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            For L As Integer = 0 To settingForm.DGV_AddUsers.Rows.Count - 1
                If TextUsername.Text.Trim <> "" Then

                    If settingForm.DGV_AddUsers.Rows(L).Cells(1).Value = TextUsername.Text And
                        settingForm.DGV_AddUsers.Rows(L).Cells(2).Value = TextPassword.Text Then

                        My.Settings.CurrentUser = settingForm.DGV_AddUsers.Rows(L).Cells(1).Value
                        My.Settings.CurrentPass = settingForm.DGV_AddUsers.Rows(L).Cells(2).Value
                        My.Settings.CurrentPer = settingForm.DGV_AddUsers.Rows(L).Cells(3).Value

                        My.Settings.Logged = True

                        Dim CounterTable As DataTable = Access.GetTable("select * from Login")
                        Access.RunCommand("insert into TableLogin values(" & CounterTable.Rows.Count + 1 & ",'" & My.Settings.CurrentUser & "','" & Date.Now.ToString & "','')")

                        formMain.TextUser.Text = My.Settings.CurrentUser
                        formMain.TextPerm.Text = My.Settings.CurrentPer


                        Me.Hide()
                        formMain.Show()
                        formMain.Focus()
                        Exit Sub

                    End If
                End If
            Next
            TextUsername.Text = ""
            TextPassword.Text = ""
            formMyMessageBox.TextMesssage.Text = "اسم الستخدم او كلمة المرور خطا"
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub


End Class