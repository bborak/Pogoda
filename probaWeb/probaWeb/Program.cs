﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.IO;

namespace probaWeb
{
//    public class WebRequestGetExample
//    {
//        public static void Main()
//        {
//            // Create a request for the URL. 		
//            WebRequest request = WebRequest.Create("http://www.contoso.com/default.html");
//            // If required by the server, set the credentials.
//            request.Credentials = CredentialCache.DefaultCredentials;
//            // Get the response.
//            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
//            // Display the status.
//            Console.WriteLine(response.StatusDescription);
//            // Get the stream containing content returned by the server.
//            Stream dataStream = response.GetResponseStream();
//            // Open the stream using a StreamReader for easy access.
//            StreamReader reader = new StreamReader(dataStream);
//            // Read the content.
//            string responseFromServer = reader.ReadToEnd();
//            // Display the content.
//            Console.WriteLine(responseFromServer);
//            // Cleanup the streams and the response.
//            reader.Close();
//            dataStream.Close();
//            response.Close();
//        }
//    }
//}
class Program
    {
        static void Main(string[] args)
        {
            //Create a request for the URL. 		
                        WebRequest request = WebRequest.Create("http://www.twojapogoda.pl/polska/slaskie/bielsko-biala/");
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();
        }
    }
}
