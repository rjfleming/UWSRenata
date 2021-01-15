Public Class frmBrowser

    Private Bookmarks(100) As Bookmark
    Dim favouritesFileLocation As String

    <Serializable()> Structure Bookmark
        Dim savedDate As Date
        Dim websiteAddress As String
        Dim bookmarkDesc As String

        'Create new bookmark
        Public Sub New(ByVal desc As String, ByVal todaysDate As Date, ByVal websiteAddr As String)
            bookmarkDesc = desc
            savedDate = todaysDate
            websiteAddress = websiteAddr
        End Sub
    End Structure

    Private Sub resizeFormContents()
        Dim borderIndent As Integer
        Dim goBtn_X As Integer
        Dim saveBtn_X As Integer
        Dim addBtn_X As Integer
        Dim closeBtn_X As Integer

        borderIndent = WebBrowser.Location.X


        addBtn_X = Me.Size.Width - AddButton.Width - borderIndent * 40
        AddButton.Location = New Point(addBtn_X, AddButton.Location.Y)


        saveBtn_X = Me.Size.Width - SaveButton.Width - borderIndent * 40
        SaveButton.Location = New Point(saveBtn_X, SaveButton.Location.Y)


        TxtUrlBox.Width = GoButton.Location.X - borderIndent * 4


        WebBrowser.Width = Me.Size.Width - borderIndent * 4
        WebBrowser.Height = Me.Size.Height - WebBrowser.Location.Y - borderIndent * 5

        goBtn_X = Me.Size.Width - GoButton.Width - borderIndent * 35
        GoButton.Location = New Point(goBtn_X, GoButton.Location.Y)

        closeBtn_X = Me.Size.Width - closeButton.Width - borderIndent * 12
        closeButton.Location = New Point(closeBtn_X, closeButton.Location.Y)


        FavsGroupBox.Width = Me.Size.Width - borderIndent * 40

        BookmarkCombBox.Width = Me.Size.Width - borderIndent * 65

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        'The close button can now be pressed
        closeButton.Enabled = True
        Dim websiteAddress As String
        Dim ComboIndex As Integer
        Dim bookmarkDesc As String
        Dim savedDate As Date

        If TxtUrlBox.Text = "" Then
            GoTo IgnoreEntry
        End If

        Dim ButtonPressed = MessageBox.Show("Are you sure you want to add " + TxtUrlBox.Text + "to your bookmarks", "Yes No Cancel", MessageBoxButtons.YesNoCancel)

        'If the user decides to click No or Cancel on the pop up then we ignore the Add button press
        'If they choose yes then we continue ahead and try to add the bookmark
        Select Case ButtonPressed
            Case vbYes
                Exit Select
            Case vbNo
                GoTo IgnoreEntry
            Case vbCancel
                GoTo IgnoreEntry
        End Select

        savedDate = DateTime.Today
        websiteAddress = TxtUrlBox.Text

        bookmarkDesc = InputBox("Please provide a description for Bookmark")

        If bookmarkDesc = "" Then
            GoTo IgnoreEntry
        End If

        BookmarkCombBox.BeginUpdate()
        BookmarkCombBox.Items.Add(bookmarkDesc)
        BookmarkCombBox.Text = bookmarkDesc
        BookmarkCombBox.EndUpdate()
        ComboIndex = BookmarkCombBox.SelectedIndex

        Bookmarks(ComboIndex) = New Bookmark(bookmarkDesc, savedDate, websiteAddress)
IgnoreEntry:
    End Sub


    Private Sub txtURL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUrlBox.KeyPress
        Dim keyAscii As Char

        keyAscii = e.KeyChar
        If (keyAscii = vbCr) Then
            If TxtUrlBox.Text <> "" Then
                Call WebBrowser.Navigate(TxtUrlBox.Text)
            End If
        End If
    End Sub


    Private Sub bookmarkCombBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BookmarkCombBox.SelectedIndexChanged
        Dim IndexValue As Integer
        IndexValue = BookmarkCombBox.SelectedIndex
        If (Bookmarks(IndexValue).websiteAddress <> "") Then
            BookmarkDateDisplay.Text = Bookmarks(IndexValue).savedDate
            WebBrowser.Navigate(Bookmarks(IndexValue).websiteAddress)
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        'The close button can now be pressed
        closeButton.Enabled = True

        Dim MemStream As New System.IO.MemoryStream()
        Dim BufForm As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()

        BufForm.Serialize(MemStream, Bookmarks)
        My.Computer.FileSystem.WriteAllBytes(favouritesFileLocation,
            MemStream.GetBuffer(), False)
    End Sub



    Private Sub frmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initialise the close button to be disabled but as soon as other buttons are pressed this will be enabled
        closeButton.Enabled = False

        resizeFormContents()

        favouritesFileLocation = "C:\UWSCourseWork\favourites.fws"
        My.Computer.FileSystem.WriteAllText("C:\UWSCourseWork\history.hlf",
            Date.Today.ToString & vbCrLf, True)
        Dim BufForm As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        Dim MemStream As New System.IO.MemoryStream()

        Dim DataStream As Byte()
        Dim Index As Integer

        If My.Computer.FileSystem.FileExists(favouritesFileLocation) Then

            DataStream = My.Computer.FileSystem.ReadAllBytes(favouritesFileLocation)

            Bookmarks = BufForm.Deserialize(New System.IO.MemoryStream(DataStream))

            Index = 0
            BookmarkCombBox.BeginUpdate()
            While (Bookmarks(Index).bookmarkDesc <> "")
                BookmarkCombBox.Items.Add(Bookmarks(Index).bookmarkDesc)
                Index = Index + 1
            End While
            BookmarkCombBox.EndUpdate()
        End If
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        'The close button can now be pressed
        closeButton.Enabled = True
        WebBrowser.GoBack()
    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        'The close button can now be pressed
        closeButton.Enabled = True
        WebBrowser.Navigate("www.bbc.com")
    End Sub

    Private Sub fwdBtn_Click(sender As Object, e As EventArgs) Handles ForwardButton.Click
        closeButton.Enabled = True
        WebBrowser.GoForward()
    End Sub

    Private Sub goBtn_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        'The close button can now be pressed
        closeButton.Enabled = True
        WebBrowser.Navigate(TxtUrlBox.Text)
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        'The close button can now be pressed
        closeButton.Enabled = True
        WebBrowser.Refresh()
    End Sub

    Private Sub webBrowser_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser.DocumentCompleted
        TxtUrlBox.Text = WebBrowser.Url.ToString
        Dim lines() As String = IO.File.ReadAllLines("C:\UWSCourseWork\history.hlf")
        If TxtUrlBox.Text <> lines(lines.Length - 1) Then
            My.Computer.FileSystem.WriteAllText("C:\UWSCourseWork\history.hlf",
            TxtUrlBox.Text & vbCrLf, True)
        End If
    End Sub

    Private Sub frmBrowser_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        resizeFormContents()
    End Sub


    'The close button should only work if some other has been pressed
    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        End
    End Sub
End Class