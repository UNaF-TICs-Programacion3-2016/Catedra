Imports Oracle.DataAccess.Client
Public Class Form1

    Private Sub CargarPersonasBtn_Click(sender As Object, e As EventArgs) Handles CargarPersonasBtn.Click
        Dim Conexion As New OracleConnection()
        Dim Comando As New OracleCommand("Select * From Persona", Conexion)
        Dim Reader As OracleDataReader
        Dim Tabla As New DataTable()
        Try
            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=UNAF;" _
                                        + "Password=Unaf;"
            Conexion.Open()

            Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection)
            'While Reader.Read()
            '    MessageBox.Show(Reader("APELLIDOYNOMBRE"))
            'End While
            Tabla.Load(Reader, LoadOption.OverwriteChanges)
            PersonasCmb.DataSource = Tabla
            PersonasCmb.DisplayMember = "ApellidoyNombre"
            PersonasCmb.ValueMember = "Sexo"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub

    Friend Sub CargarComboPersonas()
        Dim Conexion As New OracleConnection()
        Dim Comando As New OracleCommand("Select * From Persona", Conexion)
        Dim Reader As OracleDataReader
        Dim Tabla As New DataTable()
        Try
            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=UNAF;" _
                                        + "Password=Unaf;"
            Conexion.Open()

            Reader = Comando.ExecuteReader(CommandBehavior.CloseConnection)

            Tabla.Load(Reader, LoadOption.OverwriteChanges)
            PersonasCmb.DataSource = Tabla
            PersonasCmb.DisplayMember = "ApellidoyNombre"
            PersonasCmb.ValueMember = "Id_Persona"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub PersonasCmb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PersonasCmb.SelectedIndexChanged

    End Sub

    Private Sub CargarPersonasConDatasetBtn_Click(sender As Object, e As EventArgs) Handles CargarPersonasConDatasetBtn.Click
        Dim Conexion As New OracleConnection()
        Dim PersonaDS As New DataSet
        Dim Adaptador As New OracleDataAdapter("Select * From Persona", Conexion)
        Dim Tabla As New DataTable
        Try
            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=UNAF;" _
                                        + "Password=Unaf;"

            Adaptador.Fill(PersonaDS, "Personas")
            'Tabla = 
            PersonasCmb.DataSource = PersonaDS.Tables("Personas")
            PersonasCmb.DisplayMember = "ApellidoyNombre"
            PersonasCmb.ValueMember = "Id_Persona"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub PersonasCmb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles PersonasCmb.SelectionChangeCommitted
        MsgBox(PersonasCmb.SelectedItem("ID_PERSONA").ToString())
    End Sub


    Private Sub CargarInmueblesBtn_Click(sender As Object, e As EventArgs) Handles CargarInmueblesBtn.Click
        Dim Conexion As New OracleConnection()
        Dim InmuebleDS As New DataSet
        Dim Adaptador As New OracleDataAdapter("Select * From Inmueble", Conexion)
        Dim Tabla As New DataTable
        Try
            Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=UNAF;" _
                                        + "Password=Unaf;"

            Adaptador.Fill(InmuebleDS, "inmueble")
            Tabla = InmuebleDS.Tables("inmueble")
            InmuebleDGV.DataSource = InmuebleDS.Tables("inmueble")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub


    Private Sub InmuebleDGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles InmuebleDGV.CellDoubleClick
        MsgBox(InmuebleDGV.CurrentRow.Cells("ID_INMUEBLE").Value)
    End Sub

    Private Sub InmuebleDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles InmuebleDGV.CellContentClick

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AgregarPersonaCmd_Click(sender As Object, e As EventArgs) Handles AgregarPersonaCmd.Click
        Form2.Show()
    End Sub
End Class
