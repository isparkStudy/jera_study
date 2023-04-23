using System;
using System.IO;
using System.Net;

class HttpWebRequestDemo
{
    static void Main(string[] args)
    {
        // 아래 URL에서 HTML 문서를 가져 온다고 가정
        string url = "http://www.naver.com";

        var req = HttpWebRequest.CreateHttp(url);
        var res = req.GetResponse() as HttpWebResponse;

        var stream = res.GetResponseStream();

        using (var sr = new StreamReader(stream))
        {
            var html = sr.ReadToEnd();
            Console.WriteLine(html);
        }

    }
}