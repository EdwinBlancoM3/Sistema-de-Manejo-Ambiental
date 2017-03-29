Imports System.Data.OleDb
Public Class frmReporte
    Private Sub dgvreport()
        Dim lectura As New OleDbDataAdapter
        Dim Recursos As New DataSet
        Dim comando As String = "SELECT * FROM RECURSOS"
        lectura = New OleDbDataAdapter(comando, conn)
        Recursos.Tables.Add("Recursos")
        lectura.Fill(Recursos.Tables("Recursos"))
        dgvReporteRecursos.DataSource = recursos.Tables("Recursos")
    End Sub

    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvreport()
    End Sub

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        If (dgvReporteRecursos.RowCount - 1 > 0) Then
            If Funciones.GridAExcel(dgvReporteRecursos) = False Then
                MessageBox.Show("Error al exportar!!")
            End If
        Else
            MessageBox.Show("No hay registros para exportar!!")
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
        frmInicio.Show()
    End Sub
End Class