<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DW_Load
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
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtAT = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAD = New System.Windows.Forms.TextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(59, 40)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(224, 48)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 3
        Me.RectangleShape2.Location = New System.Drawing.Point(46, 31)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(248, 66)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.RectangleShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(333, 155)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Location = New System.Drawing.Point(179, 132)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 15)
        Me.Label21.TabIndex = 306
        Me.Label21.Text = "AT"
        '
        'txtAT
        '
        Me.txtAT.Enabled = False
        Me.txtAT.Location = New System.Drawing.Point(208, 129)
        Me.txtAT.Name = "txtAT"
        Me.txtAT.Size = New System.Drawing.Size(68, 20)
        Me.txtAT.TabIndex = 305
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Location = New System.Drawing.Point(59, 132)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 15)
        Me.Label18.TabIndex = 304
        Me.Label18.Text = "AD"
        '
        'txtAD
        '
        Me.txtAD.Enabled = False
        Me.txtAD.Location = New System.Drawing.Point(88, 129)
        Me.txtAD.Name = "txtAD"
        Me.txtAD.Size = New System.Drawing.Size(61, 20)
        Me.txtAD.TabIndex = 303
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -147
        Me.LineShape1.X2 = 478
        Me.LineShape1.Y1 = 118
        Me.LineShape1.Y2 = 118
        '
        'Timer1
        '
        '
        'DW_Load
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 155)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtAT)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtAD)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DW_Load"
        Me.Text = "DW_Load"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtAT As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAD As System.Windows.Forms.TextBox
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
