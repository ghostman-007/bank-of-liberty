Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Static i As Integer
        Dim password As String
        password = PasswordTextBox.Text
        If password = "charlie" Then
            My.Forms.MDIParent.Show()
            Me.Close()
        Else
            i = i + 1
            MsgBox("The Username or Password is incorrect. Try Again" & vbNewLine & "Attemp Left : " & 3 - i, MsgBoxStyle.Critical, "!!! SECURITY BREACH !!!")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Focus()
            If i = 3 Then
                Me.Close()
            End If
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
