Public Class UNITS_REG_FORM

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
         Dim selectedItem As String = ComboBox1.SelectedItem.ToString()
        If Not ListBox1.Items.Contains(selectedItem) Then
            ListBox1.Items.Add(selectedItem)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Sorted = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim count As Integer = ListBox1.Items.Count
        If count > 6 Then
            MessageBox.Show("You have reached the maximum number of units.")
            Return
        End If
        Dim unit As String = ComboBox1.SelectedItem.ToString()
        If ListBox1.Items.Contains(unit) Then
            MessageBox.Show("You have already registered for this unit.")
            Return
        End If
        ListBox1.Items.Add(unit)
        Dim fee As Integer = count * 10000
        MessageBox.Show("You have registered for " & count.ToString() & " units. The fee paid is " & fee.ToString() & " rupees.")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim count As Integer = ListBox1.Items.Count
        Dim fee As Integer = count * 10000
        Dim paid As Integer = Integer.Parse(TextBox1.Text)
        Dim difference As Integer = paid - fee
        If difference > 0 Then
            MessageBox.Show("You have paid " & difference.ToString() & " rupees more than the fee.")
        ElseIf difference < 0 Then
            MessageBox.Show("You still need to pay " & (-difference).ToString() & " rupees to cover the fee.")
        Else
            MessageBox.Show("You have paid the exact fee.")
        End If
    End Sub
End Class