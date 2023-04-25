' Program Name: Smart home savings
' Name: Zachary Conley\
' Date: April 25,2023
' Description: This app shows savings from a 12 monmth period of time for a smart home

Option Strict On

Public Class FrmSmarthome

    Private _intsizearray As Integer = 11
    Private _strSavingshome(_intsizearray) As String
    Private _decBilling(_intsizearray) As Decimal

    Private Sub FrmSmarthome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The form load event reads the text file and then puts the months inside the combo box.
        ' Once that happens, the streamreader objext starts to work


        Dim objread As IO.StreamReader
        Dim strSavings As String
        Dim intcount As Integer = 0
        Dim intfill As Integer

        Lbltotsavings.Text = ""
        Lblavsavings.Text = ""
        Lblbestsavings.Text = ""

        ' This statement verifies that the file is in existence
        If IO.File.Exists("C:\Users\zco20\savings.txt.txt") = True Then
            objread = IO.File.OpenText("C:\Users\zco20\savings.txt.txt")
            ' The path for my file is under my user profile
            ' The file is then read until completion
            Do While objread.Peek <> -1
                _strSavingshome(intcount) = objread.ReadLine()
                strSavings = objread.ReadLine()
                _decBilling(intcount) = Convert.ToDecimal(strSavings)
                intcount += 1
            Loop
            objread.Close()

            For intfill = 0 To (_strSavingshome.Length - 1)
                Cbomonthsavings.Items.Add(_strSavingshome(intfill))
            Next
        Else
            MsgBox("The file is not available, Please restart the program when the file is available", , "Error")
            Close()
        End If
    End Sub


    Private Sub computemax()
        ' This is used to compute whichever month has the best savings out of all the months
        Dim intmonths As Integer
        Dim intLargestsavings As Integer = 0
        Dim intindex As Integer = 0
        Dim stryearval As String = ""

        For Each intmonths In _decBilling
            intLargestsavings = Math.Max(intLargestsavings, intmonths)
            If (intmonths >= intLargestsavings) Then
                stryearval = _strSavingshome(intindex)
            End If
            intindex += 1
        Next
        Lblbestsavings.Text = stryearval & " had the most significant monthly savings"
    End Sub


    Private Sub computeavg()
        ' This is used to compute the average monthly savings amongst all the months
        Dim intyearcount As Integer
        Dim intyears As Integer = 0
        Dim decBilltotal As Decimal = 0
        Dim decavgnumbill As Decimal = 0D

        For Each intyearcount In _decBilling
            decBilltotal += _decBilling(intyears)
            intyears += 1
        Next
        decavgnumbill = decBilltotal / Convert.ToDecimal(_decBilling.Length())
        Lblavsavings.Text = "The average monthly savings: " & decavgnumbill.ToString("C2")

    End Sub

    Private Sub Btndisplay_Click(sender As Object, e As EventArgs) Handles Btndisplay.Click
        ' This calls the avg and max subs above
        computeavg()
        computemax()

    End Sub


    Private Sub cbomonthsavings_Selectedindexchanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbomonthsavings.SelectedIndexChanged
        Dim intselectedcity As Integer
        ' This part of the app displays the savings for whichever month is picked

        intselectedcity = Cbomonthsavings.SelectedIndex
        Lbltotsavings.Text = "The electric savings for " & _strSavingshome(intselectedcity) & " is $" & _decBilling(intselectedcity).ToString()
        Btndisplay.Visible = True

    End Sub
End Class
