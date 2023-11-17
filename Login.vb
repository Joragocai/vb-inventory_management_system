Public Class Login
    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUserName.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Enter Username and Password")
        ElseIf txtUserName.Text = "Admin" And txtPassword.Text = "Password" Then
            Dim obj = New Items
            obj.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Username or Password")
            txtUserName.Text = ""
            txtPassword.Text = ""
        End If
    End Sub

    Private Sub lblContinueAsSeller_Click(sender As Object, e As EventArgs) Handles lblContinueAsSeller.Click
        Dim obj = New Billing
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub pbClose_Click(sender As Object, e As EventArgs) Handles pbClose.Click
        End
    End Sub

    Private Sub txtUserName_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txtPassword.Focus()
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnLogin.Focus()
        Else
            e.Handled = False
        End If
    End Sub
End Class