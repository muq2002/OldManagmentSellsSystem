Public Class FormCounting
    Dim QR_Generator As New MessagingToolkit.QRCode.Codec.QRCodeEncoder
    Dim Access As New DatabaseEngine

    Public Sub DGV_Desgin()
        ' Simple_Static DataGirdView
        DGV_SimpleStatic.Rows.Add("السلعة  الاعلى مبيعاً ")
        DGV_SimpleStatic.Rows.Add("السلعة  الاعلى مبيعا بالنقد ")
        DGV_SimpleStatic.Rows.Add("السلعة  الاعلى مبيعا بالدين ")
        DGV_SimpleStatic.Rows.Add("السلعة  الاعلى خصماً  ")
        DGV_SimpleStatic.Rows.Add("")
        DGV_SimpleStatic.Rows.Add("الزبون  الاعلى شراء ")
        DGV_SimpleStatic.Rows.Add("الزبون  الاعلى شراء بالنقد ")
        DGV_SimpleStatic.Rows.Add("الزبون  الاعلى شراء بالدين ")
        DGV_SimpleStatic.Rows.Add("الزبون  الاعلى خصماً  ")
        LoadMainChart()
        'Product Counter DataGridView

        DGV_CounterProduct.Columns(0).DisplayIndex = 9
        DGV_CounterProduct.Columns(1).DisplayIndex = 9
        DGV_CounterProduct.Columns(2).DisplayIndex = 9
        DGV_CounterProduct.Columns(3).DisplayIndex = 9
        DGV_CounterProduct.Columns(0).Width = 80
        DGV_CounterProduct.Columns(1).Width = 80

        ' Now Started 
        DGV_CounterProduct.Columns(4).Width = 40 'ID
        DGV_CounterProduct.Columns(5).Width = 100 ' Code
        DGV_CounterProduct.Columns(6).Width = 120 ' Name
        DGV_CounterProduct.Columns(7).Width = 80  ' Price
        DGV_CounterProduct.Columns(9).Width = 200 ' Qu
        LoadCounter() ' Fetch  And Fill Data To Counter Prodcut in Second Page On TabControl
        FillInfoOnCounterProdcut()
        ' Spy Product DataGridView
        DGV_SpyProduct.Columns(0).Width = 40
        DGV_SpyProduct.Columns(1).Width = 200
        DGV_SpyProduct.Columns(2).Width = 80
        DGV_SpyProduct.Columns(3).Width = 60
        DGV_SpyProduct.Columns(4).Width = 60
        DGV_SpyProduct.Columns(5).Width = 50
        ' load Name Product
        TextCounterProductName.DataSource = Access.GetTable("select NameProduct,CodeProduct from RegPrice where [DeleteState]='No' order by ID")
        TextCounterProductName.ValueMember = "CodeProduct"
        TextCounterProductName.DisplayMember = "NameProduct"

        LoadDataSpyProduct()
        ' Costumer DataGirdView
        DGV_SpyCostumer.Columns(11).DisplayIndex = 0
        DGV_SpyCostumer.Columns(10).DisplayIndex = 0
        DGV_SpyCostumer.Columns(10).Width = 30
        DGV_SpyCostumer.Columns(11).Width = 130
        TextTotalCostumer.Text = DGV_SpyCostumer.RowCount - 1
    End Sub
    ' ON first Page This
    Public Sub LoadMainChart()
        Dim A As Long = 0 : Dim B As Long = 0 : Dim C As Long = 0
        Dim SellingTotal As DataTable = Access.GetTable("select PriceProductSelling , QuanityProduct from RegPrice where [DeleteState]='No' order by ID")
        Dim SellingLive As DataTable = Access.GetTable("select PriceProductSelling, QunaityProduct, PayOff from RegSelling where WaySelling='نقدا' and [DeleteState]='No' order by ID")
        Dim SellingDebt As DataTable = Access.GetTable("select PriceProductSelling, QunaityProduct, PayOff from RegSelling where WaySelling='بالاجل'and [DeleteState]='No' order by ID")
        Chart2.Series(0).Font = New Font("Cairo", 14, FontStyle.Regular)
        Chart2.Series(0).Points.Clear()
        For Each Data As DataRow In SellingTotal.Rows
            A += (Data.Item(0) * Data.Item(1))
        Next

        Chart2.Series(0).Points.AddXY("سعر السلع الكلي", A)

        For Each Data As DataRow In SellingLive.Rows
            B += (Data.Item(0) * Data.Item(1)) - Data.Item(2) ' PayOff Item 2
        Next

        Chart2.Series(0).Points.AddXY("سعر البيع بالنقد", B)

        For Each Data As DataRow In SellingDebt.Rows
            C += (Data.Item(0) * Data.Item(1)) - Data.Item(2) ' PayOff Item 2
        Next

        Chart2.Series(0).Points.AddXY("سعر البيع بالدين", C)
        Chart2.Series(0).Points.AddXY("سعر  البيع الكلي", B + C)

        TexttotalPrice.Text = B + C
    End Sub
    Public Sub CounterMax()
        For L As Integer = 0 To DGV_CounterProduct.RowCount - 1
            For J As Integer = 0 To DGV_CounterProduct.RowCount - 1
                If DGV_CounterProduct.Rows(L).Cells(0).Value > DGV_CounterProduct.Rows(J).Cells(0).Value Then
                    DGV_SimpleStatic.Rows(0).Cells(2).Value = DGV_CounterProduct.Rows(L).Cells(0).Value
                    DGV_SimpleStatic.Rows(0).Cells(1).Value = DGV_CounterProduct.Rows(L).Cells(6).Value ' Name Product

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next
        ' Number Of Product Selling as Cash
        For L As Integer = 0 To DGV_CounterProduct.RowCount - 1
            For J As Integer = 0 To DGV_CounterProduct.RowCount - 1
                If DGV_CounterProduct.Rows(L).Cells(3).Value > DGV_CounterProduct.Rows(J).Cells(3).Value Then
                    DGV_SimpleStatic.Rows(1).Cells(2).Value = DGV_CounterProduct.Rows(L).Cells(3).Value
                    DGV_SimpleStatic.Rows(1).Cells(1).Value = DGV_CounterProduct.Rows(L).Cells(6).Value ' Name Product

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next
        ' Number Of Product Selling as Debt
        For L As Integer = 0 To DGV_CounterProduct.RowCount - 1
            For J As Integer = 0 To DGV_CounterProduct.RowCount - 1
                If DGV_CounterProduct.Rows(L).Cells(2).Value > DGV_CounterProduct.Rows(J).Cells(2).Value Then
                    DGV_SimpleStatic.Rows(2).Cells(2).Value = DGV_CounterProduct.Rows(L).Cells(2).Value
                    DGV_SimpleStatic.Rows(2).Cells(1).Value = DGV_CounterProduct.Rows(L).Cells(6).Value ' Name Product

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next
        ' Number Of Costumer 
        For L As Integer = 0 To DGV_SpyCostumer.RowCount - 1
            For J As Integer = 0 To DGV_SpyCostumer.RowCount - 1
                If DGV_SpyCostumer.Rows(L).Cells(0).Value > DGV_SpyCostumer.Rows(J).Cells(0).Value Then
                    DGV_SimpleStatic.Rows(5).Cells(2).Value = DGV_SpyCostumer.Rows(L).Cells(0).Value
                    DGV_SimpleStatic.Rows(5).Cells(1).Value = DGV_SpyCostumer.Rows(L).Cells(11).Value ' Name Product

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next

        For L As Integer = 0 To DGV_SpyCostumer.RowCount - 1
            For J As Integer = 0 To DGV_SpyCostumer.RowCount - 1
                If DGV_SpyCostumer.Rows(L).Cells(3).Value > DGV_SpyCostumer.Rows(J).Cells(3).Value Then
                    DGV_SimpleStatic.Rows(6).Cells(2).Value = DGV_SpyCostumer.Rows(L).Cells(2).Value
                    DGV_SimpleStatic.Rows(6).Cells(1).Value = DGV_SpyCostumer.Rows(L).Cells(11).Value ' Name Product

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next

        For L As Integer = 0 To DGV_SpyCostumer.RowCount - 1
            For J As Integer = 0 To DGV_SpyCostumer.RowCount - 1
                If DGV_SpyCostumer.Rows(L).Cells(5).Value > DGV_SpyCostumer.Rows(J).Cells(5).Value Then
                    DGV_SimpleStatic.Rows(7).Cells(2).Value = DGV_SpyCostumer.Rows(L).Cells(4).Value
                    DGV_SimpleStatic.Rows(7).Cells(1).Value = DGV_SpyCostumer.Rows(L).Cells(11).Value ' Name Product

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next

        For L As Integer = 0 To DGV_SpyCostumer.RowCount - 1
            For J As Integer = 0 To DGV_SpyCostumer.RowCount - 1
                If DGV_SpyCostumer.Rows(L).Cells(5).Value > DGV_SpyCostumer.Rows(J).Cells(5).Value Then
                    DGV_SimpleStatic.Rows(8).Cells(2).Value = DGV_SpyCostumer.Rows(L).Cells(8).Value
                    DGV_SimpleStatic.Rows(8).Cells(1).Value = DGV_SpyCostumer.Rows(L).Cells(11).Value ' Name Product

                End If
                Application.DoEvents()
            Next
            Application.DoEvents()
        Next
    End Sub
    ' On Sceond Page
    Public Sub LoadCounter()
        For L As ULong = 0 To DGV_CounterProduct.Rows.Count - 2
            Dim A As ULong = 0 : Dim B As ULong = 0
            Dim CounterSellingProduct As DataTable = Access.GetTable("select QunaityProduct from RegSelling where [NameProduct]='" & DGV_CounterProduct.Rows(L).Cells(6).Value & "' and [DeleteState]='No' order by ID")

            For Each Data As DataRow In CounterSellingProduct.Rows
                A += Val(Data.Item(0).ToString())
                Application.DoEvents()
            Next
            DGV_CounterProduct.Rows(L).Cells(0).Value = A ' amount of selling 
            DGV_CounterProduct.Rows(L).Cells(1).Value = Val(DGV_CounterProduct.Rows(L).Cells(8).Value) - A ' amount Remian from selling

            ' Counter Paying Product As Live
            Dim CounterSellingProductAsLive As DataTable = Access.GetTable("select QunaityProduct from RegSelling where  [WaySelling]='نقدا' And [NameProduct]='" & DGV_CounterProduct.Rows(L).Cells(6).Value & "' and [DeleteState]='No'  order by ID")
            For Each Data As DataRow In CounterSellingProductAsLive.Rows
                B += Val(Data.Item(0).ToString())
                Application.DoEvents()
            Next
            DGV_CounterProduct.Rows(L).Cells(3).Value = B
            DGV_CounterProduct.Rows(L).Cells(2).Value = DGV_CounterProduct.Rows(L).Cells(0).Value - CounterSellingProductAsLive.Rows.Count
        Next
    End Sub

    Public Sub FillInfoOnCounterProdcut()
        Dim TotalPrice, TotalNumber As Long
        Try
            If DGV_CounterProduct.CurrentRow IsNot Nothing And Not IsDBNull(DGV_CounterProduct.CurrentRow.Cells(0).Value) Then
                ProductNumberCurrent.Text = DGV_CounterProduct.CurrentRow.Cells(8).Value
                ProductPriceCurrent.Text = DGV_CounterProduct.CurrentRow.Cells(8).Value * DGV_CounterProduct.CurrentRow.Cells(7).Value
            End If
            PicturRQCode.Image = QR_Generator.Encode(DGV_CounterProduct.CurrentRow.Cells(5).Value)
            For L As Integer = 0 To DGV_CounterProduct.Rows.Count - 2
                TotalPrice += DGV_CounterProduct.Rows(L).Cells(7).Value * DGV_CounterProduct.Rows(L).Cells(8).Value
                TotalNumber += DGV_CounterProduct.Rows(L).Cells(8).Value
                Application.DoEvents()
            Next
            ChartSellingProduct.Series(0).Points.Clear()

            ChartSellingProduct.Series(0).Points.AddXY(Fix((Val((DGV_CounterProduct.CurrentRow.Cells(0).Value / DGV_CounterProduct.CurrentRow.Cells(8).Value)) * 100)).ToString & "%", Val((DGV_CounterProduct.CurrentRow.Cells(0).Value / DGV_CounterProduct.CurrentRow.Cells(8).Value)) * 100)
            ChartSellingProduct.Series(0).Points.AddXY(Fix((Val((DGV_CounterProduct.CurrentRow.Cells(1).Value / DGV_CounterProduct.CurrentRow.Cells(8).Value)) * 100)).ToString & "%", Val((DGV_CounterProduct.CurrentRow.Cells(1).Value / DGV_CounterProduct.CurrentRow.Cells(8).Value)) * 100)
        Catch ex As Exception

        End Try

        ProductNumberTotal.Text = TotalNumber.ToString
        ProductPriceTotal.Text = TotalPrice.ToString
        AllProductNumber.Text = DGV_CounterProduct.Rows.Count - 1
    End Sub


    ' On Thrid Page Data
    Public Sub LoadDataSpyProduct()
        DGV_SpyProduct.DataSource = Access.GetTable("select ID as [*],NameCostumer as [اسم الزبون], PriceProductSelling as [السعر], QunaityProduct as [الكمية],PayOff as [الخصم] , WaySelling as [طريقة البيع],DateSelling as [تاريخ  البيع] from RegSelling where [NameProduct]='" & TextCounterProductName.Text & "' and [DeleteState]='No'  order by ID")
        TextCounterProductNumberSelling.Text = DGV_SpyProduct.RowCount - 1
        ' Live Part
        Dim GotDataLive As DataTable = Access.GetTable("select PriceProductSelling , QunaityProduct,PayOff from RegSelling  where [NameProduct]='" & TextCounterProductName.Text & "' And [WaySelling]='نقدا'  and [DeleteState]='No' order by ID")
        Dim A As Long = 0 : Dim B As Long = 0
        For Each Data As DataRow In GotDataLive.Rows
            If Data.Item(0).ToString <> "" And Data.Item(1).ToString <> "" Then
                A += Val(Data.Item(0)) * Val(Data.Item(1))
                B += Val(Data.Item(2))
            End If
        Next
        TextCounterProductPriceGot.Text = A
        TextCounterProductPricePayOff.Text = B
        ' Un Live Part
        Dim GotDataUnLive As DataTable = Access.GetTable("select PriceProductSelling , QunaityProduct,PayOff from RegSelling  where [NameProduct]='" & TextCounterProductName.Text & "' And [WaySelling]='بالاجل' and [DeleteState]='No' order by ID")
        Dim A1 As Long = 0 : Dim B1 As Long = 0
        For Each Data As DataRow In GotDataUnLive.Rows
            If Data.Item(0).ToString <> "" And Data.Item(1).ToString <> "" Then
                A1 += Val(Data.Item(0)) * Val(Data.Item(1))
                B1 += Val(Data.Item(2))
            End If
        Next
        '  Number Of Selling in this month
        Dim NumSellingMonth As DataTable = Access.GetTable("select  * from  RegSelling where [NameProduct]='" & TextCounterProductName.Text & "' And [DateSelling] Like'%" & Date.Now.Month & "%/" & Date.Now.Year & "' and [DeleteState]='No' order by ID")
        TextCounterProductNumberSellingMonth.Text = NumSellingMonth.Rows.Count
        TextCounterProductPriceDebt.Text = A1
        TextCounterProductPricePayOff2.Text = B1
        TextCounterProductPriceTotal.Text = A + B
        ' Load Chart
        Chart1.Series(0).Points.Clear()
        Chart1.Series(0).Points.AddXY("مبلغ التسديد", TextCounterProductPriceGot.Text)
        Chart1.Series(0).Points.AddXY("المبلغ التخفيض (نقدا)", TextCounterProductPricePayOff.Text)
        Chart1.Series(0).Points.AddXY("مبلغ الدين", TextCounterProductPriceDebt.Text)
        Chart1.Series(0).Points.AddXY("المبلغ التخفيض(بالدين)", TextCounterProductPricePayOff2.Text)
    End Sub

    Private Sub Counting_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        formMain.Show()
    End Sub


    Private Sub Counting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_CounterProduct.DataSource = Access.GetTable("select ID as [*], CodeProduct as [كود السلعة], NameProduct as [اسم السلعة], PriceProductSelling as [سعر السلعة], QuanityProduct as [الكمية], DateAddProduct as [تاريخ  التسجيل]  from RegPrice where [DeleteState]='No' order by ID")
        DGV_SpyProduct.DataSource = Access.GetTable("select ID as [*],NameCostumer as [اسم الزبون], PriceProductSelling as [السعر], QunaityProduct as [الكمية],PayOff as [الخصم] , WaySelling as [طريقة البيع],DateSelling as [تاريخ  البيع] from RegSelling where [DeleteState]='No'  order by ID")
        DGV_SpyCostumer.DataSource = Access.GetTable("select ID as [*] ,NameCostumer as [اسم الزبون] from Costumer where [DeleteState]='No' order by ID")

        ' Require Design
        DGV_Desgin() ' DataGridViews Design
        TextNameShop.Text = My.Settings.ShopName
        PicturRQCode.Image = QR_Generator.Encode("0")
        GroupBox2.Text = "احصاء ليوم " & Date.Now.Day.ToString

        ' Nav Bar Static
        Dim TotalPrice As ULong = 0 : Dim TotalNumber As ULong = 0 : Dim PriceSellingAll As ULong = 0 : Dim PriceSellingDebt As ULong = 0
        For L As Integer = 0 To DGV_CounterProduct.Rows.Count - 2
            TotalPrice += Val(DGV_CounterProduct.Rows(L).Cells(7).Value) * Val(DGV_CounterProduct.Rows(L).Cells(8).Value)
            TotalNumber += DGV_CounterProduct.Rows(L).Cells(8).Value
            PriceSellingAll += Val(DGV_CounterProduct.Rows(L).Cells(7).Value) * Val(DGV_CounterProduct.Rows(L).Cells(0).Value)
            If DGV_CounterProduct.Rows(L).Cells(2).Value <> "0" Then
                PriceSellingDebt += Val(DGV_CounterProduct.Rows(L).Cells(7).Value) * Val(DGV_CounterProduct.Rows(L).Cells(0).Value)
            End If
            Application.DoEvents()
        Next
        TextTotalAmoutProduct.Text = TotalNumber
        TextTotalAmoutProductPrice.Text = TotalPrice
        TTextTotalAmoutCostumer.Text = TextTotalCostumer.Text

        TexttotalPrice.Text = PriceSellingAll
        TextRemainPrice.Text = PriceSellingDebt
        CounterMax()
        DailyCounter()
        FormWaitStatic.Close()
    End Sub


    Public Sub DailyCounter()
        Dim A As Long = 0 : Dim B As Long = 0
        '  Number Of Selling In This Day Live And Debt
        Dim NumSellingLive As DataTable = Access.GetTable("Select * from RegSelling where [DeleteState]='No' and [WaySelling]='نقدا' and [DateSelling] Like '%" & Date.Now.ToShortDateString & "%'")
        TextNumberSellingDayLive.Text = NumSellingLive.Rows.Count
        Dim NumSellingDebt As DataTable = Access.GetTable("Select * from RegSelling where [DeleteState]='No' and [WaySelling]='بالاجل' and [DateSelling] Like '%" & Date.Now.ToShortDateString & "%'")
        TextNumberSellingDayDebt.Text = NumSellingLive.Rows.Count
        TextNumberSellingDay.Text = Val(TextNumberSellingDayLive.Text) + Val(TextNumberSellingDayDebt.Text)

        '  Price Of Selling In This Day Live And Debt
        Dim PriceSellingLive As DataTable = Access.GetTable("Select [PriceProductSelling],[QunaityProduct],[PayOff] from RegSelling where [DeleteState]='No' and [WaySelling]='نقدا' and [DateSelling] Like '%" & Date.Now.ToShortDateString & "%'")
        For Each Data As DataRow In PriceSellingLive.Rows
            A += (Data.Item(0) * Data.Item(1)) - Data.Item(2)
            Application.DoEvents()
        Next
        TextPriceDayLive.Text = A
        Dim PriceSellingDebt As DataTable = Access.GetTable("Select [PriceProductSelling],[QunaityProduct],[PayOff] from RegSelling where [DeleteState]='No' and [WaySelling]='بالاجل' and [DateSelling] Like '%" & Date.Now.ToShortDateString & "%'")
        For Each Data As DataRow In PriceSellingLive.Rows
            B += (Data.Item(0) * Data.Item(1)) - Data.Item(2)
            Application.DoEvents()
        Next
        TextPriceDayDebt.Text = B
        TextPriceDay.Text = Val(TextPriceDayDebt.Text) + Val(TextPriceDayLive.Text)
    End Sub

    Private Sub DGV_CounterProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_CounterProduct.CellClick
        FillInfoOnCounterProdcut()
    End Sub



    Private Sub TextCounterProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TextCounterProductName.SelectedIndexChanged
        LoadDataSpyProduct()
    End Sub



    Private Sub DGV_SpyCostumer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_SpyCostumer.CellClick
        Dim CostumerTable As DataTable = Access.GetTable("select * from Costumer where [DeleteState]='No' order by ID")
        For Each Data As DataRow In CostumerTable.Rows
            If Data.Item(1).ToString = DGV_SpyCostumer.CurrentRow.Cells(11).Value Then
                TextNameCostumer.Text = DGV_SpyCostumer.CurrentRow.Cells(11).Value
                TextPhoneNumberCostumer.Text = Data.Item(2).ToString
                TextDateAddedCostumer.Text = Data.Item(3).ToString
                TextNoteCoustmer.Text = Data.Item(4).ToString
                Exit For
            End If
        Next
    End Sub
    Public Sub LoadData_SpyCostumer()
        Try
            For L As ULong = 0 To DGV_SpyCostumer.RowCount - 2
                Dim A As ULong = 0 : Dim B As ULong = 0 : Dim C As ULong = 0 : Dim D As ULong = 0
                ' Number Of Product And Price For Each Costumer As Live Or Cash
                Dim SellingTable As DataTable = Access.GetTable("select PriceProductSelling , QunaityProduct from  RegSelling Where [WaySelling]='نقدا' and [NameCostumer]='" & DGV_SpyCostumer.Rows(L).Cells(11).Value & "' and [DeleteState]='No' order by ID")
                For Each Data As DataRow In SellingTable.Rows
                    A += Val(Data.Item(0)) * Val(Data.Item(1))
                    Application.DoEvents()
                Next
                DGV_SpyCostumer.Rows(L).Cells(2).Value = SellingTable.Rows.Count
                DGV_SpyCostumer.Rows(L).Cells(3).Value = A
                ' Number Of Product And Price For Each Costumer As Debt
                Dim SellingTableDebt As DataTable = Access.GetTable("select PriceProductSelling , QunaityProduct from  RegSelling Where [WaySelling]='بالاجل' and [NameCostumer]='" & DGV_SpyCostumer.Rows(L).Cells(11).Value & "'and [DeleteState]='No' order by ID")
                For Each Data As DataRow In SellingTableDebt.Rows
                    B += Val(Data.Item(0)) * Val(Data.Item(1))
                    Application.DoEvents()
                Next
                DGV_SpyCostumer.Rows(L).Cells(4).Value = SellingTableDebt.Rows.Count
                DGV_SpyCostumer.Rows(L).Cells(5).Value = B
                ' Number Of Product And Price For Each Costumer As Total
                DGV_SpyCostumer.Rows(L).Cells(1).Value = DGV_SpyCostumer.Rows(L).Cells(3).Value + DGV_SpyCostumer.Rows(L).Cells(5).Value
                DGV_SpyCostumer.Rows(L).Cells(0).Value = DGV_SpyCostumer.Rows(L).Cells(4).Value + DGV_SpyCostumer.Rows(L).Cells(4).Value
                ' Number Of Product And Price For Each Costumer As PayOff
                Dim SellingTablePayOff As DataTable = Access.GetTable("SELECT PayOff from RegSelling Where Not [PayOff] = '0' and [NameCostumer]='" & DGV_SpyCostumer.Rows(L).Cells(11).Value & "' and [DeleteState]='No' order by ID")
                For Each Data As DataRow In SellingTablePayOff.Rows
                    C += Val(Data.Item(0))
                    Application.DoEvents()
                Next
                DGV_SpyCostumer.Rows(L).Cells(8).Value = SellingTablePayOff.Rows.Count
                DGV_SpyCostumer.Rows(L).Cells(9).Value = C

                ' Number Of Product 
                Dim PricePay As DataTable = Access.GetTable("SELECT PricePay from PayBill Where [NameCostumer]='" & DGV_SpyCostumer.Rows(L).Cells(11).Value & "' and [DeleteState]='No' order by ID")
                For Each Data As DataRow In PricePay.Rows
                    D += Val(Data.Item(0))
                    Application.DoEvents()
                Next
                DGV_SpyCostumer.Rows(L).Cells(6).Value = D
                DGV_SpyCostumer.Rows(L).Cells(7).Value = DGV_SpyCostumer.Rows(L).Cells(1).Value - DGV_SpyCostumer.Rows(L).Cells(6).Value
                A = 0 : B = 0
                Application.DoEvents()
            Next
        Catch ex As Exception

        End Try
    End Sub





    Private Sub DGV_CounterProduct_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_CounterProduct.SelectionChanged
        FillInfoOnCounterProdcut()
    End Sub

    Private Sub DGV_CounterProduct_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_CounterProduct.DataBindingComplete
        LoadCounter()
    End Sub

    Private Sub DGV_SpyCostumer_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DGV_SpyCostumer.DataBindingComplete
        LoadData_SpyCostumer()
    End Sub

    Private Sub DGV_SpyCostumer_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_SpyCostumer.SelectionChanged
        Try
            Dim CostumerTable As DataTable = Access.GetTable("select * from Costumer where [DeleteState]='No'  order by ID")
            For Each Data As DataRow In CostumerTable.Rows
                If Data.Item(1).ToString = DGV_SpyCostumer.CurrentRow.Cells(11).Value Then
                    TextNameCostumer.Text = DGV_SpyCostumer.CurrentRow.Cells(11).Value
                    TextPhoneNumberCostumer.Text = Data.Item(2).ToString
                    TextDateAddedCostumer.Text = Data.Item(3).ToString
                    TextNoteCoustmer.Text = Data.Item(4).ToString
                    Exit For
                End If
            Next


            Chart3.Series(0).Points.Clear()
            Dim SData As Long = Val(DGV_SpyCostumer.CurrentRow.Cells(1).Value / Val(TexttotalPrice.Text))
            Chart3.Series(0).Points.AddXY(SData & "%", SData)
            Chart3.Series(0).Points.AddXY(100 - SData & "%", 100 - SData)

        Catch ex As Exception

        End Try

    End Sub




    Private Sub PictureExit_Click(sender As Object, e As EventArgs) Handles PictureExit.Click
        Me.Close()
    End Sub


End Class