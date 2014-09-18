Public Class MainViewModel

#Region "Singleton & Constructor"
    Private Shared _Instance As MainViewModel
    Public Shared ReadOnly Property Instance As MainViewModel
        Get
            If _Instance Is Nothing Then _Instance = New MainViewModel
            Return _Instance
        End Get
    End Property

    Public Sub New()
    End Sub

#End Region

#Region "Properties"

#End Region
End Class
