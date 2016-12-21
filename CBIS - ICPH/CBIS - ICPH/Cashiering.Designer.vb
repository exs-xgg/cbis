<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cashiering
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTransacNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.txtRmNo = New System.Windows.Forms.Label()
        Me.txtDiscType = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.Label()
        Me.txtDiscTotal = New System.Windows.Forms.Label()
        Me.txtTendered = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.transac_item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.item_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transac_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtSCId = New System.Windows.Forms.Label()
        Me.btnCheckOut = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtChange = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 38)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CASHIERING SYSTEM - Logged in as: "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(765, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PowderBlue
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtTransacNo)
        Me.Panel2.Location = New System.Drawing.Point(-3, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 49)
        Me.Panel2.TabIndex = 1
        '
        'txtTransacNo
        '
        Me.txtTransacNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransacNo.Location = New System.Drawing.Point(150, 13)
        Me.txtTransacNo.Name = "txtTransacNo"
        Me.txtTransacNo.Size = New System.Drawing.Size(208, 26)
        Me.txtTransacNo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transaction No. :"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(364, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 29)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "SEARCH"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transac_item, Me.item_qty, Me.item_price, Me.transac_total})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 85)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(593, 155)
        Me.DataGridView1.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(-3, 242)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(883, 193)
        Me.Panel3.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Patient Name:"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.Controls.Add(Me.txtSCId)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.txtDiscType)
        Me.Panel4.Controls.Add(Me.txtRmNo)
        Me.Panel4.Controls.Add(Me.txtName)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Location = New System.Drawing.Point(8, 7)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(602, 172)
        Me.Panel4.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room #:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 21)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Discount:"
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(115, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(49, 21)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = "name"
        '
        'txtRmNo
        '
        Me.txtRmNo.AutoSize = True
        Me.txtRmNo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRmNo.Location = New System.Drawing.Point(77, 23)
        Me.txtRmNo.Name = "txtRmNo"
        Me.txtRmNo.Size = New System.Drawing.Size(65, 21)
        Me.txtRmNo.TabIndex = 4
        Me.txtRmNo.Text = "rm101a"
        '
        'txtDiscType
        '
        Me.txtDiscType.AutoSize = True
        Me.txtDiscType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscType.Location = New System.Drawing.Point(83, 44)
        Me.txtDiscType.Name = "txtDiscType"
        Me.txtDiscType.Size = New System.Drawing.Size(101, 21)
        Me.txtDiscType.TabIndex = 5
        Me.txtDiscType.Text = "sc/pwd/none"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel5.Controls.Add(Me.txtChange)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.btnCheckOut)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.txtTendered)
        Me.Panel5.Controls.Add(Me.txtDiscTotal)
        Me.Panel5.Controls.Add(Me.txtSubTotal)
        Me.Panel5.Controls.Add(Me.txtTotal)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Location = New System.Drawing.Point(598, 85)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(282, 336)
        Me.Panel5.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Subtotal"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Discount   -"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 21)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(50, 77)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(148, 32)
        Me.txtTotal.TabIndex = 4
        Me.txtTotal.Text = "0000000.00"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.AutoSize = True
        Me.txtSubTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(85, 4)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(65, 20)
        Me.txtSubTotal.TabIndex = 5
        Me.txtSubTotal.Text = "Subtotal"
        '
        'txtDiscTotal
        '
        Me.txtDiscTotal.AutoSize = True
        Me.txtDiscTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscTotal.Location = New System.Drawing.Point(85, 24)
        Me.txtDiscTotal.Name = "txtDiscTotal"
        Me.txtDiscTotal.Size = New System.Drawing.Size(65, 20)
        Me.txtDiscTotal.TabIndex = 6
        Me.txtDiscTotal.Text = "Subtotal"
        '
        'txtTendered
        '
        Me.txtTendered.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTendered.Location = New System.Drawing.Point(40, 162)
        Me.txtTendered.Name = "txtTendered"
        Me.txtTendered.Size = New System.Drawing.Size(219, 33)
        Me.txtTendered.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 21)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Amount Tendered"
        '
        'transac_item
        '
        Me.transac_item.HeaderText = "Item"
        Me.transac_item.Name = "transac_item"
        Me.transac_item.Width = 250
        '
        'item_qty
        '
        Me.item_qty.HeaderText = "Quantity"
        Me.item_qty.Name = "item_qty"
        '
        'item_price
        '
        Me.item_price.HeaderText = "Price"
        Me.item_price.Name = "item_price"
        '
        'transac_total
        '
        Me.transac_total.HeaderText = "Total"
        Me.transac_total.Name = "transac_total"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(114, 21)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "SC/PWD ID no:"
        '
        'txtSCId
        '
        Me.txtSCId.AutoSize = True
        Me.txtSCId.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSCId.Location = New System.Drawing.Point(123, 65)
        Me.txtSCId.Name = "txtSCId"
        Me.txtSCId.Size = New System.Drawing.Size(38, 21)
        Me.txtSCId.TabIndex = 7
        Me.txtSCId.Text = "N/A"
        '
        'btnCheckOut
        '
        Me.btnCheckOut.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckOut.Location = New System.Drawing.Point(45, 276)
        Me.btnCheckOut.Name = "btnCheckOut"
        Me.btnCheckOut.Size = New System.Drawing.Size(214, 57)
        Me.btnCheckOut.TabIndex = 9
        Me.btnCheckOut.Text = "CHECKOUT"
        Me.btnCheckOut.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Change"
        '
        'txtChange
        '
        Me.txtChange.AutoSize = True
        Me.txtChange.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChange.Location = New System.Drawing.Point(50, 220)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(148, 32)
        Me.txtChange.TabIndex = 11
        Me.txtChange.Text = "0000000.00"
        '
        'Cashiering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(869, 430)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cashiering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing/Cashiering"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTransacNo As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtDiscType As System.Windows.Forms.Label
    Friend WithEvents txtRmNo As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.Label
    Friend WithEvents txtDiscTotal As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.Label
    Friend WithEvents transac_item As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents item_price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents transac_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTendered As System.Windows.Forms.TextBox
    Friend WithEvents txtSCId As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtChange As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCheckOut As System.Windows.Forms.Button
End Class
