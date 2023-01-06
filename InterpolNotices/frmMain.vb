Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ToolStripStatusLabel.Text = ""
        Timer.Enabled = True

    End Sub







    Private Sub GetNotices()

        ToolStripStatusLabel.Text = "Erstelle Interpol Anfrage..."
        StatusStrip.Refresh()
        Me.Refresh()
        Application.DoEvents()

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim jsonfull As String = New System.Net.WebClient().DownloadString("https://ws-public.interpol.int/notices/v1/red?&resultPerPage=200")
        Dim parsejson As JObject = JObject.Parse(jsonfull)
        For Each Notice In parsejson.SelectToken("_embedded.notices")
            Dim LVItem As ListViewItem = ListView.Items.Add(Notice.SelectToken("entity_id").ToString())
            LVItem.SubItems.Add(Notice.SelectToken("forename").ToString())
            LVItem.SubItems.Add(Notice.SelectToken("name").ToString())
            LVItem.SubItems.Add(CDate(Notice.SelectToken("date_of_birth").ToString()).ToShortDateString)
            LVItem.SubItems.Add(cleanString(Notice.SelectToken("nationalities").ToString()))
        Next

        ToolStripStatusLabel.Text = ""

    End Sub

    Private Function cleanString(ByVal s As String) As String

        Dim tmp As String = s.Replace("[", "")
        tmp = tmp.Replace("]", "")
        tmp = tmp.Replace("""", "")
        Return tmp

    End Function

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        Timer.Enabled = False
        GetNotices()

    End Sub

    Private Sub ListView_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView.ColumnClick

        Dim Sort_Order As Integer = SortOrder.Ascending
        If ListView.Columns.Item(e.Column).ListView.Sorting <> SortOrder.Ascending Then
            Sort_Order = SortOrder.Ascending
        Else
            Sort_Order = SortOrder.Descending
        End If
        ListView.Columns.Item(e.Column).ListView.Sorting = Sort_Order

        If e.Column = 3 Then
            Dim LVSorter = New ListViewItemDateComparer(e.Column, Sort_Order)
            ListView.ListViewItemSorter = LVSorter
        Else
            Dim LVSorter = New ListViewItemComparer(e.Column, Sort_Order)
            ListView.ListViewItemSorter = LVSorter
        End If

    End Sub
End Class

Friend Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private _sort As SortOrder = SortOrder.Ascending

    Public Sub New(column As Integer, sort As Windows.Forms.SortOrder)
        col = column
        _sort = sort
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare

        Dim returnVal As Integer = -1
        If (_sort = 1) Then
            returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        Else
            returnVal = [String].Compare(CType(y, ListViewItem).SubItems(col).Text, CType(x, ListViewItem).SubItems(col).Text)
        End If

        Return returnVal

    End Function

End Class

Friend Class ListViewItemDateComparer

    Implements IComparer
    Private col As Integer
    Private _sort As SortOrder = SortOrder.Ascending

    Public Sub New(column As Integer, sort As Windows.Forms.SortOrder)
        col = column
        _sort = sort
    End Sub

    Public Function Compare(x As Object, y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1

        ' parse LV contents back to DateTime value
        Dim dtX As DateTime = DateTime.Parse(CType(x, ListViewItem).SubItems(col).Text)
        Dim dtY As DateTime = DateTime.Parse(CType(y, ListViewItem).SubItems(col).Text)

        ' compare
        returnVal = DateTime.Compare(dtX, dtY)

        If _sort = SortOrder.Descending Then
            returnVal *= -1
        End If
        Return returnVal

    End Function
End Class