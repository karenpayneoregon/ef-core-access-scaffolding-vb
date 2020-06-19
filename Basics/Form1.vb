Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports Basics.Models
Imports Microsoft.EntityFrameworkCore


Partial Public Class Form1
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
        Using context = New NorthContext()
            Dim results = context.Customers.Include(Function(item) item.ContactTitleNavigation).ToList()
            Console.WriteLine()
        End Using
    End Sub
End Class