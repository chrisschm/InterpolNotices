Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class NoticeForm

    Public Sub GetNotice(ByVal ID As String)

        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        Dim jsonfull As String = New System.Net.WebClient().DownloadString("https://ws-public.interpol.int/notices/v1/red/" & ID)
        Dim parsejson As JObject = JObject.Parse(jsonfull)

        txtWeight.Text = parsejson.SelectToken("weight").ToString()
        txtForename.Text = parsejson.SelectToken("forename").ToString()
        txtDateOfBirth.Text = CDate(parsejson.SelectToken("date_of_birth").ToString()).ToShortDateString()
        txtSpokenLanguages.Text = cleanString(parsejson.SelectToken("languages_spoken_ids").ToString())
        txtNationalities.Text = cleanString(parsejson.SelectToken("nationalities").ToString())
        txtHight.Text = parsejson.SelectToken("height").ToString()
        txtSex.Text = parsejson.SelectToken("sex_id").ToString()
        txtCountryOfBirth.Text = parsejson.SelectToken("country_of_birth_id").ToString()
        txtName.Text = parsejson.SelectToken("name").ToString()
        txtDistinguishingMarks.Text = parsejson.SelectToken("distinguishing_marks").ToString()
        txtEyesColor.Text = cleanString(parsejson.SelectToken("eyes_colors_id").ToString())
        txtHairsColor.Text = cleanString(parsejson.SelectToken("hairs_id").ToString())
        txtPlaceOfBirth.Text = parsejson.SelectToken("place_of_birth").ToString()

        For Each Entry In parsejson.SelectToken("arrest_warrants")
            txtIssuingCountry.Text = Entry.SelectToken("issuing_country_id").ToString()
            txtCharge.Text = Entry.SelectToken("charge").ToString()
        Next

        PictureBox.Load(parsejson.SelectToken("_links").Item("thumbnail").SelectToken("href").ToString)
        Me.Refresh()
        Application.DoEvents()

        ListView.BeginUpdate()
        Dim jsonimages As String = New System.Net.WebClient().DownloadString(parsejson.SelectToken("_links").Item("images").SelectToken("href").ToString)
        Dim parseimages As JObject = JObject.Parse(jsonimages)
        For Each Part In parseimages.SelectToken("_embedded").SelectToken("images")
            Dim WC As New System.Net.WebClient
            Dim strIMGFile As String = Part.Item("_links").Item("self").Item("href").ToString()
            Dim strFile As String = System.IO.Path.GetTempFileName
            WC.DownloadFile(strIMGFile, strFile)
            Dim Img As Image = Image.FromFile(strFile)
            ImageList.Images.Add(strIMGFile, Img)
            ListView.Items.Add(strIMGFile, strIMGFile)
        Next
        ListView.EndUpdate()

    End Sub


End Class