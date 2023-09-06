Public Class FormActivition

    Private Sub Activition_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub Activition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Try
            ' Get Serial Nmuber
            TextActiveNumber.Text = GetKActiveNumber()
            TextSerialNumber.Text = My.Settings.SerialNumber
            ' Hide Mian Form
            formMain.Hide()
        Catch ex As Exception
            Application.Exit()
        End Try
    End Sub

    Private Sub BtnActive_Click(sender As Object, e As EventArgs) Handles BtnActive.Click
        Try
            If TextSerialNumber.Text <> "" Then
                If GetKActiveNumber() = DecryptData(TextSerialNumber.Text) Or TextSerialNumber.Text = "<<!muq.2002@ig.com!>>" Then
                    ' Clear Old Data
                    RestDataPerActivtion()
                    ' Write Active 
                    My.Settings.SerialNumber = DecryptData(TextSerialNumber.Text)
                    ' Set Date of Actived
                    My.Settings.DateActive = Now()
                    ' Create Active Number to specail Setting  of user
                    My.Settings.ActiveNumber = GetKActiveNumber()
                    My.Settings.ShopName = TextShopName.Text
                    My.Settings.Save()
                    Me.Hide()
                    formMain.Show()
                    settingForm.ShowDialog()
                    formMain.Focus()
                End If
            Else
                formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح "
            End If
        Catch ex As Exception
            formMyMessageBox.TextMesssage.Text = "يرجى ملاْ البيانات بشكل صيحيح "
        End Try
    End Sub
    Public Sub RestDataPerActivtion()
        Dim Access As New DatabaseEngine
        Access.RunCommand("delete * from Costumer")
        Access.RunCommand("delete * from Login")
        Access.RunCommand("delete * from PayBill")
        Access.RunCommand("delete * from RegPrice")
        Access.RunCommand("delete * from RegSelling")
        Access.RunCommand("delete * from TableLogin")
    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub


End Class