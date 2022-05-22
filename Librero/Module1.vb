Module Module1
    Dim bases(cant) As Integer
    Dim altlibros(cant) As Integer
    Dim cant As Integer = 0

    Function librero() As Integer
        Dim resul As Integer
        Dim suma As Integer
        Dim resulAux As Integer
        Dim resulAux2 As Integer

        For a = 0 To cant 'Metodo de burbujeo para ordenar de mayor a menor las alturas de las bases
            For l = 0 To cant - 1
                If bases(l) > bases(l + 1) Then
                    resulAux = bases(l + 1)
                    bases(l + 1) = bases(l)
                    bases(l) = resulAux
                End If
            Next
        Next

        For a = 0 To cant 'Metodo de burbujeo para ordenar de menor a mayor las alturas de los libros
            For l = 0 To cant - 1
                If altlibros(l) < altlibros(l + 1) Then
                    resulAux2 = altlibros(l + 1)
                    altlibros(l + 1) = altlibros(l)
                    altlibros(l) = resulAux2
                End If
            Next
        Next

        suma = Val(bases(0)) + Val(altlibros(0))

        For l = 0 To 1
            For a = 0 To cant
                If (bases(a) + altlibros(a)) = suma Then 'Comparar cada uno de los resultados de la suma, con la suma de las primeras posiciones de cada vector
                    resul = suma
                Else
                    resul = -1
                End If
            Next
        Next

        Return resul
    End Function

    Function subTarea() As Integer
        Dim puntaje As Integer

        If cant <= 10 Then
            puntaje = 25
        End If
        If cant <= 100 Then
            puntaje += 25
        End If
        If cant <= 1000 Then
            puntaje += 25
        End If
        If librero() <> -1 Then
            puntaje += 12
        End If

        If cant = 1 Then
            puntaje += 5
        End If
        If cant = 2 Then
            puntaje += 8
        End If

        Return puntaje
    End Function

    Sub Main()
        Try
            Console.Write("Ingrese cantidad de libros:")
            cant = Console.ReadLine & vbCrLf
            If cant < 1 Or cant > 1000 Then
                Console.WriteLine("Cantidad incorrecta")
                Console.ReadKey()
                End
            Else
                cant -= 1
            End If

        Catch ex As Exception
            Console.WriteLine("Caracter invalido")
            Console.ReadKey()
            End
        End Try

        ReDim Preserve bases(cant)
        ReDim Preserve altlibros(cant)


        Try
            Console.Write("Ingrese las alturas de las bases:")
            For a = 0 To cant
                bases(a) = Console.ReadLine
                If bases(a) < 1 Or bases(a) > 1000 Then
                    Console.WriteLine("Numeros no validos")
                    Console.ReadKey()
                    End
                End If
            Next

            Console.Write("Ingrese las alturas de los libros:")
            For l = 0 To cant
                altlibros(l) = Console.ReadLine
                If altlibros(l) < 1 Or altlibros(l) > 1000 Then
                    Console.WriteLine("Numeros no validos")
                    Console.ReadKey()
                    End
                End If
            Next
        Catch ex As Exception
            Console.WriteLine("Caracter invalido")
        Console.ReadKey()
        End
        End Try

        Console.WriteLine("El resultado es:" & librero())
        Console.WriteLine("El puntaje es:" & subTarea())
        Console.ReadKey()
    End Sub

End Module
