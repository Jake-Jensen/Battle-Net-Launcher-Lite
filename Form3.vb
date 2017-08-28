Public Class Form3
    Private Sub OneZeroZero_Click(sender As Object, e As EventArgs) Handles OneZeroZero.Click
        TextBoxChangelog.Text = "Initial release" & vbNewLine &
            "Basic user interface with 4 control buttons, 4 status buttons, 4 killswitches, 4 play buttons (Chose that over flags) and the 'about' button"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles OneZeroOne.Click
        TextBoxChangelog.Text = "The rise of the wikia!" & vbNewLine &
            "Added 'Zergling' image, and fleshed out the stats/ lore of it" & vbNewLine &
            "Added 'Baneling' image, and fleshed out the stats/ lore of it" & vbNewLine &
            "Added changelog button" & vbNewLine &
            "Changed 'About' to 'legal'" & vbNewLine &
            "Added the actual changelog window" & vbNewLine &
            "Added the wikia window"
    End Sub
End Class