<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGamemaster
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
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnGame = New System.Windows.Forms.Button()
        Me.grpChangeColor = New System.Windows.Forms.GroupBox()
        Me.radYellow = New System.Windows.Forms.RadioButton()
        Me.radRed = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.picDraw = New System.Windows.Forms.PictureBox()
        Me.picDiscard = New System.Windows.Forms.PictureBox()
        Me.lblDiscardNum = New System.Windows.Forms.Label()
        Me.grpChangeColor.SuspendLayout()
        CType(Me.picDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiscard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(25, 25)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(149, 13)
        Me.lblSelect.TabIndex = 0
        Me.lblSelect.Text = "Initializing Game... Please wait"
        '
        'btnGame
        '
        Me.btnGame.Location = New System.Drawing.Point(28, 111)
        Me.btnGame.Name = "btnGame"
        Me.btnGame.Size = New System.Drawing.Size(158, 23)
        Me.btnGame.TabIndex = 1
        Me.btnGame.Text = "Start Game"
        Me.btnGame.UseVisualStyleBackColor = True
        '
        'grpChangeColor
        '
        Me.grpChangeColor.Controls.Add(Me.radYellow)
        Me.grpChangeColor.Controls.Add(Me.radRed)
        Me.grpChangeColor.Controls.Add(Me.radGreen)
        Me.grpChangeColor.Controls.Add(Me.radBlue)
        Me.grpChangeColor.Location = New System.Drawing.Point(12, 183)
        Me.grpChangeColor.Name = "grpChangeColor"
        Me.grpChangeColor.Size = New System.Drawing.Size(174, 109)
        Me.grpChangeColor.TabIndex = 2
        Me.grpChangeColor.TabStop = False
        '
        'radYellow
        '
        Me.radYellow.AutoSize = True
        Me.radYellow.Location = New System.Drawing.Point(6, 86)
        Me.radYellow.Name = "radYellow"
        Me.radYellow.Size = New System.Drawing.Size(56, 17)
        Me.radYellow.TabIndex = 3
        Me.radYellow.TabStop = True
        Me.radYellow.Text = "&Yellow"
        Me.radYellow.UseVisualStyleBackColor = True
        '
        'radRed
        '
        Me.radRed.AutoSize = True
        Me.radRed.Location = New System.Drawing.Point(6, 63)
        Me.radRed.Name = "radRed"
        Me.radRed.Size = New System.Drawing.Size(45, 17)
        Me.radRed.TabIndex = 2
        Me.radRed.TabStop = True
        Me.radRed.Text = "&Red"
        Me.radRed.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(6, 40)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(54, 17)
        Me.radGreen.TabIndex = 1
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "&Green"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(6, 19)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(46, 17)
        Me.radBlue.TabIndex = 0
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "&Blue"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'picDraw
        '
        Me.picDraw.Image = Global.FinalProject.My.Resources.Resources.facecover
        Me.picDraw.Location = New System.Drawing.Point(243, 44)
        Me.picDraw.Name = "picDraw"
        Me.picDraw.Size = New System.Drawing.Size(156, 196)
        Me.picDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDraw.TabIndex = 3
        Me.picDraw.TabStop = False
        Me.picDraw.Visible = False
        '
        'picDiscard
        '
        Me.picDiscard.Location = New System.Drawing.Point(432, 44)
        Me.picDiscard.Name = "picDiscard"
        Me.picDiscard.Size = New System.Drawing.Size(156, 196)
        Me.picDiscard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiscard.TabIndex = 4
        Me.picDiscard.TabStop = False
        '
        'lblDiscardNum
        '
        Me.lblDiscardNum.AutoSize = True
        Me.lblDiscardNum.Location = New System.Drawing.Point(499, 132)
        Me.lblDiscardNum.Name = "lblDiscardNum"
        Me.lblDiscardNum.Size = New System.Drawing.Size(0, 13)
        Me.lblDiscardNum.TabIndex = 5
        '
        'frmGamemaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 450)
        Me.Controls.Add(Me.lblDiscardNum)
        Me.Controls.Add(Me.picDiscard)
        Me.Controls.Add(Me.picDraw)
        Me.Controls.Add(Me.grpChangeColor)
        Me.Controls.Add(Me.btnGame)
        Me.Controls.Add(Me.lblSelect)
        Me.Name = "frmGamemaster"
        Me.Text = "Gamemaster Panel"
        Me.grpChangeColor.ResumeLayout(False)
        Me.grpChangeColor.PerformLayout()
        CType(Me.picDraw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiscard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelect As Label
    Friend WithEvents btnGame As Button
    Friend WithEvents grpChangeColor As GroupBox
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radYellow As RadioButton
    Friend WithEvents radRed As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents picDraw As PictureBox
    Friend WithEvents picDiscard As PictureBox
    Friend WithEvents lblDiscardNum As Label
End Class
