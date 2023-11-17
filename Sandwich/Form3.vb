Public Class Form3
    Dim Sandwich As String
    Dim Drinks As String
    Dim cTotal As String
    Dim Firstnum As Double
    Dim secondnum As Double
    Dim answer As Double
    Dim operators As String

    Declare Function Wow64disableWow64FsRedirection Lib "Kerne132" (ByRef oldvalue As Long) As Boolean
    Private osk As String = "c:/windows/system32/osk.exe"
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim Name As String = txtName.Text
        Dim SRequests As String = txtRequests.Text

        rtReceipt.AppendText(vbNewLine + "Hello " + Name + "!" + vbNewLine)
        rtReceipt.AppendText(vbNewLine + "***************************************************************" + vbNewLine)
        rtReceipt.AppendText(vbNewLine + " Your order: " + vbNewLine)
        rtReceipt.AppendText(vbNewLine + "***************************************************************" + vbNewLine)
        rtReceipt.AppendText(vbNewLine + "A " + Sandwich + " with a " + Drinks + ".")
        rtReceipt.AppendText(vbNewLine + "Special Requests: " + SRequests + vbNewLine)
        rtReceipt.AppendText(vbNewLine + "This order will cost a total of: " + vbNewLine + cTotal + "." + vbNewLine)
        rtReceipt.AppendText(vbNewLine + "***************************************************************" + vbNewLine)
        rtReceipt.AppendText(vbNewLine + "********************* Thank You For your Purchase **************************" + vbNewLine)
    End Sub

    Private Sub btnHam_Click(sender As Object, e As EventArgs) Handles btnHam.Click
        Sandwich = "Ham Sandwich"
        cTotal = FormatCurrency(cTotal + 1.0)

    End Sub

    Private Sub btnVeg_Click(sender As Object, e As EventArgs) Handles btnVeg.Click
        Sandwich = "Vegetable Sandwich"
        cTotal = FormatCurrency(cTotal + 0.5)
    End Sub

    Private Sub btnChick_Click(sender As Object, e As EventArgs) Handles btnChick.Click
        Sandwich = "Chicken Sandwich"
        cTotal = FormatCurrency(cTotal + 1.5)
    End Sub

    Private Sub btnSpecial_Click(sender As Object, e As EventArgs) Handles btnSpecial.Click
        Sandwich = "Special Sandwich"
        cTotal = FormatCurrency(cTotal + 2.0)
    End Sub

    Private Sub btnTea_Click(sender As Object, e As EventArgs) Handles btnTea.Click
        Drinks = "Tea"
        cTotal = FormatCurrency(cTotal + 1.0)
    End Sub

    Private Sub btnChoc_Click(sender As Object, e As EventArgs) Handles btnChoc.Click
        Drinks = "Hot Chocolate"
        cTotal = FormatCurrency(cTotal + 2.0)
    End Sub

    Private Sub btnCold_Click(sender As Object, e As EventArgs) Handles btnCold.Click
        Drinks = "Cold Drink"
        cTotal = FormatCurrency(cTotal + 1.5)
    End Sub

    Private Sub btnWater_Click(sender As Object, e As EventArgs) Handles btnWater.Click
        Drinks = "Water"
        cTotal = FormatCurrency(cTotal + 0.5)
    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim i As DialogResult

        i = MessageBox.Show("Confirm your order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If i = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Label1.Font = FontDialog1.Font

            Label2.Font = FontDialog1.Font

            Label3.Font = FontDialog1.Font

            Label4.Font = FontDialog1.Font

            Label5.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then


            Panel1.BackColor = ColorDialog1.Color


        End If
    End Sub
End Class