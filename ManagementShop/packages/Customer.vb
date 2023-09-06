Public Class Customer
    Dim dataBaseEngine As New DatabaseEngine
    Dim getCustomerTable As DataTable

    Public Property id As String
    Public Property name As String
    Public Property phoneNumber As String
    Public Property note As String
    Public Property addedDate As String
    Public Property addedBy As String

    Public Function getCustomerTableUpdate()
        getCustomerTable = dataBaseEngine.GetTable("select ID as [*], NameCostumer as [اسم الزبون]," &
                                                    "Phones as [رقم الهاتف], Note as [الملاحظات]," &
                                                   " AddedDate as [تاريخ  التسجيل], AddedBy as [مدخل البيان]" &
                                                   "  FROM Costumer  WHERE [DeleteState]='No' order by ID")

        Return getCustomerTable
    End Function
    Public Function isDuplicateCustomerTable(customerName As String, tableCustomer As DataTable)
        Dim customerDataView As DataView = tableCustomer.DefaultView
        customerDataView.RowFilter = "[اسم الزبون] = '" & customerName & "'"
        Return customerDataView.Count > 0
    End Function

    Public Function updateCustomer(customerName As String, customerPhoneNumber As String, customerNote As String,
                                   customerDate As String, customerId As String)
        dataBaseEngine.RunCommand("UPDATE Costumer SET NameCostumer='" &
                                  customerName & "', Phones='" & customerPhoneNumber &
                                  "', [Note]='" & customerNote & "' , AddedDate='" &
                                  customerDate & "' WHERE  [DeleteState]='No' And ID=" & customerId)
    End Function
    Public Function addCustomer(customerName As String, customerPhoneNumber As String,
                                customerNote As String, customerDate As String, addedBy As String)
        dataBaseEngine.RunCommand("INSERT INTO Costumer VALUES(" &
                                getLastRowCustomerTable() & ",'" & customerName &
                                  "','" & customerPhoneNumber & "','" & customerDate &
                                  "','" & customerNote & "','" & addedBy & "','No')")
    End Function
    Function getLastRowCustomerTable()
        Return 0
    End Function
    Public Function deleteCustomer(customerId As Integer)
        Try
            dataBaseEngine.RunCommand("UPDATE  Costumer SET [DeleteState]= 'Yes' WHERE ID=" & customerId)
        Catch ex As Exception

        End Try

    End Function
End Class
