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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(7, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1273, 827)
        Me.Panel1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button9.Location = New System.Drawing.Point(51, 373)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(76, 55)
        Me.Button9.TabIndex = 27
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button8.Location = New System.Drawing.Point(51, 457)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(76, 55)
        Me.Button8.TabIndex = 26
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(169, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(996, 667)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Touch To Start. "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(995, 108)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Solaaa's Sandwiches "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 834)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button9 As Button
    Friend WithEvents FontDialog1 As FontDialog
End Class
