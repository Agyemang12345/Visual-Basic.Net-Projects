Public Class Form5
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtnumberofMonths.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDownPayment.Text = String.Empty
        txtnumberofMonths.Text = String.Empty
        txtVehicleCost.Text = String.Empty
        radNew.Checked = False
        radUsed.Checked = False
        lblInterestRate.Text = String.Empty
        lstPrincipalPayment.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult =
            MessageBox.Show("Do you wish to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Retrieves input values from textboxes
        Dim costOfVehicle As Double = Double.Parse(txtVehicleCost.Text)
        Dim amountofdownPayment As Double = Double.Parse(txtDownPayment.Text)
        Dim numberofMonths As Integer = Integer.Parse(txtnumberofMonths.Text)
        Dim interestRate As Decimal
        Dim Loan As Double = costOfVehicle - amountofdownPayment
        Dim monthlyPayment As Decimal
        Dim interest As Decimal
        Dim payment As Decimal

        If radNew.Checked Then
            ' For new vehicles: calculates the monthly payment, interest, and principal for each month
            interestRate = 0.05
            lblInterestRate.Text = 5.0 & "%"
            monthlyPayment = Pmt(interestRate / 12, numberofMonths, -Loan)

            For count = 0 To numberofMonths Step 1
                interest = Pmt(interestRate / 12, 6, numberofMonths, -Loan)
                payment = Pmt(interest / 12, 6, numberofMonths, -Loan)
                lstPrincipalPayment.Items.Add("Month" & count.ToString("00") & ": payment = " & monthlyPayment.ToString("0.00") & ", interest = " & interest.ToString("0.00") & ", Principal = " & payment.ToString("0.00"))
            Next
        ElseIf radUsed.Checked Then
            ' For used vehicles: calculates the monthly payment, interest, and principal for each month
            interestRate = 0.08
            lblInterestRate.Text = 8.0 & "%"
            monthlyPayment = Pmt(interestRate / 12, numberofMonths, -Loan)

            For count = 0 To numberofMonths Step 1
                interest = Pmt(interestRate / 12, 6, numberofMonths, -Loan)
                payment = Pmt(interest / 12, 6, numberofMonths, -Loan)
                lstPrincipalPayment.Items.Add("Month" & count.ToString("00") & ": payment = " & monthlyPayment.ToString("0.00") & ", interest = " & interest.ToString("0.00") & ", Principal = " & payment.ToString("0.00"))
            Next
        End If
    End Sub
End Class