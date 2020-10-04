<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPratientsWeight
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
        Me.radKilograms = New System.Windows.Forms.RadioButton()
        Me.radPounds = New System.Windows.Forms.RadioButton()
        Me.btnDisplayWeight = New System.Windows.Forms.Button()
        Me.btnClearButton = New System.Windows.Forms.Button()
        Me.GrpWeightType = New System.Windows.Forms.GroupBox()
        Me.txtUserInput = New System.Windows.Forms.TextBox()
        Me.lblWeightCalculator = New System.Windows.Forms.Label()
        Me.lblInputWeightHere = New System.Windows.Forms.Label()
        Me.lblCovertedWeight = New System.Windows.Forms.Label()
        Me.lblConversion = New System.Windows.Forms.Label()
        Me.GrpWeightType.SuspendLayout()
        Me.SuspendLayout()
        '
        'radKilograms
        '
        Me.radKilograms.AutoSize = True
        Me.radKilograms.Checked = True
        Me.radKilograms.Location = New System.Drawing.Point(6, 39)
        Me.radKilograms.Name = "radKilograms"
        Me.radKilograms.Size = New System.Drawing.Size(121, 17)
        Me.radKilograms.TabIndex = 1
        Me.radKilograms.TabStop = True
        Me.radKilograms.Text = "Kilograms to Pounds"
        Me.radKilograms.UseVisualStyleBackColor = True
        '
        'radPounds
        '
        Me.radPounds.AutoSize = True
        Me.radPounds.Location = New System.Drawing.Point(6, 77)
        Me.radPounds.Name = "radPounds"
        Me.radPounds.Size = New System.Drawing.Size(121, 17)
        Me.radPounds.TabIndex = 2
        Me.radPounds.Text = "Pounds to Kilograms"
        Me.radPounds.UseVisualStyleBackColor = True
        '
        'btnDisplayWeight
        '
        Me.btnDisplayWeight.Location = New System.Drawing.Point(161, 343)
        Me.btnDisplayWeight.Name = "btnDisplayWeight"
        Me.btnDisplayWeight.Size = New System.Drawing.Size(104, 23)
        Me.btnDisplayWeight.TabIndex = 3
        Me.btnDisplayWeight.Text = "Display Weight"
        Me.btnDisplayWeight.UseVisualStyleBackColor = True
        '
        'btnClearButton
        '
        Me.btnClearButton.Location = New System.Drawing.Point(469, 343)
        Me.btnClearButton.Name = "btnClearButton"
        Me.btnClearButton.Size = New System.Drawing.Size(75, 23)
        Me.btnClearButton.TabIndex = 4
        Me.btnClearButton.Text = "Clear Button"
        Me.btnClearButton.UseVisualStyleBackColor = True
        '
        'GrpWeightType
        '
        Me.GrpWeightType.Controls.Add(Me.radPounds)
        Me.GrpWeightType.Controls.Add(Me.radKilograms)
        Me.GrpWeightType.Location = New System.Drawing.Point(344, 169)
        Me.GrpWeightType.Name = "GrpWeightType"
        Me.GrpWeightType.Size = New System.Drawing.Size(200, 100)
        Me.GrpWeightType.TabIndex = 5
        Me.GrpWeightType.TabStop = False
        Me.GrpWeightType.Text = "Weight Type"
        '
        'txtUserInput
        '
        Me.txtUserInput.Location = New System.Drawing.Point(344, 113)
        Me.txtUserInput.Name = "txtUserInput"
        Me.txtUserInput.Size = New System.Drawing.Size(100, 20)
        Me.txtUserInput.TabIndex = 6
        '
        'lblWeightCalculator
        '
        Me.lblWeightCalculator.AutoSize = True
        Me.lblWeightCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeightCalculator.Location = New System.Drawing.Point(245, 31)
        Me.lblWeightCalculator.Name = "lblWeightCalculator"
        Me.lblWeightCalculator.Size = New System.Drawing.Size(199, 25)
        Me.lblWeightCalculator.TabIndex = 7
        Me.lblWeightCalculator.Text = "Weight Calculator"
        '
        'lblInputWeightHere
        '
        Me.lblInputWeightHere.AutoSize = True
        Me.lblInputWeightHere.Location = New System.Drawing.Point(158, 113)
        Me.lblInputWeightHere.Name = "lblInputWeightHere"
        Me.lblInputWeightHere.Size = New System.Drawing.Size(92, 13)
        Me.lblInputWeightHere.TabIndex = 8
        Me.lblInputWeightHere.Text = "Input Weight here"
        '
        'lblCovertedWeight
        '
        Me.lblCovertedWeight.AutoSize = True
        Me.lblCovertedWeight.Location = New System.Drawing.Point(158, 312)
        Me.lblCovertedWeight.Name = "lblCovertedWeight"
        Me.lblCovertedWeight.Size = New System.Drawing.Size(96, 13)
        Me.lblCovertedWeight.TabIndex = 9
        Me.lblCovertedWeight.Text = "Converted Weight:"
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Location = New System.Drawing.Point(344, 311)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(39, 13)
        Me.lblConversion.TabIndex = 10
        Me.lblConversion.Text = "Label3"
        '
        'frmPratientsWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 563)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.lblCovertedWeight)
        Me.Controls.Add(Me.lblInputWeightHere)
        Me.Controls.Add(Me.lblWeightCalculator)
        Me.Controls.Add(Me.txtUserInput)
        Me.Controls.Add(Me.GrpWeightType)
        Me.Controls.Add(Me.btnClearButton)
        Me.Controls.Add(Me.btnDisplayWeight)
        Me.Name = "frmPratientsWeight"
        Me.Text = "Patients Weight"
        Me.GrpWeightType.ResumeLayout(False)
        Me.GrpWeightType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radKilograms As RadioButton
    Friend WithEvents radPounds As RadioButton
    Friend WithEvents btnDisplayWeight As Button
    Friend WithEvents btnClearButton As Button
    Friend WithEvents GrpWeightType As GroupBox
    Friend WithEvents txtUserInput As TextBox
    Friend WithEvents lblWeightCalculator As Label
    Friend WithEvents lblInputWeightHere As Label
    Friend WithEvents lblCovertedWeight As Label
    Friend WithEvents lblConversion As Label
End Class
