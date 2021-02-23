Public Class MainForm
#Region "Buttons"
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        CompilerServices.ProjectData.EndApp()
    End Sub
    Private Sub BuildButton_Click(sender As Object, e As EventArgs) Handles BuildButton.Click
        If Not HeadersListBox.Items.Count = 0 Then
            HeadersListBox.Items.Clear()
        End If
        If Not LanguageChoose.SelectedItem = "" Then
            If Not RequestLIB.SelectedItem = "" Then
                If RequestType.SelectedItem = "POST" Then
#Region "VB.NET POST Request"
                    If LanguageChoose.SelectedItem = "Visual Basic" Then
                        If Not Url.Text = "" Then
                            If Not PostData.Text = "" Then
                                If RequestLIB.SelectedItem = "Normal" Then
                                    Dim PostDataFix As String = PostData.Text.Replace(My.Resources.Apostraphae, My.Resources.Apostraphae1)
                                    Dim FirstLine As String = "Try : Net.ServicePointManager.CheckCertificateRevocationList = False : NET.ServicePointManager.DefaultConnectionLimit = 300 : NET.ServicePointManager.UseNagleAlgorithm = False : NET.ServicePointManager.Expect100Continue = False : NET.ServicePointManager.SecurityProtocol = 3072"
                                    Dim SecondLine As String = $"Dim Encoding As New text.UTF8Encoding : Dim Bytes As Byte() = Encoding.GetBytes(""{PostDataFix}"")"
                                    Dim ThirdLine As String = $"Dim AJ As  Net.HttpWebRequest = DirectCast(Net.WebRequest.Create(""{Url.Text}""),  Net.HttpWebRequest)"
                                    Dim FourthLine As String = "With AJ"
                                    Dim FifthLine As String = "        .Method = ""POST"""
                                    Dim SixthLine As String = ""
                                    If Not Headers.Text = "" Then
                                        Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                        For Each Header As String In HeadersListBox.Items
                                            SixthLine = SixthLine + vbNewLine + $"        .Headers.add(""{Header}"")"
                                        Next
                                    End If
                                    Dim SeventhLine As String = "End With"
                                    Dim EighthLine As String = "Dim Stream As IO.Stream = AJ.GetRequestStream() : Stream.Write(Bytes, 0, Bytes.Length) : Stream.Dispose() : Stream.Close()"
                                    Dim NinthLine As String = "Dim Reader As New io.StreamReader(DirectCast(AJ.GetResponse(),  Net.HttpWebResponse).GetResponseStream()) :  Dim Text As String = Reader.ReadToEnd : Reader.Dispose() : Reader.Close()"
                                    Dim TenthLine As String = "Catch ex As Net.WebException : Dim AJJ As String = New IO.StreamReader(ex.Response.GetResponseStream()).ReadToEnd() : MsgBox($""Error: {AJJ}"") : End Try"
                                    RequestInfo.Text = $"{FirstLine}{vbNewLine}{SecondLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine}{vbNewLine}{FifthLine}{SixthLine}{vbNewLine}{SeventhLine}{vbNewLine}{EighthLine}{vbNewLine}{NinthLine}{vbNewLine}{TenthLine}"
                                ElseIf RequestLIB.SelectedItem = "RestSharp" Then
                                    Dim PostDataFix As String = PostData.Text.Replace(My.Resources.Apostraphae, My.Resources.Apostraphae1)
                                    Dim FirstLine As String = $"Dim RestClient As New RestClient(""{Url.Text}"") : Dim RestRequest As New RestRequest(""{URL2.Text}"", Method.POST)"
                                    Dim SecondLine As String = ""
                                    If Not Headers.Text = "" Then
                                        Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                        For Each Header As String In HeadersListBox.Items
                                            If Header.Contains(":") Then
                                                SecondLine = SecondLine + vbNewLine + $"RestClient.AddDefaultHeader(""{Header.Split(New Char() {":"c})(0).Trim()}"", ""{Header.Split(New Char() {":"c})(1).Trim()}"")"
                                            End If
                                        Next
                                    End If
                                    Dim ThirdLine As String = $"RestRequest.AddParameter("""", ""{PostDataFix}"", ParameterType.RequestBody)"
                                    Dim FourthLine As String = "Dim Response As String = RestClient.Execute(RestRequest).Content"
                                    RequestInfo.Text = $"{FirstLine}{SecondLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine}"
                                ElseIf RequestLIB.SelectedItem = "WebClient" Then
                                    Dim PostDataFix As String = PostData.Text.Replace(My.Resources.Apostraphae, My.Resources.Apostraphae1)
                                    Dim FirstLine As String = $"Resp = {My.Resources.Apostraphae}{My.Resources.Apostraphae}"
                                    Dim SecondLine As String = "Dim WebC As WebClient = New WebClient()"
                                    Dim ThirdLine As String = $"Dim PostData As String = ""{PostDataFix}"""
                                    Dim FourthLine As String = ""
                                    If Not Headers.Text = "" Then
                                        Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                        For Each Header As String In HeadersListBox.Items
                                            If Header.Contains(":") Then
                                                FourthLine = FourthLine + vbNewLine + $"WebC.Headers.Add(""{Header.Split(New Char() {":"c})(0).Trim()}"", ""{Header.Split(New Char() {":"c})(1).Trim()}"")"
                                            End If
                                        Next
                                    End If
                                    Dim SixthLine As String = "Try"
                                    Dim SeventhLine As String = "        Resp = WebC.UploadString(SecureURL, PostData)"
                                    Dim EighthLine As String = "Catch ex As WebException"
                                    Dim NinthLine As String = "End Try"
                                    RequestInfo.Text = $"{FirstLine}{vbNewLine}{SecondLine}{vbNewLine}{ThirdLine}{FourthLine}{vbNewLine}{SixthLine}{vbNewLine}{SeventhLine}{vbNewLine}{EighthLine}{vbNewLine}{SixthLine}"
                                End If
                            Else
                                MsgBox("No PostData Set!", MsgBoxStyle.Critical)
                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
