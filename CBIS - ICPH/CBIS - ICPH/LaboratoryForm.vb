Public Class LaboratoryForm

    Private Sub LaboratoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = "Currently Logged in as: " & userGlobal
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'NEW TRANSACTION
        LabNew.txtTimeStamp.Text = "Time of Transcation : " + initRecord() 'CREATES NEW RECORD
        LabNew.txtUserGlobal.Text = "Currently Logged in as: " + userGlobal
        LabNew.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class