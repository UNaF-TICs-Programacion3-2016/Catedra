Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types
Public Class Form2
    Public Enum EstadoCivil As Byte
        Soltero = 0
        Casado = 1
    End Enum

    Public Enum Sexo As Byte
        Femenino = 0
        Masculino = 1
    End Enum

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cargo Combo Sexo
        CmbSexo.Items.Insert(Sexo.Femenino, Sexo.Femenino.ToString)
        CmbSexo.Items.Insert(Sexo.Masculino, Sexo.Masculino.ToString)

        'Cargo Combo Estado Civil
        CmbEstadoCivil.Items.Insert(EstadoCivil.Soltero, EstadoCivil.Soltero.ToString)
        CmbEstadoCivil.Items.Insert(EstadoCivil.Casado, EstadoCivil.Casado.ToString)


        TxtApyNombre.Text = ""
        TxtDni.Text = ""
        TxtTipo.Text = ""
        TxtNumero.Text = ""
        TxtDigitoVerificador.Text = ""
        DtpFNacimiento.Value = Date.Now
        CmbSexo.SelectedIndex = -1
        CmbEstadoCivil.SelectedIndex = -1
    End Sub

    Private Sub AceptarCmd_Click(sender As Object, e As EventArgs) Handles AceptarCmd.Click

        Dim Conexion As New OracleConnection
        Dim InsertCmd As New OracleCommand
        Dim Adaptador As New OracleDataAdapter("Select * From Persona Where Id_Persona = -1", Conexion)
        Dim PersonaDS As New DataSet
        Dim Registro As DataRow

        Conexion.ConnectionString = "Data Source=localhost;" _
                                        + "User Id=UNAF;" _
                                        + "Password=Unaf;"
        Adaptador.Fill(PersonaDS, "persona")

        Registro = PersonaDS.Tables("persona").NewRow()

        Registro("ID_PERSONA") = -1 'Form1.PersonasCmb.SelectedItem("ID_PERSONA").value
        Registro("APELLIDOYNOMBRE") = TxtApyNombre.Text
        Registro("DNI") = CInt(TxtDni.Text)
        Registro("CUIL") = TxtTipo.Text + TxtNumero.Text + TxtDigitoVerificador.Text
        Registro("SEXO") = CType(CmbSexo.SelectedIndex, Sexo)
        Registro("ESTADOCIVIL") = CType(CmbEstadoCivil.SelectedIndex, EstadoCivil)
        Registro("FECHANACIMIENTO") = DtpFNacimiento.Value

        PersonaDS.Tables("persona").Rows.Add(Registro)

        InsertCmd.CommandText = "Insert Into Persona
           VALUES (:idpersona,:apellidoynombre,:dni,:cuil,:sexo,:estadocivil,:fechanacimiento)"

        InsertCmd.Connection = Conexion

        InsertCmd.Parameters.Add(New OracleParameter(":idpersona", OracleDbType.Int32, 0, "ID_PERSONA"))
        InsertCmd.Parameters.Add(New OracleParameter(":apellidoynombre", OracleDbType.Varchar2, 0, "APELLIDOYNOMBRE"))
        InsertCmd.Parameters.Add(New OracleParameter(":sexo", OracleDbType.Byte, 0, "SEXO"))
        InsertCmd.Parameters.Add(New OracleParameter(":dni", OracleDbType.Varchar2, 0, "DNI"))
        InsertCmd.Parameters.Add(New OracleParameter(":cuil", OracleDbType.Varchar2, 0, "CUIL"))
        InsertCmd.Parameters.Add(New OracleParameter(":fechanacimiento", OracleDbType.Date, 0, "FECHANACIMIENTO"))
        InsertCmd.Parameters.Add(New OracleParameter(":estadocivil", OracleDbType.Byte, 0, "ESTADOCIVIL"))

        Adaptador.InsertCommand = InsertCmd

        Adaptador.Update(PersonaDS, "persona")

        MessageBox.Show("Los datos se guardaron correctamente.")
        Form1.CargarComboPersonas()
        Me.Close()

    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub
End Class