Public Class FrmLevel
    Public Level As Integer
    Dim clickedButton As Button
    Private Sub FrmLevel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub FrmLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = FrmMemoryGame.Location
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles BtnEasy.Click, BtnMedium.Click, BtnHard.Click
        clickedButton = DirectCast(sender, Button)
        Level = clickedButton.Tag
        Me.Hide()
        FrmGame.Show()
    End Sub
End Class