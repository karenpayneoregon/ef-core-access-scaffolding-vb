Namespace Models
    Partial Public Class CustomersContactTitle
        Public Sub New()
            Customers = New HashSet(Of Customers)()
        End Sub

        Public Property ContactTitleId() As Integer
        Public Property Title() As String

        Public Overridable Property Customers() As ICollection(Of Customers)
    End Class
End Namespace
