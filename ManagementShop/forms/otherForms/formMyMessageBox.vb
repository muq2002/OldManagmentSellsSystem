Public Class formMyMessageBox
    Public ValueButton As Boolean = False
    Private Sub MyMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Label36.Select()
        TextMesssage.Text &= "  ."

    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub

    Private Sub BtnYes_Click(sender As Object, e As EventArgs) Handles BtnYes.Click
        ValueButton = True
        Me.Close()
    End Sub

    Private Sub BtnNo_Click(sender As Object, e As EventArgs) Handles BtnNo.Click
        ValueButton = False
        Me.Close()
    End Sub


End Class