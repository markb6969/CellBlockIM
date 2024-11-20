﻿Public Class MainDashboard

    Public Sub switchTableLayoutPanel(tlp As TableLayoutPanel, newControl As UserControl)
        tlp.Controls.Clear()
        newControl.Dock = DockStyle.Fill
        tlp.Controls.Add(newControl, 0, 0)
    End Sub

    Public Sub SwitchToMainDashboadControl()
        switchTableLayoutPanel(tlpMain, New MainDashboardControl())
    End Sub
    Public Sub SwitchToAddCellblockControlHome()
        switchTableLayoutPanel(tlpMain, New AddCellblockControlHome())
    End Sub

    Public Sub SwitchToAddStaffControlHome()
        switchTableLayoutPanel(tlpMain, New AddStaffHomeControl())
    End Sub

    Public Sub SwitchToMovepdlHomeControl()
        switchTableLayoutPanel(tlpMain, New MovepdlHomeControl())
    End Sub

    Public Sub SwitchToMovepdlControl()
        switchTableLayoutPanel(tlpMain, New MovepdlControl())
    End Sub

    Public Sub SwitchToReportHomeControl()
        switchTableLayoutPanel(tlpMain, New ReportHomeControl())
    End Sub

    Public Sub SwitchToInmateHomeControl()
        switchTableLayoutPanel(tlpMain, New InmateHomeControl())
    End Sub

    Public Sub SwitchToInmateCriminalCaseControl()
        switchTableLayoutPanel(tlpMain, New AddCriminalCaseControl())
    End Sub
    Public Sub SwitchToInmateMedicalInfoControl()
        switchTableLayoutPanel(tlpMain, New AddMedicalinfoControl())
    End Sub


    ' Switch to AddCellblockControl
    Public Sub SwitchToAddCellblockControl()
        switchTableLayoutPanel(tlpMain, New AddCellblockControl())
    End Sub

    ' Switch to EditCellblockControl
    Public Sub SwitchToEditCellblockControl()
        switchTableLayoutPanel(tlpMain, New EditCellblockControl())
    End Sub

    ' Switch to DeleteCellblockControl
    Public Sub SwitchToDeleteCellblockControl()
        switchTableLayoutPanel(tlpMain, New DeleteCellblockControl())
    End Sub



    ' Switch to AddStaffControl
    Public Sub SwitchToAddStaffControl()
        switchTableLayoutPanel(tlpMain, New AddStaffControl())
    End Sub

    ' Switch to EditStaffControl
    Public Sub SwitchToEditStaffControl()
        switchTableLayoutPanel(tlpMain, New EditStaffControl())
    End Sub

    ' Switch to DeleteStaffControl
    Public Sub SwitchToDeleteStaffControl()
        switchTableLayoutPanel(tlpMain, New DeleteStaffControl())
    End Sub


    ' Switch to InmateControl
    Public Sub SwitchToAddInmateControl()
        switchTableLayoutPanel(tlpMain, New AddInmateControl())
    End Sub

    Public Sub SwitchToUpdateInmateControl()
        switchTableLayoutPanel(tlpMain, New UpdateHomeControl())
    End Sub

    Public Sub SwitchToRemoveInmateControl()
        switchTableLayoutPanel(tlpMain, New RemoveHomeControl())
    End Sub




    ' OLD CODE
    Private Sub btnMainDB_Click(sender As Object, e As EventArgs) Handles btnMainDB.Click
        Dim mainDashboardControl As New MainDashboardControl()
        switchTableLayoutPanel(tlpMain, mainDashboardControl)
    End Sub
    Private Sub btnAddEntity_Click(sender As Object, e As EventArgs) Handles btnAddEntity.Click
        Dim addEntityControl As New AddEntityControl()
        switchTableLayoutPanel(tlpMain, addEntityControl)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim reportControl As New ReportHomeControl()
        switchTableLayoutPanel(tlpMain, reportControl)
    End Sub

    Private Sub btnManageInmate_Click(sender As Object, e As EventArgs) Handles btnManageInmate.Click
        Dim inmateControl As New InmateHomeControl()
        switchTableLayoutPanel(tlpMain, inmateControl)
    End Sub

    Private Sub btnManageUser_Click(sender As Object, e As EventArgs) Handles btnManageUser.Click
        ManageHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        SettingsHome.Show()
        Me.Hide()

    End Sub


End Class