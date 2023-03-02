Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter username")
            TextBox1.Focus()
            Exit Sub
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Please enter password")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox1.Text = "admin" And TextBox2.Text = "admin" Then
            UNITS_REG_FORM.ShowDialog()
        Else
            MessageBox.Show("incorrect username or password")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
