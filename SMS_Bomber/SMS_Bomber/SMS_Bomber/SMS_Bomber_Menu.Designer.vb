<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.OpenFileSMSDialog = New System.Windows.Forms.OpenFileDialog()
        Me.OpenSMSFileTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileButton = New System.Windows.Forms.Button()
        Me.SMSGatewaysComboBox = New System.Windows.Forms.ComboBox()
        Me.OpenSMSFileLabel = New System.Windows.Forms.Label()
        Me.SMSGatewaysLabel = New System.Windows.Forms.Label()
        Me.TargetTextBox = New System.Windows.Forms.TextBox()
        Me.TargetLabel = New System.Windows.Forms.Label()
        Me.TargetCountLabel = New System.Windows.Forms.Label()
        Me.SendFromSMTPButton = New System.Windows.Forms.Button()
        Me.ThresholdLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PayloadTextBox = New System.Windows.Forms.TextBox()
        Me.ThresholdNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.QTYNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SubjectTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectLabel = New System.Windows.Forms.Label()
        Me.FromLabel = New System.Windows.Forms.Label()
        Me.FromTextBox = New System.Windows.Forms.TextBox()
        Me.CarrierLabel = New System.Windows.Forms.LinkLabel()
        Me.OpenSMTPFileLabel = New System.Windows.Forms.Label()
        Me.OpenFileSMTPButton = New System.Windows.Forms.Button()
        Me.OpenFileSMTPTextBox = New System.Windows.Forms.TextBox()
        Me.OpenFileSMTPDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SMTPPasswordMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SMTPPasswordLabel = New System.Windows.Forms.Label()
        Me.SMTPLoginTextBox = New System.Windows.Forms.TextBox()
        Me.SMTPLoginLabel = New System.Windows.Forms.Label()
        Me.SMTPRelaysComboBox = New System.Windows.Forms.ComboBox()
        Me.SMTPRelaysLabel = New System.Windows.Forms.Label()
        Me.SMTPPortNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.SMTPPortLabel = New System.Windows.Forms.Label()
        Me.SSLCheckBox = New System.Windows.Forms.CheckBox()
        Me.BombProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.TimeOutNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.TimeOutLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.GettingStartedMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcceptableUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ThresholdNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QTYNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMTPPortNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeOutNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(625, 371)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(82, 23)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'OpenFileSMSDialog
        '
        Me.OpenFileSMSDialog.Title = "Select your SMS Gateway List"
        '
        'OpenSMSFileTextBox
        '
        Me.OpenSMSFileTextBox.Location = New System.Drawing.Point(11, 78)
        Me.OpenSMSFileTextBox.Name = "OpenSMSFileTextBox"
        Me.OpenSMSFileTextBox.Size = New System.Drawing.Size(121, 20)
        Me.OpenSMSFileTextBox.TabIndex = 2
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Location = New System.Drawing.Point(138, 78)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenFileButton.TabIndex = 3
        Me.OpenFileButton.Text = "Browse"
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'SMSGatewaysComboBox
        '
        Me.SMSGatewaysComboBox.FormattingEnabled = True
        Me.SMSGatewaysComboBox.Location = New System.Drawing.Point(229, 50)
        Me.SMSGatewaysComboBox.Name = "SMSGatewaysComboBox"
        Me.SMSGatewaysComboBox.Size = New System.Drawing.Size(188, 21)
        Me.SMSGatewaysComboBox.TabIndex = 4
        '
        'OpenSMSFileLabel
        '
        Me.OpenSMSFileLabel.AutoSize = True
        Me.OpenSMSFileLabel.Location = New System.Drawing.Point(12, 59)
        Me.OpenSMSFileLabel.Name = "OpenSMSFileLabel"
        Me.OpenSMSFileLabel.Size = New System.Drawing.Size(126, 13)
        Me.OpenSMSFileLabel.TabIndex = 5
        Me.OpenSMSFileLabel.Text = "Import SMS Gateway List"
        '
        'SMSGatewaysLabel
        '
        Me.SMSGatewaysLabel.AutoSize = True
        Me.SMSGatewaysLabel.Location = New System.Drawing.Point(230, 34)
        Me.SMSGatewaysLabel.Name = "SMSGatewaysLabel"
        Me.SMSGatewaysLabel.Size = New System.Drawing.Size(114, 13)
        Me.SMSGatewaysLabel.TabIndex = 6
        Me.SMSGatewaysLabel.Text = "Choose SMS Gateway"
        '
        'TargetTextBox
        '
        Me.TargetTextBox.Location = New System.Drawing.Point(229, 90)
        Me.TargetTextBox.Name = "TargetTextBox"
        Me.TargetTextBox.Size = New System.Drawing.Size(188, 20)
        Me.TargetTextBox.TabIndex = 7
        Me.TargetTextBox.Text = "+15555556789"
        '
        'TargetLabel
        '
        Me.TargetLabel.AutoSize = True
        Me.TargetLabel.Location = New System.Drawing.Point(226, 74)
        Me.TargetLabel.Name = "TargetLabel"
        Me.TargetLabel.Size = New System.Drawing.Size(107, 13)
        Me.TargetLabel.TabIndex = 8
        Me.TargetLabel.Text = "Enter Target Phone#"
        '
        'TargetCountLabel
        '
        Me.TargetCountLabel.AutoSize = True
        Me.TargetCountLabel.Location = New System.Drawing.Point(28, 191)
        Me.TargetCountLabel.Name = "TargetCountLabel"
        Me.TargetCountLabel.Size = New System.Drawing.Size(98, 13)
        Me.TargetCountLabel.TabIndex = 10
        Me.TargetCountLabel.Text = "Enter QTY of Texts"
        '
        'SendFromSMTPButton
        '
        Me.SendFromSMTPButton.Location = New System.Drawing.Point(625, 259)
        Me.SendFromSMTPButton.Name = "SendFromSMTPButton"
        Me.SendFromSMTPButton.Size = New System.Drawing.Size(82, 83)
        Me.SendFromSMTPButton.TabIndex = 11
        Me.SendFromSMTPButton.Text = "Bombs Away"
        Me.SendFromSMTPButton.UseVisualStyleBackColor = True
        '
        'ThresholdLabel
        '
        Me.ThresholdLabel.AutoSize = True
        Me.ThresholdLabel.Location = New System.Drawing.Point(28, 242)
        Me.ThresholdLabel.Name = "ThresholdLabel"
        Me.ThresholdLabel.Size = New System.Drawing.Size(105, 13)
        Me.ThresholdLabel.TabIndex = 13
        Me.ThresholdLabel.Text = "Threshold (Seconds)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Message / Payload"
        '
        'PayloadTextBox
        '
        Me.PayloadTextBox.Location = New System.Drawing.Point(229, 221)
        Me.PayloadTextBox.MaxLength = 2147483647
        Me.PayloadTextBox.Multiline = True
        Me.PayloadTextBox.Name = "PayloadTextBox"
        Me.PayloadTextBox.Size = New System.Drawing.Size(188, 98)
        Me.PayloadTextBox.TabIndex = 16
        Me.PayloadTextBox.Text = "Some Hate, Phishing Link, or KnownTextPushSMSStackExploit Here + AT+CMGL=""ALL""<CR" & _
    ">"
        '
        'ThresholdNumericUpDown
        '
        Me.ThresholdNumericUpDown.DecimalPlaces = 1
        Me.ThresholdNumericUpDown.Location = New System.Drawing.Point(31, 259)
        Me.ThresholdNumericUpDown.Maximum = New Decimal(New Integer() {600, 0, 0, 0})
        Me.ThresholdNumericUpDown.Name = "ThresholdNumericUpDown"
        Me.ThresholdNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.ThresholdNumericUpDown.TabIndex = 17
        Me.ThresholdNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'QTYNumericUpDown
        '
        Me.QTYNumericUpDown.Location = New System.Drawing.Point(31, 207)
        Me.QTYNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QTYNumericUpDown.Name = "QTYNumericUpDown"
        Me.QTYNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.QTYNumericUpDown.TabIndex = 18
        Me.QTYNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.Location = New System.Drawing.Point(229, 168)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.Size = New System.Drawing.Size(188, 20)
        Me.SubjectTextBox.TabIndex = 19
        Me.SubjectTextBox.Text = "Random Subject Here"
        '
        'SubjectLabel
        '
        Me.SubjectLabel.AutoSize = True
        Me.SubjectLabel.Location = New System.Drawing.Point(226, 152)
        Me.SubjectLabel.Name = "SubjectLabel"
        Me.SubjectLabel.Size = New System.Drawing.Size(46, 13)
        Me.SubjectLabel.TabIndex = 20
        Me.SubjectLabel.Text = "Subject:"
        '
        'FromLabel
        '
        Me.FromLabel.AutoSize = True
        Me.FromLabel.Location = New System.Drawing.Point(226, 113)
        Me.FromLabel.Name = "FromLabel"
        Me.FromLabel.Size = New System.Drawing.Size(33, 13)
        Me.FromLabel.TabIndex = 22
        Me.FromLabel.Text = "From:"
        '
        'FromTextBox
        '
        Me.FromTextBox.Location = New System.Drawing.Point(229, 129)
        Me.FromTextBox.Name = "FromTextBox"
        Me.FromTextBox.Size = New System.Drawing.Size(188, 20)
        Me.FromTextBox.TabIndex = 21
        Me.FromTextBox.Text = "+15555551234@spoofdomain.com"
        '
        'CarrierLabel
        '
        Me.CarrierLabel.AutoSize = True
        Me.CarrierLabel.Location = New System.Drawing.Point(9, 34)
        Me.CarrierLabel.Name = "CarrierLabel"
        Me.CarrierLabel.Size = New System.Drawing.Size(117, 13)
        Me.CarrierLabel.TabIndex = 23
        Me.CarrierLabel.TabStop = True
        Me.CarrierLabel.Text = "Lookup Target's Carrier"
        '
        'OpenSMTPFileLabel
        '
        Me.OpenSMTPFileLabel.AutoSize = True
        Me.OpenSMTPFileLabel.Location = New System.Drawing.Point(12, 113)
        Me.OpenSMTPFileLabel.Name = "OpenSMTPFileLabel"
        Me.OpenSMTPFileLabel.Size = New System.Drawing.Size(118, 13)
        Me.OpenSMTPFileLabel.TabIndex = 26
        Me.OpenSMTPFileLabel.Text = "Import SMTP Relay List"
        '
        'OpenFileSMTPButton
        '
        Me.OpenFileSMTPButton.Location = New System.Drawing.Point(138, 132)
        Me.OpenFileSMTPButton.Name = "OpenFileSMTPButton"
        Me.OpenFileSMTPButton.Size = New System.Drawing.Size(75, 23)
        Me.OpenFileSMTPButton.TabIndex = 25
        Me.OpenFileSMTPButton.Text = "Browse"
        Me.OpenFileSMTPButton.UseVisualStyleBackColor = True
        '
        'OpenFileSMTPTextBox
        '
        Me.OpenFileSMTPTextBox.Location = New System.Drawing.Point(11, 132)
        Me.OpenFileSMTPTextBox.Name = "OpenFileSMTPTextBox"
        Me.OpenFileSMTPTextBox.Size = New System.Drawing.Size(121, 20)
        Me.OpenFileSMTPTextBox.TabIndex = 24
        '
        'OpenFileSMTPDialog
        '
        Me.OpenFileSMTPDialog.Title = "Select your SMTP Relay List"
        '
        'SMTPPasswordMaskedTextBox
        '
        Me.SMTPPasswordMaskedTextBox.Location = New System.Drawing.Point(442, 136)
        Me.SMTPPasswordMaskedTextBox.Name = "SMTPPasswordMaskedTextBox"
        Me.SMTPPasswordMaskedTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SMTPPasswordMaskedTextBox.Size = New System.Drawing.Size(188, 20)
        Me.SMTPPasswordMaskedTextBox.TabIndex = 28
        '
        'SMTPPasswordLabel
        '
        Me.SMTPPasswordLabel.AutoSize = True
        Me.SMTPPasswordLabel.Location = New System.Drawing.Point(439, 120)
        Me.SMTPPasswordLabel.Name = "SMTPPasswordLabel"
        Me.SMTPPasswordLabel.Size = New System.Drawing.Size(86, 13)
        Me.SMTPPasswordLabel.TabIndex = 29
        Me.SMTPPasswordLabel.Text = "SMTP Password"
        '
        'SMTPLoginTextBox
        '
        Me.SMTPLoginTextBox.Location = New System.Drawing.Point(442, 97)
        Me.SMTPLoginTextBox.Name = "SMTPLoginTextBox"
        Me.SMTPLoginTextBox.Size = New System.Drawing.Size(188, 20)
        Me.SMTPLoginTextBox.TabIndex = 30
        '
        'SMTPLoginLabel
        '
        Me.SMTPLoginLabel.AutoSize = True
        Me.SMTPLoginLabel.Location = New System.Drawing.Point(439, 81)
        Me.SMTPLoginLabel.Name = "SMTPLoginLabel"
        Me.SMTPLoginLabel.Size = New System.Drawing.Size(66, 13)
        Me.SMTPLoginLabel.TabIndex = 31
        Me.SMTPLoginLabel.Text = "SMTP Login"
        '
        'SMTPRelaysComboBox
        '
        Me.SMTPRelaysComboBox.FormattingEnabled = True
        Me.SMTPRelaysComboBox.Location = New System.Drawing.Point(442, 50)
        Me.SMTPRelaysComboBox.Name = "SMTPRelaysComboBox"
        Me.SMTPRelaysComboBox.Size = New System.Drawing.Size(188, 21)
        Me.SMTPRelaysComboBox.TabIndex = 32
        '
        'SMTPRelaysLabel
        '
        Me.SMTPRelaysLabel.AutoSize = True
        Me.SMTPRelaysLabel.Location = New System.Drawing.Point(439, 34)
        Me.SMTPRelaysLabel.Name = "SMTPRelaysLabel"
        Me.SMTPRelaysLabel.Size = New System.Drawing.Size(106, 13)
        Me.SMTPRelaysLabel.TabIndex = 33
        Me.SMTPRelaysLabel.Text = "Choose SMTP Relay"
        '
        'SMTPPortNumericUpDown
        '
        Me.SMTPPortNumericUpDown.Location = New System.Drawing.Point(442, 184)
        Me.SMTPPortNumericUpDown.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
        Me.SMTPPortNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SMTPPortNumericUpDown.Name = "SMTPPortNumericUpDown"
        Me.SMTPPortNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.SMTPPortNumericUpDown.TabIndex = 35
        Me.SMTPPortNumericUpDown.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'SMTPPortLabel
        '
        Me.SMTPPortLabel.AutoSize = True
        Me.SMTPPortLabel.Location = New System.Drawing.Point(439, 168)
        Me.SMTPPortLabel.Name = "SMTPPortLabel"
        Me.SMTPPortLabel.Size = New System.Drawing.Size(59, 13)
        Me.SMTPPortLabel.TabIndex = 34
        Me.SMTPPortLabel.Text = "SMTP Port"
        '
        'SSLCheckBox
        '
        Me.SSLCheckBox.AutoSize = True
        Me.SSLCheckBox.Location = New System.Drawing.Point(504, 187)
        Me.SSLCheckBox.Name = "SSLCheckBox"
        Me.SSLCheckBox.Size = New System.Drawing.Size(92, 17)
        Me.SSLCheckBox.TabIndex = 37
        Me.SSLCheckBox.Text = "SSL Required"
        Me.SSLCheckBox.UseVisualStyleBackColor = True
        '
        'BombProgressBar
        '
        Me.BombProgressBar.Location = New System.Drawing.Point(10, 371)
        Me.BombProgressBar.Name = "BombProgressBar"
        Me.BombProgressBar.Size = New System.Drawing.Size(586, 23)
        Me.BombProgressBar.TabIndex = 38
        '
        'ProgressLabel
        '
        Me.ProgressLabel.AutoSize = True
        Me.ProgressLabel.Location = New System.Drawing.Point(12, 355)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(48, 13)
        Me.ProgressLabel.TabIndex = 39
        Me.ProgressLabel.Text = "Progress"
        '
        'TimeOutNumericUpDown
        '
        Me.TimeOutNumericUpDown.Location = New System.Drawing.Point(442, 237)
        Me.TimeOutNumericUpDown.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.TimeOutNumericUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TimeOutNumericUpDown.Name = "TimeOutNumericUpDown"
        Me.TimeOutNumericUpDown.Size = New System.Drawing.Size(46, 20)
        Me.TimeOutNumericUpDown.TabIndex = 41
        Me.TimeOutNumericUpDown.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'TimeOutLabel
        '
        Me.TimeOutLabel.AutoSize = True
        Me.TimeOutLabel.Location = New System.Drawing.Point(439, 221)
        Me.TimeOutLabel.Name = "TimeOutLabel"
        Me.TimeOutLabel.Size = New System.Drawing.Size(94, 13)
        Me.TimeOutLabel.TabIndex = 40
        Me.TimeOutLabel.Text = "Timeout (seconds)"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.HelpMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(719, 24)
        Me.MenuStrip1.TabIndex = 42
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GettingStartedMenu, Me.AboutMenu, Me.AcceptableUseToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "Help"
        '
        'GettingStartedMenu
        '
        Me.GettingStartedMenu.Name = "GettingStartedMenu"
        Me.GettingStartedMenu.Size = New System.Drawing.Size(153, 22)
        Me.GettingStartedMenu.Text = "Getting Started"
        '
        'AboutMenu
        '
        Me.AboutMenu.Name = "AboutMenu"
        Me.AboutMenu.Size = New System.Drawing.Size(153, 22)
        Me.AboutMenu.Text = "About"
        '
        'AcceptableUseToolStripMenuItem
        '
        Me.AcceptableUseToolStripMenuItem.Name = "AcceptableUseToolStripMenuItem"
        Me.AcceptableUseToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AcceptableUseToolStripMenuItem.Text = "Acceptable Use"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 406)
        Me.Controls.Add(Me.TimeOutNumericUpDown)
        Me.Controls.Add(Me.TimeOutLabel)
        Me.Controls.Add(Me.ProgressLabel)
        Me.Controls.Add(Me.BombProgressBar)
        Me.Controls.Add(Me.SSLCheckBox)
        Me.Controls.Add(Me.SMTPPortNumericUpDown)
        Me.Controls.Add(Me.SMTPPortLabel)
        Me.Controls.Add(Me.SMTPRelaysLabel)
        Me.Controls.Add(Me.SMTPRelaysComboBox)
        Me.Controls.Add(Me.SMTPLoginLabel)
        Me.Controls.Add(Me.SMTPLoginTextBox)
        Me.Controls.Add(Me.SMTPPasswordLabel)
        Me.Controls.Add(Me.SMTPPasswordMaskedTextBox)
        Me.Controls.Add(Me.OpenSMTPFileLabel)
        Me.Controls.Add(Me.OpenFileSMTPButton)
        Me.Controls.Add(Me.OpenFileSMTPTextBox)
        Me.Controls.Add(Me.CarrierLabel)
        Me.Controls.Add(Me.FromLabel)
        Me.Controls.Add(Me.FromTextBox)
        Me.Controls.Add(Me.SubjectLabel)
        Me.Controls.Add(Me.SubjectTextBox)
        Me.Controls.Add(Me.QTYNumericUpDown)
        Me.Controls.Add(Me.ThresholdNumericUpDown)
        Me.Controls.Add(Me.PayloadTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ThresholdLabel)
        Me.Controls.Add(Me.SendFromSMTPButton)
        Me.Controls.Add(Me.TargetCountLabel)
        Me.Controls.Add(Me.TargetLabel)
        Me.Controls.Add(Me.TargetTextBox)
        Me.Controls.Add(Me.SMSGatewaysLabel)
        Me.Controls.Add(Me.OpenSMSFileLabel)
        Me.Controls.Add(Me.SMSGatewaysComboBox)
        Me.Controls.Add(Me.OpenFileButton)
        Me.Controls.Add(Me.OpenSMSFileTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.Text = "SMS Bomber v1.0"
        CType(Me.ThresholdNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QTYNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMTPPortNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeOutNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileSMSDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenSMSFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileButton As System.Windows.Forms.Button
    Friend WithEvents SMSGatewaysComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents OpenSMSFileLabel As System.Windows.Forms.Label
    Friend WithEvents SMSGatewaysLabel As System.Windows.Forms.Label
    Friend WithEvents TargetTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TargetLabel As System.Windows.Forms.Label
    Friend WithEvents TargetCountLabel As System.Windows.Forms.Label
    Friend WithEvents SendFromSMTPButton As System.Windows.Forms.Button
    Friend WithEvents ThresholdLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PayloadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ThresholdNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents QTYNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectLabel As System.Windows.Forms.Label
    Friend WithEvents FromLabel As System.Windows.Forms.Label
    Friend WithEvents FromTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CarrierLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenSMTPFileLabel As System.Windows.Forms.Label
    Friend WithEvents OpenFileSMTPButton As System.Windows.Forms.Button
    Friend WithEvents OpenFileSMTPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileSMTPDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SMTPPasswordMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents SMTPPasswordLabel As System.Windows.Forms.Label
    Friend WithEvents SMTPLoginTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SMTPLoginLabel As System.Windows.Forms.Label
    Friend WithEvents SMTPRelaysComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SMTPRelaysLabel As System.Windows.Forms.Label
    Friend WithEvents SMTPPortNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents SMTPPortLabel As System.Windows.Forms.Label
    Friend WithEvents SSLCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BombProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressLabel As System.Windows.Forms.Label
    Friend WithEvents TimeOutNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents TimeOutLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GettingStartedMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcceptableUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
