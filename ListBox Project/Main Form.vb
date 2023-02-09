' Name:         ListBox Project
' Purpose:      Demonstrate the String Collection Editor.
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelected_Click(sender As Object, e As EventArgs) Handles btnSelected.Click
        ' Display the selected item and selected index.

        lblItem.Text = lstStates.SelectedItem.ToString
        lblIndex.Text = lstStates.SelectedIndex.ToString
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Select the first item in the lstStates control.

        lstStates.SelectedIndex = 0

    End Sub

    Private Sub lstStates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstStates.SelectedIndexChanged
        ' Clear the contents of the Item and Index boxes.

        lblIndex.Text = String.Empty
        lblItem.Text = String.Empty
    End Sub
End Class
