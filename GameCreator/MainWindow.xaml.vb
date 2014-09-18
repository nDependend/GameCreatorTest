Imports MahApps.Metro.Controls.Dialogs

Class MainWindow
    Private _AddItem As RelayCommand
    Public ReadOnly Property AddItem As RelayCommand
        Get
            If _AddItem Is Nothing Then _AddItem = New RelayCommand(Async Sub(parameter As Object)
                                                                        Dim name As String = Await Me.ShowInputAsync(Application.Current.FindResource("New" & parameter.ToString.ToString), Application.Current.FindResource("Name".ToString) & ":")
                                                                        Select Case parameter.ToString
                                                                            Case "Class"
                                                                                MainViewModel.Instance.Classes.Add(New GC_Class(name))
                                                                            Case "Image"
                                                                                MainViewModel.Instance.Images.Add(New GC_Image(name))
                                                                            Case "Object"
                                                                                MainViewModel.Instance.Objects.Add(New GC_Object(name))
                                                                            Case "Level"
                                                                                MainViewModel.Instance.Levels.Add(New GC_Level(name))
                                                                        End Select
                                                                    End Sub)
            Return _AddItem
        End Get
    End Property

End Class
