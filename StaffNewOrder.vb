Public Class StaffNewOrder
    Dim CalculatedAmount As Integer
    Private Sub GoBackOrdersButton_Click(sender As Object, e As EventArgs) Handles GoBackOrdersButton.Click
        Form1.StaffPage.LoadOrdersPage()
    End Sub

    Private Sub CreateOrderButton_Click(sender As Object, e As EventArgs) Handles CreateOrderButton.Click

        Validation.IsValidName(SNInput.Text)
        If Validation.IsNameInvalid Then
            MessageBox.Show("Sender name : " + Validation.ErrMessage)
            Exit Sub
        End If

        Validation.IsValidPhoneNumber(SPInput.Text)
        If Validation.IsPhoneNumberInvalid Then
            MessageBox.Show("Sender phone : " + Validation.ErrMessage)

            Exit Sub
        End If
        Validation.IsValidPinNumber(SPINInput.Text)
        If (Validation.IsPinNumberInvalid) Then
            MessageBox.Show("Sender PIN : " + Validation.ErrMessage)
            Exit Sub
        End If

        Validation.IsValidName(RNInput.Text)
        If Validation.IsNameInvalid Then
            MessageBox.Show("Recepient name : " + Validation.ErrMessage)
            Exit Sub
        End If


        Validation.IsValidPhoneNumber(RPInput.Text)
        If Validation.IsPhoneNumberInvalid Then
            MessageBox.Show("Recepient phone : " + Validation.ErrMessage)

            Exit Sub
        End If
        Validation.IsValidPinNumber(RPINInput.Text)
        If (Validation.IsPinNumberInvalid) Then
            MessageBox.Show("Recepient PIN : " + Validation.ErrMessage)
            Exit Sub
        End If

        SubmitNewOrder()
    End Sub

    Private Sub SubmitNewOrder()
        Dim IsFragile = False

        If (FragileInput.Text = "Yes") Then
            IsFragile = True
        End If

        CalculateAmount(WeightInput.Value, IsFragile)
        Dim Amount = CalculatedAmount

        Dim CreatedAt = Date.Now()
        Dim DeliveryDate = DateAdd("d", DaysInput.Value, CreatedAt)

        Dim NewOrder = New OrderModel With {
            .Content = ContentInput.Text,
            .Weight = WeightInput.Value,
            .IsFragile = IsFragile,
            .Amount = Amount,
            .SName = SNInput.Text,
            .SPhone = SPInput.Text,
            .SAddr1 = SA1Input.Text,
            .SAddr2 = SA2Input.Text,
            .SAddr3 = SA3Input.Text,
            .SPin = SPINInput.Text,
            .Rname = RNInput.Text,
            .RPhone = RPInput.Text,
            .RAddr1 = RA1Input.Text,
            .RAddr2 = RA2Input.Text,
            .RAddr3 = RA3Input.Text,
            .RPin = RPINInput.Text,
            .CreatedAt = CreatedAt,
            .Delivery = DeliveryDate,
            .HasDelivered = False
        }

        OrderModule.CraeteOrder(NewOrder)
    End Sub

    Private Sub CalculateAmount(Weight As Integer, ISFragile As Boolean)
        Dim Amount As Integer

        If (ISFragile) Then
            Amount = 100 + Weight * 3
        Else
            Amount = 70 + Weight * 2
        End If

        CalculatedAmount = Amount
    End Sub

    Private Sub CheckPriceButton_Click(sender As Object, e As EventArgs) Handles CheckPriceButton.Click
        Dim IsFragile = False

        If (FragileInput.Text = "Yes") Then
            IsFragile = True
        End If

        CalculateAmount(WeightInput.Value, IsFragile)
        PriceLabel.Text = CalculatedAmount
    End Sub
End Class
