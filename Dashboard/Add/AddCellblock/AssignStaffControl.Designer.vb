<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AssignStaffControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.pnlTxtUsername = New System.Windows.Forms.Panel()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cmbStaffShift = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cmbStaffSecurityLevel = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        Me.pnlTxtUsername.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 28)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Assign Staff"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Full Name"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Location = New System.Drawing.Point(39, 176)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(373, 44)
        Me.Panel3.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkGray
        Me.TextBox1.Location = New System.Drawing.Point(12, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(356, 24)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Enter Full Name of Staff"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(35, 76)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(51, 21)
        Me.lblFirstName.TabIndex = 27
        Me.lblFirstName.Text = "Staff ID"
        '
        'pnlTxtUsername
        '
        Me.pnlTxtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.pnlTxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTxtUsername.Controls.Add(Me.txtStaffID)
        Me.pnlTxtUsername.Location = New System.Drawing.Point(39, 100)
        Me.pnlTxtUsername.Name = "pnlTxtUsername"
        Me.pnlTxtUsername.Size = New System.Drawing.Size(373, 44)
        Me.pnlTxtUsername.TabIndex = 25
        '
        'txtStaffID
        '
        Me.txtStaffID.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.txtStaffID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStaffID.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStaffID.ForeColor = System.Drawing.Color.DarkGray
        Me.txtStaffID.Location = New System.Drawing.Point(12, 9)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(356, 24)
        Me.txtStaffID.TabIndex = 0
        Me.txtStaffID.Text = "Enter Staff ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(35, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 21)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Shift"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Security Level"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.cmbStaffShift)
        Me.Panel6.Location = New System.Drawing.Point(39, 254)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(373, 44)
        Me.Panel6.TabIndex = 28
        '
        'cmbStaffShift
        '
        Me.cmbStaffShift.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStaffShift.FormattingEnabled = True
        Me.cmbStaffShift.Items.AddRange(New Object() {"Morning", "Afternoon", " Night"})
        Me.cmbStaffShift.Location = New System.Drawing.Point(3, 6)
        Me.cmbStaffShift.Name = "cmbStaffShift"
        Me.cmbStaffShift.Size = New System.Drawing.Size(365, 31)
        Me.cmbStaffShift.TabIndex = 24
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.cmbStaffSecurityLevel)
        Me.Panel5.Location = New System.Drawing.Point(39, 330)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(373, 44)
        Me.Panel5.TabIndex = 29
        '
        'cmbStaffSecurityLevel
        '
        Me.cmbStaffSecurityLevel.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStaffSecurityLevel.FormattingEnabled = True
        Me.cmbStaffSecurityLevel.Items.AddRange(New Object() {"Minimum Security", "Medium Security", "Maximum Security", "Juvenile", "Women's Facility"})
        Me.cmbStaffSecurityLevel.Location = New System.Drawing.Point(3, 6)
        Me.cmbStaffSecurityLevel.Name = "cmbStaffSecurityLevel"
        Me.cmbStaffSecurityLevel.Size = New System.Drawing.Size(365, 31)
        Me.cmbStaffSecurityLevel.TabIndex = 24
        '
        'AssignStaffControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.pnlTxtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AssignStaffControl"
        Me.Size = New System.Drawing.Size(468, 402)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.pnlTxtUsername.ResumeLayout(False)
        Me.pnlTxtUsername.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents pnlTxtUsername As Panel
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cmbStaffShift As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cmbStaffSecurityLevel As ComboBox
End Class
