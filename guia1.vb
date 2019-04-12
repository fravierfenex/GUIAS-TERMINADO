Module Module1

    Sub Main()
        llamada()
        multiplo()
        resultadoAcademico()
        clima()
        TickTock()
        PersonajesFavoritos()
    End Sub
    Sub llamada()
        Dim n As Integer

        Console.WriteLine("PROGRAMA A UTILIZAR")
        Console.WriteLine("1. Multiplo")
        Console.WriteLine("2. ResultadoAcademico")
        Console.WriteLine("3. Temperatura")
        Console.WriteLine("4. Tick Tock")
        Console.WriteLine("5. Personaje Favorito")
        Console.WriteLine("6. Salir del Menú")
        n = Console.ReadLine()

        Select Case n
            Case Is = 1
                Call multiplo()
            Case Is = 2
                Call resultadoAcademico()
            Case Is = 3
                Call clima()
            Case Is = 4
                Call TickTock()
            Case Is = 5
                Call PersonajesFavoritos()
            Case Is = 6
                Call salir()
        End Select

    End Sub


    Sub multiplo()

        Dim n1 As Integer, n2 As Integer
        Console.WriteLine("ingrese  un numero")
        n1 = Console.ReadLine()
        If n1 Mod 5 = 0 Then
            Console.WriteLine("su numero es multiplo de 5", n1)
            Console.ReadLine()
        Else
            Console.WriteLine("no es multiplo de 5", n1)
            Console.ReadLine()
        End If
        Console.WriteLine("ingrese su segundo numero")
        n2 = Console.ReadLine()
        If n2 Mod 3 = 0 Then
            Console.WriteLine("su numero es multiplo de 3", n2)
            Console.ReadLine()
        Else
            Console.WriteLine("su  numero no es multiplo de 3", n2)
            Console.ReadLine()
        End If

    End Sub
    Sub resultadoAcademico()
        Dim nombre As String, apellido As String
        Dim nota As Double, asistencia As Integer
        Console.WriteLine("RESULTADO ACADEMICO")
        Console.WriteLine("ingrese su nombre completo")
        nombre = Console.ReadLine()
        Console.WriteLine("ingrese su apellido completo")
        apellido = Console.ReadLine()
        Console.WriteLine("ingresar asistencia")
        asistencia = Console.ReadLine()
        Console.WriteLine("ingrese la nota de estudiante")
        nota = Console.ReadLine()
        If asistencia >= 75 And asistencia <= 100 Then
        ElseIf asistencia > 100 Then
            Console.WriteLine("este dato esta fuera del rango", asistencia)
        ElseIf nota >= 6 And nota <= 10 Then
        ElseIf nota > 10 Then
            Console.WriteLine("este dato esta fuera del rango", nota)


            Console.WriteLine("aprobado")
            Console.WriteLine("FELICIDAES")
            Console.ReadLine()
        Else
            Console.WriteLine("reprobado")
            Console.WriteLine("NECESITA MEJORAR")
            Console.ReadLine()

        End If
    End Sub

    Sub clima()
        Dim clima As Integer
        Console.WriteLine("ingrese el estado del clima en grados del 0 al 30")
        clima = Console.ReadLine()
        Select Case clima = 0
            Case clima <= 10
                Console.WriteLine("el clima se encuentra muy frio o lluvioso , se recomienda usar sueter")
                Console.ReadLine()
            Case clima <= 20
                Console.WriteLine("el clima se encuentra muy bueno , esta bueno para salir a pasear")
                Console.ReadLine()
            Case clima <= 27
                Console.WriteLine("el clima se encuentra bueno, para ir ala playa")
                Console.ReadLine()
            Case clima <= 30
                Console.WriteLine("el clima se encuentra muy caluroso, usar bloquedor solar")
                Console.ReadLine()

        End Select

        Console.ReadLine()
    End Sub

    Sub TickTock()
        Dim contador = 0

        While contador <= 100
            If (contador Mod 3 = 0) And (contador Mod 5 = 0) Then
                Console.WriteLine("tic-tac")
            ElseIf contador Mod 5 = 0 Then
                Console.WriteLine("toc")
            ElseIf contador Mod 3 = 0 Then
                Console.WriteLine("tic")
            ElseIf (contador Mod 3 <> 0) And (contador Mod 5 <> 0) Then
                Console.WriteLine(contador)
            End If
            contador = contador + 1
        End While
        Console.ReadLine()

    End Sub


    Sub PersonajesFavoritos()

        Dim salir = 1
        Dim favoritos
        While salir <= 3
            Console.WriteLine("elija un grupo y  luego un personaje favorito")
            Console.WriteLine("")
            Console.WriteLine("1.deportistas")
            Console.WriteLine("2.generos musicales")
            Console.WriteLine("3.serie")
            Console.WriteLine("")
            Dim n As Integer = Console.ReadLine
            If n = 1 Then

                Dim jugadores = "deportistas"
                Console.WriteLine("1-hazard")
                Console.WriteLine("2-neymar")
                Console.WriteLine("3-cristiano ronaldo")
                Console.WriteLine("4-marcelo")
                Console.WriteLine("ingrese su personaje favorito")
                Console.WriteLine("")
                Dim n1 = Console.ReadLine()
                If n1 = 1 Then
                    favoritos = " hazard"
                ElseIf n1 = 2 Then
                    favoritos = "neymar"
                ElseIf n1 = 3 Then
                    favoritos = "cristiano ronaldo"
                ElseIf n1 = 4 Then
                    favoritos = "marcelo"
                End If
                Console.WriteLine("su grupo favorito es " & jugadores & " y su personaje favorito es " & favoritos)
                Console.ReadLine()

            ElseIf n = 2 Then
                Console.WriteLine("ingrese su personaje favorito")
                Dim genero = "generos musicales"
                Console.WriteLine("1.rock")
                Console.WriteLine("2.80s")
                Console.WriteLine("3.pop lirico")
                Console.WriteLine("4.opera")
                Console.WriteLine("")
                Dim n2 = Console.ReadLine()
                If n2 = 1 Then
                    favoritos = "rock"
                ElseIf n2 = 2 Then
                    favoritos = "80s"
                ElseIf n2 = 3 Then
                    favoritos = "pop lirico"
                ElseIf n2 = 4 Then
                    favoritos = "opera"
                End If

                Console.WriteLine("su grupo favorito es " & genero & " y su personaje favorito es " & favoritos)
                Console.ReadLine()
            ElseIf n = 3 Then
                Console.WriteLine("ingrese su personaje favorito")
                Dim serie = "serie"
                Console.WriteLine("1.dods American")
                Console.WriteLine("2.dragon ball")
                Console.WriteLine("3.naruto shippuden")
                Dim n3 = Console.ReadLine()
                If n3 = 1 Then
                    favoritos = "gods American"
                ElseIf n3 = 2 Then
                    favoritos = "dragon ball"
                ElseIf n3 = 3 Then
                    favoritos = "naruto shippuden"
                End If

                Console.WriteLine("su grupo favorito es " & serie & " y su personaje favorito es " & favoritos)
                Console.ReadLine()
            End If
            salir = salir + 1

        End While
        Console.ReadLine()


    End Sub
    Sub salir()
        Console.WriteLine("pulse enter para salir")
        Console.ReadLine()
    End Sub



End Module
