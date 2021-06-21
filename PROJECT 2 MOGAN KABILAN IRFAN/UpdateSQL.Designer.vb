<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSQL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.txtDep = New System.Windows.Forms.TextBox()
        Me.txtMat = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnupd
        '
        Me.btnupd.BackColor = System.Drawing.Color.LawnGreen
        Me.btnupd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupd.Location = New System.Drawing.Point(217, 309)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(145, 50)
        Me.btnupd.TabIndex = 26
        Me.btnupd.Text = "UPDATE"
        Me.btnupd.UseVisualStyleBackColor = False
        '
        'txtDep
        '
        Me.txtDep.Location = New System.Drawing.Point(95, 269)
        Me.txtDep.Name = "txtDep"
        Me.txtDep.Size = New System.Drawing.Size(401, 20)
        Me.txtDep.TabIndex = 25
        '
        'txtMat
        '
        Me.txtMat.Location = New System.Drawing.Point(95, 127)
        Me.txtMat.Name = "txtMat"
        Me.txtMat.Size = New System.Drawing.Size(401, 20)
        Me.txtMat.TabIndex = 24
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(95, 199)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(401, 20)
        Me.txtNama.TabIndex = 23
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(95, 60)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(401, 20)
        Me.txtId.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 242)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 24)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "DEPARTMENT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "MATRIX.NO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "STUDENT'S ID"
        '
        'UpdateSQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(584, 388)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.txtDep)
        Me.Controls.Add(Me.txtMat)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateSQL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnupd As Button
    Friend WithEvents txtDep As TextBox
    Friend WithEvents txtMat As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
