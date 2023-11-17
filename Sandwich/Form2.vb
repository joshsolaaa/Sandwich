Public Class Form2
    Dim f3 As New Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f3.show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        f3.show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Label1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then


            Panel1.BackColor = ColorDialog1.Color


        End If
    End Sub
End Class