Public Class frmEcuacionCuadratica

    Dim A, B, C As Double
    Dim x1, x2 As Double

    Private Sub txtB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtB.KeyPress
        If txtB.Text = String.Empty Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-"

        ElseIf Not txtB.Text.Contains(".") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
        ElseIf Not txtB.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-"
        ElseIf txtB.Text.Contains(".") And txtB.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txtC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtC.KeyPress
        If txtC.Text = String.Empty Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-"

        ElseIf Not txtC.Text.Contains(".") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
        ElseIf Not txtC.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-"
        ElseIf txtC.Text.Contains(".") And txtC.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Private Sub txtA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtA.KeyPress
        If txtA.Text = String.Empty Then

            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." And Not e.KeyChar = "-"

        ElseIf Not txtA.Text.Contains(".") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "."
        ElseIf Not txtA.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "-"
        ElseIf txtA.Text.Contains(".") And txtA.Text.Contains("-") Then
            e.Handled = Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        End If
    End Sub

    Dim dis As Double

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click

        If txtA.Text = String.Empty Or txtB.Text = String.Empty Or txtA.Text = String.Empty Then


        Else

            A = txtA.Text
            B = txtB.Text
            C = txtC.Text

        End If


        dis = (B * B) - (4 * A * C)

        If dis < 0 Then

            dis = dis * -1
            dis = Math.Sqrt(dis)
            dis = dis / (2 * A)

            x1 = -B / (2 * A)

            MsgBox("X1 = " & x1.ToString & " + " & dis.ToString & "i" & vbCrLf & "X2 = " & x1.ToString & " - " & dis.ToString & "i")


        ElseIf dis = 0 Then
            x1 = -B / (2 * A)
            x2 = -B / (2 * A)

            MsgBox("X1 = " & x1.ToString & vbCrLf & "X2 = " & x2.ToString)

        Else

            x1 = -B / (2 * A) + Math.Sqrt(dis) / (2 * A)
            x2 = -B / (2 * A) - Math.Sqrt(dis) / (2 * A)

            MsgBox("X1 = " & x1.ToString & vbCrLf & "X2 = " & x2.ToString)

        End If

    End Sub







End Class
