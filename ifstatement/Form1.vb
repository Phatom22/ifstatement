Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click
        Dim country As String

        country = txtCountry.Text.ToUpper
        If country = "SOUTH AFRICA" Then
            MsgBox("molo")

        ElseIf country = "SPAIN" Then
            MsgBox("ola")
        ElseIf country = "ZIMBABWE" Then
            MsgBox("ZWIRIBO")
        Else
            MsgBox("hi")
        End If
    End Sub
End Class
