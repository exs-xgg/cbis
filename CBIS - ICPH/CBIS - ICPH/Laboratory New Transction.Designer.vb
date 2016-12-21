<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabNew
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTransacNo = New System.Windows.Forms.Label()
        Me.txtTimeStamp = New System.Windows.Forms.Label()
        Me.txtPtType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDisc = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtServices = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mname = New System.Windows.Forms.TextBox()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.seniorGrp = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiscID = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDiscount = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.Label()
        Me.totalString = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUserGlobal = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.seniorGrp.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTransacNo
        '
        Me.txtTransacNo.AutoSize = True
        Me.txtTransacNo.Location = New System.Drawing.Point(12, 83)
        Me.txtTransacNo.Name = "txtTransacNo"
        Me.txtTransacNo.Size = New System.Drawing.Size(92, 13)
        Me.txtTransacNo.TabIndex = 0
        Me.txtTransacNo.Text = "Transaction No. : "
        '
        'txtTimeStamp
        '
        Me.txtTimeStamp.AutoSize = True
        Me.txtTimeStamp.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeStamp.Location = New System.Drawing.Point(10, 58)
        Me.txtTimeStamp.Name = "txtTimeStamp"
        Me.txtTimeStamp.Size = New System.Drawing.Size(53, 25)
        Me.txtTimeStamp.TabIndex = 1
        Me.txtTimeStamp.Text = "Date"
        '
        'txtPtType
        '
        Me.txtPtType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPtType.FormattingEnabled = True
        Me.txtPtType.Items.AddRange(New Object() {"IN-PATIENT", "OUT-PATIENT"})
        Me.txtPtType.Location = New System.Drawing.Point(260, 40)
        Me.txtPtType.Name = "txtPtType"
        Me.txtPtType.Size = New System.Drawing.Size(174, 29)
        Me.txtPtType.TabIndex = 2
        Me.txtPtType.Text = "Type of Patient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name of Patient"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDisc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtServices)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPtType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.mname)
        Me.GroupBox1.Controls.Add(Me.fname)
        Me.GroupBox1.Controls.Add(Me.lname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 124)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 285)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'txtDisc
        '
        Me.txtDisc.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisc.FormattingEnabled = True
        Me.txtDisc.Items.AddRange(New Object() {"None", "Senior Citizen", "PWD"})
        Me.txtDisc.Location = New System.Drawing.Point(21, 223)
        Me.txtDisc.Name = "txtDisc"
        Me.txtDisc.Size = New System.Drawing.Size(366, 29)
        Me.txtDisc.TabIndex = 13
        Me.txtDisc.Text = "None"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Discount"
        '
        'txtServices
        '
        Me.txtServices.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServices.FormattingEnabled = True
        Me.txtServices.Items.AddRange(New Object() {"---"})
        Me.txtServices.Location = New System.Drawing.Point(21, 157)
        Me.txtServices.Name = "txtServices"
        Me.txtServices.Size = New System.Drawing.Size(366, 29)
        Me.txtServices.TabIndex = 11
        Me.txtServices.Text = "Type of Transaction"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Type of Transaction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(392, 118)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "MI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(206, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Name"
        '
        'mname
        '
        Me.mname.Location = New System.Drawing.Point(392, 91)
        Me.mname.Name = "mname"
        Me.mname.Size = New System.Drawing.Size(37, 20)
        Me.mname.TabIndex = 6
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(206, 91)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(180, 20)
        Me.fname.TabIndex = 5
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(20, 91)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(180, 20)
        Me.lname.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 20)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Name of Patient"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(24, 95)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(180, 20)
        Me.TextBox1.TabIndex = 15
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(210, 95)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(180, 20)
        Me.TextBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(395, 95)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 20)
        Me.TextBox3.TabIndex = 17
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(26, 159)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(365, 31)
        Me.TextBox5.TabIndex = 18
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(26, 225)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(365, 31)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(264, 42)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(174, 31)
        Me.TextBox7.TabIndex = 20
        '
        'seniorGrp
        '
        Me.seniorGrp.Controls.Add(Me.Label9)
        Me.seniorGrp.Controls.Add(Me.txtDiscID)
        Me.seniorGrp.Controls.Add(Me.TextBox4)
        Me.seniorGrp.Location = New System.Drawing.Point(470, 90)
        Me.seniorGrp.Name = "seniorGrp"
        Me.seniorGrp.Size = New System.Drawing.Size(377, 58)
        Me.seniorGrp.TabIndex = 5
        Me.seniorGrp.TabStop = False
        Me.seniorGrp.Text = "Senior / PWD Details"
        Me.seniorGrp.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "ID No."
        '
        'txtDiscID
        '
        Me.txtDiscID.Location = New System.Drawing.Point(48, 18)
        Me.txtDiscID.Name = "txtDiscID"
        Me.txtDiscID.Size = New System.Drawing.Size(268, 20)
        Me.txtDiscID.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(51, 22)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(268, 20)
        Me.TextBox4.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCompute)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtDiscount)
        Me.GroupBox2.Controls.Add(Me.txtSubtotal)
        Me.GroupBox2.Controls.Add(Me.totalString)
        Me.GroupBox2.Controls.Add(Me.btnPrint)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(470, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 252)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total"
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(13, 19)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(109, 28)
        Me.btnCompute.TabIndex = 1
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(13, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Discount"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 62)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(69, 20)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Subtotal"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(120, 128)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(196, 25)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "-----------------------"
        '
        'txtDiscount
        '
        Me.txtDiscount.AutoSize = True
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(125, 101)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDiscount.Size = New System.Drawing.Size(54, 20)
        Me.txtDiscount.TabIndex = 6
        Me.txtDiscount.Text = "P 0.00"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.AutoSize = True
        Me.txtSubtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(125, 62)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSubtotal.Size = New System.Drawing.Size(54, 20)
        Me.txtSubtotal.TabIndex = 5
        Me.txtSubtotal.Text = "P 0.00"
        '
        'totalString
        '
        Me.totalString.AutoSize = True
        Me.totalString.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalString.Location = New System.Drawing.Point(120, 156)
        Me.totalString.Name = "totalString"
        Me.totalString.Size = New System.Drawing.Size(80, 25)
        Me.totalString.TabIndex = 4
        Me.totalString.Text = "P 0.00"
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(222, 201)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(148, 35)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(4, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 25)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "TOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 25)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "TOTAL"
        '
        'txtUserGlobal
        '
        Me.txtUserGlobal.AutoSize = True
        Me.txtUserGlobal.Location = New System.Drawing.Point(12, 37)
        Me.txtUserGlobal.Name = "txtUserGlobal"
        Me.txtUserGlobal.Size = New System.Drawing.Size(118, 13)
        Me.txtUserGlobal.TabIndex = 7
        Me.txtUserGlobal.Text = "Currently Logged in as: "
        '
        'logout
        '
        Me.logout.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.Location = New System.Drawing.Point(775, 37)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(71, 34)
        Me.logout.TabIndex = 8
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(259, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(367, 24)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "LABORATORY - NEW TRANSACTION"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(679, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 35)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(483, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "RESET/New Transaction"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 430)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.txtUserGlobal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.seniorGrp)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTimeStamp)
        Me.Controls.Add(Me.txtTransacNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LabNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Lab Transaction"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.seniorGrp.ResumeLayout(False)
        Me.seniorGrp.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTransacNo As System.Windows.Forms.Label
    Friend WithEvents txtTimeStamp As System.Windows.Forms.Label
    Friend WithEvents txtPtType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDisc As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtServices As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents mname As System.Windows.Forms.TextBox
    Friend WithEvents fname As System.Windows.Forms.TextBox
    Friend WithEvents lname As System.Windows.Forms.TextBox
    Friend WithEvents seniorGrp As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDiscID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtUserGlobal As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents logout As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.Label
    Friend WithEvents txtSubtotal As System.Windows.Forms.Label
    Friend WithEvents totalString As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
