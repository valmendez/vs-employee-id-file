<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Program8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.grpName = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lstLastName = New System.Windows.Forms.ListBox()
        Me.lstFirstName = New System.Windows.Forms.ListBox()
        Me.grpId = New System.Windows.Forms.GroupBox()
        Me.grpName.SuspendLayout()
        Me.grpId.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Employee ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(144, 58)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name:"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumPurple
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Gold
        Me.btnExit.Location = New System.Drawing.Point(460, 259)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 43)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.MediumPurple
        Me.btnEnter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.Gold
        Me.btnEnter.Location = New System.Drawing.Point(276, 47)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 37)
        Me.btnEnter.TabIndex = 7
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'grpName
        '
        Me.grpName.BackColor = System.Drawing.Color.Thistle
        Me.grpName.Controls.Add(Me.btnReset)
        Me.grpName.Controls.Add(Me.lstLastName)
        Me.grpName.Controls.Add(Me.lstFirstName)
        Me.grpName.Controls.Add(Me.Label2)
        Me.grpName.Controls.Add(Me.Label3)
        Me.grpName.Location = New System.Drawing.Point(82, 134)
        Me.grpName.Name = "grpName"
        Me.grpName.Size = New System.Drawing.Size(357, 168)
        Me.grpName.TabIndex = 8
        Me.grpName.TabStop = False
        Me.grpName.Text = "EmployeeName"
        Me.grpName.Visible = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.MediumPurple
        Me.btnReset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Gold
        Me.btnReset.Location = New System.Drawing.Point(276, 116)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 38)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lstLastName
        '
        Me.lstLastName.FormattingEnabled = True
        Me.lstLastName.Location = New System.Drawing.Point(94, 135)
        Me.lstLastName.Name = "lstLastName"
        Me.lstLastName.Size = New System.Drawing.Size(120, 17)
        Me.lstLastName.TabIndex = 7
        '
        'lstFirstName
        '
        Me.lstFirstName.FormattingEnabled = True
        Me.lstFirstName.Location = New System.Drawing.Point(94, 107)
        Me.lstFirstName.Name = "lstFirstName"
        Me.lstFirstName.Size = New System.Drawing.Size(120, 17)
        Me.lstFirstName.TabIndex = 6
        '
        'grpId
        '
        Me.grpId.BackColor = System.Drawing.Color.Thistle
        Me.grpId.Controls.Add(Me.Label1)
        Me.grpId.Controls.Add(Me.txtID)
        Me.grpId.Controls.Add(Me.btnEnter)
        Me.grpId.Location = New System.Drawing.Point(82, 38)
        Me.grpId.Name = "grpId"
        Me.grpId.Size = New System.Drawing.Size(357, 90)
        Me.grpId.TabIndex = 9
        Me.grpId.TabStop = False
        Me.grpId.Text = "ID"
        '
        'Program8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 450)
        Me.Controls.Add(Me.grpId)
        Me.Controls.Add(Me.grpName)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "Program8"
        Me.Text = "Employees"
        Me.grpName.ResumeLayout(False)
        Me.grpName.PerformLayout()
        Me.grpId.ResumeLayout(False)
        Me.grpId.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents grpName As GroupBox
    Friend WithEvents lstLastName As ListBox
    Friend WithEvents lstFirstName As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents grpId As GroupBox
End Class
