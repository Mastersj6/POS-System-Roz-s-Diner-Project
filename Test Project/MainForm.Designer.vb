<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnSignUp = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Roz's Online Ordering"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(37, 111)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(100, 50)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnSignUp
        '
        Me.btnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignUp.Location = New System.Drawing.Point(151, 111)
        Me.btnSignUp.Name = "btnSignUp"
        Me.btnSignUp.Size = New System.Drawing.Size(100, 50)
        Me.btnSignUp.TabIndex = 2
        Me.btnSignUp.Text = "Sign Up"
        Me.btnSignUp.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 37)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Please login or sign up to look at the menu or order." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Employee Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 201)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSignUp)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Roz's Online Ordering"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnSignUp As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
