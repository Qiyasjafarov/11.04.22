using _11._04._22__task_1.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Xml;
using System.Xml.Serialization;

namespace _11._04._22__task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datanin tarixini daxil edin (mes:10.12.2000) , Daha sonra ise datanin adini qeyd edin");
            LinkToJson.Downloadjson(Console.ReadLine(), Console.ReadLine());


        }
    }
}
