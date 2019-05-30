Public Class BookVB
    Private _title As String
    Public Property Title() As String
        Get
            Return _title
        End Get
        Set(ByVal value As String)
            _title = value
        End Set
    End Property
    Public Sub SaveBook()

    End Sub
End Class

Public Class Customer
    Private _customerId As Integer
    Public Property CustomerID() As Integer
        Get
            Return _customerId
        End Get
        Set(ByVal value As Integer)
            _customerId = value
        End Set
    End Property

End Class
