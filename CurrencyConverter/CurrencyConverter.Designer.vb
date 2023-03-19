<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrencyConverter
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
        Me.SterlingGroupBox = New System.Windows.Forms.GroupBox()
        Me.lblUpdatedSterling = New System.Windows.Forms.Label()
        Me.UpdateSterlingBtn = New System.Windows.Forms.Button()
        Me.SterlingTextBox = New System.Windows.Forms.TextBox()
        Me.lblSterling = New System.Windows.Forms.Label()
        Me.EuroGroupBox = New System.Windows.Forms.GroupBox()
        Me.UpdateEuroRate = New System.Windows.Forms.Button()
        Me.lblEuroRateUpdate = New System.Windows.Forms.Label()
        Me.EuroTextBox = New System.Windows.Forms.TextBox()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.ConverterBox = New System.Windows.Forms.GroupBox()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.lblCalucaltedAmount = New System.Windows.Forms.Label()
        Me.EuroRadioBtn = New System.Windows.Forms.RadioButton()
        Me.SterlingRadioBtn = New System.Windows.Forms.RadioButton()
        Me.dblAmountBox = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.ClearAll = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SterlingGroupBox.SuspendLayout()
        Me.EuroGroupBox.SuspendLayout()
        Me.ConverterBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SterlingGroupBox
        '
        Me.SterlingGroupBox.Controls.Add(Me.lblUpdatedSterling)
        Me.SterlingGroupBox.Controls.Add(Me.UpdateSterlingBtn)
        Me.SterlingGroupBox.Controls.Add(Me.SterlingTextBox)
        Me.SterlingGroupBox.Controls.Add(Me.lblSterling)
        Me.SterlingGroupBox.Location = New System.Drawing.Point(94, 85)
        Me.SterlingGroupBox.Name = "SterlingGroupBox"
        Me.SterlingGroupBox.Size = New System.Drawing.Size(300, 134)
        Me.SterlingGroupBox.TabIndex = 0
        Me.SterlingGroupBox.TabStop = False
        Me.SterlingGroupBox.Text = "Sterling Group"
        '
        'lblUpdatedSterling
        '
        Me.lblUpdatedSterling.AutoSize = True
        Me.lblUpdatedSterling.Location = New System.Drawing.Point(117, 70)
        Me.lblUpdatedSterling.Name = "lblUpdatedSterling"
        Me.lblUpdatedSterling.Size = New System.Drawing.Size(0, 13)
        Me.lblUpdatedSterling.TabIndex = 3
        '
        'UpdateSterlingBtn
        '
        Me.UpdateSterlingBtn.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateSterlingBtn.Location = New System.Drawing.Point(67, 101)
        Me.UpdateSterlingBtn.Name = "UpdateSterlingBtn"
        Me.UpdateSterlingBtn.Size = New System.Drawing.Size(166, 33)
        Me.UpdateSterlingBtn.TabIndex = 2
        Me.UpdateSterlingBtn.Text = "Update Sterling Rate"
        Me.UpdateSterlingBtn.UseVisualStyleBackColor = True
        '
        'SterlingTextBox
        '
        Me.SterlingTextBox.Location = New System.Drawing.Point(139, 34)
        Me.SterlingTextBox.Name = "SterlingTextBox"
        Me.SterlingTextBox.Size = New System.Drawing.Size(118, 20)
        Me.SterlingTextBox.TabIndex = 1
        '
        'lblSterling
        '
        Me.lblSterling.AutoSize = True
        Me.lblSterling.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSterling.Location = New System.Drawing.Point(18, 35)
        Me.lblSterling.Name = "lblSterling"
        Me.lblSterling.Size = New System.Drawing.Size(99, 19)
        Me.lblSterling.TabIndex = 0
        Me.lblSterling.Text = "Sterling Rate"
        '
        'EuroGroupBox
        '
        Me.EuroGroupBox.Controls.Add(Me.UpdateEuroRate)
        Me.EuroGroupBox.Controls.Add(Me.lblEuroRateUpdate)
        Me.EuroGroupBox.Controls.Add(Me.EuroTextBox)
        Me.EuroGroupBox.Controls.Add(Me.lblEuro)
        Me.EuroGroupBox.Location = New System.Drawing.Point(515, 85)
        Me.EuroGroupBox.Name = "EuroGroupBox"
        Me.EuroGroupBox.Size = New System.Drawing.Size(300, 139)
        Me.EuroGroupBox.TabIndex = 1
        Me.EuroGroupBox.TabStop = False
        Me.EuroGroupBox.Text = "EuroGroup"
        '
        'UpdateEuroRate
        '
        Me.UpdateEuroRate.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateEuroRate.Location = New System.Drawing.Point(92, 95)
        Me.UpdateEuroRate.Name = "UpdateEuroRate"
        Me.UpdateEuroRate.Size = New System.Drawing.Size(146, 33)
        Me.UpdateEuroRate.TabIndex = 3
        Me.UpdateEuroRate.Text = "Update Euro Rate"
        Me.UpdateEuroRate.UseVisualStyleBackColor = True
        '
        'lblEuroRateUpdate
        '
        Me.lblEuroRateUpdate.AutoSize = True
        Me.lblEuroRateUpdate.Location = New System.Drawing.Point(103, 70)
        Me.lblEuroRateUpdate.Name = "lblEuroRateUpdate"
        Me.lblEuroRateUpdate.Size = New System.Drawing.Size(0, 13)
        Me.lblEuroRateUpdate.TabIndex = 2
        '
        'EuroTextBox
        '
        Me.EuroTextBox.Location = New System.Drawing.Point(121, 31)
        Me.EuroTextBox.Name = "EuroTextBox"
        Me.EuroTextBox.Size = New System.Drawing.Size(132, 20)
        Me.EuroTextBox.TabIndex = 1
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuro.Location = New System.Drawing.Point(27, 31)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(69, 17)
        Me.lblEuro.TabIndex = 0
        Me.lblEuro.Text = "Euro Rate"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.SystemColors.GrayText
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitle.Location = New System.Drawing.Point(311, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(290, 23)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Belfast Holidy Currency Converter"
        '
        'ConverterBox
        '
        Me.ConverterBox.Controls.Add(Me.CalculateBtn)
        Me.ConverterBox.Controls.Add(Me.lblCalucaltedAmount)
        Me.ConverterBox.Controls.Add(Me.EuroRadioBtn)
        Me.ConverterBox.Controls.Add(Me.SterlingRadioBtn)
        Me.ConverterBox.Controls.Add(Me.dblAmountBox)
        Me.ConverterBox.Controls.Add(Me.lblAmount)
        Me.ConverterBox.Location = New System.Drawing.Point(94, 276)
        Me.ConverterBox.Name = "ConverterBox"
        Me.ConverterBox.Size = New System.Drawing.Size(721, 172)
        Me.ConverterBox.TabIndex = 3
        Me.ConverterBox.TabStop = False
        Me.ConverterBox.Text = "ConverterGoup"
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculateBtn.Location = New System.Drawing.Point(221, 120)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(168, 37)
        Me.CalculateBtn.TabIndex = 5
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'lblCalucaltedAmount
        '
        Me.lblCalucaltedAmount.AutoSize = True
        Me.lblCalucaltedAmount.Location = New System.Drawing.Point(218, 86)
        Me.lblCalucaltedAmount.Name = "lblCalucaltedAmount"
        Me.lblCalucaltedAmount.Size = New System.Drawing.Size(96, 13)
        Me.lblCalucaltedAmount.TabIndex = 4
        Me.lblCalucaltedAmount.Text = "Calculated Amount"
        '
        'EuroRadioBtn
        '
        Me.EuroRadioBtn.AutoSize = True
        Me.EuroRadioBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EuroRadioBtn.Location = New System.Drawing.Point(494, 37)
        Me.EuroRadioBtn.Name = "EuroRadioBtn"
        Me.EuroRadioBtn.Size = New System.Drawing.Size(60, 23)
        Me.EuroRadioBtn.TabIndex = 3
        Me.EuroRadioBtn.TabStop = True
        Me.EuroRadioBtn.Text = "Euro"
        Me.EuroRadioBtn.UseVisualStyleBackColor = True
        '
        'SterlingRadioBtn
        '
        Me.SterlingRadioBtn.AutoSize = True
        Me.SterlingRadioBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SterlingRadioBtn.Location = New System.Drawing.Point(369, 37)
        Me.SterlingRadioBtn.Name = "SterlingRadioBtn"
        Me.SterlingRadioBtn.Size = New System.Drawing.Size(81, 23)
        Me.SterlingRadioBtn.TabIndex = 2
        Me.SterlingRadioBtn.TabStop = True
        Me.SterlingRadioBtn.Text = "Sterling"
        Me.SterlingRadioBtn.UseVisualStyleBackColor = True
        '
        'dblAmountBox
        '
        Me.dblAmountBox.Location = New System.Drawing.Point(139, 34)
        Me.dblAmountBox.Name = "dblAmountBox"
        Me.dblAmountBox.Size = New System.Drawing.Size(161, 20)
        Me.dblAmountBox.TabIndex = 1
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.lblAmount.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(39, 32)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(72, 22)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount"
        '
        'ClearAll
        '
        Me.ClearAll.Location = New System.Drawing.Point(778, 38)
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(80, 31)
        Me.ClearAll.TabIndex = 4
        Me.ClearAll.Text = "Clear"
        Me.ClearAll.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(91, 47)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(0, 13)
        Me.lblDate.TabIndex = 5
        '
        'CurrencyConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 460)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.ClearAll)
        Me.Controls.Add(Me.ConverterBox)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.EuroGroupBox)
        Me.Controls.Add(Me.SterlingGroupBox)
        Me.Name = "CurrencyConverter"
        Me.Text = "Currency Converter"
        Me.SterlingGroupBox.ResumeLayout(False)
        Me.SterlingGroupBox.PerformLayout()
        Me.EuroGroupBox.ResumeLayout(False)
        Me.EuroGroupBox.PerformLayout()
        Me.ConverterBox.ResumeLayout(False)
        Me.ConverterBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SterlingGroupBox As GroupBox
    Friend WithEvents lblUpdatedSterling As Label
    Friend WithEvents UpdateSterlingBtn As Button
    Friend WithEvents SterlingTextBox As TextBox
    Friend WithEvents lblSterling As Label
    Friend WithEvents EuroGroupBox As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents ConverterBox As GroupBox
    Friend WithEvents UpdateEuroRate As Button
    Friend WithEvents lblEuroRateUpdate As Label
    Friend WithEvents EuroTextBox As TextBox
    Friend WithEvents lblEuro As Label
    Friend WithEvents ClearAll As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents lblCalucaltedAmount As Label
    Friend WithEvents EuroRadioBtn As RadioButton
    Friend WithEvents SterlingRadioBtn As RadioButton
    Friend WithEvents dblAmountBox As TextBox
    Friend WithEvents lblAmount As Label
End Class
