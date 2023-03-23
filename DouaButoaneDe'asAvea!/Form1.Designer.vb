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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lbl2 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.TextBox()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lbl3 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(104, 37)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 58)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Click This"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(340, 37)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 58)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "And This"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(104, 252)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(182, 32)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Label1"
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(340, 252)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(163, 32)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "Label2"
        '
        'btn3
        '
        Me.btn3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(579, 33)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(143, 68)
        Me.btn3.TabIndex = 4
        Me.btn3.Text = "Si astaaaa ???"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(579, 252)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(204, 32)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "Label3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 350)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents lbl2 As TextBox
    Friend WithEvents lbl1 As TextBox
    Friend WithEvents btn3 As Button
    Friend WithEvents lbl3 As TextBox
End Class
