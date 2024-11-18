<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RemoveOption
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnRemoveInmate = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnMainDB = New System.Windows.Forms.Button()
        Me.btnAddEntity = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnManageInmate = New System.Windows.Forms.Button()
        Me.btnManageUser = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddInmate = New System.Windows.Forms.Button()
        Me.btnUpdateInmate = New System.Windows.Forms.Button()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMoveInmate = New System.Windows.Forms.Button()
        Me.btnRelease = New System.Windows.Forms.Button()
        Me.lblPdlId = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPdlName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.DateTimePicker1.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins SemiBold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(410, 113)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Dashboard"
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
        Me.lblTotal.TabIndex = 62
        Me.lblTotal.Text = "0"
        '
        'btnRemoveInmate
        '
        Me.btnRemoveInmate.FlatAppearance.BorderSize = 0
        Me.btnRemoveInmate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveInmate.Font = New System.Drawing.Font("Poppins SemiBold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveInmate.ForeColor = System.Drawing.Color.Teal
        Me.btnRemoveInmate.Location = New System.Drawing.Point(466, 3)
        Me.btnRemoveInmate.Name = "btnRemoveInmate"
        Me.btnRemoveInmate.Size = New System.Drawing.Size(235, 77)
        Me.btnRemoveInmate.TabIndex = 24
        Me.btnRemoveInmate.Text = "Remove"
        Me.btnRemoveInmate.UseVisualStyleBackColor = True
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
        Me.FlowLayoutPanel1.TabIndex = 66
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
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAddInmate)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnUpdateInmate)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnRemoveInmate)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(253, 197)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(981, 100)
        Me.FlowLayoutPanel2.TabIndex = 67
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
        Me.btnUpdateInmate.ForeColor = System.Drawing.Color.Black
        Me.btnUpdateInmate.Location = New System.Drawing.Point(246, 3)
        Me.btnUpdateInmate.Name = "btnUpdateInmate"
        Me.btnUpdateInmate.Size = New System.Drawing.Size(214, 77)
        Me.btnUpdateInmate.TabIndex = 24
        Me.btnUpdateInmate.Text = "Update"
        Me.btnUpdateInmate.UseVisualStyleBackColor = True
        '
        'lblTotalText
        '
        Me.lblTotalText.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalText.Location = New System.Drawing.Point(878, 118)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(256, 23)
        Me.lblTotalText.TabIndex = 65
        Me.lblTotalText.Text = "Total Persons Deprived of Liberty (PDL)"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 459.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 459.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 459.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(975, 459)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39025!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.21951!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.39025!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(969, 453)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnMoveInmate)
        Me.Panel1.Controls.Add(Me.btnRelease)
        Me.Panel1.Controls.Add(Me.lblPdlId)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPdlName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(239, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 447)
        Me.Panel1.TabIndex = 0
        '
        'btnMoveInmate
        '
        Me.btnMoveInmate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMoveInmate.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnMoveInmate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMoveInmate.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMoveInmate.ForeColor = System.Drawing.Color.White
        Me.btnMoveInmate.Location = New System.Drawing.Point(45, 358)
        Me.btnMoveInmate.Name = "btnMoveInmate"
        Me.btnMoveInmate.Size = New System.Drawing.Size(107, 42)
        Me.btnMoveInmate.TabIndex = 41
        Me.btnMoveInmate.Text = "Next"
        Me.btnMoveInmate.UseVisualStyleBackColor = False
        '
        'btnRelease
        '
        Me.btnRelease.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelease.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRelease.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelease.ForeColor = System.Drawing.Color.White
        Me.btnRelease.Location = New System.Drawing.Point(45, 214)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(107, 42)
        Me.btnRelease.TabIndex = 41
        Me.btnRelease.Text = "Next"
        Me.btnRelease.UseVisualStyleBackColor = False
        '
        'lblPdlId
        '
        Me.lblPdlId.AutoSize = True
        Me.lblPdlId.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPdlId.ForeColor = System.Drawing.Color.Black
        Me.lblPdlId.Location = New System.Drawing.Point(210, 49)
        Me.lblPdlId.Name = "lblPdlId"
        Me.lblPdlId.Size = New System.Drawing.Size(101, 37)
        Me.lblPdlId.TabIndex = 30
        Me.lblPdlId.Text = "(PDL ID)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(38, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 37)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Remove from Cellblock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(38, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 37)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Release"
        '
        'lblPdlName
        '
        Me.lblPdlName.AutoSize = True
        Me.lblPdlName.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPdlName.ForeColor = System.Drawing.Color.Black
        Me.lblPdlName.Location = New System.Drawing.Point(24, 49)
        Me.lblPdlName.Name = "lblPdlName"
        Me.lblPdlName.Size = New System.Drawing.Size(143, 37)
        Me.lblPdlName.TabIndex = 30
        Me.lblPdlName.Text = "(PDL name)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins SemiBold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(24, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 37)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "PDL Information"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(253, 294)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(981, 465)
        Me.TableLayoutPanel1.TabIndex = 61
        '
        'RemoveOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1234, 761)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.lblTotalText)
        Me.Name = "RemoveOption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManageUser As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMainDB As Button
    Friend WithEvents btnAddEntity As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnManageInmate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnRemoveInmate As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnAddInmate As Button
    Friend WithEvents btnUpdateInmate As Button
    Friend WithEvents lblTotalText As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRelease As Button
    Friend WithEvents lblPdlId As Label
    Friend WithEvents lblPdlName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMoveInmate As Button
End Class
