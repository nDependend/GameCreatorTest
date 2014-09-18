Public Class GC_Level
    Inherits PropertyChangedBase
#Region "Properties"
    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            SetProperty(value, _Name)
        End Set
    End Property
#End Region

    Public Sub New(Name As String)
        Me.Name = Name
    End Sub
End Class
