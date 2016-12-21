Module ANTI_PIRACY_MODULE_BIATCH
    Public Sub checkIfLegitCopy()
        Dim thisfile1exists As Boolean = True
        Dim thisfile2exists As Boolean = True
        Dim thisfile3exists As Boolean = True
        'FILE 1 is C:\Program Files\Internet Explorer\diary.hcx
        'FILE 2 is C:\Program Files\Windows Mail\en-US\ring.hcx
        'FILE 3 is C:\Program Files\Windows Media Player\Icons\nagini.hcx
        If thisfile1exists And thisfile2exists And thisfile3exists Then
            'nice
        Else
            MsgBox("Some of the Horcruxes are missing. We need them all to finish Harry Potter.")
            Application.Exit()

        End If
    End Sub
End Module
