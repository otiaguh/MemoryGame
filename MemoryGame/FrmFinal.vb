Imports System.ComponentModel

Public Class FrmFinal
    Dim x As Boolean = False
    Private Sub FrmFinal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalSeconds As Integer = FrmGame.time
        Dim minutes As Integer = totalSeconds \ 60
        Dim seconds As Integer = totalSeconds Mod 60
        If FrmGame.gameOver = True Then
            LblTime.Hide()
            LblResult.Text = "You lost!"
            BtnRestart.Text = "Try Again"
        Else
            If minutes > 0 Then
                LblTime.Text = "In " & minutes.ToString() & " minute and " & seconds.ToString() & " seconds"
            Else
                LblTime.Text = "In " & seconds.ToString() & " seconds"
            End If
        End If
    End Sub

    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        FrmMemoryGame.Show()
        x = True
        Me.Close()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

    Private Sub FrmFinal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not x Then
            End
        End If
    End Sub
End Class