﻿Imports DAO
Imports Entyti

Public Class CuaHangBUS
    Private cls As New CuaHangDAO
    Public Function LoadData() As DataTable
        Return cls.LoadData()
    End Function
    Public Function Add(ByVal CH As CuaHangEntyti) As Integer
        Return cls.Add(CH)
    End Function
    Public Function Remove(ByVal CH As CuaHangEntyti) As Integer
        Return cls.Remove(CH)
    End Function
    Public Function Update(ByVal CH As CuaHangEntyti) As Integer
        Return cls.Update(CH)
    End Function
End Class
