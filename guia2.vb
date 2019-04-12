Module Module1
    Sub main()
        impares()
        suma()
        adivinanza()
        factorial()
        pinversa()
        alumno()
        tablas()
        contar()
        Aritmetica()
    End Sub

    Sub impares()
        Dim n = 0
        While n < 40
            If n Mod 2 = 1 Then
                Console.WriteLine(n)

            End If
            n += 1
        End While
        Console.ReadLine()
    End Sub

    Sub suma()
        Console.WriteLine(" suma de numeros enteros")
        Dim n = 0
        Dim suma = 0
        Console.WriteLine(" escriba un numero para sumar todos sus numeros enteros")
        Dim enteros As Integer = Console.ReadLine
        While n < enteros
            n += 1
            suma = suma + n
        End While
        Console.WriteLine("la suma del numero proporcionado " & enteros & " es " & suma)
        Console.ReadLine()
    End Sub


    Sub adivinanza()
        Dim num
        Console.WriteLine("adivinanza de un numero")
        Dim n As Int16 = New Random().Next(11)
        Do
            Console.WriteLine("escriba un numero para adivinar aver si el que el programa proporciono entre 0-10")
            num = Console.ReadLine
            If n <> num Then
                Console.WriteLine("suerte a la proxima precione enter para continuar ")
            ElseIf n = num Then
                Console.WriteLine("que buena suerte")
            End If
            Console.ReadLine()
        Loop
    End Sub

    Sub factorial()
        Dim n As Integer
        Dim factorial As Long = 1
        Console.WriteLine("Ingrese el numero para calcular el factorial", n)
        n = Console.ReadLine()

        If n > 0 Then
            For i As Integer = n To 1 Step -1
                factorial *= i
            Next

            Console.WriteLine("El factorial de {0} = es {1}", n, factorial)
            Console.WriteLine("Presione enter para continuar")
            Console.ReadLine()
        Else
            Console.WriteLine("No puede ingresar valores negativos")
            Console.WriteLine("Presione enter para continuar")
            Console.ReadLine()
        End If

    End Sub
    Sub pinversa()
        Dim palabra, pi As String
        pi = ""
        Console.WriteLine("Escriba una palabra: ")
        palabra = Console.ReadLine()
        For i = 1 To Len(palabra)
            pi = Mid(palabra, i, 1) + pi
        Next

        Console.WriteLine("Resultado:  ")
        Console.WriteLine("" & pi)
        Console.WriteLine("Presione enter para salir")
        Console.ReadLine()
    End Sub
    Sub alumno()
        Dim clase As New List(Of String) From {"glenda", "francisco", "kevin", "paty"}
        Console.WriteLine("estudiantes de programacion orientada a objetos")
        Console.WriteLine()
        For Each poo As String In clase
            Console.WriteLine(poo)
        Next
        Console.ReadLine()
    End Sub
    Sub tablas()

        Dim n As Integer
        Dim i As Integer
        Dim multiplo As Integer


        Console.Write("Ingrese un numero de 1 al 10 para mostrar tabla: ")
        n = Console.ReadLine


        Console.WriteLine("Tabla de Multiplicar del numero {0}", n)


        For i = 1 To 10 Step 1

            multiplo = n * i


            Console.WriteLine("{0} x {1} = {2}", n, i, multiplo)

        Next


        Console.ReadKey()

    End Sub
    Sub contar()

        Dim n As String
        Console.WriteLine("Ingrese una frase: ")
        n = Console.ReadLine()

        Dim palabras() As String = n.Split(" ")

        Console.WriteLine("La frase '" & n & "' tiene " & palabras.Count & " palabras.")
        For Each tex As String In palabras
            Console.WriteLine("La palabra '" & tex & "' tiene " & tex.Length & " letras.")
        Next

        Console.ReadLine()
    End Sub
    Sub Aritmetica()
        Dim n1() As Integer = {1, 2, 3, 4, 5}
        Dim n2() As Integer = {6, 7, 8, 9, 10}


        Console.WriteLine("Sumas: ")
        For i = 0 To n1.Length - 1
            Console.WriteLine(n1(i) & " + " & n2(i) & " = " & (n1(i) + n2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Restas: ")
        For i = 0 To n1.Length - 1
            Console.WriteLine(n1(i) & " - " & n2(i) & " = " & (n1(i) - n2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Multiplicacion: ")
        For i = 0 To n1.Length - 1
            Console.WriteLine(n1(i) & " * " & n2(i) & " = " & (n1(i) * n2(i)))
        Next

        Console.WriteLine()

        Console.WriteLine("Division: ")
        For i = 0 To n1.Length - 1
            Console.WriteLine(n1(i) & " / " & n2(i) & " = " & (n1(i) / n2(i)))
        Next

        Console.ReadLine()
    End Sub
End Module