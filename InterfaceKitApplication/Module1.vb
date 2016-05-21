Module Module1

    Dim inter As New Phidgets.InterfaceKit

    Sub Sleep(ByVal n As Integer)
        System.Threading.Thread.Sleep(n)
    End Sub

    Sub Main()
        Console.WriteLine("InterfaceKitApplication")

        ' Opens the PhidgetInterfaceKit on the USB port
        inter.open()
        inter.waitForAttachment(1000)

        Dim index As Integer = 0
        Do While True

            Console.WriteLine(index.ToString)
            index += 1

            ' Sleeps for 15ms, as specified by the int "15"
            Sleep(15)

        Loop

        Console.WriteLine("Goodbye!")

        ' For example:
        ' The following code sets index zero on the digital outputs to ON/
        '   inter.outputs(0) = True
        '
        ' This code makes the third index on the digital output OFF/
        '   inter.outputs(3) = False
        '
        ' You can also do some math with the "index" varible,
        ' such as checking if it divides into 30 using modulo (https://en.wikipedia.org/wiki/Modulo_operation),
        '
        '   If (NumberOfLoops Mod 30) is 0 Then
        '       inter.outputs(0) = True
        '   Else
        '       inter.outputs(0) = False
        '   End If

    End Sub

End Module
