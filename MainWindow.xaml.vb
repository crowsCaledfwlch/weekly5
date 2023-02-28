Imports System.Globalization

Class MainWindow
    Private Sub FormLoaded(sender As Object, e As RoutedEventArgs)
        lblCalcCost.Content = ""
        txtGroup.Clear()
        txtGroup.Focus()
        rbConSuper.IsChecked = True
        rbConAuto.IsChecked = False
        rbCon.IsChecked = False
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As RoutedEventArgs) Handles btnCalculate.Click
        Dim strGroupNum As String
        Dim intGroupNum As Int32
        Dim decCost As Decimal

        Const cdecConSuper = 380
        Const cdecConAuto = 275
        Const cdecCon = 209

        strGroupNum = txtGroup.Text
        If Integer.TryParse(strGroupNum, intGroupNum) Then
            If intGroupNum < 21 And intGroupNum > 0 Then
                If rbCon.IsChecked Then
                    decCost = intGroupNum * cdecCon
                ElseIf rbConAuto.IsChecked Then
                    decCost = intGroupNum * cdecConAuto
                ElseIf rbConSuper.IsChecked Then
                    decCost = intGroupNum * cdecConSuper
                End If
                lblCalcCost.Content = decCost.ToString("C", New CultureInfo("en-US"))
            Else
                MsgBox("Please Enter A Number between 1 and 20!!!")
                txtGroup.Clear()
                txtGroup.Focus()
            End If
        Else
            MsgBox("Please Enter a Number!!")
            txtGroup.Clear()
            txtGroup.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        lblCalcCost.Content = ""
        txtGroup.Clear()
        txtGroup.Focus()
        rbConSuper.IsChecked = True
        rbConAuto.IsChecked = False
        rbCon.IsChecked = False
    End Sub

    Private Sub rbConSuper_Checked(sender As Object, e As RoutedEventArgs) Handles rbConSuper.Checked
        rbConAuto.IsChecked = False
        rbCon.IsChecked = False

    End Sub

    Private Sub rbConAuto_Checked(sender As Object, e As RoutedEventArgs) Handles rbConAuto.Checked
        rbConSuper.IsChecked = False
        rbCon.IsChecked = False
    End Sub

    Private Sub rbCon_Checked(sender As Object, e As RoutedEventArgs) Handles rbCon.Checked
        rbConSuper.IsChecked = False
        rbConAuto.IsChecked = False
    End Sub
End Class
