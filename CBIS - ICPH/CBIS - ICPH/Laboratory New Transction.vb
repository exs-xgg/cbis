Public Class LabNew
    Dim grabValue As Integer = 0
    Private Sub Laboratory_New_Transction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDisc.SelectedIndexChanged
        If txtDisc.Text = "Senior Citizen" Or txtDisc.Text = "PWD" Then
            seniorGrp.Visible = True
            If txtDiscID.Text <> String.Empty Then
                ifDiscount = True
            End If
        Else
            seniorGrp.Visible = False

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout.Click
        'CHANGE STATUS TO LOGGED OFF
        userGlobal = String.Empty
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub txtServices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServices.SelectedIndexChanged

    End Sub

    Private Sub btnCompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompute.Click
        grabValue = 300
        'grabvalue = functionToGrabEquivalentValueFromDatabase()
        If txtDisc.Text = "Senior Citizen" Or txtDisc.Text = "PWD" Then
            seniorGrp.Visible = True
            If txtDiscID.Text <> String.Empty Then
                ifDiscount = True
            ElseIf txtDiscID.Text = String.Empty Then
                MsgBox("Enter the SC/PWD ID Number")

            End If
        Else
            seniorGrp.Visible = False
            ifDiscount = False

        End If
        txtSubtotal.Text = grabValue
        If ifDiscount = True Then
            txtDiscount.Text = "- " & (grabValue * 0.2).ToString
        Else
            txtDiscount.Text = "- " & 0.ToString
        End If
        totalString.Text = computeTotal(grabValue, ifDiscount)

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        updateTrans(lname.Text, fname.Text, mname.Text, ifDiscount, txtDisc.Text, grabValue, computeTotal(grabValue, ifDiscount))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        LaboratoryForm.Show()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtTimeStamp.Text = "Time of Transcation : " + initRecord() 'CREATES NEW RECORD
        lname.Clear()
        fname.Clear()
        mname.Clear()
        ifDiscount = False
        txtServices.Text = "Type of Transaction"
        txtDisc.Text = "None"
        txtPtType.Text = "Patient Type"
        txtDiscID.Clear()
        grabValue = 0
        txtSubtotal.Text = 0.ToString
        txtDiscount.Text = 0.ToString
        totalString.Text = 0.ToString
    End Sub
End Class