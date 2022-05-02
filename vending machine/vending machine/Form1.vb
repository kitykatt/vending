Public Class Form1
    Dim a1 As Integer = 10
    Dim a2 As Integer = 10
    Dim a3 As Integer = 10
    Dim b1 As Integer = 10
    Dim b2 As Integer = 10
    Dim b3 As Integer = 10
    Dim c1 As Integer = 10
    Dim c2 As Integer = 10
    Dim c3 As Integer = 10
    Dim d1 As Integer = 10
    Dim d2 As Integer = 10
    Dim d3 As Integer = 10
    Dim money As Decimal
    Dim broke_alert As Boolean
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
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        money = 0
    End Sub
    Private Sub selectionz(sender As Object, e As EventArgs) Handles Button25.Click, Button20.Click, Button21.Click, Button22.Click
        Label10.Text = sender.Text
    End Sub
    Private Sub Linez(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button17.Click, Button18.Click, Button19.Click, Button25.Click, Button20.Click, Button21.Click, Button22.Click
        totallabel.Text = money.ToString("c2")
        If money >= 0.5 Then
            canbuy.Text = "select option"
        End If
        If money < 0.5 Then
            canbuy.Text = "insert money"
        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        test(1, 0.5, "dart monkey", a1, 0.75, "ice monkey", a2, 1.35, "submarine monkey", a3, 1.2, "glue guner monkey", b1)
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        test(2, 1.5, "boomerang monkey", b2, 1.25, "ninja monkey", b3, 7, "super monkey", c1, 3, "farmer monkey", c2)
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        test(3, 2, "electrican monkey", c3, 1.7, "boat monkey", d1, 2, "magic monkey", d2, 100, "quincy nft", d3)
    End Sub
    Function test(deva As Decimal, cost_a As Decimal, monkey_a As String, a_count As Integer, cost_b As Decimal, monkey_b As String, b_count As Integer, cost_c As Decimal, monkey_c As String, c_count As Integer, cost_d As Decimal, monkey_d As String, d_count As Integer)
        Label1.Text = deva
        test_assist("A", cost_a, monkey_a, a_count)
        test_assist("B", cost_b, monkey_b, b_count)
        test_assist("C", cost_c, monkey_c, c_count)
        test_assist("D", cost_d, monkey_d, d_count)
        totallabel.Text = money.ToString("c2")
    End Function
    Function test_assist(abcd As String, cost As Decimal, monkey As String, count As Integer)
        If Label10.Text = abcd Then
            If money >= cost And count >= 1 Then
                ListBox1.Items.Add(monkey)
                money = money - cost
                count = count - 1
                'Label25.Text = count
            ElseIf money < cost Then
                stop_broke_alarm.Enabled = True
                broke_boy.Enabled = True
            End If
        End If
    End Function
End Class