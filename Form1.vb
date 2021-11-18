Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim dr As SqlDataReader
    Private Sub ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD.Click
        con = New SqlConnection("Data Source=STAR-PC\SQLEXPRESS;Initial Catalog=stud;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("insert into student values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Add Successfully")
        Form2.Show()
        con.Close()
    End Sub
    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        con = New SqlConnection("Data Source=STAR-PC\SQLEXPRESS;Initial Catalog=stud;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("delete student where regno='" + TextBox1.Text + "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Deleted Successfully")
        Form2.Show()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        con.Close()
    End Sub
    Private Sub UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UPDATE.Click
        con = New SqlConnection("Data Source=STAR-PC\SQLEXPRESS;Initial Catalog=stud;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("update student set regno='" + TextBox1.Text + "'", con)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Updated Successfully")
        Form2.Show()
        con.Close()
    End Sub
    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox3.Focus()
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox4.Focus()
        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox5.Focus()
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox5.TextLength = 10 Then
                TextBox6.Focus()
            Else
                MsgBox("Enter ten digit number")
            End If
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class
