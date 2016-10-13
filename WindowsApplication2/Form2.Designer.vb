<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblFNacimiento = New System.Windows.Forms.Label()
        Me.DtpFNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.LblEstadoCivil = New System.Windows.Forms.Label()
        Me.CmbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.TxtDigitoVerificador = New System.Windows.Forms.TextBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.LblCuil = New System.Windows.Forms.Label()
        Me.TxtDni = New System.Windows.Forms.TextBox()
        Me.LblSexo = New System.Windows.Forms.Label()
        Me.LblDni = New System.Windows.Forms.Label()
        Me.CmbSexo = New System.Windows.Forms.ComboBox()
        Me.LblApyNombre = New System.Windows.Forms.Label()
        Me.TxtApyNombre = New System.Windows.Forms.TextBox()
        Me.AceptarCmd = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblFNacimiento
        '
        Me.LblFNacimiento.AutoSize = True
        Me.LblFNacimiento.Location = New System.Drawing.Point(25, 174)
        Me.LblFNacimiento.Name = "LblFNacimiento"
        Me.LblFNacimiento.Size = New System.Drawing.Size(108, 13)
        Me.LblFNacimiento.TabIndex = 25
        Me.LblFNacimiento.Text = "Fecha de Nacimiento"
        '
        'DtpFNacimiento
        '
        Me.DtpFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFNacimiento.Location = New System.Drawing.Point(139, 171)
        Me.DtpFNacimiento.Name = "DtpFNacimiento"
        Me.DtpFNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.DtpFNacimiento.TabIndex = 23
        '
        'LblEstadoCivil
        '
        Me.LblEstadoCivil.AutoSize = True
        Me.LblEstadoCivil.Location = New System.Drawing.Point(71, 147)
        Me.LblEstadoCivil.Name = "LblEstadoCivil"
        Me.LblEstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.LblEstadoCivil.TabIndex = 24
        Me.LblEstadoCivil.Text = "Estado Civil"
        '
        'CmbEstadoCivil
        '
        Me.CmbEstadoCivil.FormattingEnabled = True
        Me.CmbEstadoCivil.Location = New System.Drawing.Point(139, 144)
        Me.CmbEstadoCivil.Name = "CmbEstadoCivil"
        Me.CmbEstadoCivil.Size = New System.Drawing.Size(146, 21)
        Me.CmbEstadoCivil.TabIndex = 22
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(175, 118)
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumero.TabIndex = 19
        '
        'TxtDigitoVerificador
        '
        Me.TxtDigitoVerificador.Location = New System.Drawing.Point(281, 118)
        Me.TxtDigitoVerificador.Name = "TxtDigitoVerificador"
        Me.TxtDigitoVerificador.Size = New System.Drawing.Size(21, 20)
        Me.TxtDigitoVerificador.TabIndex = 20
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(139, 118)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(30, 20)
        Me.TxtTipo.TabIndex = 16
        '
        'LblCuil
        '
        Me.LblCuil.AutoSize = True
        Me.LblCuil.Location = New System.Drawing.Point(102, 121)
        Me.LblCuil.Name = "LblCuil"
        Me.LblCuil.Size = New System.Drawing.Size(31, 13)
        Me.LblCuil.TabIndex = 21
        Me.LblCuil.Text = "CUIL"
        '
        'TxtDni
        '
        Me.TxtDni.Location = New System.Drawing.Point(139, 65)
        Me.TxtDni.MaxLength = 8
        Me.TxtDni.Name = "TxtDni"
        Me.TxtDni.Size = New System.Drawing.Size(100, 20)
        Me.TxtDni.TabIndex = 13
        '
        'LblSexo
        '
        Me.LblSexo.AutoSize = True
        Me.LblSexo.Location = New System.Drawing.Point(102, 94)
        Me.LblSexo.Name = "LblSexo"
        Me.LblSexo.Size = New System.Drawing.Size(31, 13)
        Me.LblSexo.TabIndex = 17
        Me.LblSexo.Text = "Sexo"
        '
        'LblDni
        '
        Me.LblDni.AutoSize = True
        Me.LblDni.Location = New System.Drawing.Point(107, 68)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(26, 13)
        Me.LblDni.TabIndex = 18
        Me.LblDni.Text = "DNI"
        '
        'CmbSexo
        '
        Me.CmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSexo.FormattingEnabled = True
        Me.CmbSexo.Location = New System.Drawing.Point(139, 91)
        Me.CmbSexo.Name = "CmbSexo"
        Me.CmbSexo.Size = New System.Drawing.Size(100, 21)
        Me.CmbSexo.TabIndex = 15
        '
        'LblApyNombre
        '
        Me.LblApyNombre.AutoSize = True
        Me.LblApyNombre.Location = New System.Drawing.Point(41, 39)
        Me.LblApyNombre.Name = "LblApyNombre"
        Me.LblApyNombre.Size = New System.Drawing.Size(92, 13)
        Me.LblApyNombre.TabIndex = 14
        Me.LblApyNombre.Text = "Apellido y Nombre"
        '
        'TxtApyNombre
        '
        Me.TxtApyNombre.Location = New System.Drawing.Point(139, 36)
        Me.TxtApyNombre.Name = "TxtApyNombre"
        Me.TxtApyNombre.Size = New System.Drawing.Size(338, 20)
        Me.TxtApyNombre.TabIndex = 12
        '
        'AceptarCmd
        '
        Me.AceptarCmd.Location = New System.Drawing.Point(261, 288)
        Me.AceptarCmd.Name = "AceptarCmd"
        Me.AceptarCmd.Size = New System.Drawing.Size(96, 26)
        Me.AceptarCmd.TabIndex = 26
        Me.AceptarCmd.Text = "Aceptar"
        Me.AceptarCmd.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(372, 288)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(104, 25)
        Me.Cancelar.TabIndex = 27
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 338)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.AceptarCmd)
        Me.Controls.Add(Me.LblFNacimiento)
        Me.Controls.Add(Me.DtpFNacimiento)
        Me.Controls.Add(Me.LblEstadoCivil)
        Me.Controls.Add(Me.CmbEstadoCivil)
        Me.Controls.Add(Me.TxtNumero)
        Me.Controls.Add(Me.TxtDigitoVerificador)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.LblCuil)
        Me.Controls.Add(Me.TxtDni)
        Me.Controls.Add(Me.LblSexo)
        Me.Controls.Add(Me.LblDni)
        Me.Controls.Add(Me.CmbSexo)
        Me.Controls.Add(Me.LblApyNombre)
        Me.Controls.Add(Me.TxtApyNombre)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblFNacimiento As Label
    Friend WithEvents DtpFNacimiento As DateTimePicker
    Friend WithEvents LblEstadoCivil As Label
    Friend WithEvents CmbEstadoCivil As ComboBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents TxtDigitoVerificador As TextBox
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents LblCuil As Label
    Friend WithEvents TxtDni As TextBox
    Friend WithEvents LblSexo As Label
    Friend WithEvents LblDni As Label
    Friend WithEvents CmbSexo As ComboBox
    Friend WithEvents LblApyNombre As Label
    Friend WithEvents TxtApyNombre As TextBox
    Friend WithEvents AceptarCmd As Button
    Friend WithEvents Cancelar As Button
End Class
