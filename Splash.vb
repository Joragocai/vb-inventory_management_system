﻿Imports System.Web.UI.WebControls

Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgress.Increment(2)
        Dim Percentage As String
        Percentage = Convert.ToString(MyProgress.Value)
        lblPercent.Text = Percentage + "%"
        If MyProgress.Value = 100 Then
            Me.Hide()
            Dim log = New Login
            log.Show()
            Timer1.Enabled = False

        End If
    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class
