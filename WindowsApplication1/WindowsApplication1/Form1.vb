Public Class Form1
    Dim z, p As Integer
    Dim c As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        z = TextBox1.Text
        Select Case z
            Case 2 To 45
                z = z - 1
            Dim A(z) As Integer
            A(0) = 2
            A(1) = 1
            For p = 2 To z
                A(p) = A(p - 1) + A(p - 2)
            Next
            For p = 0 To z
                c = c & A(p) & " "
            Next
            TextBox2.Text = c
        Case Else
        MsgBox("Недопустимое значение")
        End Select
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        c = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Картошка засажена, товарищ Лукашенко.",, "Детектор Лукашенко")
        TextBox1.Text = "Ơ Ó Ơ Ơ Ò Ơ Ơ Ó Ó Ò Ơ Ơ Ò Ơ Ò Ò Ơ Ơ Ò Ơ Ò Ó Ò Ơ Ơ Ò Ò Ơ"
        TextBox2.Text = "Ơ Ò Ó Ơ Ó Ó Ò Ơ Ó Ơ Ơ Ò Ơ Ò Ò Ơ Ó Ơ Ó Ò Ơ Ó Ơ Ơ Ò Ơ Ò Ò "
    End Sub
End Class
