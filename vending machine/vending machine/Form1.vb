Public Class Form1
    Dim vend As New bank
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vend.addNickel()
        totallabel.Text = vend.total.ToString("c2")
        If totallabel.Text >= 1 Then
            canbuy.Text = "select option"
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vend.addDime()
        totallabel.Text = vend.total.ToString("c2")
        If totallabel.Text >= 1 Then
            canbuy.Text = "select option"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vend.addQuarter()
        totallabel.Text = vend.total.ToString("c2")
        If totallabel.Text >= 1 Then
            canbuy.Text = "select option"
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vend.adddollars()
        totallabel.Text = vend.total.ToString("c2")
        If totallabel.Text >= 1 Then
            canbuy.Text = "select option"
        End If
    End Sub
End Class