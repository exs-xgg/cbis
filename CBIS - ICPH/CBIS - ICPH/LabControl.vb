Module LabControl
    Public ifDiscount As Boolean = False
    Public subtotal As Integer
    Public total As Integer


    'FETCH SERVICES IS FOR DIVING INTO THE DATABASE TO FIND THE SERVICES
    'AVAILABLE IN THE LABORATORY AND ALSO GETTING ITS EQUIVALENT
    'PRICE. SHOULD BE IMPORTED IN AN ARRAY
    Public Sub fetchServices()
        'READ QUERY HERE
        LabNew.txtServices.Items.Add("the query is looping")
    End Sub

    'INITRECORD IS FOR CREATING OR INITIALIZING RECORDS.
    'RETURNS A TIMESTAMP VALUE, BUT AS A STRING
    '*****TEMPORARY, MIGHT BE MIGRATED TO THE PRINT BUTTON FUNCTION
    Public Function initRecord() As String
        Dim timestamp = Date.Now.ToString
        'INSERT QUERY HERE
        'USE TIMESTAMP TO GRAB THE UNIQUE ID
        Return timestamp
    End Function

    'updateTrans IS FOR UPDATING THE RECORD TO WHEN THE PRINT BUTTON IS PRESSED
    Public Sub updateTrans(ByVal lname As String, ByVal fname As String, ByVal mname As String, ByVal discount As Boolean,
                           ByVal disctype As String, ByVal subtotal As Integer, ByVal total As Integer)

        Dim transMaster = userGlobal
        'UPDATE QUERY HERE
        'FROM PRINT BUTTON
        'update tbl_transac(trans_timestamp, pt_lname, pt_fname, pt_mname, pt_disc_type, pt_subtotal, pt_total

    End Sub

    'COMPUTE TOTAL IS FOR COMPUTING THE DISCOUNT, EITHER IT IS SET TO TRUE OR FALSE.
    'RETURNS AN INTEGER VALUE
    Public Function computeTotal(ByVal subtotal As Integer, ByVal disc As Boolean) As Integer
        Dim total As Integer
        If disc = True Then
            total = subtotal - (subtotal * 0.2)
        Else
            total = subtotal
        End If
        Return total
    End Function
    'I STILL DONT KNOW WHAT THE FUCK IS THIS
    '**CANDIDATE FOR DELETION
    Public Sub sendToDb(ByVal total As Integer, ByVal timestamp As Date, ByVal id As Integer, ByVal ptype As String)

    End Sub
End Module
