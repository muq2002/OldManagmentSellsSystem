Public Class formReporter

    Private Sub MakerReporter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_Print.Height = 500
    End Sub

    Public Sub PrintBill()

        'Fill Data 
        'TextCustumer.Text = sellingProductForm.TextRegProductCostumerName.Text
        'TextEdtor.Text = formMain.TextUser.Text
        'TextDate.Text = Now.Date
        'TextTime.Text = Now.TimeOfDay.Hours & ":" & Now.TimeOfDay.Minutes
        'TextIdNo.Text = Now.TimeOfDay.Ticks

        'Data Grid View

        'For L = 0 To sellingProductForm.DGV_PrintBill.Rows.Count - 1
        '    Dim row As String() = {sellingProductForm.DGV_PrintBill.Rows(L).Cells(1).Value, sellingProductForm.DGV_PrintBill.Rows(L).Cells(3).Value, sellingProductForm.DGV_PrintBill.Rows(L).Cells(2).Value, sellingProductForm.DGV_PrintBill.Rows(L).Cells(4).Value, sellingProductForm.DGV_PrintBill.Rows(L).Cells(5).Value, sellingProductForm.DGV_PrintBill.Rows(L).Cells(6).Value}
        '    DGV_Print.Rows.Add(row)
        'Next

        ''Price
        'TextCountGird.Text = sellingProductForm.DGV_PrintBill.Rows.Count - 1
        'TexttotalPrice.Text = sellingProductForm.TextTotalCostBill.Text
        'TextRemainPrice.Text = sellingProductForm.TextTotalCostBillRemain.Text
        'TextPayPrice.Text = Val(TexttotalPrice.Text) - Val(TextRemainPrice.Text)
        'TexttotalIQD.Text = Val(TextPayPrice.Text) * 1230
        'TextNotes.Text = ""

        Me.Show()

        PrintDocument1.Print()
    End Sub



    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim pl As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(pl, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(pl, 20, 0)

        Dim bm As New Bitmap(Me.DGV_Print.Width, Me.DGV_Print.Height)
        DGV_Print.DrawToBitmap(bm, New Rectangle(0, 0, Me.DGV_Print.Width, Me.DGV_Print.Height))
        e.Graphics.DrawImage(bm, 20, 220)

        Dim pl2 As New Bitmap(Me.Panel2.Width, Me.Panel2.Height)
        Panel2.DrawToBitmap(pl2, New Rectangle(0, 0, Me.Panel2.Width, Me.Panel2.Height))
        e.Graphics.DrawImage(pl2, 20, Me.DGV_Print.Height + 250)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        PrintDocument1.Print()
    End Sub
End Class