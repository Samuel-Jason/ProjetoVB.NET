Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Module Program
    Sub Main(args As String())

        'MessageBox.Show("Minha Caixa de texto", "Texto do titulo", MessageBoxButtons.OK, MessageBoxIcon.Information)'

        'Declaracao de variavel'
        Dim v1, v2 As Integer
        Console.WriteLine("Digite um numero:")
        v1 = Console.ReadLine()
        Console.WriteLine("Digite um numero:")
        v2 = Console.ReadLine()

        'If sem parenteses'
        If v1 = v2 Then
            Console.WriteLine("Os numeros são iguais")
        Else
            Console.WriteLine("Os numeros são diferentes")
        End If
        Console.ReadLine()

        'Capiturar codigo ASCII do caractere'
        Dim tecla As Integer
        Console.WriteLine("Digite uma tecla")
        tecla = Asc(Console.ReadLine())
        Console.WriteLine("O Codigo ASCII é: " & tecla)

        Console.ReadLine()

    End Sub
End Module
