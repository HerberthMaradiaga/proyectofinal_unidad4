Imports Microsoft.VisualBasic
Imports System.Data

Public Class alumno
    'instancia de la clase conexion
    Dim c As New conexion

    'declaracion de propiedades
    Private codigoAlumno As String
    Private nombreAlumno As String
    Private apellidoAlumno As String
    Private pagina As Page

    'metodos de propiedad

    'metodo para codigo alumno
    Public Property codalumno() As String
        Get
            Return codigoAlumno
        End Get
        Set(value As String)
            codigoAlumno = value
        End Set
    End Property
    'metodo para nombre alumno
    Public Property nomalumno() As String
        Get
            Return nombreAlumno
        End Get
        Set(value As String)
            nombreAlumno = value
        End Set
    End Property
    'metodo para apellido alumno
    Public Property apealumno() As String
        Get
            Return apellidoAlumno
        End Get
        Set(value As String)
            apellidoAlumno = value
        End Set
    End Property

    Public Function listarRegistros() As DataTable
        'c hace referencia a la instancia de la clase conexion
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT codigoAlumno, nombreAlumno, apellidoAlumno FROM alumno"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function

End Class
