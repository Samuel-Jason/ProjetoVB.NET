Imports System

Module Program
    Sub Main(args As String())

        Dim comprimento As Integer
        Dim palavra As String

        palavra = Console.ReadLine()
        comprimento = palavra.Length()

        Console.WriteLine()
        Console.WriteLine("A palavra {0} digitada tem {1} caracteres",
                            palavra, comprimento)
        Console.WriteLine()

    End Sub
End Module
