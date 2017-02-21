'Author: Berkay KÖKSAL

Imports System.Text.RegularExpressions

Public Class MainForm
    Private Const m_numOfSeats As Integer = 60
    Private m_seatMngr As SeatManager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        m_seatMngr = New SeatManager(m_numOfSeats)
        InitializeGUI()
    End Sub



    ''' <summary>
    ''' Bring everything at the default position.
    ''' </summary>
    Private Sub InitializeGUI()
        txtName.Text = String.Empty
        txtPrice.Text = String.Empty
        cmbDisplayOptions.Items.AddRange([Enum].GetNames(GetType(DisplayOptions)))
        cmbDisplayOptions.SelectedIndex = DirectCast(DisplayOptions.All_Seats, Integer)
        UpdateGUI()
    End Sub

    ''' <summary>
    ''' Checks if any item is checked from the listbox or not.
    ''' </summary>
    Private Function CheckSelectedIndex() As Boolean
        If (lstReservation.SelectedIndex < 0) Then
            MessageBox.Show("Select an item in the listbox first", "Error!", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return False
        End If
        Return True
    End Function


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If rbtnReserved.Checked Then
            ReserveSeat()
        Else
            CalcelSeat()
        End If
    End Sub
    ''' <summary>
    ''' reserve seat function
    ''' </summary>
    Private Sub ReserveSeat()
        Dim proceed As Boolean = CheckIfSeatAlreadyReserved()
        If (Not proceed) Then Return

        Dim customerName As String = String.Empty
        Dim seatPrice As Double = 0.0

        If ReadAndValidateInput(customerName, seatPrice) Then
            m_seatMngr.ReserveSeat(customerName, seatPrice, lstReservation.SelectedIndex)
            UpdateGUI()
        End If
    End Sub

    ''' <summary>
    ''' cancel seat function
    ''' </summary>
    Private Sub CalcelSeat()
        If (Not CheckSelectedIndex()) Then Return
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel this seat?", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.[Error])
        If (result = DialogResult.Cancel) Then
            Return

        else

        m_seatMngr.CancelSeat(lstReservation.SelectedIndex)
            UpdateGUI()
        End If
    End Sub

    ''' <summary>
    ''' reads input information both if valid or not
    ''' </summary>
    Private Function ReadAndValidateInput(ByRef name As String, ByRef price As Double) As Boolean
        name = String.Empty
        price = 0.0
        Return ReadAndValidateName(name) AndAlso ReadAndValidatePrice(price)
    End Function

    ''' <summary>
    ''' validates name is it is numeric or not or empty string or not. this part works perfectly. Berkay6 is okay 6Berkay is okay but 666 is not okay. the name cannot be numeric only!
    ''' </summary>
    Private Function ReadAndValidateName(ByRef name As String) As Boolean
        name = txtName.Text
        Dim x As Boolean = IsNumeric(name)
        If x = False Then

            If Not name = String.Empty Then
                Return True
            End If

        Else
            MessageBox.Show("Name must contain at least a letter", "Input error")
            Return False

        End If

        Return False

    End Function


    ''' <summary>
    ''' checks if the price can be parsed into double. if yes is it greater than zero. if not that is a problem
    ''' </summary>
    Private Function ReadAndValidatePrice(ByRef price As Double) As Boolean
        Dim check As Boolean = Double.TryParse(txtPrice.Text, price)
        If (price > 0) Then
            Return True
        Else
            MessageBox.Show("price must be a positive number!", "Input error")
            Return False
        End If
        Return check
    End Function

    ''' <summary>
    ''' Updates the user interface forum with everything.
    ''' </summary>
    Private Sub UpdateGUI()
        seatnumberlabel.Text = lstReservation.SelectedIndex + 1
        lstReservation.Items.Clear()

        Dim seatInfoStrings As String() = Nothing
        Dim calcOption As DisplayOptions = DirectCast(cmbDisplayOptions.SelectedIndex, DisplayOptions)
        Dim count As Integer = m_seatMngr.GetSeatInfoStrings(calcOption, seatInfoStrings)

        If count > 0 Then
            lstReservation.Items.AddRange(seatInfoStrings)
        Else
            lstReservation.Items.Add("Nothing to display!")
        End If

        totalseatslabel.Text = m_seatMngr.GetNumOfSeats(DisplayOptions.All_Seats).ToString
        reservedseatslabel.Text = m_seatMngr.GetNumReserved
        availableseatslabel.Text = m_seatMngr.GetNumVacant


        If (cmbDisplayOptions.Text = "All_Seats") Then
            btnOK.Enabled = True
        Else
            btnOK.Enabled = False
        End If





    End Sub

    ''' <summary>
    ''' when radiobutton reserve is checked the button will say Reserve
    ''' </summary>
    Private Sub rbtnReserved_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnReserved.CheckedChanged
        btnOK.Text = "Reserve"
        'grpReserve.Enabled = True
    End Sub

    ''' <summary>
    ''' when cancel is selected the button will say Cancel
    ''' </summary>
    Private Sub rbtnCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnCancel.CheckedChanged
        btnOK.Text = "Cancel"
        'grpReserve.Enabled = True
    End Sub

    ''' <summary>
    ''' When user chooses any item from the listbox. this function will seperate the whole item into strings and put them inside operands(). operands(1) keeps the seat number of each columb element
    ''' </summary>
    Private Sub lstReservation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstReservation.SelectedIndexChanged
        Dim operands() As String = Regex.Split(lstReservation.SelectedItem.ToString(), "\s+")
        seatnumberlabel.Text = operands(1).ToString

    End Sub


    ''' <summary>
    ''' when you change the item it will automaticly update the form
    ''' </summary>
    Private Sub cmbDisplayOptions_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDisplayOptions.SelectedIndexChanged
        UpdateGUI()
    End Sub

    ''' <summary>
    ''' operands is the strings of elements from the listbox. operands(2) keeps the reservation status. it can be Reserved or Vacant. if it is vacant this function will give you the error.
    ''' </summary>
    Private Function CheckIfSeatAlreadyReserved() As Boolean
        Dim operands() As String = Regex.Split(lstReservation.SelectedItem.ToString(), "\s+")
        If Not (operands(2) = "Vacant") Then
            Dim result As DialogResult = MessageBox.Show("Seat is already taken. Click ok to procede or cancel to don't", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.[Warning])
            If (result = DialogResult.Cancel) Then
                Return False
            End If
        End If
        Return True
    End Function

End Class
