'***************************************************
'Author: Yaser Ahmed
'Date created:27/08/1444
'Last updated:19/03/23 pm
'Purpose: This program is intended to allow the user to set the exchange rate for both euro and sterling.
'When the rate Is set it will display the updated rate to screen.
'It will also use the rate in the buy currency box to take the amount needed and times it by the exchange rate.
'This overall total will display at the bottom of the screen and then all information can be cleeared by clicking the clear button.
'
'
'
'language: Visual Basic
'
'**********************
Public Class CurrencyConverter
    Dim dblSterling As Double 'stores the sterling exchange rate'
    Dim dblEuro As Double 'stores the euro exchange rate'
    Dim dblTotal As Double 'stores the total amount
    Dim intQuantity As Integer 'Stores the amount of currency to be converted' 
    Dim StrEuroorSterling As String 'stores information on whether euro or sterling'
    Dim thisdate As Date = Today 'variable to store and display today's date'

    Private Sub CurrencyConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = thisdate
    End Sub

    Private Sub UpdateSterlingBtn_Click(sender As Object, e As EventArgs) Handles UpdateSterlingBtn.Click
        dblSterling = Val(SterlingTextBox.Text)
        If dblSterling > 0 And dblSterling <= 10 Then
            lblUpdatedSterling.Text = "New rate for sterling is: " & "" & dblSterling
        Else
            MessageBox.Show("Sterling Amount entered must be between 1 and 10")
        End If
    End Sub

    'Method to allow user entered sterling rate to be stored and then displayed
    'to screen on a label
    Private Sub UpdateEuroRate_Click(sender As Object, e As EventArgs) Handles UpdateEuroRate.Click
        dblEuro = Val(EuroTextBox.Text)
        If dblEuro > 0 And dblEuro <= 10 Then
            lblEuroRateUpdate.Text = "Euro rate is: " & dblEuro
        Else
            MessageBox.Show("Euro Amount entered must be between 1 and 10")
        End If
    End Sub

    ' calculate the needed amount in sterling and euro
    Private Sub CalculateBtn_Click(sender As Object, e As EventArgs) Handles CalculateBtn.Click
        intQuantity = Val(dblAmountBox.Text)
        If SterlingRadioBtn.Checked = True Then
            dblTotal = intQuantity * dblEuro
            lblCalucaltedAmount.Text = "The cost for  " & intQuantity & "Sterling is Euro € " & dblTotal
        ElseIf EuroRadioBtn.Checked = True Then
            dblTotal = intQuantity * dblSterling
            lblCalucaltedAmount.Text = "The cost for  " & intQuantity & "Euro is £ " & dblTotal
        Else
            MessageBox.Show("You need to select a currency")
        End If
    End Sub

    ' clearn function that set all valiable and textBoxes
    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        ' clear all variable
        dblEuro = 0
        dblSterling = 0
        dblTotal = 0

        ' clear all input field
        dblAmountBox.Text = ""
        SterlingTextBox.Text = ""
        EuroTextBox.Text = ""

        ' clearn all label
        lblCalucaltedAmount.Text = "Calculated Amount"
        lblUpdatedSterling.Text = ""
        lblEuroRateUpdate.Text = ""
    End Sub

End Class
