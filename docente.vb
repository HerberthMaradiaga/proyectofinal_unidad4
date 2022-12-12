Imports Microsoft.VisualBasic
Imports System.Data

Public Class docente
    'instancia de la clase conexion
    Dim c As New conexion

    'declaracion de propiedades
    Private nombre As String
    Private apellido As String
    Private direccion As String
    Private especialidad As String
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
    Public Property ape() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property
    'metodo para direccion alumno
    Public Property dir() As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property
    'metodo para especialidad alumno
    Public Property esp() As String
        Get
            Return especialidad
        End Get
        Set(value As String)
            especialidad = value
        End Set
    End Property

    Public Function listarRegistros() As DataTable
        'c hace referencia a la instancia de la clase conexion
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT nombre, apellido, direccion, especialidad FROM docente"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function
End Class
