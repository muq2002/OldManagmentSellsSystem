Public Class User
    Dim dataBaseEngine As New DatabaseEngine
    Dim getLoginTable As DataTable

    Public Property id As String
    Public Property name As String
    Public Property password As String
    Public Property permissionLicence As String
    Public Property permissionExpireDate As String
    Public Function getLoginTableUpdate()
        getLoginTable = dataBaseEngine.GetTable("select ID as [*], Username as [اسم المستخدم], " &
                                                "Password as [كلمة المرور], Permission as [الصلاحية]" &
                                                ",ExpirePermisson as [نفاذ الصلاحية]  from Login")

        Return getLoginTable
    End Function
    Public Function isDuplicateLoginTable(user As User, tableUser As DataTable)
        Dim customerDataView As DataView = tableUser.DefaultView
        customerDataView.RowFilter = "[اسم المستخدم] = '" & user.name & "'"
        Return customerDataView.Count > 0
    End Function

    Public Function updateUser(customerName As String, customerPhoneNumber As String, customerNote As String,
                                   customerDate As String, userId As String)
        dataBaseEngine.RunCommand("UPDATE Costumer SET NameCostumer='" &
                                  customerName & "', Phones='" & customerPhoneNumber &
                                  "', [Note]='" & customerNote & "' , AddedDate='" &
                                  customerDate & "' WHERE  [DeleteState]='No' And ID=" & userId)
    End Function
    Public Function addUser(user As User)

        dataBaseEngine.RunCommand("insert into Login values(" &
                                  getLastRowLoginTable() & ",'" &
                                  user.name & "','" & user.password &
                                  "','" & user.permissionLicence & "','" &
                                 user.permissionExpireDate & "')")
    End Function

    Function getLastRowLoginTable()

    End Function
    Public Function deleteUser(userId As Integer)
        dataBaseEngine.RunCommand("UPDATE  Costumer SET [DeleteState]= 'Yes' WHERE ID=" & userId)
    End Function

    Public Function findUser(username As String, password As String)
        dataBaseEngine.GetTable("")

    End Function
End Class
