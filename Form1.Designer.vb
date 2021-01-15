<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowser
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
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.FavsGroupBox = New System.Windows.Forms.GroupBox()
        Me.BookmarkLabel = New System.Windows.Forms.Label()
        Me.BookmarkDateDisplay = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.BookmarkCombBox = New System.Windows.Forms.ComboBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.diaSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.diaOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.ForwardButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.WebBrowser = New System.Windows.Forms.WebBrowser()
        Me.GoButton = New System.Windows.Forms.Button()
        Me.TxtUrlBox = New System.Windows.Forms.TextBox()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.FavsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'RefreshButton
        '
        Me.RefreshButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.RefreshButton.Location = New System.Drawing.Point(193, 139)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(139, 45)
        Me.RefreshButton.TabIndex = 0
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'HomeButton
        '
        Me.HomeButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.HomeButton.Location = New System.Drawing.Point(42, 139)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(139, 45)
        Me.HomeButton.TabIndex = 1
        Me.HomeButton.Text = "Home"
        Me.HomeButton.UseVisualStyleBackColor = True
        '
        'FavsGroupBox
        '
        Me.FavsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FavsGroupBox.Controls.Add(Me.BookmarkLabel)
        Me.FavsGroupBox.Controls.Add(Me.BookmarkDateDisplay)
        Me.FavsGroupBox.Controls.Add(Me.AddButton)
        Me.FavsGroupBox.Controls.Add(Me.BookmarkCombBox)
        Me.FavsGroupBox.Controls.Add(Me.SaveButton)
        Me.FavsGroupBox.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.FavsGroupBox.Location = New System.Drawing.Point(393, 75)
        Me.FavsGroupBox.Name = "FavsGroupBox"
        Me.FavsGroupBox.Size = New System.Drawing.Size(773, 118)
        Me.FavsGroupBox.TabIndex = 2
        Me.FavsGroupBox.TabStop = False
        Me.FavsGroupBox.Text = "Favourites"
        '
        'BookmarkLabel
        '
        Me.BookmarkLabel.AutoSize = True
        Me.BookmarkLabel.Location = New System.Drawing.Point(26, 78)
        Me.BookmarkLabel.Name = "BookmarkLabel"
        Me.BookmarkLabel.Size = New System.Drawing.Size(122, 18)
        Me.BookmarkLabel.TabIndex = 8
        Me.BookmarkLabel.Text = "Bookmark Date"
        '
        'BookmarkDateDisplay
        '
        Me.BookmarkDateDisplay.Location = New System.Drawing.Point(167, 78)
        Me.BookmarkDateDisplay.Name = "BookmarkDateDisplay"
        Me.BookmarkDateDisplay.Size = New System.Drawing.Size(306, 25)
        Me.BookmarkDateDisplay.TabIndex = 7
        Me.BookmarkDateDisplay.Tag = ""
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.AddButton.Location = New System.Drawing.Point(518, 17)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(139, 45)
        Me.AddButton.TabIndex = 6
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'BookmarkCombBox
        '
        Me.BookmarkCombBox.FormattingEnabled = True
        Me.BookmarkCombBox.Location = New System.Drawing.Point(19, 25)
        Me.BookmarkCombBox.Name = "BookmarkCombBox"
        Me.BookmarkCombBox.Size = New System.Drawing.Size(454, 26)
        Me.BookmarkCombBox.TabIndex = 2
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.SaveButton.Location = New System.Drawing.Point(518, 70)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(139, 45)
        Me.SaveButton.TabIndex = 5
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'diaOpenFile
        '
        Me.diaOpenFile.FileName = "OpenFileDialog1"
        '
        'ForwardButton
        '
        Me.ForwardButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ForwardButton.Location = New System.Drawing.Point(193, 75)
        Me.ForwardButton.Name = "ForwardButton"
        Me.ForwardButton.Size = New System.Drawing.Size(139, 45)
        Me.ForwardButton.TabIndex = 3
        Me.ForwardButton.Text = "Forward"
        Me.ForwardButton.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(42, 75)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(139, 45)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'WebBrowser
        '
        Me.WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser.Location = New System.Drawing.Point(12, 219)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.ScriptErrorsSuppressed = True
        Me.WebBrowser.Size = New System.Drawing.Size(1158, 453)
        Me.WebBrowser.TabIndex = 5
        Me.WebBrowser.Url = New System.Uri("http://www.bbc.co.uk", System.UriKind.Absolute)
        '
        'GoButton
        '
        Me.GoButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GoButton.Location = New System.Drawing.Point(727, 4)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(139, 45)
        Me.GoButton.TabIndex = 6
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'TxtUrlBox
        '
        Me.TxtUrlBox.Location = New System.Drawing.Point(25, 13)
        Me.TxtUrlBox.Name = "TxtUrlBox"
        Me.TxtUrlBox.Size = New System.Drawing.Size(609, 26)
        Me.TxtUrlBox.TabIndex = 7
        '
        'closeButton
        '
        Me.closeButton.Font = New System.Drawing.Font("Modern No. 20", 8.0!, System.Drawing.FontStyle.Bold)
        Me.closeButton.Location = New System.Drawing.Point(960, 4)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(139, 45)
        Me.closeButton.TabIndex = 8
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'frmBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 697)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.TxtUrlBox)
        Me.Controls.Add(Me.GoButton)
        Me.Controls.Add(Me.WebBrowser)
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ForwardButton)
        Me.Controls.Add(Me.FavsGroupBox)
        Me.Name = "frmBrowser"
        Me.Text = "Browser"
        Me.FavsGroupBox.ResumeLayout(False)
        Me.FavsGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RefreshButton As Button
    Friend WithEvents HomeButton As Button
    Friend WithEvents FavsGroupBox As GroupBox
    Friend WithEvents BookmarkCombBox As ComboBox
    Friend WithEvents diaSaveFile As SaveFileDialog
    Friend WithEvents diaOpenFile As OpenFileDialog
    Friend WithEvents ForwardButton As Button
    Friend WithEvents BackButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents WebBrowser As WebBrowser
    Friend WithEvents GoButton As Button
    Friend WithEvents TxtUrlBox As TextBox
    Friend WithEvents BookmarkLabel As Label
    Friend WithEvents BookmarkDateDisplay As TextBox
    Friend WithEvents closeButton As Button
End Class
