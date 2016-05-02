Class MainWindow


    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized
        Me.DataContext = New SettingsManager
        Me.NotifyIcon.BeginInit()
        Me.NotifyIcon.Icon = My.Resources.test
        Me.NotifyIcon.EndInit()


        Me.UpdateLayout()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs) Handles btnSave.Click
        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub btnHide_Click(sender As Object, e As RoutedEventArgs) Handles btnHide.Click
        Me.Visibility = Visibility.Hidden
    End Sub

    Private Sub btnClose_Click(sender As Object, e As RoutedEventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub NotifyIcon_TrayMouseDoubleClick(sender As Object, e As RoutedEventArgs) Handles NotifyIcon.TrayMouseDoubleClick
        Me.Visibility = Visibility.Visible
    End Sub


    Private boo As Boolean = False
    Private b As New BackgroundTask
    Private Sub btnSave_Copy_Click(sender As Object, e As RoutedEventArgs) Handles btnSave_Copy.Click
        If Not boo Then
            b.startBT()
        Else
            b.stopBT()
        End If
        boo = Not boo
    End Sub
End Class
