Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picCars.Image = My.Resources.rightCarPic_blur_
        picParts.Image = My.Resources.leftPartsPics_blur_
    End Sub

    Private Sub picCars_MouseEnter(sender As Object, e As EventArgs) Handles picCars.MouseEnter
        picCars.Image = My.Resources.rightCarPics_Edit_ 'To show the (pic) when the mouse (enter) their area
    End Sub

    Private Sub picCars_MouseLeave(sender As Object, e As EventArgs) Handles picCars.MouseLeave
        picCars.Image = My.Resources.rightCarPic_blur_ 'to show the (blur pic) when the mouse (leave) their area
    End Sub

    Private Sub picCars_Click(sender As Object, e As EventArgs) Handles picCars.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub picParts_MouseEnter(sender As Object, e As EventArgs) Handles picParts.MouseEnter
        picParts.Image = My.Resources.leftPartsPic_Edit_ 'To show the (pic) when the mouse (enter) their area
    End Sub

    Private Sub picParts_MouseLeave(sender As Object, e As EventArgs) Handles picParts.MouseLeave
        picParts.Image = My.Resources.leftPartsPics_blur_ 'to show the (blur pic) when the mouse (leave) their area
    End Sub

    Private Sub picParts_Click(sender As Object, e As EventArgs) Handles picParts.Click
        MessageBox.Show("Not available yet!", "Car's parts", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MessageBox.Show("Are you sure?", "Loging out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class
