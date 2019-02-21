Imports System.IO
Imports System.Text
Imports System.Collections



Public Class Form2

    'Variables publicas
    Public bruta, bruta1, bruta2 As String
    Public opcion, opcion1, opcion2 As String
    Public documento, documento1, documento2 As String
    'Funciones para dar origen al archivo
    Public A, B, C As String
    Sub Copia()
        Dim i, j, k, largo As Integer
        Dim via1 As String = My.Computer.FileSystem.ReadAllText(bruta & "\" & documento)
        Dim via2 As String = My.Computer.FileSystem.ReadAllText(bruta1 & "\" & documento1)
        Dim via3 As String = My.Computer.FileSystem.ReadAllText(bruta2 & "\" & documento2)

        Dim vallev1, vallev2, dsv1, dsv2, dfv1, dfv2, matrizV1(6, 3), matrizV2(6, 3) As String
        Dim texto_vias() As String = via1.Split(vbLf)
        Dim prio2() As String = via2.Split(Chr(9))
        Dim prio3() As String = via3.Split(Chr(9))
        Dim archivo_final(texto_vias.Length) As String
        Dim archivo_Generado(texto_vias.Length) As String

        '---- ALMACENADO DE ARCHIVO MT.CONF
        i = 0
        Dim Archivo As IO.StreamReader
        Archivo = IO.File.OpenText(bruta & "\" & documento)
        Do Until Archivo.EndOfStream
            archivo_final(i) = Archivo.ReadLine()
            i = i + 1
        Loop
        Archivo.Close()

        'información de prio 2 y 3 a matriz

        k = 0
        For i = 0 To 6
            For j = 0 To 3
                matrizV1(i, j) = prio2(k)
                k = k + 1
            Next
        Next

        k = 0
        For i = 0 To 6
            For j = 0 To 3
                matrizV2(i, j) = prio3(k)
                k = k + 1
            Next
        Next

        Dim complemento As String = "[HRG_BTAN]    "

        'datos via 1
        For i = 1 To 6
            vallev1 = vallev1 + matrizV1(i, 1) + ","
        Next
        vallev1 = complemento & vallev1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 6
            dsv1 = dsv1 + matrizV1(i, 2) + ","
        Next
        dsv1 = complemento & dsv1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 6
            dfv1 = dfv1 + matrizV1(i, 3) + ","
        Next
        dfv1 = complemento & dfv1.Replace(vbTab, ",").Replace("-", "0").Trim(",")



        'Datos vía 2

        For i = 1 To 6
            vallev2 = vallev2 + matrizV2(i, 1) + ","
        Next
        vallev2 = complemento & vallev2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 6
            dsv2 = dsv2 + matrizV2(i, 2) + ","
        Next
        dsv2 = complemento & dsv2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 6
            dfv2 = dfv2 + matrizV2(i, 3) + ","
        Next
        dfv2 = complemento & dfv2.Replace(vbTab, ",").Replace("-", "0").Trim(",")



        Dim out_path, out_origin As String
        out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Antiguo.txt"
        out_origin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\CambioL4A.txt"
        Using sw As StreamWriter = New StreamWriter(out_path)
            Using sh As StreamWriter = New StreamWriter(out_origin)
            
                For i = 0 To texto_vias.Length - 5
                    If "!                                 T H A L E S " = archivo_final(i) Then
                        sw.Write("!         O R I A N N A   V.1.0               ")
                    End If
                    If archivo_final(i) = opcion Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" Then
                            sw.Write(opcion)
                            sw.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = vallev1
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LCI_V2,SRA_V2,SRO_V2,LGR_V2,SJU_V2,VIM_V2" Then
                            sw.Write(opcion)
                            sw.Write("[HRG_ARRETS]  LCI_V2,SRA_V2,SRO_V2,LGR_V2,SJU_V2,VIM_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)
                            archivo_final(i + 3) = vallev2
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)
                        End If
                    End If


                    If archivo_final(i) = opcion1 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" Then
                            sw.Write(opcion1)
                            sw.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)
                            archivo_final(i + 3) = dsv1
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LCI_V2,SRA_V2,SRO_V2,LGR_V2,SJU_V2,VIM_V2" Then
                            sw.Write(opcion1)
                            sw.Write("[HRG_ARRETS]  LCI_V2,SRA_V2,SRO_V2,LGR_V2,SJU_V2,VIM_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)
                            archivo_final(i + 3) = dsv2
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)
                        End If
                    End If

                    If archivo_final(i) = opcion2 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" Then
                            sw.Write(opcion2)
                            sw.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)
                            archivo_final(i + 3) = dfv1
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LCI_V2,SRA_V2,SRO_V2,LGR_V2,SJU_V2,VIM_V2" Then
                            sw.Write(opcion2)
                            sw.Write("[HRG_ARRETS]  LCI_V2,SRA_V2,SRO_V2,LGR_V2,SJU_V2,VIM_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)
                            archivo_final(i + 3) = dfv2
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  VIM_V1,SJU_V1,LGR_V1,SRO_V1,SRA_V1,LCI_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)
                        End If
                    End If
                Next



            End Using
        End Using
     

        MsgBox("archivo generado")


        
       



        out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mtL4A.conf"

        Using sw As StreamWriter = New StreamWriter(out_path)

            sw.Write("!-----Oriana V.1.0 Document -------")

            For i = 0 To texto_vias.Length

                sw.Write(archivo_final(i) & vbLf)

            Next




        End Using





        'var = vallev1.Replace(vbTab, ",").Replace("-", "0")
        'Dim charArray() As Char = var.ToCharArray
        'For i = 0 To charArray.Length
        '    If i = 0 Then
        '        charArray(0) = ""
        '    End If

        'Next







        'Dim largo As Integer = texto.Length
        'For i = 0 To largo
        '    'If "[LABEL]       C" = texto(i) Then
        '    '    MsgBox("encontrado")
        '    'End If
        'Next

    End Sub


    'Boton para archivos congif.mt
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim B
            FolderBrowserDialog1.ShowDialog()
            bruta = FolderBrowserDialog1.SelectedPath

            B = My.Computer.FileSystem.GetFiles(bruta)

            With ComboBox1
                .Items.Clear()
                For Each element In B
                    .Items.Add(Replace(element.ToString, bruta & "\", ""))
                Next


            End With
            ComboBox1.SelectedIndex = 0
            documento = Me.ComboBox1.SelectedItem



        Catch ex As Exception

        End Try
    End Sub

    'boton para archivos vía 1 y vía 2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim B2
            FolderBrowserDialog2.ShowDialog()
            bruta1 = FolderBrowserDialog2.SelectedPath

            B2 = My.Computer.FileSystem.GetFiles(bruta1)

            With ComboBox2
                .Items.Clear()
                For Each element In B2
                    .Items.Add(Replace(element.ToString, bruta1 & "\", ""))
                Next


            End With
            ComboBox2.SelectedIndex = 0
            documento1 = Me.ComboBox2.SelectedItem



        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim B3
            FolderBrowserDialog3.ShowDialog()
            bruta2 = FolderBrowserDialog3.SelectedPath

            B3 = My.Computer.FileSystem.GetFiles(bruta2)

            With ComboBox3
                .Items.Clear()
                For Each element In B3
                    .Items.Add(Replace(element.ToString, bruta2 & "\", ""))
                Next


            End With
            ComboBox3.SelectedIndex = 0
            documento2 = Me.ComboBox3.SelectedItem



        Catch ex As Exception

        End Try
    End Sub

    'Boton Generar archivo
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Copia()
    End Sub

    '----------------------------------------------------------------------------------------------------------

    'Combobox de archivos config.mt
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        documento = Me.ComboBox1.SelectedItem
    End Sub
    'Combobox de archivos planos de vía 1 y vía 2
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        documento1 = Me.ComboBox2.SelectedItem
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        documento2 = Me.ComboBox3.SelectedItem
    End Sub

    '----------------------------------------------------------------------------------------------------------
    'Archivos de marchas

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        A = ComboBox4.Text
        If A = "A" Then
            opcion = "[LABEL]       A"
        End If
        If A = "B" Then
            opcion = "[LABEL]       B"
        End If
        If A = "C" Then
            opcion = "[LABEL]       C"
        End If
        If A = "D" Then
            opcion = "[LABEL]       D"
        End If
        If A = "E" Then
            opcion = "[LABEL]       E"
        End If
       
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        B = ComboBox5.Text

        If B = "A" Then
            opcion1 = "[LABEL]       A"
        End If
        If B = "B" Then
            opcion1 = "[LABEL]       B"
        End If
        If B = "C" Then
            opcion1 = "[LABEL]       C"
        End If
        If B = "D" Then
            opcion1 = "[LABEL]       D"
        End If
        If B = "E" Then
            opcion1 = "[LABEL]       E"
        End If
  
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        C = ComboBox6.Text

        If C = "A" Then
            opcion2 = "[LABEL]       A"
        End If
        If C = "B" Then
            opcion2 = "[LABEL]       B"
        End If
        If C = "C" Then
            opcion2 = "[LABEL]       C"
        End If
        If C = "D" Then
            opcion2 = "[LABEL]       D"
        End If
        If C = "E" Then
            opcion2 = "[LABEL]       E"
        End If
   
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FolderBrowserDialog2_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog2.HelpRequest

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'textbox 1
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'textbox 2
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ElementHost1_ChildChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.Integration.ChildChangedEventArgs)

    End Sub
End Class