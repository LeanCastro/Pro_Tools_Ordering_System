Public Class loginform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Check if the entered username and password are correct
        If AuthenticateUser(TextBox1.Text, TextBox2.Text) Then
            MessageBox.Show("Login successful!")
            homepage.Show()
            Me.Hide()
            ' You can add code here to navigate to another form or perform other actions after successful login
        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Function AuthenticateUser(username As String, password As String) As Boolean
        ' You should replace this with your actual authentication logic
        ' For simplicity, let's assume a hardcoded username and password
        Dim validUsername As String = "leanadmin"
        Dim validPassword As String = "nash 08"

        ' Check if the entered username and password match the valid ones
        Return username = validUsername AndAlso password = validPassword
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Set the PasswordChar property to "*" to hide the password
        TextBox2.PasswordChar = "•"
    End Sub

    Private Sub Exitbtn_Click_1(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Close()
    End Sub
End Class
