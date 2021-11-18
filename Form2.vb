Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudDataSet2.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter2.Fill(Me.StudDataSet2.student)
        'TODO: This line of code loads data into the 'StudDataSet1.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter1.Fill(Me.StudDataSet1.student)


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class