Imports Oracle.DataAccess.Client
Public Class Form2
    Public Enum EstadoCivil As Byte
        Soltero = 0
        Casado = 1
    End Enum

    Public Enum Sexo As Byte
        Femenino = 0
        Masculino = 1
    End Enum

    Private Conexion As New OracleConnection("Data Source=localhost;
                                        User Id=UNAF;
                                        Password=Unaf;")
    Dim Adaptador As OracleDataAdapter
    Dim PersonaDS As New DataSet
    Dim Registro As DataRow

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargo Combo Sexo
        CmbSexo.Items.Insert(Sexo.Femenino, Sexo.Femenino.ToString)
        CmbSexo.Items.Insert(Sexo.Masculino, Sexo.Masculino.ToString)

        'Cargo Combo Estado Civil
        CmbEstadoCivil.Items.Insert(EstadoCivil.Soltero, EstadoCivil.Soltero.ToString)
        CmbEstadoCivil.Items.Insert(EstadoCivil.Casado, EstadoCivil.Casado.ToString)

        Adaptador = New OracleDataAdapter("Select * From Persona Where Id_Persona = " + Form1.IdPersona.ToString, Conexion)
        Adaptador.Fill(PersonaDS, "persona")
        If Form1.Accion = TipoAccion.Alta Then
            Registro = PersonaDS.Tables("persona").NewRow()
            Registro("ID_PERSONA") = -1
        Else
            Registro = PersonaDS.Tables("persona").Rows.Item(0)
        End If

        TxtApyNombre.Text = Registro("APELLIDOYNOMBRE").ToString
        TxtDni.Text = Registro("DNI").ToString
        TxtTipo.Text = Mid$(Registro("CUIL").ToString(), 1, 2)
        TxtNumero.Text = Mid$(Registro("CUIL").ToString(), 3, 8)
        TxtDigitoVerificador.Text = Mid$(Registro("CUIL").ToString(), 11, 1)
        DtpFNacimiento.Value = IIf(IsDBNull(Registro("FECHANACIMIENTO")), Date.Now, Registro("FECHANACIMIENTO"))
        CmbSexo.SelectedIndex = IIf(IsDBNull(Registro("SEXO")), -1, Registro("SEXO"))
        CmbEstadoCivil.SelectedIndex = IIf(IsDBNull(Registro("ESTADOCIVIL")), -1, Registro("ESTADOCIVIL"))

        TxtApyNombre.Enabled = (Form1.Accion <> TipoAccion.Baja)
        TxtDni.Enabled = (Form1.Accion <> TipoAccion.Baja)
        TxtTipo.Enabled = (Form1.Accion <> TipoAccion.Baja)
        TxtNumero.Enabled = (Form1.Accion <> TipoAccion.Baja)
        TxtDigitoVerificador.Enabled = (Form1.Accion <> TipoAccion.Baja)
        DtpFNacimiento.Enabled = (Form1.Accion <> TipoAccion.Baja)
        CmbSexo.Enabled = (Form1.Accion <> TipoAccion.Baja)
        CmbEstadoCivil.Enabled = (Form1.Accion <> TipoAccion.Baja)

    End Sub

    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click

        Dim InsertCmd As New OracleCommand
        Dim UpdateCmd As New OracleCommand
        Dim DeleteCmd As New OracleCommand

        Registro("APELLIDOYNOMBRE") = TxtApyNombre.Text
        Registro("DNI") = CInt(TxtDni.Text)
        Registro("CUIL") = TxtTipo.Text + TxtNumero.Text + TxtDigitoVerificador.Text
        Registro("SEXO") = CType(CmbSexo.SelectedIndex, Sexo)
        Registro("ESTADOCIVIL") = CType(CmbEstadoCivil.SelectedIndex, EstadoCivil)
        Registro("FECHANACIMIENTO") = DtpFNacimiento.Value

        If Form1.Accion = TipoAccion.Alta Then
            PersonaDS.Tables("persona").Rows.Add(Registro)
        ElseIf Form1.Accion = TipoAccion.Baja Then
            PersonaDS.Tables("persona").Rows.Remove(Registro)
        End If

        InsertCmd.CommandText = "Insert Into Persona
           VALUES (:idpersona,:apellidoynombre,:dni,:cuil,:sexo,:estadocivil,:fechanacimiento)"
        UpdateCmd.CommandText = "Update Persona 
            set ApellidoyNombre = :apellidoynombre,
                Dni = :dni,
                CUIL = :cuil,
                Sexo = :sexo,
                EstadoCivil = :estadocivil,
                FechaNacimiento = :fechanacimiento
            where Id_Persona = :idpersona"
        DeleteCmd.CommandText = "Delete * From Persona Where Id_Persona = :idpersona"

        InsertCmd.Connection = Conexion
        UpdateCmd.Connection = Conexion
        DeleteCmd.Connection = Conexion

        InsertCmd.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int32, 0, "ID_PERSONA"))
        InsertCmd.Parameters.Add(New OracleParameter(":apellidoynombre", OracleDbType.Varchar2, 0, "APELLIDOYNOMBRE"))
        InsertCmd.Parameters.Add(New OracleParameter(":sexo", OracleDbType.Byte, 0, "SEXO"))
        InsertCmd.Parameters.Add(New OracleParameter(":dni", OracleDbType.Varchar2, 0, "DNI"))
        InsertCmd.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Varchar2, 0, "CUIL"))
        InsertCmd.Parameters.Add(New OracleParameter(":fechanacimiento", OracleDbType.Date, 0, "FECHANACIMIENTO"))
        InsertCmd.Parameters.Add(New OracleParameter(":estadocivil", OracleDbType.Byte, 0, "ESTADOCIVIL"))


        UpdateCmd.Parameters.Add(New OracleParameter(":apellidoynombre", OracleDbType.Varchar2, 0, "APELLIDOYNOMBRE"))
        UpdateCmd.Parameters.Add(New OracleParameter(":dni", OracleDbType.Varchar2, 8, "DNI"))
        UpdateCmd.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Varchar2, 13, "CUIL"))
        UpdateCmd.Parameters.Add(New OracleParameter(":sexo", OracleDbType.Byte, 0, "SEXO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":estadocivil", OracleDbType.Byte, 0, "ESTADOCIVIL"))
        UpdateCmd.Parameters.Add(New OracleParameter(":fechanacimiento", OracleDbType.Date, 0, "FECHANACIMIENTO"))
        UpdateCmd.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int32, 0, "ID_PERSONA"))

        DeleteCmd.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int32, 0, "ID_PERSONA"))

        Adaptador.InsertCommand = InsertCmd
        Adaptador.UpdateCommand = UpdateCmd
        Adaptador.DeleteCommand = DeleteCmd
        Try
            Adaptador.Update(PersonaDS, "persona")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If Form1.Accion = TipoAccion.Alta Then
            MessageBox.Show("Los datos se guardaron correctamente.")
        ElseIf Form1.Accion = TipoAccion.Modificacion Then
            MessageBox.Show("Los datos se actualizaron correctamente.")
        Else
            MessageBox.Show("El registro se eliminó correctamente.")
        End If
        Form1.CargarComboPersonas()
        Me.Close()

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class