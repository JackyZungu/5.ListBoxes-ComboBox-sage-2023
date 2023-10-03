Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ListBox1.Items.Add("Redmi")
        Dim myitem

        'myitem = InputBox("Enter your fav Phone")
        'istBox1.Items.Add(myitem)

        myitem = InputBox("Enter your Phone")
        ComboBox1.Items.Add(myitem)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'ListBox1.Items.Remove("Mobicel")
        Dim myitem2
        'myitem2 = InputBox("Enter name of the phone to reamove")
        'ListBox1.Items.Remove(myitem2)
        myitem2 = InputBox("Enter name of the phone to reamove")
        ComboBox1.Items.Remove(myitem2)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'ListBox1.Items.Remove(ListBox1.SelectedItem)
        ComboBox1.Items.Remove(ComboBox1.SelectedItem)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'ListBox1.Items.Clear()
        ComboBox1.Items.Clear()
    End Sub
End Class
