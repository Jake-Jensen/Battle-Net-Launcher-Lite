Public Class LauncherForm

    Private Sub LauncherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Sets the SC2 launch button to transparent. 
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Transparent
        Button1.FlatAppearance.MouseOverBackColor = Color.Transparent
        Button1.BackColor = Color.Transparent

    End Sub

    Private Sub Form_Load() 'Initializes the timer, sets it to 3 seconds, and enables it.
        Dim Timer1
        Timer1.Interval = 3000 '3 seconds
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick 'Part of the Timer set. Once the timer fully ticks down, call the status checker.
        Call CheckIfRunning()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, 'Launches the application using SC2's switcher.
        ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("C:\Program Files (x86)\StarCraft II\Support64\SC2Switcher_x64.exe")
        Call CheckIfRunning() 'Skips waiting for the timer and calls the status checker immediately after launching. 

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Basic copyright shit for Blizzard, and shows my dev signature. 
        MessageBox.Show("Battle.Net ©1996 - 2014 Blizzard Entertainment, Inc. All rights reserved. Battle.net and Blizzard Entertainment are trademarks or registered trademarks of Blizzard Entertainment, Inc. in the U.S. and/or other countries." & vbNewLine & "Blizzard Entertainment is a trademark or registered trademark of Blizzard Entertainment, Inc. in the U.S. and/or other countries. All rights reserved." & vbNewLine & "StarCraft II: Wings of Libery ©2010 Blizzard Entertainment, Inc. All rights reserved. Wings of Liberty is a trademark, and StarCraft and Blizzard Entertainment are trademarks or registered trademarks of Blizzard Entertainment, Inc. in the U.S. and/or other countries." & vbNewLine & "Heroes of the Storm ©2014 Blizzard Entertainment, Inc. All rights reserved. Heroes of the Storm is a trademark of Blizzard Entertainment, Inc." & vbNewLine & "Lite Launcher developed by Jake Jensen ©2017", "Battle.net Launcher About",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click 'Button for killing SC2's main process via shell. 
        Shell("taskkill /F /IM SC2_x64.exe /T", 0)
        Call CheckIfRunning()

    End Sub

    Dim p() As Process 'Creates the variables "p" as a process
    Private Sub CheckIfRunning() 'Checks if SC2 is running or not, then changes the text on the status button to reflect if it is or not. 
        p = Process.GetProcessesByName("SC2_x64")
        If p.Count > 0 Then
            SCStatus.Text = "SC2 is running" ' Process is running
        Else
            SCStatus.Text = "SC2 is not running" ' Process is not running
        End If
    End Sub
End Class

