Public Class Form1

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim intA, intB As Integer

        ' Declare variables from input
        intA = CInt(txtIntA.Text)
        intB = CInt(txtIntB.Text)

        ' The brain of the program
        If (intA) < (intB) Then
            lblResult.Text = "Value B is greatest"

        ElseIf intA > intB Then
            lblResult.Text = "Value A is greatest"

        ElseIf intA = intB Then
            lblResult.Text = "Values are the same"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