#Region "Python POST Request"
                    ElseIf LanguageChoose.SelectedItem = "Python" Then
                        If Not Url.Text = "" Then
                            If RequestLIB.SelectedItem = "Normal" Then
                                Dim FirstLine As String = "Response = requests.post('" + Url.Text + "', headers={"
                                Dim SecondLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        If Header.Contains(":") Then
                                            SecondLine = SecondLine + vbNewLine + $"        '{Header.Split(New Char() {":"c})(0).Trim()}': '{Header.Split(New Char() {":"c})(1).Trim()}',"
                                        End If
                                    Next
                                End If
                                Dim ThirdLine As String = "}, data='" + PostData.Text + "')"
                                Dim FourthLine As String = "return Response.text"
                                RequestInfo.Text = $"{FirstLine}{SecondLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine}"
                            ElseIf RequestLIB.SelectedItem = "PyCurl" Then
                                Dim FirstLine As String = "def PyCurlRequest():"
                                Dim SecondLine As String = "        try:"
                                Dim ThirdLine As String = "                Response = ''"
                                Dim FourthLine As String = "                CurlOB = pycurl.Curl()"
                                Dim FifthLine As String = "                CurlOB.setopt(pycurl.SSL_VERIFYHOST, 0)"
                                Dim SeventhLine As String = "                CurlOB.setopt(pycurl.SSL_VERIFYPEER, 0)"
                                Dim EighthLine As String = "                CurlOB.setopt(pycurl.URL, """ + Url.Text + """)"
                                Dim NinthLine As String = "                CurlOB.setopt(pycurl.HTTPHEADER, ["
                                Dim TenthLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        If TenthLine = "" Then
                                            TenthLine = $"'{Header}'" + TenthLine
                                        Else
                                            TenthLine = TenthLine + $", '{Header}'"
                                        End If
                                    Next
                                End If
                                Dim EleventhLine As String = "])"
                                Dim TwelvthLine As String = "                CurlOB.setopt(pycurl.POST, True)"
                                Dim ThirteenthLine As String = $"                CurlOB.setopt(pycurl.POSTFIELDS, '{PostData.Text}')"
                                Dim FourteenthLine As String = "                Response = CurlOB.perform_rs()"
                                Dim FifteenthLine As String = "         except: pass"
                                Dim SixteenthLine As String = "         return Response"
                                RequestInfo.Text = $"{FirstLine}{vbNewLine}{SecondLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine}{vbNewLine}{FifthLine}{vbNewLine}{SeventhLine}{vbNewLine}{EighthLine}{vbNewLine}{NinthLine}{TenthLine}{EleventhLine}{vbNewLine}{TwelvthLine}{vbNewLine}{ThirteenthLine}{vbNewLine}{FourteenthLine}{vbNewLine}{FifteenthLine}{vbNewLine}{SixteenthLine}"
                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
#Region "C# POST Request"
                    ElseIf LanguageChoose.SelectedItem = "C#" Then
                        If Not Url.Text = "" Then
                            If RequestLIB.SelectedItem = "Normal" Then
                                Dim PostDataFix As String = PostData.Text.Replace(My.Resources.Apostraphae, My.Resources.Apostraphae2)
                                Dim FirstLine As String = $"string Resp = {My.Resources.Apostraphae}{My.Resources.Apostraphae};"
                                Dim ThirdLine As String = "try"
                                Dim FifthLine As String = "{" + vbNewLine + $"        byte[] Bytes = new UTF8Encoding().GetBytes(""{PostDataFix}"");"
                                Dim SixthLine As String = $"        HttpWebRequest Req = WebRequest.CreateHttp(""{Url.Text}"");"
                                Dim PostReq As String = "        Req.Method = ""POST"";"
                                Dim Headerz As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        Headerz = Headerz + vbNewLine + $"        Req.Headers.Add(""{Header}"");"
                                    Next
                                End If
                                Dim SeventhLine As String = "        Stream ReqStream = Req.GetRequestStream(); ReqStream.Write(Bytes, 0, Bytes.Length); ReqStream.Dispose(); ReqStream.Close();"
                                Dim EighthLine As String = "        StreamReader ReqReader = new StreamReader(((HttpWebResponse)Req.GetResponse()).GetResponseStream());"
                                Dim NinthLine As String = "        Resp = ReqReader.ReadToEnd(); ReqReader.Dispose(); ReqReader.Close();"
                                Dim TenthLine As String = "catch (WebException e)" + vbNewLine + "        {"
                                Dim EleventhLine As String = "                Resp = new StreamReader(e.Response.GetResponseStream()).ReadToEnd();"
                                Dim TwelvthLine As String = "        }" + vbNewLine + "        return Resp;"
                                Dim ThirteenthLine As String = "}"
                                RequestInfo.Text = $"{FirstLine}{vbNewLine}{ThirdLine}{vbNewLine}{FifthLine}{vbNewLine}{SixthLine}{vbNewLine}{PostReq}{Headerz}{vbNewLine}{EighthLine}{vbNewLine}{NinthLine}{vbNewLine}{TenthLine}{vbNewLine}{EleventhLine}{vbNewLine}{TwelvthLine}{vbNewLine}{ThirteenthLine}"
                            ElseIf RequestLIB.SelectedItem = "WebClient" Then
                                Dim PostDataFix As String = PostData.Text.Replace(My.Resources.Apostraphae, My.Resources.Apostraphae2)
                                Dim FirstLine As String = $"string Resp = {My.Resources.Apostraphae}{My.Resources.Apostraphae};"
                                Dim ThirdLine As String = "try"
                                Dim FifthLine As String = "{"
                                Dim SixthLine As String = $"        WebClient Req = new WebClient ();"
                                Dim PostReq As String = $"        byte[] Bytes = new UTF8Encoding().GetBytes('{PostDataFix}');"
                                Dim Headerz As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        Headerz = Headerz + vbNewLine + $"        Req.Headers.Add('{Header}');"
                                    Next
                                End If
                                Dim EighthLine As String = $"        byte[] RespArray = myWebClient.UploadData('{Url.Text}', Bytes);"
                                Dim NinthLine As String = "        Resp = Encoding.ASCII.GetString(RespArray);"
                                Dim TenthLine As String = "catch (WebException e)" + vbNewLine + "        {"
                                Dim EleventhLine As String = "                Resp = new StreamReader(e.Response.GetResponseStream()).ReadToEnd();"
                                Dim TwelvthLine As String = "        }" + vbNewLine + "        return Resp;"
                                Dim ThirteenthLine As String = "}"
                                RequestInfo.Text = $"{FirstLine}{vbNewLine}{ThirdLine}{vbNewLine}{FifthLine}{vbNewLine}{SixthLine}{vbNewLine}{PostReq}{Headerz}{vbNewLine}{EighthLine}{vbNewLine}{NinthLine}{vbNewLine}{TenthLine}{vbNewLine}{EleventhLine}{vbNewLine}{TwelvthLine}{vbNewLine}{ThirteenthLine}"

                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
#Region "cURL POST Request"
                    ElseIf LanguageChoose.SelectedItem = "cURL" Then
                        If Not Url.Text = "" Then
                            If RequestLIB.SelectedItem = "Normal" Then
                                Dim FirstLine As String = "curl -L -X POST "
                                Dim SecondLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        SecondLine = SecondLine + $" -H '{Header}'"
                                    Next
                                End If
                                Dim ThirdLine As String = $" --data-raw '{PostData.Text}' '{Url.Text}'"
                                RequestInfo.Text = $"{FirstLine}{SecondLine}{ThirdLine}"
                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
                    End If
                ElseIf RequestType.SelectedItem = "GET" Then
#Region "VB.NET GET Request"
                    If LanguageChoose.SelectedItem = "Visual Basic" Then
                        If Not Url.Text = "" Then
                            If RequestLIB.SelectedItem = "Normal" Then
                                Dim FirstLine As String = "Try : Net.ServicePointManager.CheckCertificateRevocationList = False : NET.ServicePointManager.DefaultConnectionLimit = 300 : NET.ServicePointManager.UseNagleAlgorithm = False : NET.ServicePointManager.Expect100Continue = False : NET.ServicePointManager.SecurityProtocol = 3072"
                                Dim ThirdLine As String = $"Dim AJ As  Net.HttpWebRequest = DirectCast(Net.WebRequest.Create(""{Url.Text}""),  Net.HttpWebRequest)"
                                Dim FourthLine As String = "With AJ"
                                Dim FifthLine As String = "        .Method = ""GET"""
                                Dim SixthLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        SixthLine = SixthLine + vbNewLine + $"        .Headers.add(""{Header}"")"
                                    Next
                                End If
                                Dim SeventhLine As String = "End With"
                                Dim EighthLine As String = "Dim Response As Net.HttpWebResponse = DirectCast(AJ.GetResponse, Net.HttpWebResponse)"
                                Dim NinthLine As String = "Dim Reader As New IO.StreamReader(Response.GetResponseStream) : Dim Text As String = Reader.ReadToEnd : Reader.Dispose() : Reader.Close() : Response.Dispose() : Response.Close()"
                                Dim TenthLine As String = "Catch ex As Net.WebException : Dim AJJ As String = New IO.StreamReader(ex.Response.GetResponseStream()).ReadToEnd() : MsgBox($""Error: {AJJ}"") : End Try"
                                RequestInfo.Text = $"{FirstLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine}{vbNewLine}{FifthLine}{SixthLine}{vbNewLine}{SeventhLine}{vbNewLine}{EighthLine}{vbNewLine}{NinthLine}{vbNewLine}{TenthLine}"
                            ElseIf RequestLIB.SelectedItem = "RestSharp" Then
                                Dim FirstLine As String = $"Dim RestClient As New RestClient(""{Url.Text}"") : Dim RestRequest As New RestRequest(""{URL2.Text}"", Method.GET)"
                                Dim SecondLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        If Header.Contains(":") Then
                                            SecondLine = SecondLine + vbNewLine + $"RestClient.AddDefaultHeader(""{Header.Split(New Char() {":"c})(0).Trim()}"", ""{Header.Split(New Char() {":"c})(1).Trim()}"")"
                                        End If
                                    Next
                                End If
                                Dim ThirdLine As String = "Dim Response As String = RestClient.Execute(RestRequest).Content"
                                RequestInfo.Text = $"{FirstLine}{SecondLine}{vbNewLine}{ThirdLine}"
                            ElseIf RequestLIB.SelectedItem = "WebClient" Then
                                Dim Firsty As String = $"Resp = {My.Resources.Apostraphae}{My.Resources.Apostraphae}"
                                Dim FirstLine As String = "Dim WebC As WebClient = New WebClient()"
                                Dim SecondLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        If Header.Contains(":") Then
                                            SecondLine = SecondLine + vbNewLine + $"WebC.Headers.Add(""{Header.Split(New Char() {":"c})(0).Trim()}"", ""{Header.Split(New Char() {":"c})(1).Trim()}"")"
                                        End If
                                    Next
                                End If
                                Dim ThirdLine As String = "Try"
                                Dim FourthLine As String = "        Resp = WebC.DownloadString(SecureURL)"
                                Dim FifthLine As String = "Catch ex As WebException"
                                Dim SixthLine As String = "End Try"
                                RequestInfo.Text = $"{Firsty}{vbNewLine}{FirstLine}{SecondLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine}{vbNewLine}{FifthLine}{vbNewLine}{SixthLine}"
                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
