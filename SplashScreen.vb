Public NotInheritable Class SplashScreen

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Static i As Integer
        i = i + 1
        If i <= 100 Then
            ProgressBar1.Value = i
        Else
            My.Forms.LoginForm.Show()
            Me.Close()
        End If


    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
