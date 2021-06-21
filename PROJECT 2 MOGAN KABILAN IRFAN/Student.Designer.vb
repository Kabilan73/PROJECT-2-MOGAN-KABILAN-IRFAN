<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student
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
        Me.dgvStudent = New System.Windows.Forms.DataGridView()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.btnrea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.matrixnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnhome
        '
        Me.btnhome.BackColor = System.Drawing.Color.Lime
        Me.btnhome.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhome.Location = New System.Drawing.Point(400, 216)
        Me.btnhome.Name = "btnhome"
        Me.btnhome.Size = New System.Drawing.Size(115, 54)
        Me.btnhome.TabIndex = 27
        Me.btnhome.Text = "HOME"
        Me.btnhome.UseVisualStyleBackColor = False
        '
        'dgvStudent
        '
        Me.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStudent.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.matrixnum, Me.studname, Me.department})
        Me.dgvStudent.Location = New System.Drawing.Point(12, 70)
        Me.dgvStudent.Name = "dgvStudent"
        Me.dgvStudent.RowHeadersWidth = 47
        Me.dgvStudent.Size = New System.Drawing.Size(553, 126)
        Me.dgvStudent.TabIndex = 26
        '
        'btnupd
        '
        Me.btnupd.BackColor = System.Drawing.Color.Lime
        Me.btnupd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupd.Location = New System.Drawing.Point(57, 216)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(116, 54)
        Me.btnupd.TabIndex = 25
        Me.btnupd.Text = "UPDATE"
        Me.btnupd.UseVisualStyleBackColor = False
        '
        'btnrea
        '
        Me.btnrea.BackColor = System.Drawing.Color.Lime
        Me.btnrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrea.Location = New System.Drawing.Point(231, 216)
        Me.btnrea.Name = "btnrea"
        Me.btnrea.Size = New System.Drawing.Size(116, 54)
        Me.btnrea.TabIndex = 24
        Me.btnrea.Text = "READ"
        Me.btnrea.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "STUDENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.MinimumWidth = 6
        Me.Id.Name = "Id"
        Me.Id.Width = 125
        '
        'matrixnum
        '
        Me.matrixnum.HeaderText = "MatrixNo"
        Me.matrixnum.MinimumWidth = 6
        Me.matrixnum.Name = "matrixnum"
        Me.matrixnum.Width = 125
        '
        'studname
        '
        Me.studname.HeaderText = "Name"
        Me.studname.MinimumWidth = 6
        Me.studname.Name = "studname"
        Me.studname.Width = 125
        '
        'department
        '
        Me.department.HeaderText = "Department"
        Me.department.MinimumWidth = 6
        Me.department.Name = "department"
        Me.department.Width = 125
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(577, 292)
        Me.Controls.Add(Me.btnhome)
        Me.Controls.Add(Me.dgvStudent)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.btnrea)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student"
        CType(Me.dgvStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnhome As Button
    Friend WithEvents dgvStudent As DataGridView
    Friend WithEvents btnupd As Button
    Friend WithEvents btnrea As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents matrixnum As DataGridViewTextBoxColumn
    Friend WithEvents studname As DataGridViewTextBoxColumn
    Friend WithEvents department As DataGridViewTextBoxColumn
End Class
