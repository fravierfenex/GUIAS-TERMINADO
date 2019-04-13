Module Module1
    Sub Main()
        Dim hi As holamundo = New holamundo
        hi.saludo()
    End Sub
    Sub car()
        Dim carro1 As carro = New carro
        carro1.marca = "honda"
        carro1.modelo = "SA56"
        carro1.año = "1990"
        carro1.color = "NEGRO"
        Dim carro2 As carro = New carro
        carro2.marca = "honda"
        carro2.modelo = "SA56"
        carro2.año = "1990"
        carro2.color = "NEGRO"
        Dim carro3 As carro = New carro
        carro3.marca = "honda"
        carro3.modelo = "SA56"
        carro3.año = "1990"
        carro3.color = "NEGRO"

        carro1.car()
        Console.ReadLine()
        carro2.car()
        Console.ReadLine()
        carro3.car()
        Console.ReadLine()
    End Sub



    End Sub
    Sub cuent()
        Dim cuenta As banco = New banco(10, 30)
        cuenta.deposito(200)
        cuenta.retiro(10)
        cuenta.mostrar()
    End Sub
    Class holamundo
        Sub saludo()
            Console.WriteLine("hola mundo")
            Console.ReadLine()
        End Sub
    End Class

End Module
