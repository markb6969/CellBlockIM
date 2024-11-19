<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminHome
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
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnSuperAdmin = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnClient = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnMainDB = New System.Windows.Forms.Button()
        Me.btnAddEntity = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnManageInmate = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvAdmin = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnManageAdmin = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSuperAdmin)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAdmin)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnClient)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(253, 194)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(981, 100)
        Me.FlowLayoutPanel2.TabIndex = 39
        '
        'btnSuperAdmin
        '
        Me.btnSuperAdmin.FlatAppearance.BorderSize = 0
        Me.btnSuperAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuperAdmin.Font = New System.Drawing.Font("Poppins SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuperAdmin.Location = New System.Drawing.Point(3, 3)
        Me.btnSuperAdmin.Name = "btnSuperAdmin"
        Me.btnSuperAdmin.Size = New System.Drawing.Size(203, 77)
        Me.btnSuperAdmin.TabIndex = 24
        Me.btnSuperAdmin.Text = "Me"
        Me.btnSuperAdmin.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Poppins SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.Teal
        Me.btnAdmin.Location = New System.Drawing.Point(212, 3)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(207, 77)
        Me.btnAdmin.TabIndex = 24
        Me.btnAdmin.Text = "Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnClient
        '
        Me.btnClient.FlatAppearance.BorderSize = 0
        Me.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClient.Font = New System.Drawing.Font("Poppins SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClient.Location = New System.Drawing.Point(425, 3)
        Me.btnClient.Name = "btnClient"
        Me.btnClient.Size = New System.Drawing.Size(235, 77)
        Me.btnClient.TabIndex = 24
        Me.btnClient.Text = "Client"
        Me.btnClient.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 207)
        Me.Panel4.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.CellBlockIM.My.Resources.Resources.cellblock_central__1_
        Me.PictureBox1.Location = New System.Drawing.Point(47, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 163)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lblTotalText
        '
        Me.lblTotalText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalText.Location = New System.Drawing.Point(954, 118)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(106, 23)
        Me.lblTotalText.TabIndex = 37
        Me.lblTotalText.Text = "Total Accounts"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMM, dd, yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(259, 118)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 27)
        Me.DateTimePicker1.TabIndex = 36
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Poppins", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(973, 41)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(3, 0, 50, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(75, 93)
        Me.lblTotal.TabIndex = 34
        Me.lblTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(605, 113)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Manage Account"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnMainDB)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnAddEntity)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnReport)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnManageInmate)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnManageUser)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnSettings)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(253, 761)
        Me.FlowLayoutPanel1.TabIndex = 38
        '
        'btnMainDB
        '
        Me.btnMainDB.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnMainDB.FlatAppearance.BorderSize = 0
        Me.btnMainDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMainDB.Image = Global.CellBlockIM.My.Resources.Resources.grid
        Me.btnMainDB.Location = New System.Drawing.Point(0, 216)
        Me.btnMainDB.Name = "btnMainDB"
        Me.btnMainDB.Size = New System.Drawing.Size(250, 75)
        Me.btnMainDB.TabIndex = 1
        Me.btnMainDB.UseVisualStyleBackColor = False
        '
        'btnAddEntity
        '
        Me.btnAddEntity.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAddEntity.FlatAppearance.BorderSize = 0
        Me.btnAddEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEntity.Image = Global.CellBlockIM.My.Resources.Resources.plus
        Me.btnAddEntity.Location = New System.Drawing.Point(0, 297)
        Me.btnAddEntity.Name = "btnAddEntity"
        Me.btnAddEntity.Size = New System.Drawing.Size(250, 75)
        Me.btnAddEntity.TabIndex = 1
        Me.btnAddEntity.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Image = Global.CellBlockIM.My.Resources.Resources.report
        Me.btnReport.Location = New System.Drawing.Point(0, 378)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(250, 75)
        Me.btnReport.TabIndex = 1
        Me.btnReport.UseVisualStyleBackColor = False
        '
        'btnManageInmate
        '
        Me.btnManageInmate.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnManageInmate.FlatAppearance.BorderSize = 0
        Me.btnManageInmate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageInmate.Image = Global.CellBlockIM.My.Resources.Resources.inmate__1_
        Me.btnManageInmate.Location = New System.Drawing.Point(0, 459)
        Me.btnManageInmate.Name = "btnManageInmate"
        Me.btnManageInmate.Size = New System.Drawing.Size(250, 75)
        Me.btnManageInmate.TabIndex = 1
        Me.btnManageInmate.UseVisualStyleBackColor = False
        '
        'btnManageUser
        '
        Me.btnManageUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnManageUser.FlatAppearance.BorderSize = 0
        Me.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageUser.Image = Global.CellBlockIM.My.Resources.Resources.setting__4_
        Me.btnManageUser.Location = New System.Drawing.Point(0, 540)
        Me.btnManageUser.Name = "btnManageUser"
        Me.btnManageUser.Size = New System.Drawing.Size(250, 75)
        Me.btnManageUser.TabIndex = 1
        Me.btnManageUser.UseVisualStyleBackColor = False
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Image = Global.CellBlockIM.My.Resources.Resources.setting__2_
        Me.btnSettings.Location = New System.Drawing.Point(0, 621)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(250, 75)
        Me.btnSettings.TabIndex = 1
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(253, 294)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(981, 465)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(248, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(484, 364)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.dgvAdmin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(484, 364)
        Me.Panel2.TabIndex = 3
        '
        'dgvAdmin
        '
        Me.dgvAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAdmin.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAdmin.Location = New System.Drawing.Point(58, 106)
        Me.dgvAdmin.Name = "dgvAdmin"
        Me.dgvAdmin.Size = New System.Drawing.Size(369, 150)
        Me.dgvAdmin.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins Medium", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 33)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Admins"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58603!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82793!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.58604!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(248, 373)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(484, 89)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnManageAdmin, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(78, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(327, 83)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'btnManageAdmin
        '
        Me.btnManageAdmin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnManageAdmin.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnManageAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnManageAdmin.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnManageAdmin.ForeColor = System.Drawing.Color.White
        Me.btnManageAdmin.Location = New System.Drawing.Point(112, 3)
        Me.btnManageAdmin.Name = "btnManageAdmin"
        Me.btnManageAdmin.Size = New System.Drawing.Size(103, 42)
        Me.btnManageAdmin.TabIndex = 43
        Me.btnManageAdmin.Text = "Manage"
        Me.btnManageAdmin.UseVisualStyleBackColor = False
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 761)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblTotalText)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "AdminHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSettings As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnSuperAdmin As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnClient As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnManageInmate As Button
    Friend WithEvents btnMainDB As Button
    Friend WithEvents btnAddEntity As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnManageUser As Button
    Friend WithEvents lblTotalText As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnManageAdmin As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvAdmin As DataGridView
End Class
