Public Class Cashiering

    Private Sub Cashiering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "CASHIERING SYSTEM - Logged in as: " & userGlobal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        userGlobal = String.Empty
        Me.Close()
        Form1.Show()

    End Sub
End Class