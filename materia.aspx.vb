Imports System.Data

Public Class materia
    Inherits System.Web.UI.Page
    Dim materia As New materia
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            'llenar datable con la base de datos
            Dim dt As DataTable = materia.listarRegistros

            'construllendo html string
            Dim html As New StringBuilder()

            'inicia creacion de la tabla
            html.Append("table class='table table-striped'")

            'agregando encabezado a tabla
            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<th>nombremateria</th>")
            html.Append("<th>uv</th>")
            html.Append("</tr>")
            html.Append("</thead>")
            html.Append("<tbody>")

            'mostrar datos en filas
            For i = 0 To dt.Rows.Count - 1
                Dim codigo As Integer = dt.Rows(i).Item("nombre")

                html.Append("<tr>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("nombremateria"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("uv"))
                html.Append("</td><td>")
                html.Append("</tr>")
            Next

            html.Append("</tbody>")
            'finaliza tabla
            html.Append("</Table>")

            'agregar html en placeholder1
            materia.Controls.Add(New Literal() With {.Text = html.ToString})
        End If
    End Sub

End Class