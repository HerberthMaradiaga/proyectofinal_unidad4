Imports System.Data

Public Class alumno1
    Inherits System.Web.UI.Page
    Dim alumno As New alumno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then
            'llenar datable con la base de datos
            Dim dt As DataTable = alumno.listarRegistros

            'construllendo html string
            Dim html As New StringBuilder()

            'inicia creacion de la tabla
            html.Append("table class='table table-striped'")

            'agregando encabezado a tabla
            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<th>Codigo</th>")
            html.Append("<th>Nombre</th>")
            html.Append("<th>Apellido</th>")
            html.Append("</tr>")
            html.Append("</thead>")
            html.Append("<tbody>")

            'mostrar datos en filas
            For i = 0 To dt.Rows.Count - 1
                Dim codigo As Integer = dt.Rows(i).Item("codAlumno")

                html.Append("<tr>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("codAlumno"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("nomAlumno"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("apeAlumno"))
                html.Append("</td>")
                html.Append("</tr>")
            Next

            html.Append("</tbody>")
            'finaliza tabla
            html.Append("</Table>")

            'agregar html en placeholder1
            Estudiantes.Controls.Add(New Literal() With {.Text = html.ToString})
        End If
    End Sub

End Class