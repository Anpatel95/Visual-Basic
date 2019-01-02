'An Patel
'Chapter 5 Project 3 page 219 
'This program design by An PAtel will show total cost of furniture with users order summary.

Option Explicit On

Public Class frmFurniture

    Const Sofa As Double = 925
    Const Chair As Double = 350
    Const Saletax As Double = 0.05


    'List box items
    Public Sub DisplayInvoice(invoicenumber As String, customerName As String, total As Double)
        lstDisplay.Items.Add("Invoice Number: " & invoicenumber)
        lstDisplay.Items.Add(" ")
        lstDisplay.Items.Add("Customer Name: " & customerName)
        lstDisplay.Items.Add("Address: " & txtAddress.Text)
        lstDisplay.Items.Add("City, State, Zip: " & txtCity.Text)
        lstDisplay.Items.Add(" ")
        lstDisplay.Items.Add("Number of chairs ordered: " & txtChairs.Text)
        lstDisplay.Items.Add("Number of sofas ordered: " & txtSofas.Text)
        lstDisplay.Items.Add("Total due (including tax): " & FormatCurrency(total, 2))
    End Sub
    'Functions created
    Public Function SwappedNames(name As String) As String

        Dim firstname As String
        Dim lastname As String

        firstname = name.Split(",")(1).Trim
        lastname = name.Split(",")(0).Trim

        Return firstname & " " & lastname

    End Function

    Public Function InvoiceNum(name As String, city As String) As String
        Dim invoiceNumber As String

        invoiceNumber = name.Substring(0, 2).ToUpper
        invoiceNumber += city.Substring(city.Length - 4)

        Return invoiceNumber

    End Function

    Public Function InputValidation() As Boolean

        If Not txtCustomer.Text.Contains(",") Then
            MsgBox("Please seperate the name by a comma")
            txtCustomer.Focus()
            Return False
        End If

        If txtAddress.Text = "" Or txtCity.Text = "" Then
            MsgBox("Please enter address and city")
            Return False
        End If

        If Not IsNumeric(txtChairs.Text) Or Not IsNumeric(txtSofas.Text) Then
            MsgBox("Please enter valid quantities")
            txtChairs.Focus()
            Return False
        End If

        Return True

    End Function

    Public Function CalcTotal(chairQuan As Integer, sofaQuan As Integer) As Double
        Dim total As Double
        Dim tax As Double

        total = (chairQuan * Chair) + (sofaQuan * Sofa)
        tax = total * Saletax

        Return total + tax

    End Function

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCustomer.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        txtSofas.Text = ""
        txtChairs.Text = ""
        lstDisplay.Items.Clear()

    End Sub
    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim valid As Boolean
        Dim Total As Double
        Dim Name As String
        Dim City As String
        Dim Address As String
        Dim ChairQuan As Integer, sofaQuan As Integer
        Dim Invoicenum As String
        Dim Swappnames As String
        valid = InputValidation()

        If valid Then
            Name = txtCustomer.Text
            Address = txtAddress.Text
            City = txtCity.Text
            ChairQuan = CInt(txtChairs.Text)
            sofaQuan = CInt(txtSofas.Text)



            Total = CalcTotal(ChairQuan, sofaQuan)
            Invoicenum = Me.InvoiceNum(Name, City)
            Swappnames = SwappedNames(Name)
            DisplayInvoice(Invoicenum, Swappnames, Total)

        End If
    End Sub

    Private Sub frmFurniture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
