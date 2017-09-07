Public Class LauncherForm

    Private Sub LauncherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Sets the SC2 launch button to transparent. 
        StarCraftButton.FlatAppearance.BorderSize = 0
        StarCraftButton.FlatAppearance.MouseDownBackColor = Color.Transparent
        StarCraftButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        StarCraftButton.BackColor = Color.Transparent
        HeroesButton.FlatAppearance.BorderSize = 0
        HeroesButton.FlatAppearance.MouseDownBackColor = Color.Transparent
        HeroesButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        HeroesButton.BackColor = Color.Transparent
        WowButton.FlatAppearance.BorderSize = 0
        WowButton.FlatAppearance.MouseDownBackColor = Color.Transparent
        WowButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        WowButton.BackColor = Color.Transparent
        BroodButton.FlatAppearance.BorderSize = 0
        BroodButton.FlatAppearance.MouseDownBackColor = Color.Transparent
        BroodButton.FlatAppearance.MouseOverBackColor = Color.Transparent
        BroodButton.BackColor = Color.Transparent
        StarCraftLaunchButton.Visible = False
        HeroesLaunchButton.Visible = False
        WoWLaunchButton.Visible = False
        BroodLauncher.Visible = False
        BroodNotice.Visible = False
        MsgBox("Graphics are temporary until some custom artwork can be used, until then, generic images will be used.")

    End Sub

    Private Sub Form_Load() 'Initializes the timer, sets it to 3 seconds, and enables it.
        Dim Timer1
        Timer1.Interval = 3000 '3 seconds
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick 'Part of the Timer set. Once the timer fully ticks down, call the status checker.
        Call CheckIfRunning1()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Basic copyright shit for Blizzard, and shows my dev signature. 
        MessageBox.Show("Battle.Net ©1996 - 2014 Blizzard Entertainment, Inc. All rights reserved. Battle.net and Blizzard Entertainment are trademarks or registered trademarks of Blizzard Entertainment, Inc. in the U.S. and/or other countries." & vbNewLine & "Blizzard Entertainment is a trademark or registered trademark of Blizzard Entertainment, Inc. in the U.S. and/or other countries. All rights reserved." & vbNewLine & "StarCraft II: Wings of Libery ©2010 Blizzard Entertainment, Inc. All rights reserved. Wings of Liberty is a trademark, and StarCraft and Blizzard Entertainment are trademarks or registered trademarks of Blizzard Entertainment, Inc. in the U.S. and/or other countries." & vbNewLine & "Heroes of the Storm ©2014 Blizzard Entertainment, Inc. All rights reserved. Heroes of the Storm is a trademark of Blizzard Entertainment, Inc." & vbNewLine & "Lite Launcher developed by Jake Jensen ©2017", "Battle.net Launcher About",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles KillSC2.Click 'Button for killing SC2's main process via shell. 
        Shell("taskkill /F /IM SC2_x64.exe /T", 0)
        Call CheckIfRunning1()

    End Sub

    Dim SC2() As Process
    Dim HoTS() As Process
    Dim WoW() As Process
    Dim BW() As Process
    Private Sub CheckIfRunning1() 'Checks if SC2 is running or not, then changes the text on the status button to reflect if it is or not. 
        SC2 = Process.GetProcessesByName("SC2_x64")
        If SC2.Count > 0 Then
            SCStatus.Text = "SC2 is running" ' Process is running
            HoTS_Status.Text = "HoTS is running"
        Else
            SCStatus.Text = "SC2 is not running" ' Process is not running
            HoTS_Status.Text = "HoTS is not running"
        End If

        HoTS = Process.GetProcessesByName("HeroesOfTheStorm_x64")
        If HoTS.Count > 0 Then
            HoTS_Status.Text = "HoTS is running"
        Else
            HoTS_Status.Text = "HoTS is not running"
        End If

        WoW = Process.GetProcessesByName("WoW-64")
        If WoW.Count > 0 Then
            WoWStatus.Text = "WoW is running"
        Else
            WoWStatus.Text = "WoW is not running"
        End If

        BW = Process.GetProcessesByName("WoW-64")
        If BW.Count > 0 Then
            BWStatus.Text = "BW is running"
        Else
            BWStatus.Text = "BW is not running"
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, 'Launches the application using HoTS's switcher.
        ByVal e As System.EventArgs) Handles HeroesButton.Click
        Me.BackgroundImage = My.Resources.background_wow_mop
        StarCraftLaunchButton.Visible = False
        HeroesLaunchButton.Visible = True
        WoWLaunchButton.Visible = False
        BroodLauncher.Visible = False
        BroodNotice.Visible = False

    End Sub

    Private Sub BroodButton_Click(sender As Object, e As EventArgs) Handles BroodButton.Click
        Me.BackgroundImage = My.Resources.background_sc2_wol
        StarCraftLaunchButton.Visible = False
        HeroesLaunchButton.Visible = False
        WoWLaunchButton.Visible = False
        BroodLauncher.Visible = True
        BroodNotice.Visible = True

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles WowButton.Click
        Me.BackgroundImage = My.Resources.background_wow_bc
        StarCraftLaunchButton.Visible = False
        HeroesLaunchButton.Visible = False
        WoWLaunchButton.Visible = True
        BroodLauncher.Visible = False
        BroodNotice.Visible = False

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StarCraftButton.Click
        Me.BackgroundImage = My.Resources.background_sc2_hots
        StarCraftLaunchButton.Visible = True
        HeroesLaunchButton.Visible = False
        WoWLaunchButton.Visible = False
        BroodLauncher.Visible = False
        BroodNotice.Visible = False

    End Sub

    Private Sub BroodLauncher_Click(sender As Object, e As EventArgs) Handles BroodLauncher.Click
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\Starcraft\StarCraft Launcher.exe") Then
            System.Diagnostics.Process.Start("C:\Program Files (x86)\StarCraft\StarCraft Launcher.exe")
        Else
            MsgBox("Brood War not found!")
        End If
    End Sub

    Private Sub BroodNotice_Click(sender As Object, e As EventArgs) Handles BroodNotice.Click
        MessageBox.Show("StarCraft Remastered is hard coded to use the official launcher. Until I figure out how to bypass that, this will launch the official app, then start StarCraft Remastered.", "Brood War Notice",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub WoWLaunchButton_Click(sender As Object, e As EventArgs) Handles WoWLaunchButton.Click
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\World of Warcraft\WoW-64.exe") Then
            System.Diagnostics.Process.Start("C:\Program Files (x86)\World of Warcraft\WoW-64.exe")
        Else
            MsgBox("Wow not found!")
        End If
    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, 'Launches the application using HoTS's switcher.
    ByVal e As System.EventArgs) Handles HeroesLaunchButton.Click
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\Heroes of the Storm\Support64\HeroesSwitcher_x64.exe") Then
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Heroes of the Storm\Support64\HeroesSwitcher_x64.exe")
        Else
            MsgBox("HoTS not found!")
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, 'Launches the application using SC2's switcher.
    ByVal e As System.EventArgs) Handles StarCraftLaunchButton.Click
        If My.Computer.FileSystem.FileExists("C:\Program Files (x86)\StarCraft II\Support64\SC2Switcher_x64.exe") Then
            System.Diagnostics.Process.Start("C:\Program Files (x86)\StarCraft II\Support64\SC2Switcher_x64.exe")
        Else
            MsgBox("SC2 not found!")
        End If
    End Sub

    Private Sub KillWoW_Click(sender As Object, e As EventArgs) Handles KillWoW.Click
        Shell("taskkill /F /IM Wow-64.exe /T", 0)
        Call CheckIfRunning1()
    End Sub

    Private Sub KillBW_Click(sender As Object, e As EventArgs) Handles KillBW.Click
        Shell("taskkill /F /IM Starcraft.exe /T", 0)
        Call CheckIfRunning1()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles KillHots.Click
        Shell("taskkill /F /IM HeroesOfTheStorm_x64.exe /T", 0)
        Call CheckIfRunning1()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        MessageBox.Show("The wikia is still in early development; Some graphics may be generic, and some data may not be available.", "Wikia Notice",
MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub Changelog_Click(sender As Object, e As EventArgs) Handles Changelog.Click
        Form3.Show()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        MessageBox.Show("The updater has been overhauled. Now requires manual interaction via the git page", "Update Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
        Process.Start("https://github.com/SapphireExile/Battle-Net-Launcher-Lite/blob/master/SapphiresLauncher.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Developer version 0.1 of release candidate 1.10" & vbNewLine & "This version is hardcoded to use C:\Program Files(X86)\ for game paths. If your games aren't installed here, this version will not launch them, while the killswitches will still work.", "Dev Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
    End Sub
End Class