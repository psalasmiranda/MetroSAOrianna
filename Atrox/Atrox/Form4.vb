Imports System.IO
Imports System.Text
Imports System.Collections



Public Class Form4
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

        Dim vallev1, vallev2, dsv1, dsv2, dfv1, dfv2, matrizV1(33, 10), matrizV2(33, 10) As String

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

        'Dim complemento As String = "[HRG_BTAN]    "

        ''datos via 1
        'For i = 1 To 22
        '    PAMV_V1 = PAMV_V1 + matrizV1(i, 1) + ","
        'Next
        'PAMV_V1 = complemento & PAMV_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        'For i = 1 To 22
        '    PPMV_V1 = PPMV_V1 + matrizV1(i, 2) + ","
        'Next
        'PPMV_V1 = complemento & PPMV_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    PAMR_V1 = PAMR_V1 + matrizV1(i, 2) + ","
        'Next
        'PAMR_V1 = complemento & PAMR_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    PPMR_V1 = PPMR_V1 + matrizV1(i, 2) + ","
        'Next
        'PPMR_V1 = complemento & PPMR_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        'For i = 1 To 22
        '    PREPAM_V1 = PREPAM_V1 + matrizV1(i, 2) + ","
        'Next
        'PREPAM_V1 = complemento & PREPAM_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    VALLE_V1 = VALLE_V1 + matrizV1(i, 2) + ","
        'Next
        'VALLE_V1 = complemento & VALLE_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    NOCHE_V1 = NOCHE_V1 + matrizV1(i, 2) + ","
        'Next
        'NOCHE_V1 = complemento & NOCHE_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    DS_V1 = DS_V1 + matrizV1(i, 2) + ","
        'Next
        'DS_V1 = complemento & DS_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    DF_V1 = DF_V1 + matrizV1(i, 2) + ","
        'Next
        'DF_V1 = complemento & DF_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    PAMV_V2 = PAMV_V2 + matrizV1(i, 1) + ","
        'Next
        'PAMV_V2 = complemento & PAMV_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        'For i = 1 To 22
        '    PPMV_V2 = PPMV_V2 + matrizV1(i, 2) + ","
        'Next
        'PPMV_V2 = complemento & PPMV_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    PAMR_V2 = PAMR_V2 + matrizV1(i, 2) + ","
        'Next
        'PAMR_V2 = complemento & PAMR_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    PPMR_V2 = PPMR_V2 + matrizV1(i, 2) + ","
        'Next
        'PPMR_V2 = complemento & PPMR_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        'For i = 1 To 22
        '    PREPAM_V2 = PREPAM_V2 + matrizV1(i, 2) + ","
        'Next
        'PREPAM_V2 = complemento & PREPAM_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    VALLE_V2 = VALLE_V2 + matrizV1(i, 2) + ","
        'Next
        'VALLE_V2 = complemento & VALLE_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    NOCHE_V2 = NOCHE_V2 + matrizV1(i, 2) + ","
        'Next
        'NOCHE_V2 = complemento & NOCHE_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    DS_V2 = DS_V2 + matrizV1(i, 2) + ","
        'Next
        'DS_V2 = complemento & DS_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        'For i = 1 To 22
        '    DF_V2 = DF_V2 + matrizV1(i, 2) + ","
        'Next
        'DF_V2 = complemento & DF_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")





        'Dim out_path, out_origin As String
        'out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\AntiguoL2.txt"
        'out_origin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\CambioL2.txt"
        'Using sw As StreamWriter = New StreamWriter(out_path)
        '    Using sh As StreamWriter = New StreamWriter(out_origin)
        '        sw.Write("!-----Oriana V.1.0 Document -------" & vbLf)
        '        sw.Write("!-----Cambios según marchas -------" & vbLf)
        '        sw.Write("!----------------------------------" & vbLf)
        '        sh.Write("!-----Oriana V.1.0 Document -------" & vbLf)
        '        sh.Write("!-----Cambios según marchas -------" & vbLf)
        '        sh.Write("!----------------------------------" & vbLf)
        '        For i = 0 To archivo_final.Length - 5



        '            If archivo_final(i) = opcion Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = PAMV_V1
        '                    sh.Write(opcion)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion0 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion0)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = PAMV_V2
        '                    sh.Write(opcion0)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If

        '            '--------------------------


        '            If archivo_final(i) = opcion1 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion1)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = PPMV_V1
        '                    sh.Write(opcion1)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion11 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion11)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = PPMV_V2
        '                    sh.Write(opcion11)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If
        '            '-------------------------


        '            If archivo_final(i) = opcion2 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion2)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = PAMR_V1
        '                    sh.Write(opcion2)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion22 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion22)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = PAMR_V2
        '                    sh.Write(opcion22)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If

        '            '-------------------------

        '            If archivo_final(i) = opcion3 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion3)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = PPMR_V1
        '                    sh.Write(opcion3)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion33 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion33)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = PPMR_V2
        '                    sh.Write(opcion33)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If
        '            '---------------------


        '            If archivo_final(i) = opcion4 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion4)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = PREPAM_V1
        '                    sh.Write(opcion4)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion44 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion44)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = PREPAM_V2
        '                    sh.Write(opcion44)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If

        '            '-----------


        '            If archivo_final(i) = opcion5 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion5)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = VALLE_V1
        '                    sh.Write(opcion5)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion55 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion55)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = VALLE_V2
        '                    sh.Write(opcion55)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If
        '            '------------------


        '            If archivo_final(i) = opcion6 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion6)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = NOCHE_V1
        '                    sh.Write(opcion6)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion66 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion66)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = NOCHE_V2
        '                    sh.Write(opcion66)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If
        '            '------------------


        '            If archivo_final(i) = opcion7 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion7)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = DS_V1
        '                    sh.Write(opcion7)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion77 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion77)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = DS_V2
        '                    sh.Write(opcion77)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If
        '            '---------------


        '            If archivo_final(i) = opcion8 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" Then
        '                    sw.Write(opcion8)
        '                    sw.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)

        '                    archivo_final(i + 5) = DF_V1
        '                    sh.Write(opcion8)
        '                    sh.Write("[HRG_ARRETS]  AV_V1,ZA_V1,DO_V1,EI_V1,CE_V1,CB_V1,PT_V1,CA_V1,AN_V1,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              CN_V1,LO_V1,EP_V1,LC_V1" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)

        '                End If
        '            End If

        '            If archivo_final(i) = opcion88 Then
        '                If archivo_final(i + 2) = "[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" Then
        '                    sw.Write(opcion88)
        '                    sw.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sw.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sw.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sw.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sw.Write(archivo_final(i + 5) & vbLf)
        '                    archivo_final(i + 5) = DF_V2
        '                    sh.Write(opcion88)
        '                    sh.Write("[HRG_ARRETS]  LC_V2,EP_V2,LO_V2,CN_V2,DE_V2,LV_V2,SM_V2,LL_V2,FR_V2,+" & vbLf)
        '                    sh.Write("              RO_V2,PQ_V2,TO_V2,HE_V2,AN_V2,CA_V2,PT_V2,CB_V2,CE_V2,+" & vbLf)
        '                    sh.Write("              EI_V2,DO_V2,ZA_V2,AV_V2" & vbLf)
        '                    sh.Write("Se modifica línea:" & i + 5 & vbLf)
        '                    sh.Write(archivo_final(i + 5) & vbLf)
        '                End If
        '            End If



        '        Next



        '    End Using
        'End Using



        'MsgBox("archivo generado")







        'out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mtL2.conf"

        'Using sw As StreamWriter = New StreamWriter(out_path)

        '    sw.Write("!-----Oriana V.1.0 Document -------")

        '    For i = 0 To texto_vias.Length

        '        sw.Write(archivo_final(i) & vbLf)

        '    Next




        'End Using
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

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        documento = Me.ComboBox1.SelectedItem
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        documento1 = Me.ComboBox2.SelectedItem
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        documento2 = Me.ComboBox3.SelectedItem
    End Sub
End Class