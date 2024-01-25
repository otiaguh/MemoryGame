Imports System.ComponentModel
Public Class FrmGame
    Dim Level As Integer = FrmLevel.Level
    Dim ClickedCount As Integer = 0
    Dim FirstClicked As PictureBox = Nothing
    Dim SecondClicked As PictureBox = Nothing
    Dim pairsFound As Integer = 0
    Dim totalClicks As Integer = 40
    Public time As Integer = 0
    Public gameOver As Boolean
    Dim x As Boolean = False
    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tags As New List(Of String)

        For i As Integer = 1 To 10
            tags.Add("" & i.ToString())
            tags.Add("" & i.ToString())
        Next i

        Dim rand As New Random()
        tags = tags.OrderBy(Function() rand.Next()).ToList()

        For i As Integer = 1 To 20
            Dim picName As String = "PicI" & i.ToString()
            Dim picBox As PictureBox = CType(Me.Controls(picName), PictureBox)
            picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("hide")
            picBox.BackgroundImageLayout = ImageLayout.Stretch
            picBox.Tag = tags(i - 1)
            AddHandler picBox.Click, AddressOf Pic_Click
        Next i
        LblTries.Hide()
        If Level = 3 Then
            LblTries.Show()
            showImagesInHardLevel()
        End If
    End Sub


    Private Sub Pic_Click(sender As Object, e As EventArgs)
        Dim picBox As PictureBox = DirectCast(sender, PictureBox)
        Dim tagDaPictureBox As String = picBox.Tag.ToString()
        TmrTime.Start()
        TmrDelay1.Interval = 800
        TmrDelay2.Interval = 800

        If Level = 1 Then
            If ClickedCount = 0 Then
                FirstClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1
            ElseIf ClickedCount = 1 AndAlso picBox IsNot FirstClicked Then
                SecondClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1
                If FirstClicked.Tag.ToString() = SecondClicked.Tag.ToString() Then
                    PairFound()
                End If
            ElseIf ClickedCount = 2 Then
                pairDiferent()
                FirstClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1
            End If
        ElseIf Level = 2 Then
            If ClickedCount = 0 Then
                FirstClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1
            ElseIf ClickedCount = 1 AndAlso picBox IsNot FirstClicked Then
                TmrDelay1.Stop()
                TmrDelay2.Stop()
                SecondClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1

                If FirstClicked.Tag.ToString() = SecondClicked.Tag.ToString() Then
                    PairFound()
                Else
                    TmrDelay1.Start()
                    TmrDelay2.Start()
                End If
            ElseIf ClickedCount = 2 Then
                pairDiferent()
                TmrDelay1.Stop()
                TmrDelay2.Stop()
                FirstClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1
            End If
        ElseIf Level = 3 Then
            If ClickedCount = 0 Then
                TmrDelay1.Stop()
                TmrDelay2.Stop()
                FirstClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1
            ElseIf ClickedCount = 1 AndAlso picBox IsNot FirstClicked Then
                TmrDelay1.Stop()
                TmrDelay2.Stop()
                SecondClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1

                If FirstClicked.Tag.ToString() = SecondClicked.Tag.ToString() Then
                    PairFound()
                Else
                    totalClicks -= 1
                    TmrDelay1.Start()
                    TmrDelay2.Start()
                End If
            ElseIf ClickedCount = 2 Then
                pairDiferent()
                TmrDelay1.Stop()
                TmrDelay2.Stop()
                totalClicks -= 1
                FirstClicked = picBox
                picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & tagDaPictureBox)
                ClickedCount += 1
            End If
            LblTries.Text = "Remaining Attempts: " & totalClicks.ToString
            If totalClicks = 0 Then
                onGameOver()
            End If
        End If

    End Sub
    Private Sub showImagesInHardLevel()
        For i As Integer = 1 To 20
            Dim picName As String = "PicI" & i.ToString()
            Dim picBox As PictureBox = CType(Me.Controls(picName), PictureBox)

            picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("I" & picBox.Tag.ToString())
            picBox.BackgroundImageLayout = ImageLayout.Stretch
        Next i

        Dim displayTimer As New Timer()
        displayTimer.Interval = 1400
        AddHandler displayTimer.Tick, Sub(sender As Object, e As EventArgs)
                                          For i As Integer = 1 To 20
                                              Dim picName As String = "PicI" & i.ToString()
                                              Dim picBox As PictureBox = CType(Me.Controls(picName), PictureBox)
                                              picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("hide")
                                          Next i
                                          displayTimer.Stop()
                                      End Sub
        displayTimer.Start()
    End Sub
    Private Sub PairFound()
        ClickedCount = 0
        FirstClicked.Enabled = False
        SecondClicked.Enabled = False
        If pairsFound < 10 Then
            pairsFound = pairsFound + 1
            LblPairsFound.Text = "Pairs Found: " & pairsFound.ToString
            If pairsFound = 10 Then
                TmrTime.Stop()

                Dim tags As New List(Of String)

                For i As Integer = 1 To 10
                    tags.Add("" & i.ToString())
                    tags.Add("" & i.ToString())
                Next i

                Dim rand As New Random()
                tags = tags.OrderBy(Function() rand.Next()).ToList()

                For i As Integer = 1 To 20
                    Dim picName As String = "PicI" & i.ToString()
                    Dim picBox As PictureBox = CType(Me.Controls(picName), PictureBox)
                    picBox.BackgroundImage = My.Resources.ResourceManager.GetObject("hide")
                    picBox.BackgroundImageLayout = ImageLayout.Stretch
                    picBox.Tag = tags(i - 1)
                    picBox.Enabled = True
                    AddHandler picBox.Click, AddressOf Pic_Click
                Next i
                pairsFound = 0
                LblPairsFound.Text = "Pairs Found: " & pairsFound.ToString
                ClickedCount = 0
                TmrTime.Stop()
                totalClicks = 40
                LblTries.Hide()
                LblTries.Text = "Remaining Attempts: 40"
                FrmFinal.Show()
                x = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub onGameOver()
        gameOver = True
        x = True
        FrmFinal.Show()
        Me.Close()

        Dim tags As New List(Of String)

        For i As Integer = 1 To 10
            tags.Add("" & i.ToString())
            tags.Add("" & i.ToString())
        Next i

        Dim rand As New Random()
        tags = tags.OrderBy(Function() rand.Next()).ToList()
        ClickedCount = 0
        pairsFound = 0
        TmrTime.Stop()
        totalClicks = 40
        LblTries.Hide()
        LblTries.Text = "Remaining Attempts: 40"
        LblPairsFound.Text = "Pairs Found: " & pairsFound.ToString
    End Sub
    Private Sub pairDiferent()
        FirstClicked.BackgroundImage = My.Resources.ResourceManager.GetObject("hide")
        SecondClicked.BackgroundImage = My.Resources.ResourceManager.GetObject("hide")
        ClickedCount = 0
    End Sub

    Private Sub TmrTime_Tick(sender As Object, e As EventArgs) Handles TmrTime.Tick
        time += 1
    End Sub

    Private Sub TmrDelay1_Tick(sender As Object, e As EventArgs) Handles TmrDelay1.Tick
        FirstClicked.BackgroundImage = My.Resources.ResourceManager.GetObject("hide")
    End Sub

    Private Sub TmrDelay2_Tick(sender As Object, e As EventArgs) Handles TmrDelay2.Tick
        SecondClicked.BackgroundImage = My.Resources.ResourceManager.GetObject("hide")
        ClickedCount = 0
    End Sub

    Private Sub FrmGame_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not x Then
            End
        End If
    End Sub
End Class
