<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.InmuebleDGV = New System.Windows.Forms.DataGridView()
        Me.PersonasCmb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CargarPersonasBtn = New System.Windows.Forms.Button()
        Me.CargarInmueblesBtn = New System.Windows.Forms.Button()
        Me.CargarPersonasConDatasetBtn = New System.Windows.Forms.Button()
        Me.AgregarPersonaCmd = New System.Windows.Forms.Button()
        CType(Me.InmuebleDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InmuebleDGV
        '
        Me.InmuebleDGV.AllowUserToAddRows = False
        Me.InmuebleDGV.AllowUserToDeleteRows = False
        Me.InmuebleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InmuebleDGV.Location = New System.Drawing.Point(12, 76)
        Me.InmuebleDGV.Name = "InmuebleDGV"
        Me.InmuebleDGV.ReadOnly = True
        Me.InmuebleDGV.Size = New System.Drawing.Size(554, 237)
        Me.InmuebleDGV.TabIndex = 0
        '
        'PersonasCmb
        '
        Me.PersonasCmb.FormattingEnabled = True
        Me.PersonasCmb.Location = New System.Drawing.Point(69, 49)
        Me.PersonasCmb.Name = "PersonasCmb"
        Me.PersonasCmb.Size = New System.Drawing.Size(361, 21)
        Me.PersonasCmb.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Personas"
        '
        'CargarPersonasBtn
        '
        Me.CargarPersonasBtn.Location = New System.Drawing.Point(12, 12)
        Me.CargarPersonasBtn.Name = "CargarPersonasBtn"
        Me.CargarPersonasBtn.Size = New System.Drawing.Size(155, 23)
        Me.CargarPersonasBtn.TabIndex = 3
        Me.CargarPersonasBtn.Text = "Cargar Personas"
        Me.CargarPersonasBtn.UseVisualStyleBackColor = True
        '
        'CargarInmueblesBtn
        '
        Me.CargarInmueblesBtn.Location = New System.Drawing.Point(395, 12)
        Me.CargarInmueblesBtn.Name = "CargarInmueblesBtn"
        Me.CargarInmueblesBtn.Size = New System.Drawing.Size(130, 23)
        Me.CargarInmueblesBtn.TabIndex = 4
        Me.CargarInmueblesBtn.Text = "Cargar Inmuebles"
        Me.CargarInmueblesBtn.UseVisualStyleBackColor = True
        '
        'CargarPersonasConDatasetBtn
        '
        Me.CargarPersonasConDatasetBtn.Location = New System.Drawing.Point(173, 12)
        Me.CargarPersonasConDatasetBtn.Name = "CargarPersonasConDatasetBtn"
        Me.CargarPersonasConDatasetBtn.Size = New System.Drawing.Size(195, 23)
        Me.CargarPersonasConDatasetBtn.TabIndex = 5
        Me.CargarPersonasConDatasetBtn.Text = "Cargar Personas con Dataset"
        Me.CargarPersonasConDatasetBtn.UseVisualStyleBackColor = True
        '
        'AgregarPersonaCmd
        '
        Me.AgregarPersonaCmd.Location = New System.Drawing.Point(452, 43)
        Me.AgregarPersonaCmd.Name = "AgregarPersonaCmd"
        Me.AgregarPersonaCmd.Size = New System.Drawing.Size(114, 26)
        Me.AgregarPersonaCmd.TabIndex = 6
        Me.AgregarPersonaCmd.Text = "Agregar Persona"
        Me.AgregarPersonaCmd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 325)
        Me.Controls.Add(Me.AgregarPersonaCmd)
        Me.Controls.Add(Me.CargarPersonasConDatasetBtn)
        Me.Controls.Add(Me.CargarInmueblesBtn)
        Me.Controls.Add(Me.CargarPersonasBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PersonasCmb)
        Me.Controls.Add(Me.InmuebleDGV)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.InmuebleDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InmuebleDGV As DataGridView
    Friend WithEvents PersonasCmb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CargarPersonasBtn As Button
    Friend WithEvents CargarInmueblesBtn As Button
    Friend WithEvents CargarPersonasConDatasetBtn As Button
    Friend WithEvents AgregarPersonaCmd As Button
End Class
