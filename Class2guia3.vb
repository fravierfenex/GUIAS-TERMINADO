Public Class banco
    Private bancaria As Integer
    Private valance As Double
    Public Sub New(bancaria, valance)
        Me.bancaria = bancaria
        Me.valance = valance
    End Sub
    Public Sub deposito(total As Double)
        valance = valance + total
    End Sub
    Public Sub retiro(total As Double)
        valance = valance - total
    End Sub
    Public Sub mostrar()
        Console.WriteLine("Mostrar total: " & valance)
        Console.ReadLine()
    End Sub
End Class
