Public Class dtw
    Public Shared Function DateToText(ByVal D As DateTime) As String

        Dim MonthName = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(D.Month)
        Dim dayNum As String = ""

        Select Case DateTime.Now.Day
            Case 1
                dayNum = "st"
                Exit Select
            Case 2
                dayNum = "nd"
                Exit Select
            Case 3
                dayNum = "rd"
                Exit Select
            Case 21
                dayNum = "st"
                Exit Select
            Case 22
                dayNum = "nd"
                Exit Select
            Case 23
                dayNum = "rd"
                Exit Select
            Case 31
                dayNum = "st"
                Exit Select
            Case Else
                dayNum = "th"
                Exit Select
        End Select

        Dim result = D.Day & dayNum & " of " & MonthName & " " & Date.Today.Year
        Return result

    End Function
End Class