Public Class frmInicio

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picControlSalones_Click(sender As Object, e As EventArgs)
        frmControlSalones.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmControlSalones.Show()
        Me.Hide()
    End Sub

    Private Sub picControlSensores_Click(sender As Object, e As EventArgs) Handles picControlSensores.Click
        frmControlSalones.Show()
        Me.Close()
    End Sub

    Private Sub btnControlConsumibles_Click(sender As Object, e As EventArgs) Handles btnControlConsumibles.Click
        frmRecursos.Show()
    End Sub

    Private Sub picReportes_Click(sender As Object, e As EventArgs) Handles picReportes.Click
        frmReporte.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class