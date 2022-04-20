Public Class Form1
    Dim vend As New bank
    Dim m_total As Decimal
    Public ReadOnly Property total As Decimal
        Get
            m_total = nickels * 0.05 + dimes * 0.1 + quarters * 0.25 + dollars
            Return m_total
        End Get
    End Property
    Public Property nickels As Integer
    Public Property dimes As Integer
    Public Property quarters As Integer
    Public Property dollars As Integer
    Public Sub addNickel()
        nickels = nickels + 1
        m_total = m_total + 0.05
    End Sub
    Public Sub addDime()
        dimes = dimes + 1
        m_total = m_total + 0.1
    End Sub
    Public Sub addQuarter()
        quarters = quarters + 1
        m_total = m_total + 0.25
    End Sub
    Public Sub adddollars()
        dollars = dollars + 1
        m_total = m_total + 1
    End Sub
    Public Function buyy(amount As Decimal)
        If (amount >= m_total) Then
            m_total = m_total - amount
            Return True
        End If
        Return False
    End Function
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
        totallabel.Text = total.ToString("c2")
        If totallabel.Text >= 1 Then
            canbuy.Text = "select option"
        End If
    End Function
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Label1.Text = 1
        If Label10.Text = "A" Then
            If buy(0.95) Then
                totallabel.Text = total.ToString("c2")
                ListBox1.Items.Add("dart monkey")
            End If
        End If
        If Label10.Text = "B" Then
            If buy(0.95) Then
                totallabel.Text = total.ToString("c2")
                ListBox1.Items.Add("ice monkey")
            End If
        End If
        If Label10.Text = "C" Then
            If buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("submarine monkey")
            End If
        End If
        If Label10.Text = "D" Then
            If buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("glue guner monkey")
            End If
        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Label1.Text = 2
        If Label10.Text = "A" Then
            If buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("dart monkey")
            End If
        End If
        If Label10.Text = "B" Then
            If buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("ice monkey")
            End If
        End If
        If Label10.Text = "C" Then
            If vend.buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("submarine monkey")
            End If
        End If
        If Label10.Text = "D" Then
            If vend.buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("glue guner monkey")
            End If
        End If
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Label1.Text = 3
        If Label10.Text = "A" Then
            If vend.buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("dart monkey")
            End If
        End If
        If Label10.Text = "B" Then
            If vend.buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("ice monkey")
            End If
        End If
        If Label10.Text = "C" Then
            If vend.buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("submarine monkey")
            End If
        End If
        If Label10.Text = "D" Then
            If vend.buy(0.95) Then
                totallabel.Text = vend.total.ToString("c2")
                ListBox1.Items.Add("glue guner monkey")
            End If
        End If
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
    End Sub
    Public Function buy(amount As Decimal)
        If (amount >= m_total) Then
            m_total = bank.m_total - amount
            Return True
        End If
        Return False
    End Function
End Class