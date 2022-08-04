Module Validation
    Public IsNameInvalid = False
    Public IsPhoneNumberInvalid = False
    Public IsPinNumberInvalid = False
    Public ErrMessage As String

    Public Sub IsValidName(Name As String)
        IsNameInvalid = False
        If Len(Name) = 0 Then
            IsNameInvalid = True
            ErrMessage = "Please enter a name"

            Exit Sub
        End If

        If Text.RegularExpressions.Regex.Match(Name, "\d").Success Then
            IsNameInvalid = True
            ErrMessage = "Name can only contain alpahabets"

            Exit Sub
        End If
    End Sub

    Public Sub IsValidPhoneNumber(Phone As String)
        IsPhoneNumberInvalid = False

        If Len(Phone) = 0 Then
            IsPhoneNumberInvalid = True
            ErrMessage = "Please enter a phone number"

            Exit Sub
        End If

        If IsNumeric(Phone) = False Then
            IsPhoneNumberInvalid = True
            ErrMessage = "Phone number can only contain numeric characters"

            Exit Sub
        End If

        If (Len(Phone) <> 10) Then
            IsPhoneNumberInvalid = True
            ErrMessage = "Please enter a valid 10 char phone number"

            Exit Sub
        End If
    End Sub

    Public Sub IsValidPinNumber(Pin As String)
        IsPinNumberInvalid = False

        If Len(Pin) = 0 Then
            IsPinNumberInvalid = True
            ErrMessage = "Please enter a pin number"

            Exit Sub
        End If

        If IsNumeric(Pin) = False Then
            IsPinNumberInvalid = True
            ErrMessage = "Pin number can only contain numeric characters"
            Exit Sub
        End If

        If (Len(Pin) <> 6) Then
            IsPinNumberInvalid = True
            ErrMessage = "Please enter a valid 6 char pin number"

            Exit Sub
        End If

    End Sub
End Module
