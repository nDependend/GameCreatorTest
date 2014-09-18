Public Class GC_Object
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
    Private _Class As GC_Class
    Public Property [Class] As GC_Class
        Get
            Return _Class
        End Get
        Set(value As GC_Class)
            SetProperty(value, _Class)
        End Set
    End Property
    Private _Image As GC_Image
    Public Property Image As GC_Image
        Get
            Return _Image
        End Get
        Set(value As GC_Image)
            SetProperty(value, _Image)
        End Set
    End Property

#End Region
    Public Sub New(Name As String)
        Me.Name = Name
    End Sub

End Class
