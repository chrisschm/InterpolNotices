<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageRedNotice = New System.Windows.Forms.TabPage()
        Me.ListViewRed = New System.Windows.Forms.ListView()
        Me.entity_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.forename = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lastname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.date_of_birth = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.nationalities = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageYellow = New System.Windows.Forms.TabPage()
        Me.TabPageUN = New System.Windows.Forms.TabPage()
        Me.StatusStrip.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageRedNotice.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(602, 22)
        Me.StatusStrip.TabIndex = 0
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(21, 17)
        Me.ToolStripStatusLabel.Text = "##"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageRedNotice)
        Me.TabControl.Controls.Add(Me.TabPageYellow)
        Me.TabControl.Controls.Add(Me.TabPageUN)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(602, 428)
        Me.TabControl.TabIndex = 2
        '
        'TabPageRedNotice
        '
        Me.TabPageRedNotice.Controls.Add(Me.ListViewRed)
        Me.TabPageRedNotice.Location = New System.Drawing.Point(4, 22)
        Me.TabPageRedNotice.Name = "TabPageRedNotice"
        Me.TabPageRedNotice.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageRedNotice.Size = New System.Drawing.Size(594, 402)
        Me.TabPageRedNotice.TabIndex = 0
        Me.TabPageRedNotice.Text = "Red Notices"
        Me.TabPageRedNotice.UseVisualStyleBackColor = True
        '
        'ListViewRed
        '
        Me.ListViewRed.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.entity_id, Me.forename, Me.lastname, Me.date_of_birth, Me.nationalities})
        Me.ListViewRed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListViewRed.FullRowSelect = True
        Me.ListViewRed.HideSelection = False
        Me.ListViewRed.Location = New System.Drawing.Point(3, 3)
        Me.ListViewRed.MultiSelect = False
        Me.ListViewRed.Name = "ListViewRed"
        Me.ListViewRed.Size = New System.Drawing.Size(588, 396)
        Me.ListViewRed.TabIndex = 2
        Me.ListViewRed.UseCompatibleStateImageBehavior = False
        Me.ListViewRed.View = System.Windows.Forms.View.Details
        '
        'entity_id
        '
        Me.entity_id.Text = "ID"
        Me.entity_id.Width = 90
        '
        'forename
        '
        Me.forename.Text = "Vorname"
        Me.forename.Width = 120
        '
        'lastname
        '
        Me.lastname.Text = "Nachname"
        Me.lastname.Width = 150
        '
        'date_of_birth
        '
        Me.date_of_birth.Text = "Gebutsdatum"
        Me.date_of_birth.Width = 100
        '
        'nationalities
        '
        Me.nationalities.Text = "Nationalitäten"
        Me.nationalities.Width = 100
        '
        'TabPageYellow
        '
        Me.TabPageYellow.Location = New System.Drawing.Point(4, 22)
        Me.TabPageYellow.Name = "TabPageYellow"
        Me.TabPageYellow.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageYellow.Size = New System.Drawing.Size(594, 402)
        Me.TabPageYellow.TabIndex = 1
        Me.TabPageYellow.Text = "Yellow Notices"
        Me.TabPageYellow.UseVisualStyleBackColor = True
        '
        'TabPageUN
        '
        Me.TabPageUN.Location = New System.Drawing.Point(4, 22)
        Me.TabPageUN.Name = "TabPageUN"
        Me.TabPageUN.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageUN.Size = New System.Drawing.Size(594, 402)
        Me.TabPageUN.TabIndex = 2
        Me.TabPageUN.Text = "UN Notices"
        Me.TabPageUN.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 450)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Interpol Notices"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.TabPageRedNotice.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents Timer As Timer
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageRedNotice As TabPage
    Friend WithEvents ListViewRed As ListView
    Friend WithEvents entity_id As ColumnHeader
    Friend WithEvents forename As ColumnHeader
    Friend WithEvents lastname As ColumnHeader
    Friend WithEvents date_of_birth As ColumnHeader
    Friend WithEvents nationalities As ColumnHeader
    Friend WithEvents TabPageYellow As TabPage
    Friend WithEvents TabPageUN As TabPage
End Class
