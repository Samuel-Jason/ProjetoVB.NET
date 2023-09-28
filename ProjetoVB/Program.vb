Imports System
Imports System.ComponentModel
Imports System.Windows.Forms

Module Program
    Sub Main(args As String())

        'MessageBox.Show("Minha Caixa de texto", "Texto do titulo", MessageBoxButtons.OK, MessageBoxIcon.Information)'

        Dim v1, v2 As Integer
        Console.WriteLine("Digite um numero:")
        v1 = Console.ReadLine()
        Console.WriteLine("Digite um numero:")
        v2 = Console.ReadLine()

        If v1 = v2 Then
            Console.WriteLine("Os numeros são iguais")
        Else
            Console.WriteLine("Os numeros são diferentes")
        End If

        Console.ReadLine()


    End Sub
End Module
