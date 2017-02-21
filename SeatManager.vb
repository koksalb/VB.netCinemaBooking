'Author: Berkay KÖKSAL

Public Class SeatManager
    Private ReadOnly m_totNumOfSeats As Integer
    Private m_namelist As String() = Nothing
    Private m_priceList As Double() = Nothing

    Public Sub New(ByVal maxNumberOfSeats As Integer)
        m_totNumOfSeats = maxNumberOfSeats
        m_namelist = New String(m_totNumOfSeats - 1) {}
        m_priceList = New Double(m_totNumOfSeats - 1) {}
    End Sub
    ''' <summary>
    ''' check input if it is inside the array size or not
    ''' </summary>
    Private Function CheckIndex(ByVal index As Integer) As Boolean
        Return (index >= 0) And (index < m_totNumOfSeats)
    End Function

    ''' <summary>
    ''' reserve seat function with incoming informations as byval
    ''' </summary>
    Public Function ReserveSeat(ByVal name As String, ByVal price As Double, ByVal index As Integer) As Boolean
        Dim success As Boolean = False
        If CheckIndex(index) Then
            m_namelist(index) = name
            m_priceList(index) = price
            success = True
        End If
        Return success
    End Function

    ''' <summary>
    ''' cancel seat will change the name to empty string and price to 0.0 just like the default values
    ''' </summary>
    Public Function CancelSeat(ByVal index As Integer) As Boolean
        Dim success As Boolean = False
        If CheckIndex(index) Then
            m_namelist(index) = Nothing
            m_priceList(index) = 0.0
            success = True
        End If
        Return success
    End Function

    ''' <summary>
    ''' gets the number of reserved seats and puts it into an integer called "sum"
    ''' </summary>
    Public Function GetNumReserved() As Integer
        Dim sum As Integer = 0
        For i As Integer = 0 To m_totNumOfSeats - 1
            If (Not String.IsNullOrEmpty(m_namelist(i))) Then
                sum += 1
            End If
        Next
        Return sum
    End Function

    ''' <summary>
    ''' by substracting reserved seats from the total seat number we have this. so no need to put loops inside this one like previous one
    ''' </summary>
    Public Function GetNumVacant() As Integer
        Return (m_totNumOfSeats - GetNumReserved())
    End Function

    ''' <summary>
    ''' takes number of seats according to your option. if it is all seats then it will take them all if not it will act like that
    ''' </summary>
    Public Function GetNumOfSeats(ByVal choice As DisplayOptions) As Integer
        Dim count As Integer = 0
        Select Case choice
            Case DisplayOptions.All_Seats
                count = m_totNumOfSeats
                Exit Select
            Case DisplayOptions.Vacant_Seats
                count = GetNumVacant()
                Exit Select
            Case DisplayOptions.Reserved_Seats
                count = GetNumReserved()
                Exit Select
        End Select
        Return count
    End Function


    ''' <summary>
    ''' returns to nuumber of seats in the end. but this function generates the string array which we will add into the listbox. with the string format and everything
    ''' </summary>
    Public Function GetSeatInfoStrings(ByVal choice As DisplayOptions, ByRef strSeatInfoStrings As String()) As Integer
        Dim count As Integer = GetNumOfSeats(choice)
        If (count <= 0) Then
            Return 0
        End If
        strSeatInfoStrings = New String(count - 1) {}
        Dim strReservation As String = ""
        strSeatInfoStrings = New String(count - 1) {}
        Dim i As Integer = 0


        For index As Integer = 0 To m_totNumOfSeats - 1
            Dim strName As String = ""
            Dim reserved As Boolean = Not String.IsNullOrEmpty(m_namelist(index))
            If (choice = DisplayOptions.All_Seats) Or (reserved And choice = DisplayOptions.Reserved_Seats) Or ((Not reserved) And (choice = DisplayOptions.Vacant_Seats)) Then
                If (reserved) Then
                    strReservation = "Reserved"
                    strName = m_namelist(index)
                Else
                    strReservation = "Vacant"
                    strName = " .......... "
                End If
                strSeatInfoStrings(i) = String.Format("{0,4}   {1,-8} {2, -20} {3,10:f2}", index + 1, strReservation, strName, m_priceList(index))
                i += 1
            End If
        Next
        Return count
    End Function




End Class
