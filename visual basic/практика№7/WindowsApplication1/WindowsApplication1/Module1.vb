Module Module1
    Public win As Short
    Public pre As Short
    Public gamb As String
    Public star As Short
    Function stat(ByVal Hit As Short, ByVal Tri As Short) As String
        Dim Perc As Single
        Perc = Hit / Tri
        Return (Format(Perc, "0.0%"))
    End Function
    Sub res(ByVal pla As String)
        Dim txt As String
        txt = "Уважаемый(ая) " & pla & "!" & vbCrLf & "Вы совершили " & "попыток из них " & win & " выигрышных. " & "Процентное соотношение выигрышей " & stat(win, pre)
        MsgBox(txt)
    End Sub
End Module
