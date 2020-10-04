' Program Name: Chapter 5 Patients weight
' Author:       Nathan Douangkesone
' Date:         January 4, 2020
' Purpose:      This Windows application computes the result
'               of weight based on the conversion rate of 2.2046
'               between pounds and kilograms.

Public Class frmPratientsWeight

    Const decConversion As Decimal = 2.2046D

    Private Sub frmPratientsWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmPratientsWeight_Load event handler makes lblConversion invisible 

        lblConversion.Visible = False
    End Sub

    Private Sub btnDisplayWeight_Click(sender As Object, e As EventArgs) Handles btnDisplayWeight.Click
        ' The btnDisplayWeight event handler calculates the conversion rate 
        ' between pounds and kilograms and if the user inputs a non numeric or 
        ' a number less than zero it returns a error.

        ' Declaration Section
        Dim decResults As Decimal

        If IsNumeric(txtUserInput.Text) Then
            decResults = Decimal.Parse(txtUserInput.Text)

            If decResults > 0 Then

                If radKilograms.Checked = True Then
                    decResults = txtUserInput.Text * decConversion
                    lblConversion.Text = Math.Round(decResults, 3)
                    lblConversion.Visible = True
                Else
                    If radPounds.CheckAlign = True Then
                        decResults = txtUserInput.Text / decConversion
                        lblConversion.Text = Math.Round(decResults, 3)
                        lblConversion.Visible = True
                    End If
                    Select Case True
                        Case radKilograms.Checked
                            decResults = txtUserInput.Text * decConversion
                            lblConversion.Text = Math.Round(decResults, 3)
                            lblConversion.Visible = True
                        Case radPounds.Checked
                            decResults = txtUserInput.Text / decConversion
                            lblConversion.Text = Math.Round(decResults, 3)
                            lblConversion.Visible = True
                    End Select
                End If
            Else
                'Display Message to user and selects user input

                MessageBox.Show("Please Enter a non-numeric value greater than zero", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                txtUserInput.SelectAll()
                txtUserInput.Focus()
                lblConversion.Text = ""
            End If
        Else
            ' Display Message to user and selects user input

            MessageBox.Show("Data Entry Error, Please Enter a non-numeric value for the weight value", "Data Entry Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtUserInput.SelectAll()
            txtUserInput.Focus()
            lblConversion.Text = ""
        End If

    End Sub

    Private Sub btnClearButton_Click(sender As Object, e As EventArgs) Handles btnClearButton.Click
        ' The  btnClearButton_Click event handler makes txtUserInput and lblConversion empty

        txtUserInput.Clear()
        lblConversion.Text = ""
    End Sub
End Class