#Region "Python GET Request"
                    ElseIf LanguageChoose.SelectedItem = "Python" Then
                        If Not Url.Text = "" Then
                            If RequestLIB.SelectedItem = "Normal" Then
                                Dim FirstLine As String = "Response = requests.get('" + Url.Text + "', headers={"
                                Dim SecondLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        If Header.Contains(":") Then
                                            SecondLine = SecondLine + vbNewLine + $"        '{Header.Split(New Char() {":"c})(0).Trim()}': '{Header.Split(New Char() {":"c})(1).Trim()}',"
                                        End If
                                    Next
                                End If
                                Dim ThirdLine As String = "})"
                                Dim FourthLine As String = "return Response.text"
                                RequestInfo.Text = $"{FirstLine}{SecondLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine}"
                            ElseIf RequestLIB.SelectedItem = "PyCurl" Then
                                Dim FirstLine As String = "def PyCurlRequest():"
                                Dim SecondLine As String = "        try:"
                                Dim ThirdLine As String = "                Response = ''"
                                Dim FourthLine As String = "                CurlOB = pycurl.Curl()"
                                Dim FifthLine As String = "                CurlOB.setopt(pycurl.SSL_VERIFYHOST, 0)"
                                Dim SixthLine As String = "                CurlOB.setopt(pycurl.SSL_VERIFYPEER, 0)"
                                Dim SeventhLine As String = "                CurlOB.setopt(pycurl.URL, """ + Url.Text + """)"
                                Dim EighthLine As String = "                CurlOB.setopt(pycurl.HTTPHEADER, ["
                                Dim NinthLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        If NinthLine = "" Then
                                            NinthLine = $"'{Header}'" + NinthLine
                                        Else
                                            NinthLine = NinthLine + $", '{Header}'"
                                        End If
                                    Next
                                End If
                                Dim TenthLine As String = "])"
                                Dim EleventhLine As String = "                Response = CurlOB.perform_rs()"
                                Dim TwelvthLine As String = "         except: pass"
                                Dim ThirteenthLine As String = "         return Response"
                                RequestInfo.Text = $"{FirstLine}{vbNewLine}{SecondLine}{vbNewLine}{ThirdLine}{vbNewLine}{FourthLine }{vbNewLine}{FifthLine}{vbNewLine}{SixthLine}{vbNewLine}{SeventhLine}{vbNewLine}{EighthLine}{NinthLine}{TenthLine}{vbNewLine}{EleventhLine}{vbNewLine}{TwelvthLine}{vbNewLine}{ThirteenthLine}"
                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
#Region "C# GET Request"
                    ElseIf LanguageChoose.SelectedItem = "C#" Then
                        If Not Url.Text = "" Then
                            If RequestLIB.SelectedItem = "Normal" Then
                                Dim FirstLine As String = $"string Resp = {My.Resources.Apostraphae}{My.Resources.Apostraphae};"
                                Dim ThirdLine As String = "try"
                                Dim FifthLine As String = "{"
                                Dim SixthLine As String = $"        HttpWebRequest Req = WebRequest.CreateHttp(""{Url.Text}"");"
                                Dim PostReq As String = "        Req.Method = ""GET"";"
                                Dim Headerz As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        Headerz = Headerz + vbNewLine + $"        Req.Headers.Add(""{Header}"");"
                                    Next
                                End If
                                Dim EighthLine As String = "        StreamReader ReqReader = new StreamReader(((HttpWebResponse)Req.GetResponse()).GetResponseStream());"
                                Dim NinthLine As String = "        Resp = ReqReader.ReadToEnd(); ReqReader.Dispose(); ReqReader.Close();"
                                Dim TenthLine As String = "catch (WebException e)" + vbNewLine + "        {"
                                Dim EleventhLine As String = "                Resp = new StreamReader(e.Response.GetResponseStream()).ReadToEnd();"
                                Dim TwelvthLine As String = "        }" + vbNewLine + "        return Resp;"
                                Dim ThirteenthLine As String = "}"
                                RequestInfo.Text = $"{FirstLine}{vbNewLine}{ThirdLine}{vbNewLine}{FifthLine}{vbNewLine}{SixthLine}{vbNewLine}{PostReq}{Headerz}{vbNewLine}{EighthLine}{vbNewLine}{NinthLine}{vbNewLine}{TenthLine}{vbNewLine}{EleventhLine}{vbNewLine}{TwelvthLine}{vbNewLine}{ThirteenthLine}"
                            ElseIf RequestLIB.SelectedItem = "WebClient" Then
                                Dim FirstLine As String = $"string Resp = {My.Resources.Apostraphae}{My.Resources.Apostraphae};"
                                Dim ThirdLine As String = "try"
                                Dim FifthLine As String = "{"
                                Dim SixthLine As String = $"        WebClient Req = new WebClient ();"
                                Dim PostReq As String = "        Req.Method = ""GET"";"
                                Dim Headerz As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        Headerz = Headerz + vbNewLine + $"        Req.Headers.Add('{Header}');"
                                    Next
                                End If
                                Dim EighthLine As String = $"        Stream ReqData = Req.OpenRead('{Url.Text}');"
                                Dim NinthLine As String = "        StreamReader Reader = new StreamReader(ReqData);"
                                Dim Niney As String = "        Resp = Reader.ReadToEnd (); ReqData.Close(); Reader.Close();"
                                Dim TenthLine As String = "catch (WebException e)" + vbNewLine + "        {"
                                Dim EleventhLine As String = "                Resp = new StreamReader(e.Response.GetResponseStream()).ReadToEnd();"
                                Dim TwelvthLine As String = "        }" + vbNewLine + "        return Resp;"
                                Dim ThirteenthLine As String = "}"
                                RequestInfo.Text = $"{FirstLine}{vbNewLine}{ThirdLine}{vbNewLine}{FifthLine}{vbNewLine}{SixthLine}{vbNewLine}{PostReq}{Headerz}{vbNewLine}{EighthLine}{vbNewLine}{NinthLine}{vbNewLine}{Niney}{vbNewLine}{TenthLine}{vbNewLine}{EleventhLine}{vbNewLine}{TwelvthLine}{vbNewLine}{ThirteenthLine}"
                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
#Region "cURL GET Request"
                    ElseIf LanguageChoose.SelectedItem = "cURL" Then
                        If Not Url.Text = "" Then
                            If RequestLIB.SelectedItem = "Normal" Then
                                Dim FirstLine As String = "curl -L -X GET "
                                Dim SecondLine As String = ""
                                If Not Headers.Text = "" Then
                                    Dim HeadersSplit As String() = Split(Headers.Text, vbNewLine) : HeadersListBox.Items.AddRange(HeadersSplit)
                                    For Each Header As String In HeadersListBox.Items
                                        SecondLine = SecondLine + $" -H '{Header}'"
                                    Next
                                End If
                                Dim ThirdLine As String = $" '{Url.Text}'"
                                RequestInfo.Text = $"{FirstLine}{SecondLine}{ThirdLine}"
                            End If
                        Else
                            MsgBox("No Url Set!", MsgBoxStyle.Critical)
                        End If
#End Region
                    End If
                Else
                    MsgBox("No RequestType Selected!", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("No Request Library Selected!", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("No Language Selected!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub CopyButton_Click(sender As Object, e As EventArgs) Handles CopyButton.Click
        Clipboard.SetText(RequestInfo.Text)
        MsgBox("Copied Request!", MsgBoxStyle.Information)
    End Sub
#End Region
#Region "ComboBoxes"
    Private Sub RequestType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RequestType.SelectedIndexChanged
        If RequestType.SelectedItem = "GET" Then
            PostData.Enabled = False
            PostData.Text = ""
        Else
            PostData.Enabled = True
        End If
    End Sub

    Private Sub RequestLIB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RequestLIB.SelectedIndexChanged
        If RequestLIB.SelectedItem = "RestSharp" Then
            Url.Width = 109
            URL2.Show()
            URL2.Text = ""
        Else
            Url.Width = 218
            URL2.Hide()
            URL2.Text = ""
        End If
    End Sub

    Private Sub LanguageChoose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LanguageChoose.SelectedIndexChanged
        If LanguageChoose.SelectedItem = "Visual Basic" Then
            RequestLIB.Items.Clear()
            RequestLIB.Items.Add("Normal")
            RequestLIB.Items.Add("RestSharp")
            RequestLIB.Items.Add("WebClient")
            RequestLIB.SelectedItem = "Normal"
        ElseIf LanguageChoose.SelectedItem = "Python" Then
            RequestLIB.Items.Clear()
            RequestLIB.Items.Add("Normal")
            RequestLIB.Items.Add("PyCurl")
            RequestLIB.SelectedItem = "Normal"
        ElseIf LanguageChoose.SelectedItem = "C#" Then
            RequestLIB.Items.Clear()
            RequestLIB.Items.Add("Normal")
            RequestLIB.Items.Add("WebClient")
            RequestLIB.SelectedItem = "Normal"
        ElseIf LanguageChoose.SelectedItem = "cURL" Then
            RequestLIB.Items.Clear()
            RequestLIB.Items.Add("Normal")
            RequestLIB.SelectedItem = "Normal"
        End If
    End Sub
#End Region
#Region "ControlBox & FormLoad"
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox($"This was made by Roni!{vbNewLine}+ Instagram: @xexx{vbNewLine}+ Github: https://github.com/OnlyRoni", MsgBoxStyle.Information)
        LanguageChoose.SelectedItem = "Visual Basic"
        RequestLIB.SelectedItem = "Normal"
        RequestType.SelectedItem = "GET"
    End Sub
    Private Sub About_Click(sender As Object, e As EventArgs) Handles About.Click
        MsgBox($"[INFO] Made by Roni{vbNewLine}[INFO] Instagram: @xexx{vbNewLine}-----{vbNewLine}[INFO] Refrences taken from:{vbNewLine}[INFO] Instagram: @de4dot (idea), @alonemazin (design), @sql.tools (C# Codes)!", MsgBoxStyle.Information)
    End Sub
    Private Sub Minimization_Click(sender As Object, e As EventArgs) Handles Minimization.Click
        WindowState = FormWindowState.Minimized
    End Sub
#End Region
End Class