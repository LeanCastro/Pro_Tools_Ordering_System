Public Class homepage
    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub

    Private totalPrice As Decimal = 0
    Private hammerPrice As Decimal = 150
    Private flatPrice As Decimal = 62
    Private pliersPrice As Decimal = 175
    Private tapePrice As Decimal = 190
    Private rulerPrice As Decimal = 70
    Private microPrice As Decimal = 825
    Private hatPrice As Decimal = 267
    Private earPrice As Decimal = 990
    Private gloovesPrice As Decimal = 210

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles hammerbtn.Click
        totalPrice += hammerPrice

        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Hammer 150 pesos" & vbCrLf
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Flatbtn.Click
        totalPrice += flatPrice

        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Flat Screwdrivers 62 Pesos" & vbCrLf
    End Sub

    Private Sub gloovesbtn_Click(sender As Object, e As EventArgs) Handles gloovesbtn.Click
        totalPrice += gloovesPrice
        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Safety Glooves 210 Pesos" & vbCrLf
    End Sub

    Private Sub Pliersbtn_Click(sender As Object, e As EventArgs) Handles Pliersbtn.Click
        totalPrice += pliersPrice
        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Pliers 175 Pesos" & vbCrLf
    End Sub

    Private Sub Tapebtn_Click(sender As Object, e As EventArgs) Handles Tapebtn.Click
        totalPrice += tapePrice
        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Tape 190 Pesos" & vbCrLf
    End Sub

    Private Sub Rulerbtn_Click(sender As Object, e As EventArgs) Handles Rulerbtn.Click
        totalPrice += rulerPrice
        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Pliers 175 Pesos" & vbCrLf
    End Sub

    Private Sub Microbtn_Click(sender As Object, e As EventArgs) Handles Microbtn.Click
        totalPrice += microPrice
        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Micrometer 825 Pesos" & vbCrLf
    End Sub

    Private Sub Hatbtn_Click(sender As Object, e As EventArgs) Handles Hatbtn.Click
        totalPrice += hatPrice
        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Hard Hat 267 Pesos" & vbCrLf
    End Sub

    Private Sub Earbtn_Click(sender As Object, e As EventArgs) Handles Earbtn.Click
        totalPrice += earPrice
        Totalbox.Text = totalPrice.ToString()

        pricedetailbox.Text &= "Earpugs 990 Pesos" & vbCrLf
    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        loginform.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
