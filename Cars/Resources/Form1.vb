Public Class Form1

    Sub clearAndFocus() 'Function to clear all textboxes after login
        txtUserName.Clear()
        txtPassword.Clear()
        txtUserName.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim user As String = txtUserName.Text
        Dim pass As String = txtPassword.Text

        If user = "user" And pass = "user" Then
            Form2.Show() 'Opening the employee site
            Me.Hide()
            clearAndFocus() 'To clear all textboxes after login

        ElseIf user = "admin" And pass = "admin" Then
            Admin_form.Show() 'Opening the admin site
            Me.Hide()
            clearAndFocus() 'To clear all textboxes after login
        Else
            MessageBox.Show("Incorrect User Name or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub checkBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoxShowPassword.CheckedChanged
        If checkBoxShowPassword.CheckState = CheckState.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "●"
        End If
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        MessageBox.Show("Welcome to ZR-Cars :" & vbCrLf & "- To enter like employee, the admin must add your username and password." & vbCrLf & "- Any user name or password problem, you should contact the administrator." & vbCrLf & "- Any problem with this application, contact the developers." & vbCrLf & "" & vbCrLf & "The developer :" & vbCrLf & "Zeyad", "Info about ZR-Cars", MessageBoxButtons.OK)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End
        End If
    End Sub
End Class