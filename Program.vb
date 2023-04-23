Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine(Join(args, vbCrLf))
        Environment.ExitCode = -123
        Console.WriteLine(Environment.ExitCode)
        Console.WriteLine("Tada")
    End Sub
End Module
