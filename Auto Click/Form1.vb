Imports System.Windows.Forms
Imports System.Runtime.InteropServices


Public Class Form1
    Dim i As Integer = 0
    Declare Sub mouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dx As Int32, ByVal dy As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32)

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Timer1.Stop()
    End Sub
    Dim Horas As Integer = 0
    Dim Minutos As Integer = 0
    Dim Segundos As Integer = 0

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Windows.Forms.Cursor.Position = New System.Drawing.Point(Windows.Forms.Cursor.Position)



        If Time_Active_CheckBox.Checked = True Then
            Timer_Counter_Label.Text = Horas.ToString("00") & ":" & Minutos.ToString("00") & ":" & Segundos.ToString("00")

            If Left_Radio_Button.Checked = True Then
                Timer1.Interval = 1000

                'Aqui coloque dentro do Tick Clock
                If Horas = 0 And Minutos = 0 And Segundos = 0 Then
                    'LEFT CLICK
                    mouse_event(&H2, 0, 0, 0, 1)
                    mouse_event(&H4, 0, 0, 0, 1)

                    Segundos = NumericUpDown1.Value
                    '     Timer_Counter_Label.Text = "00:00:00"
                Else

                    If Segundos > 59 Then
                        Segundos = 0
                        Minutos = NumericUpDown1.Value / 60
                        If Minutos > 59 Then
                            Minutos = 0
                            Segundos = 0
                            Horas = Minutos / 3600
                        End If
                    End If

                    Segundos -= 1
                    If Segundos < 0 Then
                        Segundos = 59
                        Minutos -= 1
                        If Minutos < 0 Then
                            Minutos = 59
                            Segundos = 59
                            Horas -= 1
                        End If
                    End If
                    ' Timer_Counter_Label.Text = Horas.ToString("00") & ":" & Minutos.ToString("00") & ":" & Segundos.ToString("00")
                End If


            Else
                Timer1.Interval = 1000

                'Aqui coloque dentro do Tick Clock
                If Horas = 0 And Minutos = 0 And Segundos = 0 Then
                    'RIGHT CLICK
                    mouse_event(&H8, 0, 0, 0, 1)
                    mouse_event(&H10, 0, 0, 0, 1)

                    Segundos = NumericUpDown1.Value
                    'Timer_Counter_Label.Text = "00:00:00"
                Else
                    If Segundos > 59 Then
                        Segundos = 0
                        Minutos = NumericUpDown1.Value / 60
                        If Minutos > 59 Then
                            Minutos = 0
                            Segundos = 0
                            Horas = Minutos / 3600
                        End If
                    End If

                    Segundos -= 1
                    If Segundos < 0 Then
                        Segundos = 59
                        Minutos -= 1
                        If Minutos < 0 Then
                            Minutos = 59
                            Segundos = 59
                            Horas -= 1
                        End If
                    End If

                End If
            End If

        Else
            Timer1.Interval = 100
            If Left_Radio_Button.Checked = True Then
                'LEFT CLICK
                mouse_event(&H2, 0, 0, 0, 1)
                mouse_event(&H4, 0, 0, 0, 1)
            Else
                'RIGHT CLICK
                mouse_event(&H8, 0, 0, 0, 1)
                mouse_event(&H10, 0, 0, 0, 1)
            End If

        End If

    End Sub


    
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            ComboBox1.SelectedIndex = My.Settings.Start_Hotkey
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef m As Message, ByVal keyData As Keys) As Boolean
        'Select Case keyData
        Dim G As String = keyData.ToString
        Dim H As String = ComboBox1.SelectedItem

        If G = H Then

            If Timer1.Enabled = True Then
                Timer_Counter_Label.Text = "00:00:00"
                Timer1.Stop()
                Return True
            Else
                Segundos = NumericUpDown1.Value
                Timer1.Start()
                Return True
            End If
        End If

        If G = "Escape" Then
            Timer_Counter_Label.Text = "00:00:00"
            Timer1.Stop()
            Return True
        End If

        Return False
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles Time_Active_CheckBox.CheckedChanged
        If Time_Active_CheckBox.Checked = True Then
            NumericUpDown1.Enabled = True
        Else
            NumericUpDown1.Enabled = False
        End If
    End Sub

    Private Sub Left_Button_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Left_Button_Pic.Click
        Left_Radio_Button.Checked = True
    End Sub

    Private Sub Right_Button_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Right_Button_Pic.Click
        Right_Radio_Button.Checked = True
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            My.Settings.Start_Hotkey = ComboBox1.SelectedIndex
            My.Settings.Save()
            Start_Label.Text = "Press " & ComboBox1.SelectedItem.ToString & " to Start:"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Hide_Pic_Click(sender As System.Object, e As System.EventArgs) Handles Hide_Pic.Click
        Try
            Me.Hide()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Try
            Me.Show()
        Catch ex As Exception

        End Try
    End Sub
End Class


