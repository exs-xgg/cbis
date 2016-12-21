<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pharma = New System.Windows.Forms.Button()
        Me.admiss = New System.Windows.Forms.Button()
        Me.inv = New System.Windows.Forms.Button()
        Me.lab = New System.Windows.Forms.Button()
        Me.bill = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(813, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pharma
        '
        Me.pharma.BackColor = System.Drawing.Color.Transparent
        Me.pharma.BackgroundImage = CType(resources.GetObject("pharma.BackgroundImage"), System.Drawing.Image)
        Me.pharma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pharma.Location = New System.Drawing.Point(47, 151)
        Me.pharma.Name = "pharma"
        Me.pharma.Size = New System.Drawing.Size(139, 137)
        Me.pharma.TabIndex = 1
        Me.pharma.UseVisualStyleBackColor = False
        '
        'admiss
        '
        Me.admiss.BackColor = System.Drawing.Color.Transparent
        Me.admiss.BackgroundImage = CType(resources.GetObject("admiss.BackgroundImage"), System.Drawing.Image)
        Me.admiss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.admiss.Location = New System.Drawing.Point(210, 151)
        Me.admiss.Name = "admiss"
        Me.admiss.Size = New System.Drawing.Size(139, 137)
        Me.admiss.TabIndex = 2
        Me.admiss.UseVisualStyleBackColor = False
        '
        'inv
        '
        Me.inv.BackColor = System.Drawing.Color.Transparent
        Me.inv.BackgroundImage = CType(resources.GetObject("inv.BackgroundImage"), System.Drawing.Image)
        Me.inv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.inv.Location = New System.Drawing.Point(530, 151)
        Me.inv.Name = "inv"
        Me.inv.Size = New System.Drawing.Size(139, 137)
        Me.inv.TabIndex = 3
        Me.inv.UseVisualStyleBackColor = False
        '
        'lab
        '
        Me.lab.BackColor = System.Drawing.Color.Transparent
        Me.lab.BackgroundImage = CType(resources.GetObject("lab.BackgroundImage"), System.Drawing.Image)
        Me.lab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lab.Location = New System.Drawing.Point(372, 151)
        Me.lab.Name = "lab"
        Me.lab.Size = New System.Drawing.Size(139, 137)
        Me.lab.TabIndex = 4
        Me.lab.UseVisualStyleBackColor = False
        '
        'bill
        '
        Me.bill.BackColor = System.Drawing.Color.Transparent
        Me.bill.BackgroundImage = CType(resources.GetObject("bill.BackgroundImage"), System.Drawing.Image)
        Me.bill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bill.Location = New System.Drawing.Point(688, 151)
        Me.bill.Name = "bill"
        Me.bill.Size = New System.Drawing.Size(139, 137)
        Me.bill.TabIndex = 5
        Me.bill.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(869, 427)
        Me.Controls.Add(Me.bill)
        Me.Controls.Add(Me.lab)
        Me.Controls.Add(Me.inv)
        Me.Controls.Add(Me.admiss)
        Me.Controls.Add(Me.pharma)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pharma As System.Windows.Forms.Button
    Friend WithEvents admiss As System.Windows.Forms.Button
    Friend WithEvents inv As System.Windows.Forms.Button
    Friend WithEvents lab As System.Windows.Forms.Button
    Friend WithEvents bill As System.Windows.Forms.Button

End Class
