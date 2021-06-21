<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.btnhome = New System.Windows.Forms.Button()
        Me.txtdep = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnup = New System.Windows.Forms.Button()
        Me.btncre = New System.Windows.Forms.Button()
        Me.btnrea = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matrixnombor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.namestudent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.LawnGreen
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.Location = New System.Drawing.Point(534, 367)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(97, 49)
        Me.btnhome.TabIndex = 26
        Me.btnhome.Text = "HOME"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'txtdep
        '
        Me.txtdep.Location = New System.Drawing.Point(104, 182)
        Me.txtdep.Name = "txtdep"
        Me.txtdep.Size = New System.Drawing.Size(377, 20)
        Me.txtdep.TabIndex = 25
        '
        'txtno
        '
        Me.txtno.Location = New System.Drawing.Point(104, 60)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(377, 20)
        Me.txtno.TabIndex = 24
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(104, 122)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(377, 20)
        Me.txtnama.TabIndex = 23
        '
        'dgvStudent
        '
        Me.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.matrixnombor, Me.namestudent, Me.Department})
        Me.dgvStudent.Location = New System.Drawing.Point(53, 233)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.RowHeadersWidth = 47
        Me.dgvStudent.Size = New System.Drawing.Size(550, 109)
        Me.dgvStudent.TabIndex = 22
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.Yellow
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(404, 368)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(94, 48)
        Me.btndel.TabIndex = 21
        Me.btndel.Text = "DELETE"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnup
        '
        Me.btnup.BackColor = System.Drawing.Color.LawnGreen
        Me.btnup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnup.Location = New System.Drawing.Point(273, 367)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(100, 49)
        Me.btnup.TabIndex = 20
        Me.btnup.Text = "UPDATE"
        Me.btnup.UseVisualStyleBackColor = False
        '
        'btncre
        '
        Me.btncre.BackColor = System.Drawing.Color.Lime
        Me.btncre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncre.Location = New System.Drawing.Point(12, 367)
        Me.btncre.Name = "btncre"
        Me.btncre.Size = New System.Drawing.Size(95, 46)
        Me.btncre.TabIndex = 19
        Me.btncre.Text = "CREATE"
        Me.btncre.UseVisualStyleBackColor = False
        '
        'btnrea
        '
        Me.btnrea.BackColor = System.Drawing.Color.Yellow
        Me.btnrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrea.Location = New System.Drawing.Point(136, 368)
        Me.btnrea.Name = "btnrea"
        Me.btnrea.Size = New System.Drawing.Size(92, 48)
        Me.btnrea.TabIndex = 18
        Me.btnrea.Text = "READ"
        Me.btnrea.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(586, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "ADMIN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "MATRIX NO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "DEPARTMENT"
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.Width = 125
        '
        'matrixnombor
        '
        Me.matrixnombor.HeaderText = "MatrixNo"
        Me.matrixnombor.MinimumWidth = 6
        Me.matrixnombor.Name = "matrixnombor"
        Me.matrixnombor.Width = 125
        '
        'namestudent
        '
        Me.namestudent.HeaderText = "Name"
        Me.namestudent.MinimumWidth = 6
        Me.namestudent.Name = "namestudent"
        Me.namestudent.Width = 125
        '
        'Department
        '
        Me.Department.HeaderText = "Department"
        Me.Department.MinimumWidth = 6
        Me.Department.Name = "Department"
        Me.Department.Width = 125
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(645, 428)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.txtdep)
        Me.Controls.Add(Me.txtno)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.btncre)
        Me.Controls.Add(Me.btnrea)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnhome As Button
    Friend WithEvents txtdep As TextBox
    Friend WithEvents txtno As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents btndel As Button
    Friend WithEvents btnup As Button
    Friend WithEvents btncre As Button
    Friend WithEvents btnrea As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents matrixnombor As DataGridViewTextBoxColumn
    Friend WithEvents namestudent As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
End Class
