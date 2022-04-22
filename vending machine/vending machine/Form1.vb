Public Class Form1
    Dim money As Decimal
    Dim broke_alert As Boolean
    Function linez()
        totallabel.Text = money.ToString("c2")
        If money >= 0.5 Then
            canbuy.Text = "select option"
        End If
        If money < 0.5 Then
            canbuy.Text = "insert money"
        End If
    End Function
    Private Sub broke_boy_Tick(sender As Object, e As EventArgs) Handles broke_boy.Tick
        If canbuy.BackColor = Color.Red Then
            canbuy.BackColor = Color.Cyan
            canbuy.ForeColor = Color.Red
        ElseIf canbuy.BackColor = Color.Cyan Then
            canbuy.BackColor = Color.Red
            canbuy.ForeColor = Color.Cyan
        End If
        canbuy.Text = "insert money"
    End Sub
    Private Sub stop_broke_alarm_Tick(sender As Object, e As EventArgs) Handles stop_broke_alarm.Tick
        broke_boy.Enabled = Not broke_boy.Enabled
        stop_broke_alarm.Enabled = Not stop_broke_alarm.Enabled
        canbuy.Text = "select option"
    End Sub
    Private Sub gib_money(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click
        money = money + sender.tag
        Label1.Text = ""
        Label10.Text = ""
        linez()
    End Sub
    Private Sub selectionz(sender As Object, e As EventArgs) Handles Button25.Click, Button20.Click, Button21.Click, Button22.Click
        Label10.Text = sender.Text
        linez()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        test(1, 0.5, "dart monkey", 0.75, "ice monkey", 1.35, "submarine monkey", 1.2, "glue guner monkey")
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        test(2, 1.5, "boomerang monkey", 1.25, "ninja monkey", 7, "super monkey", 3, "farmer monkey")
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        test(3, 2, "electrican monkey", 1.7, "boat monkey", 2, "magic monkey", 100, "quincy nft")
    End Sub
    Function test(deva As Decimal, cost_a As Decimal, monkey_a As String, cost_b As Decimal, monkey_b As String, cost_c As Decimal, monkey_c As String, cost_d As Decimal, monkey_d As String)
        Label1.Text = deva
        test_assist("A", cost_a, monkey_a)
        test_assist("B", cost_b, monkey_b)
        test_assist("C", cost_c, monkey_c)
        test_assist("D", cost_d, monkey_d)
        Label1.Text = ""
        Label10.Text = ""
        linez()
    End Function
    Function test_assist(abcd As String, cost As String, monkey As String)
        If Label10.Text = abcd Then
            If money >= cost Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add(monkey)
                money = money - cost
            ElseIf money < cost Then
                stop_broke_alarm.Enabled = True
                broke_boy.Enabled = True
            End If
        End If
    End Function
End Class