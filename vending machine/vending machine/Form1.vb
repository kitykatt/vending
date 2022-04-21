Public Class Form1
    Dim vend As New bank
    Dim money As Decimal
    'Public ReadOnly Property total As Decimal
    '    Get
    '        m_total = nickels * 0.05 + dimes * 0.1 + quarters * 0.25 + dollars
    '        Return m_total
    '    End Get
    'End Property
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property quarters As Integer
    Public Property dollars As Integer
    Dim nft As Decimal
    Public Sub addNickel()
        nickels = nickels + 1
        money = money + 0.05
    End Sub
    Public Sub addDime()
        dimes = dimes + 1
        money = money + 0.1
    End Sub
    Public Sub addQuarter()
        quarters = quarters + 1
        money = money + 0.25
    End Sub
    Public Sub adddollars()
        dollars = dollars + 1
        money = money + 1
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addNickel()
        linez()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addDime()
        linez()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        addQuarter()
        linez()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        adddollars()
        linez()
    End Sub
    Function linez()
        totallabel.Text = money.ToString("c2")
        If totallabel.Text >= 0.5 Then
            canbuy.Text = "select option"
        End If
    End Function
    Function cordz()
        Label1.Text = ""
        Label10.Text = ""
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        nft = nft + 1
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Label1.Text = 1
        If Label10.Text = "A" Then
            If money >= 0.5 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("dart monkey")
            End If
        End If
        If Label10.Text = "B" Then
            If money >= 0.75 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("ice monkey")
            End If
        End If
        If Label10.Text = "C" Then
            If money >= 1.35 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("submarine monkey")
            End If
        End If
        If Label10.Text = "D" Then
            If money >= 1.2 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("glue guner monkey")
            End If
        End If
        cordz()
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Label1.Text = 2
        If Label10.Text = "A" Then
            If money >= 0.5 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("boomerang monkey")
            End If
        End If
        If Label10.Text = "B" Then
            If money >= 0.75 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("ninja monkey")
            End If
        End If
        If Label10.Text = "C" Then
            If money >= 1.35 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("super monkey")
            End If
        End If
        If Label10.Text = "D" Then
            If money >= 1.2 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("farmer monkey")
            End If
        End If
        cordz()
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Label1.Text = 3
        If Label10.Text = "A" Then
            If money >= 0.5 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("electrican monkey")
            End If
        End If
        If Label10.Text = "B" Then
            If money >= 0.75 Then
                money = money - 0.75
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("boat monkey")
            End If
        End If
        If Label10.Text = "C" Then
            If money >= 1.35 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("magic monkey")
            End If
        End If
        If Label10.Text = "D" Then
            If money >= 1 Then
                totallabel.Text = money.ToString("c2")
                ListBox1.Items.Add("quincy nft")
            End If
        End If
        cordz()
    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Label10.Text = Button22.Text
    End Sub
    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Label10.Text = Button21.Text
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Label10.Text = Button20.Text
    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Label10.Text = Button25.Text
    End Sub
    Private Sub selectionz(sender As Object, e As EventArgs) Handles Button25.Click, Button20.Click, Button21.Click, Button22.Click, Button19.Click, Button18.Click, Button17.Click
        linez()
        money = nickels * 0.05 + dimes * 0.1 + quarters * 0.25 + dollars
    End Sub
    Public Function buy(amount As Decimal)
        If (amount >= money) Then
            money = money - amount
            Return True
        End If
        Return False
    End Function
End Class