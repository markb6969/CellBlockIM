﻿Public Class AddCellblockHome
    Private Sub AddCellblockHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable

        AddHandler AddEditDeleteControl1.AddButtonClick, AddressOf HandleAddButtonClick
        AddHandler AddEditDeleteControl1.EditButtonClick, AddressOf HandleEditButtonClick
        AddHandler AddEditDeleteControl1.DeleteButtonClick, AddressOf HandleDeleteButtonClick
    End Sub


    Private Sub HandleAddButtonClick()
        Dim addCellblockForm As New AddCellblock()
        addCellblockForm.Show()
        Me.Hide()
    End Sub

    Private Sub HandleEditButtonClick()
        Dim editCellblockForm As New EditCellblock()
        editCellblockForm.Show()
        Me.Hide()
    End Sub

    Private Sub HandleDeleteButtonClick()
        Dim deleteCellblockForm As New DeleteCellblock()
        deleteCellblockForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnMainDB_Click(sender As Object, e As EventArgs) Handles btnMainDB.Click
        MainDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddEntity_Click(sender As Object, e As EventArgs) Handles btnAddEntity.Click
        AddDashboard.Show()
        Me.Hide()

    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
        AddStaffHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnMovePDL_Click(sender As Object, e As EventArgs) Handles btnMovePDL.Click
        MovepdlHome.Show()
        Me.Hide()

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ReportHome.Show()
        Me.Hide()

    End Sub
End Class
