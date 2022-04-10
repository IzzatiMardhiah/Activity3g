<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(41, 57)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(94, 29)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "Spin"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(41, 107)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(94, 29)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(213, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 123)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(386, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 123)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(553, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 123)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "0"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Activity3g.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(420, 220)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 173)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 28.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.IndianRed
        Me.Label4.Location = New System.Drawing.Point(41, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 62)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "LUCKY SEVEN"
        '
        'lblWin
        '
        Me.lblWin.AutoSize = True
        Me.lblWin.Font = New System.Drawing.Font("Arial", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lblWin.ForeColor = System.Drawing.Color.Green
        Me.lblWin.Location = New System.Drawing.Point(136, 304)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(77, 24)
        Me.lblWin.TabIndex = 7
        Me.lblWin.Text = "Win : 0"
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnSpin)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblWin As Label
End Class
