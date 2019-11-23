Public Class Form1
    Private Sub Otro_alumnoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Otro_alumnoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Otro_alumnoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Trabajo_2DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Trabajo_2DataSet.otro_alumno' Puede moverla o quitarla según sea necesario.
        Me.Otro_alumnoTableAdapter.Fill(Me.Trabajo_2DataSet.otro_alumno)

    End Sub
End Class
