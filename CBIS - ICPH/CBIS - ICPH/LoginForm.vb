Public Class LoginForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        getCreds(user.Text, pw.Text)
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "LOGIN - " & dept & " Department"
    End Sub
    Private Sub pw_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles pw.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            getCreds(user.Text, pw.Text)
        End If
    End Sub
End Class