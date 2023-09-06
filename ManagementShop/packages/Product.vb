Public Class Product
    Dim dataBaseEngine As New DatabaseEngine
    Dim getProductTable As DataTable
    Public Function getProductTableUpdate()
        getProductTable = dataBaseEngine.GetTable("select * from RegPrice")
        'getProductTable = dataBaseEngine.
        '    GetTable("SELECT ID AS [*], CodeProduct AS [كود السلعة]," &
        '                                          "NameProduct AS [اسم السلعة], PriceProductBuying AS [سعر الشراء]" &
        '                                          ", PriceProductSelling AS [سعر البيع], QuanityProduct AS [الكمية]," &
        '                                          "DateAddProduct AS [تاريخ  التسجيل], AblePayOff AS [قابلية الخصم] " &
        '                                          "FROM RegPrice")

        Return getProductTable
    End Function
    Public Function isRepeativeProducts(codeProduct As String, nameProduct As String)
        Dim numberOfRepeative As DataTable

        numberOfRepeative = dataBaseEngine.GetTable("SELECT * from RegPrice WHERE [CodeProduct]='" &
                                                    codeProduct & "' and [NameProduct]='" &
                                                    nameProduct & "' and  [DeleteState]= 'No'")
        If numberOfRepeative.Rows.Count = 0 Then : Return False : End If

        Return True
    End Function
    Public Function insertProduct(codeProduct As String, nameProduct As String,
                                  priceBuyingProduct As String, priceSellingProduct As String,
                                  quanityProduct As String, currentUser As String,
                                  Optional abilityOfPayOff As Boolean = False)

        Dim lastProductId As Integer = 0
        Dim registerDateProduct As String = Now()

        If abilityOfPayOff Then : dataBaseEngine.RunCommand("INSERT INTO registerProduct VALUES(" &
                                     lastProductId & ",'" & codeProduct & "','" &
                                      nameProduct & "','" & priceBuyingProduct & "','" &
                                      priceSellingProduct & "','" & quanityProduct &
                                      "','" & registerDateProduct & "','" & currentUser & "','نعم','No')") : End If

        dataBaseEngine.RunCommand("INSERT INTO registerProduct VALUES(" &
                                     lastProductId & ",'" & codeProduct & "','" &
                                      nameProduct & "','" & priceBuyingProduct & "','" &
                                      priceSellingProduct & "','" & quanityProduct &
                                      "','" & registerDateProduct & "','" & currentUser & "','لا','No')")
    End Function

    Public Function updateProduct(codeProduct As String, nameProduct As String,
                                  priceBuyingProduct As String, priceSellingProdcut As String,
                                  quanityProduct As String, productId As Integer,
                                  Optional abilityOfPayOff As Boolean = False)
        Dim registerDateProduct As String = Now()

        If abilityOfPayOff Then : dataBaseEngine.RunCommand("UPDATE registerProduct SET CodeProduct='" &
                      codeProduct & "',NameProduct='" & nameProduct &
                      "',PriceProduct='" & priceBuyingProduct & "',PriceProductBying='" &
                      priceSellingProdcut & "',QuanityProduct='" &
                      quanityProduct & "',DateAddProduct='" & registerDateProduct &
                      "' , AblePayOff='نعم' where ID=" & productId) : End If

        dataBaseEngine.RunCommand("UPDATE registerProduct SET CodeProduct='" &
                      codeProduct & "',NameProduct='" & nameProduct &
                      "',PriceProduct='" & priceBuyingProduct & "',PriceProductBying='" &
                      priceSellingProdcut & "',QuanityProduct='" &
                      quanityProduct & "',DateAddProduct='" & registerDateProduct &
                      "' , AblePayOff='لا' where ID=" & productId)

    End Function

    Public Function removeProduct(productId As Integer)
        dataBaseEngine.RunCommand("DELETE * FROM registerProduct WHERE ID = " & productId)
    End Function
End Class
