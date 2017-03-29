Module Module1
    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Control Ambiental.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public cmd2 As New OleDb.OleDbCommand
    Public cmd3 As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String = ""
    Public sql2 As String = ""
    Public sql3 As String = ""
    Public sql4 As String = ""
    Public sql5 As String = ""
    Public id As Integer
    Public kwhfoco As Decimal
    Public costokwhfoco As Decimal
    Public kwhclima As Decimal
    Public costokwhclima As Decimal
    Public flujoagua As Decimal
    Public costoagua As Decimal


    Public Sub conectarse()
        Try
            conn.Open()
            'MsgBox("conexion exitosa")
        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Sub

End Module
