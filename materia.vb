Imports Microsoft.VisualBasic
Imports System.Data

Public Class materia
    'instancia de la clase conexion
    Dim c As New conexion

    'declaracion de propiedades
    Private nombreMateria As String
    Private uv As String
    Private pagina As Page

    'metodos de propiedad

    'metodo para nombre materia
    Public Property nomMateria() As String
        Get
            Return nombreMateria
        End Get
        Set(value As String)
            nombreMateria = value
        End Set
    End Property
    'metodo para unidades valorativas
    Public Property unidadesVal() As String
        Get
            Return uv
        End Get
        Set(value As String)
            uv = value
        End Set
    End Property

    Public Function listarRegistros() As DataTable
        'c hace referencia a la instancia de la clase conexion
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT nombreMateria, uv FROM docente"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function
End Class
