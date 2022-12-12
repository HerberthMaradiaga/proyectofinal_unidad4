Imports System.Data

Public Class usuario
    Inherits System.Web.UI.Page
    Dim usuarios As New usuario
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            'llenar datable con la base de datos
            Dim dt As DataTable = usuarios.listarRegistros()

            'construllendo html string
            Dim html As New StringBuilder()

            'inicia creacion de la tabla
            html.Append("table class='table table-striped'")

            'agregando encabezado a tabla
            html.Append("<thead>")
            html.Append("<tr>")
            html.Append("<th>nombre</th>")
            html.Append("<th>clave</th>")
            html.Append("</tr>")
            html.Append("</thead>")
            html.Append("<tbody>")

            'mostrar datos en filas
            For i = 0 To dt.Rows.Count - 1
                Dim codigo As Integer = dt.Rows(i).Item("nombre")

                html.Append("<tr>")
                html.Append("<td>")
                html.Append(dt.Rows(i).Item("nombre"))
                html.Append("</td><td>")
                html.Append(dt.Rows(i).Item("clave"))
                html.Append("</td>")
                html.Append("</tr>")
            Next

            html.Append("</tbody>")
            'finaliza tabla
            html.Append("</Table>")

            'agregar html en placeholder1
            usuario.Controls.Add(New Literal() With {.Text = html.ToString})
        End If
    End Sub

End Class