Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Media

Public Class Form1
#Region "Variables"

    Dim Time As Integer
    Dim ResetTime As Integer
    Dim Mode As Integer = 0
    Dim Counted As Boolean = False

#End Region

#Region "Delta"

    Private Sub Delta_Tick(sender As Object, e As EventArgs) Handles Delta.Tick
        If Time <= 0 And Counted Then
            Counted = False
            Time = 0
            PlaySound()
        ElseIf Counted Then
            Time -= 1
        End If
        CalculateTimeText()
    End Sub

#End Region

#Region "ModeSet"

    Private Sub ModeTree_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles ModeTree.AfterSelect
        Select Case e.Node.Name
            Case "Sec"
                Mode = 0
            Case "Min"
                Mode = 1
            Case "Hours"
                Mode = 2
        End Select
    End Sub

#End Region

#Region "TimerButtons"

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Counted = True
        ResetTime = Time
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles StopButton.Click
        Counted = False
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        Time = ResetTime
    End Sub

#End Region

#Region "ModButtons"

    Private Sub SubButton_Click(sender As Object, e As EventArgs) Handles SubButton.Click
        If Mode = 0 Then
            Time -= 1
        End If
        If Mode = 1 Then
            Time -= 60
        End If
        If Mode = 2 Then
            Time -= 3600
        End If
        TimeLimits()
        CalculateTimeText()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If Mode = 0 Then
            Time += 1
        End If
        If Mode = 1 Then
            Time += 60
        End If
        If Mode = 2 Then
            Time += 3600
        End If
        TimeLimits()
        CalculateTimeText()
    End Sub
    ' 0 = Sec Mode
    ' 1 = Min Mode
    ' 2 = Hours Mode

#End Region

#Region "Functions"

    Private Sub CalculateTimeText()
        Dim Hours = Time \ 3600
        Dim Minutes = (Time Mod 3600) \ 60
        Dim Seconds = Time Mod 60
        Dim ResultText = String.Format("{0:D2}:{1:D2}:{2:D2}", Hours, Minutes, Seconds)
        Me.TimeText.Text = ResultText
    End Sub

    Private Sub TimeLimits()
        If Time < 0 Then
            Time = 0
        End If
        If Time > 86400 Then
            Time = 86400
        End If
    End Sub

    Private Sub PlaySound()
        Try
            Dim player As New SoundPlayer("./timerEnd.wav") ' Ruta del archivo de sonido
            player.Play()
        Catch ex As Exception
            MessageBox.Show("Error al reproducir el sonido: " & ex.Message)
        End Try
    End Sub

#End Region

End Class
