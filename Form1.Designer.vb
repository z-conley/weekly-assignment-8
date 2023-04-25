<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSmarthome
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
        Me.Picsmartphone = New System.Windows.Forms.PictureBox()
        Me.Lbltitle = New System.Windows.Forms.Label()
        Me.Lbltitle2 = New System.Windows.Forms.Label()
        Me.Cbomonthsavings = New System.Windows.Forms.ComboBox()
        Me.Lbltotsavings = New System.Windows.Forms.Label()
        Me.Lblavsavings = New System.Windows.Forms.Label()
        Me.Lblbestsavings = New System.Windows.Forms.Label()
        Me.Btndisplay = New System.Windows.Forms.Button()
        CType(Me.Picsmartphone, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picsmartphone
        '
        Me.Picsmartphone.Image = Global.weekly_assignment_8.My.Resources.Resources.smarthome
        Me.Picsmartphone.Location = New System.Drawing.Point(0, 0)
        Me.Picsmartphone.Name = "Picsmartphone"
        Me.Picsmartphone.Size = New System.Drawing.Size(285, 241)
        Me.Picsmartphone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picsmartphone.TabIndex = 0
        Me.Picsmartphone.TabStop = False
        '
        'Lbltitle
        '
        Me.Lbltitle.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle.Location = New System.Drawing.Point(444, 9)
        Me.Lbltitle.Name = "Lbltitle"
        Me.Lbltitle.Size = New System.Drawing.Size(230, 60)
        Me.Lbltitle.TabIndex = 1
        Me.Lbltitle.Text = "Smart Home"
        '
        'Lbltitle2
        '
        Me.Lbltitle2.AutoSize = True
        Me.Lbltitle2.Font = New System.Drawing.Font("Times New Roman", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltitle2.Location = New System.Drawing.Point(424, 59)
        Me.Lbltitle2.Name = "Lbltitle2"
        Me.Lbltitle2.Size = New System.Drawing.Size(270, 42)
        Me.Lbltitle2.TabIndex = 2
        Me.Lbltitle2.Text = "Electric Savings"
        '
        'Cbomonthsavings
        '
        Me.Cbomonthsavings.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbomonthsavings.FormattingEnabled = True
        Me.Cbomonthsavings.ItemHeight = 24
        Me.Cbomonthsavings.Location = New System.Drawing.Point(483, 135)
        Me.Cbomonthsavings.Name = "Cbomonthsavings"
        Me.Cbomonthsavings.Size = New System.Drawing.Size(136, 32)
        Me.Cbomonthsavings.TabIndex = 3
        '
        'Lbltotsavings
        '
        Me.Lbltotsavings.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotsavings.Location = New System.Drawing.Point(155, 273)
        Me.Lbltotsavings.Name = "Lbltotsavings"
        Me.Lbltotsavings.Size = New System.Drawing.Size(475, 29)
        Me.Lbltotsavings.TabIndex = 4
        Me.Lbltotsavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblavsavings
        '
        Me.Lblavsavings.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblavsavings.Location = New System.Drawing.Point(155, 360)
        Me.Lblavsavings.Name = "Lblavsavings"
        Me.Lblavsavings.Size = New System.Drawing.Size(475, 30)
        Me.Lblavsavings.TabIndex = 5
        Me.Lblavsavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lblbestsavings
        '
        Me.Lblbestsavings.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbestsavings.Location = New System.Drawing.Point(74, 406)
        Me.Lblbestsavings.Name = "Lblbestsavings"
        Me.Lblbestsavings.Size = New System.Drawing.Size(649, 35)
        Me.Lblbestsavings.TabIndex = 6
        Me.Lblbestsavings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btndisplay
        '
        Me.Btndisplay.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btndisplay.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btndisplay.ForeColor = System.Drawing.Color.Transparent
        Me.Btndisplay.Location = New System.Drawing.Point(294, 305)
        Me.Btndisplay.Name = "Btndisplay"
        Me.Btndisplay.Size = New System.Drawing.Size(217, 42)
        Me.Btndisplay.TabIndex = 7
        Me.Btndisplay.Text = "Display Stats"
        Me.Btndisplay.UseVisualStyleBackColor = False
        Me.Btndisplay.Visible = False
        '
        'FrmSmarthome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btndisplay)
        Me.Controls.Add(Me.Lblbestsavings)
        Me.Controls.Add(Me.Lblavsavings)
        Me.Controls.Add(Me.Lbltotsavings)
        Me.Controls.Add(Me.Cbomonthsavings)
        Me.Controls.Add(Me.Lbltitle2)
        Me.Controls.Add(Me.Lbltitle)
        Me.Controls.Add(Me.Picsmartphone)
        Me.Name = "FrmSmarthome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Picsmartphone, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picsmartphone As PictureBox
    Friend WithEvents Lbltitle As Label
    Friend WithEvents Lbltitle2 As Label
    Friend WithEvents Cbomonthsavings As ComboBox
    Friend WithEvents Lbltotsavings As Label
    Friend WithEvents Lblavsavings As Label
    Friend WithEvents Lblbestsavings As Label
    Friend WithEvents Btndisplay As Button
End Class
