Public Class Form1
    Dim vend As New bank
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vend.addNickel()
        linez()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vend.addDime()
        linez()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vend.addQuarter()
        linez()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vend.adddollars()
        linez()
    End Sub
    Function linez()
        totallabel.Text = vend.total.ToString("c2")
        If totallabel.Text >= 1 Then
            canbuy.Text = "select option"
        End If
    End Function

End Class