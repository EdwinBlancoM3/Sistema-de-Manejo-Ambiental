Imports System.Data.OleDb
Public Class frmRecursos
    Private Sub frmRecursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        Dim c, u, f, cl, ag As Decimal
        c = txtcompradas.Text
        u = txtUsadas.Text
        f = txtConsumoFocos.Text
        cl = txtclimas.Text
        ag = txtConsumoAgua.Text
        Try
            Dim Insertar = "INSERT INTO RECURSOS VALUES(@HOJAS_COMPRADAS, @HOJAS_USADAS, @CONSUMO_FOCOS, @CONSUMO_CLIMAS, @CONSUMO_ASPERSORES, @FECHA)"
            Dim Cmd As New OleDbCommand(Insertar, Cnx)
            Cmd.CommandType = CommandType.Text
            Cmd.Parameters.AddWithValue("@HOJAS_COMPRADAS", c)
            Cmd.Parameters.AddWithValue("@HOJAS_USADAS", u)
            Cmd.Parameters.AddWithValue("@CONSUMO_FOCOS", f)
            Cmd.Parameters.AddWithValue("@CONSUMO_CLIMAS", cl)
            Cmd.Parameters.AddWithValue("@CONSUMO_ASPERSORES", ag)
            Cmd.Parameters.AddWithValue("@FECHA", DateString)
            Cnx.Open()
            Cmd.ExecuteNonQuery()
            Cnx.Close()
            MsgBox("Datos Registrado")
        Catch ex As Exception
            MsgBox("Error")
        End Try
       
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        foco()
        clima()
        agua()
    End Sub
    Private Sub foco()
        Dim BUSCAR = "SELECT SUM(FOCOS) FROM REGISTROSALON"
        Dim CmdBuscar As New OleDbCommand(BUSCAR, conn)
        CmdBuscar.CommandType = CommandType.Text
        conn.Open()
        Dim Lectura As OleDbDataReader
        Lectura = CmdBuscar.ExecuteReader
        If (Lectura.Read) Then
            txtConsumoFocos.Text = Lectura(0)
        Else
            MsgBox("Los Datos no estan registrados")
        End If
        Lectura.Close()
        conn.Close()
    End Sub
    Private Sub clima()
        Dim BUSCAR2 = "SELECT SUM(CLIMAS) FROM REGISTROSALON"
        Dim CmdBuscar2 As New OleDbCommand(BUSCAR2, conn)
        CmdBuscar2.CommandType = CommandType.Text
        conn.Open()
        Dim Lectura2 As OleDbDataReader
        Lectura2 = CmdBuscar2.ExecuteReader
        If (Lectura2.Read) Then
            txtclimas.Text = Lectura2(0)
        Else
            MsgBox("Los Datos no estan registrados")
        End If
        Lectura2.Close()
        conn.Close()
    End Sub
    Private Sub agua()
        Dim BUSCAR1 = "SELECT SUM(AGUA) FROM REGISTROJARDIN"
        Dim CmdBuscar1 As New OleDbCommand(BUSCAR1, conn)
        CmdBuscar1.CommandType = CommandType.Text
        conn.Open()
        Dim Lectura1 As OleDbDataReader
        Lectura1 = CmdBuscar1.ExecuteReader
        If (Lectura1.Read) Then
            txtConsumoAgua.Text = Lectura1(0)
        Else
            MsgBox("Los Datos no estan registrados")
        End If
        Lectura1.Close()
        conn.Close()
    End Sub
End Class
