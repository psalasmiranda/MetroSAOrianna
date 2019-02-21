Imports System.IO
Imports System.Text
Imports System.Collections



Public Class Form5
       'Variables publicas
    Public bruta, bruta1, bruta2 As String
    Public opcion, opcion1, opcion2, opcion3, opcion4, opcion5, opcion6, opcion7, opcion8, opcion9, opcion10 As String
    Public opcion0, opcion11, opcion22, opcion33, opcion44, opcion55, opcion66, opcion77, opcion88, opcion99, opcion100 As String
    Public documento, documento1, documento2 As String
    'Funciones para dar origen al archivo
    Public A, B, C, D, F, G, H, L, M, N As String
    Sub Copia()



        Dim i, j, k, largo As Integer
        Dim via1 As String = My.Computer.FileSystem.ReadAllText(bruta & "\" & documento)
        Dim via2 As String = My.Computer.FileSystem.ReadAllText(bruta1 & "\" & documento1)
        Dim via3 As String = My.Computer.FileSystem.ReadAllText(bruta2 & "\" & documento2)

        Dim vallev1, vallev2, dsv1, dsv2, dfv1, dfv2, matrizV1(23, 10), matrizV2(23, 10) As String

        Dim PAMV_V1, PPMV_V1, PAMR_V1, PPMR_V1, PREPAM_V1, VALLE_V1, NOCHE_V1, DS_V1, DF_V1 As String
        Dim PAMV_V2, PPMV_V2, PAMR_V2, PPMR_V2, PREPAM_V2, VALLE_V2, NOCHE_V2, DS_V2, DF_V2 As String
        Dim texto_vias() As String = via1.Split(vbLf)
        Dim prio2() As String = via2.Split(Chr(9))
        Dim prio3() As String = via3.Split(Chr(9))


        Dim archivo_final(texto_vias.Length) As String
        Dim archivo_Generado(texto_vias.Length) As String

        '---- ALMACENADO DE ARCHIVO mt.conf
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
        For i = 0 To 22
            For j = 0 To 9
                matrizV1(i, j) = prio2(k)
                k = k + 1

            Next

        Next
        k = 0
        For i = 0 To 22
            For j = 0 To 9
                matrizV2(i, j) = prio3(k)
                k = k + 1
            Next

        Next

        Dim complemento As String = "[HRG_BTAN]    "

        'datos via 1
        For i = 1 To 22
            PAMV_V1 = PAMV_V1 + matrizV1(i, 1) + ","
        Next
        PAMV_V1 = complemento & PAMV_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 22
            PPMV_V1 = PPMV_V1 + matrizV1(i, 2) + ","
        Next
        PPMV_V1 = complemento & PPMV_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            PAMR_V1 = PAMR_V1 + matrizV1(i, 2) + ","
        Next
        PAMR_V1 = complemento & PAMR_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            PPMR_V1 = PPMR_V1 + matrizV1(i, 2) + ","
        Next
        PPMR_V1 = complemento & PPMR_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 22
            PREPAM_V1 = PREPAM_V1 + matrizV1(i, 2) + ","
        Next
        PREPAM_V1 = complemento & PREPAM_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            VALLE_V1 = VALLE_V1 + matrizV1(i, 2) + ","
        Next
        VALLE_V1 = complemento & VALLE_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            NOCHE_V1 = NOCHE_V1 + matrizV1(i, 2) + ","
        Next
        NOCHE_V1 = complemento & NOCHE_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            DS_V1 = DS_V1 + matrizV1(i, 2) + ","
        Next
        DS_V1 = complemento & DS_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            DF_V1 = DF_V1 + matrizV1(i, 2) + ","
        Next
        DF_V1 = complemento & DF_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            PAMV_V2 = PAMV_V2 + matrizV1(i, 1) + ","
        Next
        PAMV_V2 = complemento & PAMV_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 22
            PPMV_V2 = PPMV_V2 + matrizV1(i, 2) + ","
        Next
        PPMV_V2 = complemento & PPMV_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            PAMR_V2 = PAMR_V2 + matrizV1(i, 2) + ","
        Next
        PAMR_V2 = complemento & PAMR_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            PPMR_V2 = PPMR_V2 + matrizV1(i, 2) + ","
        Next
        PPMR_V2 = complemento & PPMR_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 22
            PREPAM_V2 = PREPAM_V2 + matrizV1(i, 2) + ","
        Next
        PREPAM_V2 = complemento & PREPAM_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            VALLE_V2 = VALLE_V2 + matrizV1(i, 2) + ","
        Next
        VALLE_V2 = complemento & VALLE_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            NOCHE_V2 = NOCHE_V2 + matrizV1(i, 2) + ","
        Next
        NOCHE_V2 = complemento & NOCHE_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            DS_V2 = DS_V2 + matrizV1(i, 2) + ","
        Next
        DS_V2 = complemento & DS_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 22
            DF_V2 = DF_V2 + matrizV1(i, 2) + ","
        Next
        DF_V2 = complemento & DF_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")





        Dim out_path, out_origin As String
        out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\AntiguoL2.txt"
        out_origin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\CambioL2.txt"
        Using sw As StreamWriter = New StreamWriter(out_path)
            Using sh As StreamWriter = New StreamWriter(out_origin)
                sw.Write("!-----Oriana V.1.0 Document -------" & vbLf)
                sw.Write("!-----Cambios según marchas -------" & vbLf)
                sw.Write("!----------------------------------" & vbLf)
                sh.Write("!-----Oriana V.1.0 Document -------" & vbLf)
                sh.Write("!-----Cambios según marchas -------" & vbLf)
                sh.Write("!----------------------------------" & vbLf)
                For i = 0 To archivo_final.Length - 5



                    If archivo_final(i) = opcion Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = PAMV_V1
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion0 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion0)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = PAMV_V2
                            sh.Write(opcion0)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If

                    '--------------------------


                    If archivo_final(i) = opcion1 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion1)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = PPMV_V1
                            sh.Write(opcion1)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion11 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion11)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = PPMV_V2
                            sh.Write(opcion11)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If
                    '-------------------------


                    If archivo_final(i) = opcion2 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion2)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = PAMR_V1
                            sh.Write(opcion2)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion22 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion22)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = PAMR_V2
                            sh.Write(opcion22)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If

                    '-------------------------

                    If archivo_final(i) = opcion3 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion3)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = PPMR_V1
                            sh.Write(opcion3)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion33 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion33)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = PPMR_V2
                            sh.Write(opcion33)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If
                    '---------------------


                    If archivo_final(i) = opcion4 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion4)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = PREPAM_V1
                            sh.Write(opcion4)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion44 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion44)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = PREPAM_V2
                            sh.Write(opcion44)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If

                    '-----------


                    If archivo_final(i) = opcion5 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion5)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = VALLE_V1
                            sh.Write(opcion5)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion55 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion55)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = VALLE_V2
                            sh.Write(opcion55)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If
                    '------------------


                    If archivo_final(i) = opcion6 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion6)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = NOCHE_V1
                            sh.Write(opcion6)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion66 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion66)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = NOCHE_V2
                            sh.Write(opcion66)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If
                    '------------------


                    If archivo_final(i) = opcion7 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion7)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = DS_V1
                            sh.Write(opcion7)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion77 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion77)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = DS_V2
                            sh.Write(opcion77)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If
                    '---------------


                    If archivo_final(i) = opcion8 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
                            sw.Write(opcion8)
                            sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)

                            archivo_final(i + 5) = DF_V1
                            sh.Write(opcion8)
                            sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion88 Then
                        If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
                            sw.Write(opcion88)
                            sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 5 & vbLf)
                            sw.Write(archivo_final(i + 5) & vbLf)
                            archivo_final(i + 5) = DF_V2
                            sh.Write(opcion88)
                            sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
                            sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
                            sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 5 & vbLf)
                            sh.Write(archivo_final(i + 5) & vbLf)
                        End If
                    End If



                Next



            End Using
        End Using



        MsgBox("archivo generado")







        out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mtL2.conf"

        Using sw As StreamWriter = New StreamWriter(out_path)

            sw.Write("!-----Oriana V.1.0 Document -------")

            For i = 0 To texto_vias.Length

                sw.Write(archivo_final(i) & vbLf)

            Next




        End Using
        ''Dim lectura1, lectura2 As String


        ''MsgBox("archivo generado")







        ''out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mtL4.conf"

        ''Using sw As StreamWriter = New StreamWriter(out_path)

        ''    sw.Write("!-----Oriana V.1.0 Document -------")


        ''    For i = 0 To texto_vias.Length

        ''        sw.Write(archivo_final(i) & vbLf)

        ''    Next




        ''End Using





        ' ''var = vallev1.Replace(vbTab, ",").Replace("-", "0")
        ' ''Dim charArray() As Char = var.ToCharArray
        ' ''For i = 0 To charArray.Length
        ' ''    If i = 0 Then
        ' ''        charArray(0) = ""
        ' ''    End If

        ' ''Next







        ' ''Dim largo As Integer = texto.Length
        ' ''For i = 0 To largo
        ' ''    'If "[LABEL]       C" = texto(i) Then
        ' ''    '    MsgBox("encontrado")
        ' ''    'End If
        ' ''Next

    End Sub
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
    'boton generar
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Copia()
    End Sub
    'listbox de archivos
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        documento = Me.ComboBox1.SelectedItem
    End Sub


    'lista de checkbox
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        documento1 = Me.ComboBox2.SelectedItem
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        documento2 = Me.ComboBox3.SelectedItem
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        A = ComboBox4.Text
        If A = "A" Then
            opcion = "[KEY]         MT_AVLC_A"
            opcion0 = "[KEY]         MT_LCAV_A"
        End If
        If A = "B" Then
            opcion = "[KEY]         MT_AVLC_B"
            opcion0 = "[KEY]         MT_LCAV_B"
        End If
        If A = "C" Then
            opcion = "[KEY]         MT_AVLC_C"
            opcion0 = "[KEY]         MT_LCAV_C"
        End If
        If A = "D" Then
            opcion = "[KEY]         MT_AVLC_D"
            opcion0 = "[KEY]         MT_LCAV_D"
        End If
        If A = "E" Then
            opcion = "[KEY]         MT_AVLC_E"
            opcion0 = "[KEY]         MT_LCAV_E"
        End If
       
        If A = "H" Then
            opcion = "[KEY]         MT_AVLC_H"
            opcion0 = "[KEY]         MT_LCAV_H"
        End If
  
        If A = "K" Then
            opcion = "[KEY]         MT_AVLC_K"
            opcion0 = "[KEY]         MT_LCAV_K"
        End If

        If A = "L" Then
            opcion = "[KEY]         MT_AVLC_L"
            opcion0 = "[KEY]         MT_LCAV_L"
        End If

        If A = "M" Then
            opcion = "[KEY]         MT_AVLC_M"
            opcion0 = "[KEY]         MT_LCAV_M"
        End If
        If A = "O" Then
            opcion = "[KEY]         MT_AVLC_O"
            opcion0 = "[KEY]         MT_LCAV_O"
        End If

        
       
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        B = ComboBox5.Text
        If B = "A" Then
            opcion1 = "[KEY]         MT_AVLC_A"
            opcion11 = "[KEY]         MT_LCAV_A"
        End If
        If B = "B" Then
            opcion1 = "[KEY]         MT_AVLC_B"
            opcion11 = "[KEY]         MT_LCAV_B"
        End If
        If B = "C" Then
            opcion1 = "[KEY]         MT_AVLC_C"
            opcion11 = "[KEY]         MT_LCAV_C"
        End If
        If B = "D" Then
            opcion1 = "[KEY]         MT_AVLC_D"
            opcion11 = "[KEY]         MT_LCAV_D"
        End If
        If B = "E" Then
            opcion1 = "[KEY]         MT_AVLC_E"
            opcion11 = "[KEY]         MT_LCAV_E"
        End If
        If B = "H" Then
            opcion1 = "[KEY]         MT_AVLC_H"
            opcion11 = "[KEY]         MT_LCAV_H"
        End If
        If B = "K" Then
            opcion1 = "[KEY]         MT_AVLC_K"
            opcion11 = "[KEY]         MT_LCAV_K"
        End If

        If B = "L" Then
            opcion1 = "[KEY]         MT_AVLC_L"
            opcion11 = "[KEY]         MT_LCAV_L"
        End If

        If B = "M" Then
            opcion1 = "[KEY]         MT_AVLC_M"
            opcion11 = "[KEY]         MT_LCAV_M"
        End If
        If B = "O" Then
            opcion1 = "[KEY]         MT_AVLC_O"
            opcion11 = "[KEY]         MT_LCAV_O"
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
        C = ComboBox6.Text
        If C = "A" Then
            opcion2 = "[KEY]         MT_AVLC_A"
            opcion22 = "[KEY]         MT_LCAV_A"
        End If
        If C = "B" Then
            opcion2 = "[KEY]         MT_AVLC_B"
            opcion22 = "[KEY]         MT_LCAV_B"
        End If
        If C = "C" Then
            opcion2 = "[KEY]         MT_AVLC_C"
            opcion22 = "[KEY]         MT_LCAV_C"
        End If
        If C = "D" Then
            opcion2 = "[KEY]         MT_AVLC_D"
            opcion22 = "[KEY]         MT_LCAV_D"
        End If
        If C = "E" Then
            opcion2 = "[KEY]         MT_AVLC_E"
            opcion22 = "[KEY]         MT_LCAV_E"
        End If
        If C = "H" Then
            opcion2 = "[KEY]         MT_AVLC_H"
            opcion22 = "[KEY]         MT_LCAV_H"
        End If
        
        If C = "K" Then
            opcion2 = "[KEY]         MT_AVLC_K"
            opcion22 = "[KEY]         MT_LCAV_K"
        End If

        If C = "L" Then
            opcion2 = "[KEY]         MT_AVLC_L"
            opcion22 = "[KEY]         MT_LCAV_L"
        End If

        If C = "M" Then
            opcion2 = "[KEY]         MT_AVLC_M"
            opcion22 = "[KEY]         MT_LCAV_M"
        End If

        If C = "O" Then
            opcion2 = "[KEY]         MT_AVLC_O"
            opcion22 = "[KEY]         MT_LCAV_O"
        End If

        
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        D = ComboBox12.Text
        If D = "A" Then
            opcion3 = "[KEY]         MT_AVLC_A"
            opcion33 = "[KEY]         MT_LCAV_A"
        End If
        If D = "B" Then
            opcion3 = "[KEY]         MT_AVLC_B"
            opcion33 = "[KEY]         MT_LCAV_B"
        End If
        If D = "C" Then
            opcion3 = "[KEY]         MT_AVLC_C"
            opcion33 = "[KEY]         MT_LCAV_C"
        End If
        If D = "D" Then
            opcion3 = "[KEY]         MT_AVLC_D"
            opcion33 = "[KEY]         MT_LCAV_D"
        End If
        If D = "E" Then
            opcion3 = "[KEY]         MT_AVLC_E"
            opcion33 = "[KEY]         MT_LCAV_E"
        End If
        
        If D = "H" Then
            opcion3 = "[KEY]         MT_AVLC_H"
            opcion33 = "[KEY]         MT_LCAV_H"
        End If
        

        If D = "K" Then
            opcion3 = "[KEY]         MT_AVLC_K"
            opcion33 = "[KEY]         MT_LCAV_K"
        End If

        If D = "L" Then
            opcion3 = "[KEY]         MT_AVLC_L"
            opcion33 = "[KEY]         MT_LCAV_L"
        End If
        If D = "M" Then
            opcion3 = "[KEY]         MT_AVLC_M"
            opcion33 = "[KEY]         MT_LCAV_M"
        End If
        If D = "O" Then
            opcion3 = "[KEY]         MT_AVLC_O"
            opcion33 = "[KEY]         MT_LCAV_O"
        End If

       
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        F = ComboBox11.Text
        If F = "A" Then
            opcion4 = "[KEY]         MT_AVLC_A"
            opcion44 = "[KEY]         MT_LCAV_A"
        End If
        If F = "B" Then
            opcion4 = "[KEY]         MT_AVLC_B"
            opcion44 = "[KEY]         MT_LCAV_B"
        End If
        If F = "C" Then
            opcion4 = "[KEY]         MT_AVLC_C"
            opcion44 = "[KEY]         MT_LCAV_C"
        End If
        If F = "D" Then
            opcion4 = "[KEY]         MT_AVLC_D"
            opcion44 = "[KEY]         MT_LCAV_D"
        End If
        If F = "E" Then
            opcion4 = "[KEY]         MT_AVLC_E"
            opcion44 = "[KEY]         MT_LCAV_E"
        End If
        
        If F = "H" Then
            opcion4 = "[KEY]         MT_AVLC_H"
            opcion44 = "[KEY]         MT_LCAV_H"
        End If
       

        If F = "K" Then
            opcion4 = "[KEY]         MT_AVLC_K"
            opcion44 = "[KEY]         MT_LCAV_K"
        End If

        If F = "L" Then
            opcion4 = "[KEY]         MT_AVLC_L"
            opcion44 = "[KEY]         MT_LCAV_L"
        End If

        If F = "M" Then
            opcion4 = "[KEY]         MT_AVLC_M"
            opcion44 = "[KEY]         MT_LCAV_M"
        End If

       

        If F = "O" Then
            opcion4 = "[KEY]         MT_AVLC_O"
            opcion44 = "[KEY]         MT_LCAV_O"
        End If

      
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        G = ComboBox10.Text
        If G = "A" Then
            opcion5 = "[KEY]         MT_AVLC_A"
            opcion55 = "[KEY]         MT_LCAV_A"
        End If
        If G = "B" Then
            opcion5 = "[KEY]         MT_AVLC_B"
            opcion55 = "[KEY]         MT_LCAV_B"
        End If
        If G = "C" Then
            opcion5 = "[KEY]         MT_AVLC_C"
            opcion55 = "[KEY]         MT_LCAV_C"
        End If
        If G = "D" Then
            opcion5 = "[KEY]         MT_AVLC_D"
            opcion55 = "[KEY]         MT_LCAV_D"
        End If
        If G = "E" Then
            opcion5 = "[KEY]         MT_AVLC_E"
            opcion55 = "[KEY]         MT_LCAV_E"
        End If
        
        If G = "H" Then
            opcion5 = "[KEY]         MT_AVLC_H"
            opcion55 = "[KEY]         MT_LCAV_H"
        End If
       

        If G = "K" Then
            opcion5 = "[KEY]         MT_AVLC_K"
            opcion55 = "[KEY]         MT_LCAV_K"
        End If

        If G = "L" Then
            opcion5 = "[KEY]         MT_AVLC_L"
            opcion55 = "[KEY]         MT_LCAV_L"
        End If

        If G = "M" Then
            opcion5 = "[KEY]         MT_AVLC_M"
            opcion55 = "[KEY]         MT_LCAV_M"
        End If

        

        If G = "O" Then
            opcion5 = "[KEY]         MT_AVLC_O"
            opcion55 = "[KEY]         MT_LCAV_O"
        End If

       
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox15.SelectedIndexChanged
        H = ComboBox15.Text
        If H = "A" Then
            opcion6 = "[KEY]         MT_AVLC_A"
            opcion66 = "[KEY]         MT_LCAV_A"
        End If
        If H = "B" Then
            opcion6 = "[KEY]         MT_AVLC_B"
            opcion66 = "[KEY]         MT_LCAV_B"
        End If
        If H = "C" Then
            opcion6 = "[KEY]         MT_AVLC_C"
            opcion66 = "[KEY]         MT_LCAV_C"
        End If
        If H = "D" Then
            opcion6 = "[KEY]         MT_AVLC_D"
            opcion66 = "[KEY]         MT_LCAV_D"
        End If
        If H = "E" Then
            opcion6 = "[KEY]         MT_AVLC_E"
            opcion66 = "[KEY]         MT_LCAV_E"
        End If
       
        If H = "H" Then
            opcion6 = "[KEY]         MT_AVLC_H"
            opcion66 = "[KEY]         MT_LCAV_H"
        End If
        

        If H = "K" Then
            opcion6 = "[KEY]         MT_AVLC_K"
            opcion66 = "[KEY]         MT_LCAV_K"
        End If

        If H = "L" Then
            opcion6 = "[KEY]         MT_AVLC_L"
            opcion66 = "[KEY]         MT_LCAV_L"
        End If

        If H = "M" Then
            opcion6 = "[KEY]         MT_AVLC_M"
            opcion66 = "[KEY]         MT_LCAV_M"
        End If

        

        If H = "O" Then
            opcion6 = "[KEY]         MT_AVLC_O"
            opcion66 = "[KEY]         MT_LCAV_O"
        End If

       
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        L = ComboBox9.Text
        If L = "A" Then
            opcion7 = "[KEY]         MT_AVLC_A"
            opcion77 = "[KEY]         MT_LCAV_A"
        End If
        If L = "B" Then
            opcion7 = "[KEY]         MT_AVLC_B"
            opcion77 = "[KEY]         MT_LCAV_B"
        End If
        If L = "C" Then
            opcion7 = "[KEY]         MT_AVLC_C"
            opcion77 = "[KEY]         MT_LCAV_C"
        End If
        If L = "D" Then
            opcion7 = "[KEY]         MT_AVLC_D"
            opcion77 = "[KEY]         MT_LCAV_D"
        End If
        If L = "E" Then
            opcion7 = "[KEY]         MT_AVLC_E"
            opcion77 = "[KEY]         MT_LCAV_E"
        End If
        
        If L = "H" Then
            opcion7 = "[KEY]         MT_AVLC_H"
            opcion77 = "[KEY]         MT_LCAV_H"
        End If
       

        If L = "K" Then
            opcion7 = "[KEY]         MT_AVLC_K"
            opcion77 = "[KEY]         MT_LCAV_K"
        End If

        If L = "L" Then
            opcion7 = "[KEY]         MT_AVLC_L"
            opcion77 = "[KEY]         MT_LCAV_L"
        End If

        If L = "M" Then
            opcion7 = "[KEY]         MT_AVLC_M"
            opcion77 = "[KEY]         MT_LCAV_M"
        End If

        

        If L = "O" Then
            opcion7 = "[KEY]         MT_AVLC_O"
            opcion77 = "[KEY]         MT_LCAV_O"
        End If

        
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        M = ComboBox8.Text
        If M = "A" Then
            opcion8 = "[KEY]         MT_AVLC_A"
            opcion88 = "[KEY]         MT_LCAV_A"
        End If
        If M = "B" Then
            opcion8 = "[KEY]         MT_AVLC_B"
            opcion88 = "[KEY]         MT_LCAV_B"
        End If
        If M = "C" Then
            opcion8 = "[KEY]         MT_AVLC_C"
            opcion88 = "[KEY]         MT_LCAV_C"
        End If
        If M = "D" Then
            opcion8 = "[KEY]         MT_AVLC_D"
            opcion88 = "[KEY]         MT_LCAV_D"
        End If
        If M = "E" Then
            opcion8 = "[KEY]         MT_AVLC_E"
            opcion88 = "[KEY]         MT_LCAV_E"
        End If
        
        If M = "H" Then
            opcion8 = "[KEY]         MT_AVLC_H"
            opcion88 = "[KEY]         MT_LCAV_H"
        End If
      

        If M = "K" Then
            opcion8 = "[KEY]         MT_AVLC_K"
            opcion88 = "[KEY]         MT_LCAV_K"
        End If

        If M = "L" Then
            opcion8 = "[KEY]         MT_AVLC_L"
            opcion88 = "[KEY]         MT_LCAV_L"
        End If

        If M = "M" Then
            opcion8 = "[KEY]         MT_AVLC_M"
            opcion88 = "[KEY]         MT_LCAV_M"
        End If


        If M = "O" Then
            opcion8 = "[KEY]         MT_AVLC_O"
            opcion88 = "[KEY]         MT_LCAV_O"
        End If

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class