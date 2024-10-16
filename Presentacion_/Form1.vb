Imports REGRESION_LINEAL_SIMPLE

Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)
        ' Crear una nueva instancia de Form2
        Dim nuevoFormulario As New frmMeddidas2

        ' Ocultar el formulario actual (Form1)
        Hide() ' Ocultar Form1

        ' Mostrar Form2
        nuevoFormulario.Show()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MedidasTendenciaCentralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MedidasTendenciaCentralToolStripMenuItem.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormaNominalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormaNominalToolStripMenuItem.Click
        ' Crear una nueva instancia de Form2
        Dim nuevoFormulario As New frmMediddas

        ' Ocultar el formulario actual (Form1)
        Hide() ' Ocultar Form1

        ' Mostrar Form2
        nuevoFormulario.Show()
    End Sub

    Private Sub FormaConsolidadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormaConsolidadaToolStripMenuItem.Click
        ' Crear una nueva instancia de Form2
        Dim nuevoFormulario As New frmMeddidas2

        ' Ocultar el formulario actual (Form1)
        Hide() ' Ocultar Form1

        ' Mostrar Form2
        nuevoFormulario.Show()
    End Sub

    Private Sub ProbabilidadesDependientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbabilidadesDependientesToolStripMenuItem.Click

    End Sub

    Private Sub RegresiónLinealSimpleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegresiónLinealSimpleToolStripMenuItem.Click
        ' Crear una nueva instancia de Form2
        Dim nuevoFormulario As New frmRegresionLineal

        ' Ocultar el formulario actual (Form1)
        Hide() ' Ocultar Form1

        ' Mostrar Form2
        nuevoFormulario.Show()
    End Sub
End Class
