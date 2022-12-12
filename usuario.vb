Imports Microsoft.VisualBasic
Imports System.Data

Public Class usuario
    'instancia de la clase conexion
    Dim c As New conexion

    'declaracion de propiedades
    Private nombre As String
    Private clave As String
    Private pagina As Page

    'metodos de propiedad

    'metodo para nombre alumno
    Public Property nom() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    'metodo para apellido alumno
    Public Property cla() As String
        Get
            Return clave
        End Get
        Set(value As String)
            clave = value
        End Set
    End Property

    Public Function listarRegistros() As DataTable
        'c hace referencia a la instancia de la clase conexion
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT nombre, clve FROM usuario"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function
End Class
