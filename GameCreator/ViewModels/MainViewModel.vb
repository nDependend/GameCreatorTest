Imports System.Collections.ObjectModel

Public Class MainViewModel
    Inherits PropertyChangedBase

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
    Private _Classes As ObservableCollection(Of GC_Class) = New ObservableCollection(Of GC_Class)
    Public Property Classes As ObservableCollection(Of GC_Class)
        Get
            Return _Classes
        End Get
        Set(value As ObservableCollection(Of GC_Class))
            SetProperty(value, _Classes)
        End Set
    End Property
    Private _Objects As ObservableCollection(Of GC_Object) = New ObservableCollection(Of GC_Object)
    Public Property Objects As ObservableCollection(Of GC_Object)
        Get
            Return _Objects
        End Get
        Set(value As ObservableCollection(Of GC_Object))
            SetProperty(value, _Objects)
        End Set
    End Property
    Private _Images As ObservableCollection(Of GC_Image) = New ObservableCollection(Of GC_Image)
    Public Property Images As ObservableCollection(Of GC_Image)
        Get
            Return _Images
        End Get
        Set(value As ObservableCollection(Of GC_Image))
            SetProperty(value, _Images)
        End Set
    End Property
    Private _Levels As ObservableCollection(Of GC_Level) = New ObservableCollection(Of GC_Level)
    Public Property Levels As ObservableCollection(Of GC_Level)
        Get
            Return _Levels
        End Get
        Set(value As ObservableCollection(Of GC_Level))
            SetProperty(value, _Levels)
        End Set
    End Property

#End Region
End Class
