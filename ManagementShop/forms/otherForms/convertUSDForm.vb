Public Class convertUSDForm

    Private Sub DetailsMath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hiden"
        Me.Location = New Point(-450, My.Computer.Screen.Bounds.Height - 180)
        LabelOne.Select()
    End Sub

    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        If Me.Text = "Hiden" Then
            Me.Location = New Point(0, My.Computer.Screen.Bounds.Height - 180)
            Me.Text = "Show"
        Else
            Me.Location = New Point(-450, My.Computer.Screen.Bounds.Height - 180)
            Me.Text = "Hiden"
        End If
        TextTwo.Text = My.Settings.TypeCurrenty
    End Sub


End Class