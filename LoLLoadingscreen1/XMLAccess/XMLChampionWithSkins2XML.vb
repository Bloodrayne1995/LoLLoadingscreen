Imports RiotApi.Net.RestClient.Dto.LolStaticData
Imports RiotApi.Net.RestClient
Imports System.Xml

''' <summary>
''' Generate a XML-File which stores championID, link to loading screen image (data dragon), link to youtube login screen
''' (for development it will be a path to a local video file) and a attribute which indicates wheter shall be used (data dragon or youtube)
''' For every Champion all skins will be added as childnodes with the same information 
''' </summary>
Public Class XMLChampionWithSkins2XML


    Public Sub createXMLFile(ByVal path As String, ByVal apikey As String)
        'Open XML File with UTF-8 encoding
        Console.WriteLine("Define XML settings and open file")
        Dim sett As New XmlWriterSettings
        sett.Encoding = Text.Encoding.UTF8
        sett.ConformanceLevel = ConformanceLevel.Document
        sett.NewLineChars = vbCrLf
        sett.Indent = True
        sett.IndentChars = " "

        Dim doc As XmlWriter = XmlWriter.Create(New IO.FileStream(path, IO.FileMode.OpenOrCreate), sett)

        'write XML definitions
        doc.WriteStartDocument()

        'write root node
        doc.WriteStartElement("champions")

        'create new Instance to RiotAPI
        Console.WriteLine("Create instance for RiotAPI")
        Dim client As New RiotClient(apikey)


        'iterate through all champions
        Console.WriteLine("Get ChampionList")
        Dim cList As Champion.ChampionListDto = client.LolStaticData.GetChampionList(region:=Configuration.RiotApiConfig.Regions.EUW, champData:="all")
        For Each k As String In cList.Data.Keys
            'get champion
            Dim c As Champion.ChampionDto = cList.Data(k)
            Console.WriteLine("Start new Champion: " & c.Name)
            'start new champion-node
            doc.WriteStartElement("champion")

            'add information about the champion as attributes
            doc.WriteAttributeString("id", c.Id)

            'iterate through the champion`s skins
            Console.WriteLine("Get Skins")
            For Each s As Generic.SkinDto In c.Skins
                Console.WriteLine("New Skin for " & c.Name & ": " & s.Name)

                'write a new skin node
                doc.WriteStartElement("skin")

                'write information about the skin as attributes
                doc.WriteAttributeString("id", s.Id)
                doc.WriteAttributeString("num", s.Num)
                doc.WriteAttributeString("dataDragon", getDataDragonLink(c.Key, s.Num))
                doc.WriteAttributeString("ytLink", "")
                doc.WriteAttributeString("use", "dataDragon")

                'write information about the <ausschnitt> of the video
                doc.WriteStartElement("videoOptions")
                doc.WriteAttributeString("x", "0")
                doc.WriteAttributeString("y", "0")
                doc.WriteEndElement()

                'close skin node
                doc.WriteEndElement()
            Next

            'close champion node
            doc.WriteEndElement()

        Next

        Console.WriteLine("Close Root Node")
        'close root node
        doc.WriteEndElement()

        'close XML document
        Console.WriteLine("Save and close XML-Document")
        doc.WriteEndDocument()
        doc.Flush()
        doc.Close()

    End Sub

    ''' <summary>
    ''' Get the right DataDragon-Link for the loading screen
    ''' </summary>
    ''' <param name="champion">Champion-Name</param>
    ''' <param name="skinID">skinID</param>
    ''' <returns></returns>
    Private Function getDataDragonLink(ByVal champion As String, ByVal skinID As String) As String
        Return "http://ddragon.leagueoflegends.com/cdn/img/champion/loading/" & champion & "_" & skinID & ".jpg"
    End Function





End Class
