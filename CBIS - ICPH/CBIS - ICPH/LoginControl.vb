'THIS MODULE IS USED TO STORE FUNCTIONS FOR USER LOGIN CONTROLS
Module LoginControl
    Public dept As String
    Public pw_try As Integer = 3
    Public userGlobal As String
    Public Sub pickDept(ByVal pick As String)
        dept = pick
        pw_try = 3
    End Sub

    Public Sub invalidPassword()
        If pw_try > 1 Then
            pw_try -= 1
            MsgBox("Invalid Password, Account Locked or Wrong Department. You have " & pw_try.ToString & " tries left or you account will be suspended!" &
                    vbNewLine & "Try asking your system admin for help")
        Else
            MsgBox("Your Account has been Locked. Contact your System Administrator for help.")
            LoginForm.Close()
        End If
    End Sub
    Public Function ifLocked(ByVal username) As Boolean
        'QUERY HERE
        Dim status As String = "open"
        If status = "locked" Then
            Return False
        Else
            Return True
        End If
    End Function
    Public Sub getCreds(ByVal username As String, ByVal pw As String)
        'QUERY HERE
        Dim deptQry As String = "Cashiering"
        If pw = "haha" And (ifLocked(username)) Then

            MsgBox("Nice.")
            userGlobal = username
            pw_try = 3
            Select Case dept
                Case "Laboratory"
                    LaboratoryForm.Show()
                    LoginForm.Close()
                Case "Pharmacy"
                    'code here
                    'LoginForm.Close()
                Case "Billing"
                    'Billing.show()
                    'LoginForm.Close()
                Case "Cashiering"
                    Cashiering.Show()
                    LoginForm.Close()
                Case "Stocks/Inventory"
                    'code here
                    'LoginForm.Close()

            End Select
        Else
            invalidPassword()
        End If
    End Sub

End Module
