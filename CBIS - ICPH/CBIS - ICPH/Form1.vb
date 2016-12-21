Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pharma.Click
        pickDept("Pharmacy")
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub admiss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles admiss.Click
        pickDept("Admission")
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub lab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lab.Click
        pickDept("Laboratory")
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub inv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inv.Click
        pickDept("Inventory/Stocks")
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub bill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bill.Click
        pickDept("Billing")
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        checkIfLegitCopy()
        fetchServices()

    End Sub

    Private Sub cash_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cash.Click
        pickDept("Cashiering")
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
