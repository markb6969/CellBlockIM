<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InmateHome
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
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvAllPdl = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddInmate = New System.Windows.Forms.Button()
        Me.btnUpdateInmate = New System.Windows.Forms.Button()
        Me.btnRemoveInmate = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMainDB = New System.Windows.Forms.Button()
        Me.btnAddEntity = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnManageInmate = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAllPdl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTotalText
        '
        Me.lblTotalText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalText.Location = New System.Drawing.Point(878, 118)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(256, 23)
        Me.lblTotalText.TabIndex = 44
        Me.lblTotalText.Text = "Total Persons Deprived of Liberty (PDL)"
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
        Me.DateTimePicker1.TabIndex = 43
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
        Me.lblTotal.TabIndex = 41
        Me.lblTotal.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 113)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Dashboard"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(253, 294)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 455.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(981, 455)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.57469!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.85061!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.57469!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(975, 449)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgvAllPdl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(174, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 443)
        Me.Panel1.TabIndex = 0
        '
        'dgvAllPdl
        '
        Me.dgvAllPdl.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvAllPdl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAllPdl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAllPdl.Location = New System.Drawing.Point(0, 0)
        Me.dgvAllPdl.Name = "dgvAllPdl"
        Me.dgvAllPdl.Size = New System.Drawing.Size(626, 443)
        Me.dgvAllPdl.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAddInmate)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnUpdateInmate)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnRemoveInmate)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(253, 194)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(981, 100)
        Me.FlowLayoutPanel2.TabIndex = 46
        '
        'btnAddInmate
        '
        Me.btnAddInmate.FlatAppearance.BorderSize = 0
        Me.btnAddInmate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddInmate.Font = New System.Drawing.Font("Poppins SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddInmate.ForeColor = System.Drawing.Color.Black
        Me.btnAddInmate.Location = New System.Drawing.Point(3, 3)
        Me.btnAddInmate.Name = "btnAddInmate"
        Me.btnAddInmate.Size = New System.Drawing.Size(237, 77)
        Me.btnAddInmate.TabIndex = 24
        Me.btnAddInmate.Text = "Add "
        Me.btnAddInmate.UseVisualStyleBackColor = True
        '
        'btnUpdateInmate
        '
        Me.btnUpdateInmate.FlatAppearance.BorderSize = 0
        Me.btnUpdateInmate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateInmate.Font = New System.Drawing.Font("Poppins SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateInmate.Location = New System.Drawing.Point(246, 3)
        Me.btnUpdateInmate.Name = "btnUpdateInmate"
        Me.btnUpdateInmate.Size = New System.Drawing.Size(214, 77)
        Me.btnUpdateInmate.TabIndex = 24
        Me.btnUpdateInmate.Text = "Update"
        Me.btnUpdateInmate.UseVisualStyleBackColor = True
        '
        'btnRemoveInmate
        '
        Me.btnRemoveInmate.FlatAppearance.BorderSize = 0
        Me.btnRemoveInmate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveInmate.Font = New System.Drawing.Font("Poppins SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveInmate.Location = New System.Drawing.Point(466, 3)
        Me.btnRemoveInmate.Name = "btnRemoveInmate"
        Me.btnRemoveInmate.Size = New System.Drawing.Size(235, 77)
        Me.btnRemoveInmate.TabIndex = 24
        Me.btnRemoveInmate.Text = "Remove"
        Me.btnRemoveInmate.UseVisualStyleBackColor = True
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
        Me.FlowLayoutPanel1.TabIndex = 45
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
        Me.btnManageInmate.Image = Global.CellBlockIM.My.Resources.Resources.inmate__2_
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
        Me.btnManageUser.Image = Global.CellBlockIM.My.Resources.Resources.setting__3_
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
        'InmateHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 761)
        Me.Controls.Add(Me.lblTotalText)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "InmateHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvAllPdl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalText As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnAddInmate As Button
    Friend WithEvents btnUpdateInmate As Button
    Friend WithEvents btnRemoveInmate As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMainDB As Button
    Friend WithEvents btnAddEntity As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnManageInmate As Button
    Friend WithEvents btnManageUser As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvAllPdl As DataGridView
End Class
