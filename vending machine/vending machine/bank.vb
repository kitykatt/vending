Public Class bank
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
    End Sub
    Public Sub addDime()
        dimes = dimes + 1
    End Sub
    Public Sub addQuarter()
        quarters = quarters + 1
    End Sub
    Public Sub adddollars()
        dollars = dollars + 1
    End Sub
End Class