<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnad = New System.Windows.Forms.Button()
        Me.btnstud = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnad
        '
        Me.btnad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnad.Location = New System.Drawing.Point(183, 219)
        Me.btnad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnad.Name = "btnad"
        Me.btnad.Size = New System.Drawing.Size(307, 50)
        Me.btnad.TabIndex = 10
        Me.btnad.Text = "ADMIN"
        Me.btnad.UseVisualStyleBackColor = False
        '
        'btnstud
        '
        Me.btnstud.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnstud.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstud.Location = New System.Drawing.Point(183, 126)
        Me.btnstud.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnstud.Name = "btnstud"
        Me.btnstud.Size = New System.Drawing.Size(307, 54)
        Me.btnstud.TabIndex = 9
        Me.btnstud.Text = "STUDENT"
        Me.btnstud.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Font = New System.Drawing.Font("Baskerville Old Face", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(108, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(476, 50)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PTSS ENGLISH CLUB"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Registration Application"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(687, 346)
        Me.Controls.Add(Me.btnad)
        Me.Controls.Add(Me.btnstud)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PTSS ENGLISH CLUB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnad As Button
    Friend WithEvents btnstud As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
