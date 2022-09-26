Public Class Form1
    Dim cantidad As Integer
    Dim interes As Integer
    Dim años As Integer
    Dim cuota As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cantidad = TextBox1.Text
        interes = TextBox2.Text
        años = TextBox3.Text
        TextBox4.Text = ((cantidad * interes / 100) + cantidad) / (años * 12)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
