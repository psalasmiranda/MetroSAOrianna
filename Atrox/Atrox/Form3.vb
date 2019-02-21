Imports System.IO
Imports System.Text
Imports System.Collections



Public Class Form3

    'Variables publicas
    Public bruta, bruta1, bruta2 As String
    Public opcion, opcion1, opcion2, opcion3, opcion4, opcion5, opcion6, opcion7, opcion8, opcion9, opcion10 As String
    Public documento, documento1, documento2 As String
    'Funciones para dar origen al archivo
    Public A, B, C, D, F, G, H, L, M, N As String
    Sub Copia()
        Dim i, j, k, largo As Integer
        Dim via1 As String = My.Computer.FileSystem.ReadAllText(bruta & "\" & documento)
        Dim via2 As String = My.Computer.FileSystem.ReadAllText(bruta1 & "\" & documento1)
        Dim via3 As String = My.Computer.FileSystem.ReadAllText(bruta2 & "\" & documento2)

        Dim vallev1, vallev2, dsv1, dsv2, dfv1, dfv2, matrizV1(23, 10), matrizV2(23, 10) As String

        Dim PAMV_V1, PAMR_V1, PPAV_V1, PPAR_V1, OPEXVALLEAM_V1, OPEXVALLEPM_V1, VALLE_V1, NOCHE_V1, DS_V1, DF_V1 As String
        Dim PAMV_V2, PAMR_V2, PPAV_V2, PPAR_V2, OPEXVALLEAM_V2, OPEXVALLEPM_V2, VALLE_V2, NOCHE_V2, DS_V2, DF_V2 As String
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
        For i = 0 To 23
            For j = 0 To 10
                matrizV1(i, j) = prio2(k)
                k = k + 1
            Next

        Next
        k = 0
        For i = 0 To 23
            For j = 0 To 10
                matrizV2(i, j) = prio3(k)
                k = k + 1
            Next

        Next

        Dim complemento As String = "[HRG_BTAN]    "

        'datos via 1
        For i = 1 To 23
            PAMV_V1 = PAMV_V1 + matrizV1(i, 1)
        Next

        PAMV_V1 = complemento & PAMV_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            OPEXVALLEAM_V1 = OPEXVALLEAM_V1 + matrizV1(i, 2) + ","
        Next

        OPEXVALLEAM_V1 = complemento & OPEXVALLEAM_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            PPAV_V1 = PPAV_V1 + matrizV1(i, 3) + ","
        Next
        PPAV_V1 = complemento & PPAV_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            PAMR_V1 = PAMR_V1 + matrizV1(i, 4) + ","
        Next
        PAMR_V1 = complemento & PAMR_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            OPEXVALLEPM_V1 = OPEXVALLEPM_V1 + matrizV1(i, 5) + ","
        Next
        OPEXVALLEPM_V1 = complemento & OPEXVALLEPM_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")


        For i = 1 To 23
            PPAR_V1 = PPAR_V1 + matrizV1(i, 6)
        Next
        PPAR_V1 = complemento & PPAR_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 23
            VALLE_V1 = VALLE_V1 + matrizV1(i, 7)
        Next
        VALLE_V1 = complemento + VALLE_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            NOCHE_V1 = NOCHE_V1 + matrizV1(i, 8)
        Next
        NOCHE_V1 = complemento.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 23
            DS_V1 = DS_V1 + matrizV1(i, 9)
        Next
        DS_V1 = complemento & DS_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            DF_V1 = DF_V1 + matrizV1(i, 10)
        Next
        DF_V1 = complemento & DF_V1.Replace(vbTab, ",").Replace("-", "0").Trim(",")



        'datos via 2
        For i = 1 To 23
            PAMV_V2 = PAMV_V2 + matrizV2(i, 1)
        Next

        PAMV_V2 = complemento & PAMV_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            OPEXVALLEAM_V2 = OPEXVALLEAM_V2 + matrizV2(i, 2)
        Next

        OPEXVALLEAM_V2 = complemento & OPEXVALLEAM_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            PPAV_V2 = PPAV_V2 + matrizV2(i, 3)
        Next
        PPAV_V2 = complemento & PPAV_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            PAMR_V2 = PAMR_V2 + matrizV2(i, 4)
        Next
        PAMR_V2 = complemento & PAMR_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            OPEXVALLEPM_V2 = OPEXVALLEPM_V2 + matrizV2(i, 5)
        Next
        OPEXVALLEPM_V2 = complemento & OPEXVALLEPM_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")


        For i = 1 To 23
            PPAR_V2 = PPAR_V2 + matrizV2(i, 6)
        Next
        PPAR_V2 = complemento & PPAR_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 23
            VALLE_V2 = VALLE_V2 + matrizV2(i, 7)
        Next
        VALLE_V2 = complemento + VALLE_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            NOCHE_V2 = NOCHE_V2 + matrizV2(i, 8)
        Next
        NOCHE_V2 = complemento.Replace(vbTab, ",").Replace("-", "0").Trim(",")

        For i = 1 To 23
            DS_V2 = DS_V2 + matrizV2(i, 9)
        Next
        DS_V2 = complemento & DS_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")
        For i = 1 To 23
            DF_V2 = DF_V2 + matrizV2(i, 10)
        Next
        DF_V2 = complemento & DF_V2.Replace(vbTab, ",").Replace("-", "0").Trim(",")



        Dim out_path, out_origin As String
        out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\AntiguoL4.txt"
        out_origin = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\CambioL4.txt"
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

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PAMV_V1
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PAMV_V2
                            sh.Write(opcion)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If

                    If archivo_final(i) = opcion1 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion1)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = OPEXVALLEAM_V1
                            sh.Write(opcion1)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion1)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = OPEXVALLEAM_V2
                            sh.Write(opcion1)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If

                    End If
                    If archivo_final(i) = opcion2 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion2)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PPAV_V1
                            sh.Write(opcion2)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion2)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PPAV_V2
                            sh.Write(opcion2)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                    If archivo_final(i) = opcion3 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion3)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PAMR_V1
                            sh.Write(opcion3)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion3)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PAMR_V2
                            sh.Write(opcion3)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                    If archivo_final(i) = opcion4 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion4)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = OPEXVALLEPM_V1
                            sh.Write(opcion4)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion4)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = OPEXVALLEPM_V2
                            sh.Write(opcion4)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                    If archivo_final(i) = opcion5 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion5)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PPAR_V1
                            sh.Write(opcion5)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion5)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = PPAR_V2
                            sh.Write(opcion5)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                    If archivo_final(i) = opcion6 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion6)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = VALLE_V1
                            sh.Write(opcion6)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion6)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = VALLE_V2
                            sh.Write(opcion6)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                    If archivo_final(i) = opcion7 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion7)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = NOCHE_V1
                            sh.Write(opcion7)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion7)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = NOCHE_V2
                            sh.Write(opcion7)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                    If archivo_final(i) = opcion8 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion8)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = DS_V1
                            sh.Write(opcion8)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion8)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = DS_V2
                            sh.Write(opcion8)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                    If archivo_final(i) = opcion9 Then

                        If archivo_final(i + 2) = "[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" Then


                            sw.Write(opcion9)
                            sw.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = DF_V1
                            sh.Write(opcion9)
                            sh.Write("[HRG_ARRETS]  TOB_V1,COL_V1,BIL_V1,PDG_V1,SBO_V1,PEG_V1,LOR_V1,RGR_V1,LPR_V1,RQU_V1,LTO_V1,MAC_V1,VMA_V1,VVA_V1,RMA_V1,TRI_V1,SJE_V1,LQU_V1,ECO_V1,HSR_V1,PIN_V1,LME_V1,PPA_V11" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                        If archivo_final(i + 2) = "[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" Then
                            sw.Write(opcion9)
                            sw.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sw.Write("Se modifica línea:" & i + 4 & vbLf)
                            sw.Write(archivo_final(i + 3) & vbLf)

                            archivo_final(i + 3) = DF_V2
                            sh.Write(opcion9)
                            sh.Write("[HRG_ARRETS]  PPA_V2,LME_V2,PIN_V2,HSR_V2,ECO_V2,LQU_V2,SJE_V2,TRI_V2,RMA_V2,VVA_V2,VMA_V2,MAC_V2,LTO_V2,RQU_V2,LPR_V2,RGR_V2,LOR_V2,PEG_V2,SBO_V2,PDG_V2,BIL_V2,COL_V2,TOB_V2" & vbLf)
                            sh.Write("Se modifica línea:" & i + 4 & vbLf)
                            sh.Write(archivo_final(i + 3) & vbLf)

                        End If
                    End If
                Next



            End Using
        End Using



        MsgBox("archivo generado")







        out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mtL4.conf"

        Using sw As StreamWriter = New StreamWriter(out_path)

            sw.Write("!-----Oriana V.1.0 Document -------")

            For i = 0 To texto_vias.Length

                sw.Write(archivo_final(i) & vbLf)

            Next




        End Using
        'Dim lectura1, lectura2 As String


        'MsgBox("archivo generado")







        'out_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\mtL4.conf"

        'Using sw As StreamWriter = New StreamWriter(out_path)

        '    sw.Write("!-----Oriana V.1.0 Document -------")


        '    For i = 0 To texto_vias.Length

        '        sw.Write(archivo_final(i) & vbLf)

        '    Next




        'End Using





        ''var = vallev1.Replace(vbTab, ",").Replace("-", "0")
        ''Dim charArray() As Char = var.ToCharArray
        ''For i = 0 To charArray.Length
        ''    If i = 0 Then
        ''        charArray(0) = ""
        ''    End If

        ''Next







        ''Dim largo As Integer = texto.Length
        ''For i = 0 To largo
        ''    'If "[LABEL]       C" = texto(i) Then
        ''    '    MsgBox("encontrado")
        ''    'End If
        ''Next

    End Sub
    'Boton Generar archivo
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Copia()
    End Sub

    '----------------------------------------------------------------------------------------------------------

    '---------------------------------------------------------------------------------------------------------

    
 
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

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Copia()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
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
        If A = "F" Then
            opcion = "[LABEL]       F"
        End If
        If A = "G" Then
            opcion = "[LABEL]       G"
        End If
        If A = "H" Then
            opcion = "[LABEL]       H"
        End If
        If A = "I" Then
            opcion = "[LABEL]       I"
        End If
        If A = "E" Then
            opcion = "[LABEL]       E"
        End If

        If A = "J" Then
            opcion = "[LABEL]       J"
        End If

        If A = "K" Then
            opcion = "[LABEL]       K"
        End If

        If A = "L" Then
            opcion = "[LABEL]       L"
        End If

        If A = "M" Then
            opcion = "[LABEL]       M"
        End If

        If A = "N" Then
            opcion = "[LABEL]       N"
        End If

        If A = "O" Then
            opcion = "[LABEL]       O"
        End If

        If A = "P" Then
            opcion = "[LABEL]       E"
        End If

        If A = "Q" Then
            opcion = "[LABEL]       Q"
        End If

        If A = "R" Then
            opcion = "[LABEL]       R"
        End If
        If A = "S" Then
            opcion = "[LABEL]       S"
        End If
        If A = "T" Then
            opcion = "[LABEL]       T"
        End If
        If A = "U" Then
            opcion = "[LABEL]       U"
        End If
        If A = "V" Then
            opcion = "[LABEL]       V"
        End If
        If A = "W" Then
            opcion = "[LABEL]       W"
        End If
        If A = "X" Then
            opcion = "[LABEL]       Q"
        End If
        If A = "Q" Then
            opcion = "[LABEL]       X"
        End If
        If A = "Y" Then
            opcion = "[LABEL]       Y"
        End If
        If A = "Z" Then
            opcion = "[LABEL]       Z"
        End If

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
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
        If B = "F" Then
            opcion1 = "[LABEL]       F"
        End If
        If B = "G" Then
            opcion1 = "[LABEL]       G"
        End If
        If B = "H" Then
            opcion1 = "[LABEL]       H"
        End If
        If B = "I" Then
            opcion1 = "[LABEL]       I"
        End If
        If B = "E" Then
            opcion1 = "[LABEL]       E"
        End If

        If B = "J" Then
            opcion1 = "[LABEL]       J"
        End If

        If B = "K" Then
            opcion1 = "[LABEL]       K"
        End If

        If B = "L" Then
            opcion1 = "[LABEL]       L"
        End If

        If B = "M" Then
            opcion1 = "[LABEL]       M"
        End If

        If B = "N" Then
            opcion1 = "[LABEL]       N"
        End If

        If B = "O" Then
            opcion1 = "[LABEL]       O"
        End If

        If B = "P" Then
            opcion1 = "[LABEL]       E"
        End If

        If B = "Q" Then
            opcion1 = "[LABEL]       Q"
        End If

        If B = "R" Then
            opcion1 = "[LABEL]       R"
        End If
        If B = "S" Then
            opcion1 = "[LABEL]       S"
        End If
        If B = "T" Then
            opcion1 = "[LABEL]       T"
        End If
        If B = "U" Then
            opcion1 = "[LABEL]       U"
        End If
        If B = "V" Then
            opcion1 = "[LABEL]       V"
        End If
        If B = "W" Then
            opcion1 = "[LABEL]       W"
        End If
        If B = "X" Then
            opcion1 = "[LABEL]       Q"
        End If
        If B = "Q" Then
            opcion1 = "[LABEL]       X"
        End If
        If B = "Y" Then
            opcion1 = "[LABEL]       Y"
        End If
        If B = "Z" Then
            opcion1 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox6.SelectedIndexChanged
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
        If C = "F" Then
            opcion2 = "[LABEL]       F"
        End If
        If C = "G" Then
            opcion2 = "[LABEL]       G"
        End If
        If C = "H" Then
            opcion2 = "[LABEL]       H"
        End If
        If C = "I" Then
            opcion2 = "[LABEL]       I"
        End If
        If C = "E" Then
            opcion2 = "[LABEL]       E"
        End If

        If C = "J" Then
            opcion2 = "[LABEL]       J"
        End If

        If C = "K" Then
            opcion2 = "[LABEL]       K"
        End If

        If C = "L" Then
            opcion2 = "[LABEL]       L"
        End If

        If C = "M" Then
            opcion2 = "[LABEL]       M"
        End If

        If C = "N" Then
            opcion2 = "[LABEL]       N"
        End If

        If C = "O" Then
            opcion2 = "[LABEL]       O"
        End If

        If C = "P" Then
            opcion2 = "[LABEL]       E"
        End If

        If C = "Q" Then
            opcion2 = "[LABEL]       Q"
        End If

        If C = "R" Then
            opcion2 = "[LABEL]       R"
        End If
        If C = "S" Then
            opcion2 = "[LABEL]       S"
        End If
        If C = "T" Then
            opcion2 = "[LABEL]       T"
        End If
        If C = "U" Then
            opcion2 = "[LABEL]       U"
        End If
        If C = "V" Then
            opcion2 = "[LABEL]       V"
        End If
        If C = "W" Then
            opcion2 = "[LABEL]       W"
        End If
        If C = "X" Then
            opcion2 = "[LABEL]       Q"
        End If
        If C = "Q" Then
            opcion2 = "[LABEL]       X"
        End If
        If C = "Y" Then
            opcion2 = "[LABEL]       Y"
        End If
        If C = "Z" Then
            opcion2 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        documento = Me.ComboBox1.SelectedItem
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        documento1 = Me.ComboBox2.SelectedItem
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged
        documento2 = Me.ComboBox3.SelectedItem
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox12.SelectedIndexChanged
        D = ComboBox12.Text
        If D = "A" Then
            opcion3 = "[LABEL]       A"
        End If
        If D = "B" Then
            opcion3 = "[LABEL]       B"
        End If
        If D = "C" Then
            opcion3 = "[LABEL]       C"
        End If
        If D = "D" Then
            opcion3 = "[LABEL]       D"
        End If
        If D = "E" Then
            opcion3 = "[LABEL]       E"
        End If
        If D = "F" Then
            opcion3 = "[LABEL]       F"
        End If
        If D = "G" Then
            opcion3 = "[LABEL]       G"
        End If
        If D = "H" Then
            opcion3 = "[LABEL]       H"
        End If
        If D = "I" Then
            opcion3 = "[LABEL]       I"
        End If
        If D = "E" Then
            opcion3 = "[LABEL]       E"
        End If

        If D = "J" Then
            opcion3 = "[LABEL]       J"
        End If

        If D = "K" Then
            opcion3 = "[LABEL]       K"
        End If

        If D = "L" Then
            opcion3 = "[LABEL]       L"
        End If

        If D = "M" Then
            opcion3 = "[LABEL]       M"
        End If

        If D = "N" Then
            opcion3 = "[LABEL]       N"
        End If

        If D = "O" Then
            opcion3 = "[LABEL]       O"
        End If

        If D = "P" Then
            opcion3 = "[LABEL]       E"
        End If

        If D = "Q" Then
            opcion3 = "[LABEL]       Q"
        End If

        If D = "R" Then
            opcion3 = "[LABEL]       R"
        End If
        If D = "S" Then
            opcion3 = "[LABEL]       S"
        End If
        If D = "T" Then
            opcion3 = "[LABEL]       T"
        End If
        If D = "U" Then
            opcion3 = "[LABEL]       U"
        End If
        If D = "V" Then
            opcion3 = "[LABEL]       V"
        End If
        If D = "W" Then
            opcion3 = "[LABEL]       W"
        End If
        If D = "X" Then
            opcion3 = "[LABEL]       Q"
        End If
        If D = "Q" Then
            opcion3 = "[LABEL]       X"
        End If
        If D = "Y" Then
            opcion3 = "[LABEL]       Y"
        End If
        If D = "Z" Then
            opcion3 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox11_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox11.SelectedIndexChanged
        F = ComboBox11.Text
        If F = "A" Then
            opcion4 = "[LABEL]       A"
        End If
        If F = "B" Then
            opcion4 = "[LABEL]       B"
        End If
        If F = "C" Then
            opcion4 = "[LABEL]       C"
        End If
        If F = "D" Then
            opcion4 = "[LABEL]       D"
        End If
        If F = "E" Then
            opcion4 = "[LABEL]       E"
        End If
        If F = "F" Then
            opcion4 = "[LABEL]       F"
        End If
        If F = "G" Then
            opcion4 = "[LABEL]       G"
        End If
        If F = "H" Then
            opcion4 = "[LABEL]       H"
        End If
        If F = "I" Then
            opcion4 = "[LABEL]       I"
        End If
        If F = "E" Then
            opcion4 = "[LABEL]       E"
        End If

        If F = "J" Then
            opcion4 = "[LABEL]       J"
        End If

        If F = "K" Then
            opcion4 = "[LABEL]       K"
        End If

        If F = "L" Then
            opcion4 = "[LABEL]       L"
        End If

        If F = "M" Then
            opcion4 = "[LABEL]       M"
        End If

        If F = "N" Then
            opcion4 = "[LABEL]       N"
        End If

        If F = "O" Then
            opcion4 = "[LABEL]       O"
        End If

        If F = "P" Then
            opcion4 = "[LABEL]       E"
        End If

        If F = "Q" Then
            opcion4 = "[LABEL]       Q"
        End If

        If F = "R" Then
            opcion4 = "[LABEL]       R"
        End If
        If F = "S" Then
            opcion4 = "[LABEL]       S"
        End If
        If F = "T" Then
            opcion4 = "[LABEL]       T"
        End If
        If F = "U" Then
            opcion4 = "[LABEL]       U"
        End If
        If F = "V" Then
            opcion4 = "[LABEL]       V"
        End If
        If F = "W" Then
            opcion4 = "[LABEL]       W"
        End If
        If F = "X" Then
            opcion4 = "[LABEL]       Q"
        End If
        If F = "Q" Then
            opcion4 = "[LABEL]       X"
        End If
        If F = "Y" Then
            opcion4 = "[LABEL]       Y"
        End If
        If F = "Z" Then
            opcion4 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox10.SelectedIndexChanged
        G = ComboBox10.Text
        If G = "A" Then
            opcion5 = "[LABEL]       A"
        End If
        If G = "B" Then
            opcion5 = "[LABEL]       B"
        End If
        If G = "C" Then
            opcion5 = "[LABEL]       C"
        End If
        If G = "D" Then
            opcion5 = "[LABEL]       D"
        End If
        If G = "E" Then
            opcion5 = "[LABEL]       E"
        End If
        If G = "F" Then
            opcion5 = "[LABEL]       F"
        End If
        If G = "G" Then
            opcion5 = "[LABEL]       G"
        End If
        If G = "H" Then
            opcion5 = "[LABEL]       H"
        End If
        If G = "I" Then
            opcion5 = "[LABEL]       I"
        End If
        If G = "E" Then
            opcion5 = "[LABEL]       E"
        End If

        If G = "J" Then
            opcion5 = "[LABEL]       J"
        End If

        If G = "K" Then
            opcion5 = "[LABEL]       K"
        End If

        If G = "L" Then
            opcion5 = "[LABEL]       L"
        End If

        If G = "M" Then
            opcion5 = "[LABEL]       M"
        End If

        If G = "N" Then
            opcion5 = "[LABEL]       N"
        End If

        If G = "O" Then
            opcion5 = "[LABEL]       O"
        End If

        If G = "P" Then
            opcion5 = "[LABEL]       E"
        End If

        If G = "Q" Then
            opcion5 = "[LABEL]       Q"
        End If

        If G = "R" Then
            opcion5 = "[LABEL]       R"
        End If
        If G = "S" Then
            opcion5 = "[LABEL]       S"
        End If
        If G = "T" Then
            opcion5 = "[LABEL]       T"
        End If
        If G = "U" Then
            opcion5 = "[LABEL]       U"
        End If
        If G = "V" Then
            opcion5 = "[LABEL]       V"
        End If
        If G = "W" Then
            opcion5 = "[LABEL]       W"
        End If
        If G = "X" Then
            opcion5 = "[LABEL]       Q"
        End If
        If G = "Q" Then
            opcion5 = "[LABEL]       X"
        End If
        If G = "Y" Then
            opcion5 = "[LABEL]       Y"
        End If
        If G = "Z" Then
            opcion5 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox15_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox15.SelectedIndexChanged
        H = ComboBox15.Text
        If H = "A" Then
            opcion6 = "[LABEL]       A"
        End If
        If H = "B" Then
            opcion6 = "[LABEL]       B"
        End If
        If H = "C" Then
            opcion6 = "[LABEL]       C"
        End If
        If H = "D" Then
            opcion6 = "[LABEL]       D"
        End If
        If H = "E" Then
            opcion6 = "[LABEL]       E"
        End If
        If H = "F" Then
            opcion6 = "[LABEL]       F"
        End If
        If H = "G" Then
            opcion6 = "[LABEL]       G"
        End If
        If H = "H" Then
            opcion6 = "[LABEL]       H"
        End If
        If H = "I" Then
            opcion6 = "[LABEL]       I"
        End If
        If H = "E" Then
            opcion6 = "[LABEL]       E"
        End If

        If H = "J" Then
            opcion6 = "[LABEL]       J"
        End If

        If H = "K" Then
            opcion6 = "[LABEL]       K"
        End If

        If H = "L" Then
            opcion6 = "[LABEL]       L"
        End If

        If H = "M" Then
            opcion6 = "[LABEL]       M"
        End If

        If H = "N" Then
            opcion6 = "[LABEL]       N"
        End If

        If H = "O" Then
            opcion6 = "[LABEL]       O"
        End If

        If H = "P" Then
            opcion6 = "[LABEL]       E"
        End If

        If H = "Q" Then
            opcion6 = "[LABEL]       Q"
        End If

        If H = "R" Then
            opcion6 = "[LABEL]       R"
        End If
        If H = "S" Then
            opcion6 = "[LABEL]       S"
        End If
        If H = "T" Then
            opcion6 = "[LABEL]       T"
        End If
        If H = "U" Then
            opcion6 = "[LABEL]       U"
        End If
        If H = "V" Then
            opcion6 = "[LABEL]       V"
        End If
        If H = "W" Then
            opcion6 = "[LABEL]       W"
        End If
        If H = "X" Then
            opcion6 = "[LABEL]       Q"
        End If
        If H = "Q" Then
            opcion6 = "[LABEL]       X"
        End If
        If H = "Y" Then
            opcion6 = "[LABEL]       Y"
        End If
        If H = "Z" Then
            opcion6 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox14_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox14.SelectedIndexChanged
        L = ComboBox14.Text
        If L = "A" Then
            opcion7 = "[LABEL]       A"
        End If
        If L = "B" Then
            opcion7 = "[LABEL]       B"
        End If
        If L = "C" Then
            opcion7 = "[LABEL]       C"
        End If
        If L = "D" Then
            opcion7 = "[LABEL]       D"
        End If
        If L = "E" Then
            opcion7 = "[LABEL]       E"
        End If
        If L = "F" Then
            opcion7 = "[LABEL]       F"
        End If
        If L = "G" Then
            opcion7 = "[LABEL]       G"
        End If
        If L = "H" Then
            opcion7 = "[LABEL]       H"
        End If
        If L = "I" Then
            opcion7 = "[LABEL]       I"
        End If
        If L = "E" Then
            opcion7 = "[LABEL]       E"
        End If

        If L = "J" Then
            opcion7 = "[LABEL]       J"
        End If

        If L = "K" Then
            opcion7 = "[LABEL]       K"
        End If

        If L = "L" Then
            opcion7 = "[LABEL]       L"
        End If

        If L = "M" Then
            opcion7 = "[LABEL]       M"
        End If

        If L = "N" Then
            opcion7 = "[LABEL]       N"
        End If

        If L = "O" Then
            opcion7 = "[LABEL]       O"
        End If

        If L = "P" Then
            opcion7 = "[LABEL]       E"
        End If

        If L = "Q" Then
            opcion7 = "[LABEL]       Q"
        End If

        If L = "R" Then
            opcion7 = "[LABEL]       R"
        End If
        If L = "S" Then
            opcion7 = "[LABEL]       S"
        End If
        If L = "T" Then
            opcion7 = "[LABEL]       T"
        End If
        If L = "U" Then
            opcion7 = "[LABEL]       U"
        End If
        If L = "V" Then
            opcion7 = "[LABEL]       V"
        End If
        If L = "W" Then
            opcion7 = "[LABEL]       W"
        End If
        If L = "X" Then
            opcion7 = "[LABEL]       Q"
        End If
        If L = "Q" Then
            opcion7 = "[LABEL]       X"
        End If
        If L = "Y" Then
            opcion7 = "[LABEL]       Y"
        End If
        If L = "Z" Then
            opcion7 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox9_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox9.SelectedIndexChanged
        M = ComboBox9.Text
        If M = "A" Then
            opcion8 = "[LABEL]       A"
        End If
        If M = "B" Then
            opcion8 = "[LABEL]       B"
        End If
        If M = "C" Then
            opcion8 = "[LABEL]       C"
        End If
        If M = "D" Then
            opcion8 = "[LABEL]       D"
        End If
        If M = "E" Then
            opcion8 = "[LABEL]       E"
        End If
        If M = "F" Then
            opcion8 = "[LABEL]       F"
        End If
        If M = "G" Then
            opcion8 = "[LABEL]       G"
        End If
        If M = "H" Then
            opcion8 = "[LABEL]       H"
        End If
        If M = "I" Then
            opcion8 = "[LABEL]       I"
        End If
        If M = "E" Then
            opcion8 = "[LABEL]       E"
        End If

        If M = "J" Then
            opcion8 = "[LABEL]       J"
        End If

        If M = "K" Then
            opcion8 = "[LABEL]       K"
        End If

        If M = "L" Then
            opcion8 = "[LABEL]       L"
        End If

        If M = "M" Then
            opcion8 = "[LABEL]       M"
        End If

        If M = "N" Then
            opcion8 = "[LABEL]       N"
        End If

        If M = "O" Then
            opcion8 = "[LABEL]       O"
        End If

        If M = "P" Then
            opcion8 = "[LABEL]       E"
        End If

        If M = "Q" Then
            opcion8 = "[LABEL]       Q"
        End If

        If M = "R" Then
            opcion8 = "[LABEL]       R"
        End If
        If M = "S" Then
            opcion8 = "[LABEL]       S"
        End If
        If M = "T" Then
            opcion8 = "[LABEL]       T"
        End If
        If M = "U" Then
            opcion8 = "[LABEL]       U"
        End If
        If M = "V" Then
            opcion8 = "[LABEL]       V"
        End If
        If M = "W" Then
            opcion8 = "[LABEL]       W"
        End If
        If M = "X" Then
            opcion8 = "[LABEL]       Q"
        End If
        If M = "Q" Then
            opcion8 = "[LABEL]       X"
        End If
        If M = "Y" Then
            opcion8 = "[LABEL]       Y"
        End If
        If M = "Z" Then
            opcion8 = "[LABEL]       Z"
        End If
    End Sub

    Private Sub ComboBox8_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox8.SelectedIndexChanged
        N = ComboBox8.Text
        If N = "A" Then
            opcion9 = "[LABEL]       A"
        End If
        If N = "B" Then
            opcion9 = "[LABEL]       B"
        End If
        If N = "C" Then
            opcion9 = "[LABEL]       C"
        End If
        If N = "D" Then
            opcion9 = "[LABEL]       D"
        End If
        If N = "E" Then
            opcion9 = "[LABEL]       E"
        End If
        If N = "F" Then
            opcion9 = "[LABEL]       F"
        End If
        If N = "G" Then
            opcion9 = "[LABEL]       G"
        End If
        If N = "H" Then
            opcion9 = "[LABEL]       H"
        End If
        If N = "I" Then
            opcion9 = "[LABEL]       I"
        End If
        If N = "E" Then
            opcion9 = "[LABEL]       E"
        End If

        If N = "J" Then
            opcion9 = "[LABEL]       J"
        End If

        If N = "K" Then
            opcion9 = "[LABEL]       K"
        End If

        If N = "L" Then
            opcion9 = "[LABEL]       L"
        End If

        If N = "M" Then
            opcion9 = "[LABEL]       M"
        End If

        If N = "N" Then
            opcion9 = "[LABEL]       N"
        End If

        If N = "O" Then
            opcion9 = "[LABEL]       O"
        End If

        If N = "P" Then
            opcion9 = "[LABEL]       E"
        End If

        If N = "Q" Then
            opcion9 = "[LABEL]       Q"
        End If

        If N = "R" Then
            opcion9 = "[LABEL]       R"
        End If
        If N = "S" Then
            opcion9 = "[LABEL]       S"
        End If
        If N = "T" Then
            opcion9 = "[LABEL]       T"
        End If
        If N = "U" Then
            opcion9 = "[LABEL]       U"
        End If
        If N = "V" Then
            opcion9 = "[LABEL]       V"
        End If
        If N = "W" Then
            opcion9 = "[LABEL]       W"
        End If
        If N = "X" Then
            opcion9 = "[LABEL]       Q"
        End If
        If N = "Q" Then
            opcion9 = "[LABEL]       X"
        End If
        If N = "Y" Then
            opcion9 = "[LABEL]       Y"
        End If
        If N = "Z" Then
            opcion9 = "[LABEL]       Z"
        End If

    End Sub
End Class