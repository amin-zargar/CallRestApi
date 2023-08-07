Imports System.IO
Imports System.Net

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGetInfo_Click(sender As Object, e As EventArgs) Handles btnGetInfo.Click
        Try
            Dim serviceURL As String
            If String.IsNullOrEmpty(txtCountry.Text) Then
                serviceURL = "https://restcountries.com/v3.1/all"
            Else
                serviceURL = String.Format("https://restcountries.com/v3.1/name/{0}", txtCountry.Text)
            End If

            Dim origRequest As HttpWebRequest = DirectCast(HttpWebRequest.Create(serviceURL), HttpWebRequest)

            ' در صورتیکه برای استفاده از سرویس نیاز به رمز باشد از کد زیر استفاده می شود
            'origRequest.Headers.Add("Authorization", "Basic c3NhX2RzdDpBc3AzY3RfMTIzNA==")

            origRequest.AllowAutoRedirect = False
            origRequest.Method = "GET"
            Dim origResponse As HttpWebResponse = DirectCast(origRequest.GetResponse(), HttpWebResponse)
            Dim Stream As Stream = origResponse.GetResponseStream()
            Dim sr As New StreamReader(Stream, Encoding.GetEncoding("utf-8"))
            Dim str As String = sr.ReadToEnd()
            txtResult.Text = str
        Catch ex As WebException
            txtResult.Text = txtResult.Text & "Error-Exception: " & ex.Message & vbCrLf
        End Try
    End Sub
End Class