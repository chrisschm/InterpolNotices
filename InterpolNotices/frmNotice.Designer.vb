<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoticeForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.grpPerson = New System.Windows.Forms.GroupBox()
        Me.txtDistinguishingMarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHairsColor = New System.Windows.Forms.TextBox()
        Me.lblHairsColor = New System.Windows.Forms.Label()
        Me.txtEyesColor = New System.Windows.Forms.TextBox()
        Me.lblEyesColor = New System.Windows.Forms.Label()
        Me.txtSex = New System.Windows.Forms.TextBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.txtPlaceOfBirth = New System.Windows.Forms.TextBox()
        Me.lblPlaceOfBirth = New System.Windows.Forms.Label()
        Me.txtCountryOfBirth = New System.Windows.Forms.TextBox()
        Me.lblCountryOfBirth = New System.Windows.Forms.Label()
        Me.txtSpokenLanguages = New System.Windows.Forms.TextBox()
        Me.lblSpokenLanguages = New System.Windows.Forms.Label()
        Me.txtNationalities = New System.Windows.Forms.TextBox()
        Me.lblNationalities = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtHight = New System.Windows.Forms.TextBox()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.txtDateOfBirth = New System.Windows.Forms.TextBox()
        Me.lblDateOfBirth = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtForename = New System.Windows.Forms.TextBox()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.grpArrestWarrants = New System.Windows.Forms.GroupBox()
        Me.txtIssuingCountry = New System.Windows.Forms.TextBox()
        Me.lblIssuingCountry = New System.Windows.Forms.Label()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.lblCharge = New System.Windows.Forms.Label()
        Me.grpPerson.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpArrestWarrants.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPerson
        '
        Me.grpPerson.Controls.Add(Me.txtDistinguishingMarks)
        Me.grpPerson.Controls.Add(Me.Label1)
        Me.grpPerson.Controls.Add(Me.txtHairsColor)
        Me.grpPerson.Controls.Add(Me.lblHairsColor)
        Me.grpPerson.Controls.Add(Me.txtEyesColor)
        Me.grpPerson.Controls.Add(Me.lblEyesColor)
        Me.grpPerson.Controls.Add(Me.txtSex)
        Me.grpPerson.Controls.Add(Me.lblSex)
        Me.grpPerson.Controls.Add(Me.txtPlaceOfBirth)
        Me.grpPerson.Controls.Add(Me.lblPlaceOfBirth)
        Me.grpPerson.Controls.Add(Me.txtCountryOfBirth)
        Me.grpPerson.Controls.Add(Me.lblCountryOfBirth)
        Me.grpPerson.Controls.Add(Me.txtSpokenLanguages)
        Me.grpPerson.Controls.Add(Me.lblSpokenLanguages)
        Me.grpPerson.Controls.Add(Me.txtNationalities)
        Me.grpPerson.Controls.Add(Me.lblNationalities)
        Me.grpPerson.Controls.Add(Me.txtWeight)
        Me.grpPerson.Controls.Add(Me.lblWeight)
        Me.grpPerson.Controls.Add(Me.txtHight)
        Me.grpPerson.Controls.Add(Me.lblHigh)
        Me.grpPerson.Controls.Add(Me.txtDateOfBirth)
        Me.grpPerson.Controls.Add(Me.lblDateOfBirth)
        Me.grpPerson.Controls.Add(Me.txtName)
        Me.grpPerson.Controls.Add(Me.lblName)
        Me.grpPerson.Controls.Add(Me.txtForename)
        Me.grpPerson.Controls.Add(Me.lblForename)
        Me.grpPerson.Controls.Add(Me.PictureBox)
        Me.grpPerson.Location = New System.Drawing.Point(12, 12)
        Me.grpPerson.Name = "grpPerson"
        Me.grpPerson.Size = New System.Drawing.Size(787, 179)
        Me.grpPerson.TabIndex = 0
        Me.grpPerson.TabStop = False
        Me.grpPerson.Text = "Person"
        '
        'txtDistinguishingMarks
        '
        Me.txtDistinguishingMarks.Location = New System.Drawing.Point(94, 123)
        Me.txtDistinguishingMarks.Multiline = True
        Me.txtDistinguishingMarks.Name = "txtDistinguishingMarks"
        Me.txtDistinguishingMarks.Size = New System.Drawing.Size(549, 43)
        Me.txtDistinguishingMarks.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Beschreibung"
        '
        'txtHairsColor
        '
        Me.txtHairsColor.Location = New System.Drawing.Point(542, 97)
        Me.txtHairsColor.Name = "txtHairsColor"
        Me.txtHairsColor.Size = New System.Drawing.Size(101, 20)
        Me.txtHairsColor.TabIndex = 24
        '
        'lblHairsColor
        '
        Me.lblHairsColor.AutoSize = True
        Me.lblHairsColor.Location = New System.Drawing.Point(482, 100)
        Me.lblHairsColor.Name = "lblHairsColor"
        Me.lblHairsColor.Size = New System.Drawing.Size(54, 13)
        Me.lblHairsColor.TabIndex = 23
        Me.lblHairsColor.Text = "Haarfarbe"
        '
        'txtEyesColor
        '
        Me.txtEyesColor.Location = New System.Drawing.Point(344, 97)
        Me.txtEyesColor.Name = "txtEyesColor"
        Me.txtEyesColor.Size = New System.Drawing.Size(101, 20)
        Me.txtEyesColor.TabIndex = 22
        '
        'lblEyesColor
        '
        Me.lblEyesColor.AutoSize = True
        Me.lblEyesColor.Location = New System.Drawing.Point(276, 100)
        Me.lblEyesColor.Name = "lblEyesColor"
        Me.lblEyesColor.Size = New System.Drawing.Size(62, 13)
        Me.lblEyesColor.TabIndex = 21
        Me.lblEyesColor.Text = "Augenfarbe"
        '
        'txtSex
        '
        Me.txtSex.Location = New System.Drawing.Point(94, 97)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.Size = New System.Drawing.Size(155, 20)
        Me.txtSex.TabIndex = 20
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(27, 100)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(61, 13)
        Me.lblSex.TabIndex = 19
        Me.lblSex.Text = "Geschlecht"
        '
        'txtPlaceOfBirth
        '
        Me.txtPlaceOfBirth.Location = New System.Drawing.Point(94, 71)
        Me.txtPlaceOfBirth.Name = "txtPlaceOfBirth"
        Me.txtPlaceOfBirth.Size = New System.Drawing.Size(155, 20)
        Me.txtPlaceOfBirth.TabIndex = 18
        '
        'lblPlaceOfBirth
        '
        Me.lblPlaceOfBirth.AutoSize = True
        Me.lblPlaceOfBirth.Location = New System.Drawing.Point(32, 74)
        Me.lblPlaceOfBirth.Name = "lblPlaceOfBirth"
        Me.lblPlaceOfBirth.Size = New System.Drawing.Size(56, 13)
        Me.lblPlaceOfBirth.TabIndex = 17
        Me.lblPlaceOfBirth.Text = "Geburtsort"
        '
        'txtCountryOfBirth
        '
        Me.txtCountryOfBirth.Location = New System.Drawing.Point(542, 71)
        Me.txtCountryOfBirth.Name = "txtCountryOfBirth"
        Me.txtCountryOfBirth.Size = New System.Drawing.Size(101, 20)
        Me.txtCountryOfBirth.TabIndex = 16
        '
        'lblCountryOfBirth
        '
        Me.lblCountryOfBirth.AutoSize = True
        Me.lblCountryOfBirth.Location = New System.Drawing.Point(472, 74)
        Me.lblCountryOfBirth.Name = "lblCountryOfBirth"
        Me.lblCountryOfBirth.Size = New System.Drawing.Size(64, 13)
        Me.lblCountryOfBirth.TabIndex = 15
        Me.lblCountryOfBirth.Text = "Geburtsland"
        '
        'txtSpokenLanguages
        '
        Me.txtSpokenLanguages.Location = New System.Drawing.Point(542, 45)
        Me.txtSpokenLanguages.Name = "txtSpokenLanguages"
        Me.txtSpokenLanguages.Size = New System.Drawing.Size(101, 20)
        Me.txtSpokenLanguages.TabIndex = 14
        '
        'lblSpokenLanguages
        '
        Me.lblSpokenLanguages.AutoSize = True
        Me.lblSpokenLanguages.Location = New System.Drawing.Point(483, 48)
        Me.lblSpokenLanguages.Name = "lblSpokenLanguages"
        Me.lblSpokenLanguages.Size = New System.Drawing.Size(53, 13)
        Me.lblSpokenLanguages.TabIndex = 13
        Me.lblSpokenLanguages.Text = "Sprachen"
        '
        'txtNationalities
        '
        Me.txtNationalities.Location = New System.Drawing.Point(542, 19)
        Me.txtNationalities.Name = "txtNationalities"
        Me.txtNationalities.Size = New System.Drawing.Size(101, 20)
        Me.txtNationalities.TabIndex = 12
        '
        'lblNationalities
        '
        Me.lblNationalities.AutoSize = True
        Me.lblNationalities.Location = New System.Drawing.Point(464, 22)
        Me.lblNationalities.Name = "lblNationalities"
        Me.lblNationalities.Size = New System.Drawing.Size(72, 13)
        Me.lblNationalities.TabIndex = 11
        Me.lblNationalities.Text = "Nationalitäten"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(344, 71)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(101, 20)
        Me.txtWeight.TabIndex = 10
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(292, 74)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(46, 13)
        Me.lblWeight.TabIndex = 9
        Me.lblWeight.Text = "Gewicht"
        '
        'txtHight
        '
        Me.txtHight.Location = New System.Drawing.Point(344, 45)
        Me.txtHight.Name = "txtHight"
        Me.txtHight.Size = New System.Drawing.Size(101, 20)
        Me.txtHight.TabIndex = 8
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.Location = New System.Drawing.Point(302, 48)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(36, 13)
        Me.lblHigh.TabIndex = 7
        Me.lblHigh.Text = "Größe"
        '
        'txtDateOfBirth
        '
        Me.txtDateOfBirth.Location = New System.Drawing.Point(344, 19)
        Me.txtDateOfBirth.Name = "txtDateOfBirth"
        Me.txtDateOfBirth.Size = New System.Drawing.Size(101, 20)
        Me.txtDateOfBirth.TabIndex = 6
        '
        'lblDateOfBirth
        '
        Me.lblDateOfBirth.AutoSize = True
        Me.lblDateOfBirth.Location = New System.Drawing.Point(265, 22)
        Me.lblDateOfBirth.Name = "lblDateOfBirth"
        Me.lblDateOfBirth.Size = New System.Drawing.Size(73, 13)
        Me.lblDateOfBirth.TabIndex = 5
        Me.lblDateOfBirth.Text = "Geburtsdatum"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(94, 45)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(155, 20)
        Me.txtName.TabIndex = 4
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(29, 48)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(59, 13)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Nachname"
        '
        'txtForename
        '
        Me.txtForename.Location = New System.Drawing.Point(94, 19)
        Me.txtForename.Name = "txtForename"
        Me.txtForename.Size = New System.Drawing.Size(155, 20)
        Me.txtForename.TabIndex = 2
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Location = New System.Drawing.Point(39, 22)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(49, 13)
        Me.lblForename.TabIndex = 1
        Me.lblForename.Text = "Vorname"
        '
        'PictureBox
        '
        Me.PictureBox.Location = New System.Drawing.Point(658, 19)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'ListView
        '
        Me.ListView.HideSelection = False
        Me.ListView.LargeImageList = Me.ImageList
        Me.ListView.Location = New System.Drawing.Point(12, 306)
        Me.ListView.MultiSelect = False
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(787, 302)
        Me.ListView.TabIndex = 1
        Me.ListView.UseCompatibleStateImageBehavior = False
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(256, 256)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'grpArrestWarrants
        '
        Me.grpArrestWarrants.Controls.Add(Me.txtIssuingCountry)
        Me.grpArrestWarrants.Controls.Add(Me.lblIssuingCountry)
        Me.grpArrestWarrants.Controls.Add(Me.txtCharge)
        Me.grpArrestWarrants.Controls.Add(Me.lblCharge)
        Me.grpArrestWarrants.Location = New System.Drawing.Point(12, 197)
        Me.grpArrestWarrants.Name = "grpArrestWarrants"
        Me.grpArrestWarrants.Size = New System.Drawing.Size(787, 103)
        Me.grpArrestWarrants.TabIndex = 2
        Me.grpArrestWarrants.TabStop = False
        Me.grpArrestWarrants.Text = "Haftbefehl"
        '
        'txtIssuingCountry
        '
        Me.txtIssuingCountry.Location = New System.Drawing.Point(673, 19)
        Me.txtIssuingCountry.Name = "txtIssuingCountry"
        Me.txtIssuingCountry.Size = New System.Drawing.Size(101, 20)
        Me.txtIssuingCountry.TabIndex = 30
        '
        'lblIssuingCountry
        '
        Me.lblIssuingCountry.AutoSize = True
        Me.lblIssuingCountry.Location = New System.Drawing.Point(581, 22)
        Me.lblIssuingCountry.Name = "lblIssuingCountry"
        Me.lblIssuingCountry.Size = New System.Drawing.Size(86, 13)
        Me.lblIssuingCountry.TabIndex = 29
        Me.lblIssuingCountry.Text = "Ausstellungsland"
        '
        'txtCharge
        '
        Me.txtCharge.Location = New System.Drawing.Point(94, 45)
        Me.txtCharge.Multiline = True
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(680, 43)
        Me.txtCharge.TabIndex = 28
        '
        'lblCharge
        '
        Me.lblCharge.AutoSize = True
        Me.lblCharge.Location = New System.Drawing.Point(45, 48)
        Me.lblCharge.Name = "lblCharge"
        Me.lblCharge.Size = New System.Drawing.Size(43, 13)
        Me.lblCharge.TabIndex = 27
        Me.lblCharge.Text = "Ladung"
        '
        'NoticeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 620)
        Me.Controls.Add(Me.grpArrestWarrants)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.grpPerson)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "NoticeForm"
        Me.ShowIcon = False
        Me.Text = "frmNotice"
        Me.grpPerson.ResumeLayout(False)
        Me.grpPerson.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpArrestWarrants.ResumeLayout(False)
        Me.grpArrestWarrants.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpPerson As GroupBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ListView As ListView
    Friend WithEvents ImageList As ImageList
    Friend WithEvents txtForename As TextBox
    Friend WithEvents lblForename As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtDateOfBirth As TextBox
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtHight As TextBox
    Friend WithEvents lblHigh As Label
    Friend WithEvents txtNationalities As TextBox
    Friend WithEvents lblNationalities As Label
    Friend WithEvents txtSpokenLanguages As TextBox
    Friend WithEvents lblSpokenLanguages As Label
    Friend WithEvents txtCountryOfBirth As TextBox
    Friend WithEvents lblCountryOfBirth As Label
    Friend WithEvents txtPlaceOfBirth As TextBox
    Friend WithEvents lblPlaceOfBirth As Label
    Friend WithEvents txtSex As TextBox
    Friend WithEvents lblSex As Label
    Friend WithEvents txtHairsColor As TextBox
    Friend WithEvents lblHairsColor As Label
    Friend WithEvents txtEyesColor As TextBox
    Friend WithEvents lblEyesColor As Label
    Friend WithEvents txtDistinguishingMarks As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpArrestWarrants As GroupBox
    Friend WithEvents txtCharge As TextBox
    Friend WithEvents lblCharge As Label
    Friend WithEvents txtIssuingCountry As TextBox
    Friend WithEvents lblIssuingCountry As Label
End Class
