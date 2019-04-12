Module Module1

    Sub Main()
     

        Dim opc As Char
        Dim calcu As Calculadora = New Calculadora()
        Dim a, b As Double


        Console.WriteLine("¿Qué operación deseas realizar? Presiona la letra que corresponda y luego Enter.")
        Console.WriteLine("[s]umar, [r]estar, [m]ultiplicar, [d]ividir, [t]odas")
        opc = Console.ReadLine()

        Console.WriteLine("Ingrese el primer valor: ")
        a = Console.ReadLine()
        Console.WriteLine("Ingrese el segundo valor: ")
        b = Console.ReadLine()

        Select Case opc
            Case "s"
                Console.Write("La suma de esos números es: ")
                calcu.Sumar(a, b)

            Case "r"
                Console.Write("La resta de esos números es: ")
                calcu.Restar(a, b)

            Case "m"
                Console.Write("La multiplicacion de esos números es: ")
                calcu.Multiplicar(a, b)

            Case "d"
                Console.Write("La division de esos números es: ")
                calcu.Dividir(a, b)

            Case "t"
                Console.WriteLine("el resultado de todas las operaciones es: ")
                calcu.Todas(a, b)

            Case Else
                Console.WriteLine("OPCION INVALIDA")
        End Select

        Console.WriteLine("Presiona Enter para salir del programa...")
        Console.ReadLine()
    End Sub

End Module
