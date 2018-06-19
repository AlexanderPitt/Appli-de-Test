<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrafficMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(668, 279)
        Me.textBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(196, 31)
        Me.textBox1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(994, 279)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 44)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(668, 94)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(412, 44)
        Me.ProgressBar1.TabIndex = 5
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(668, 181)
        Me.TrackBar1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(412, 90)
        Me.TrackBar1.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(46, 94)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(464, 33)
        Me.ComboBox1.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 633)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textBox1)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "TrafficMain"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents textBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox

End Class
