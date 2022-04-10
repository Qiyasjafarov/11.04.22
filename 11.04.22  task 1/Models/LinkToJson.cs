using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml;

namespace _11._04._22__task_1.Models
{
    public static class LinkToJson
    {
        public static void Downloadjson(string date,string FileName)
        {
            string Date = date;
            string link = "https://www.cbar.az/currencies/"+Date+".xml";

            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(link).Result;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\qiyas\Downloads\"+FileName+".json");
            streamWriter.Write(jsonText);
            streamWriter.Close();
            Console.WriteLine("cevrildi");

        }

        
    }
}
