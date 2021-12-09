using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class MyWebRequest : IReader
    {
        public string URL { get; set; }
        private WebRequest request;
        private WebResponse response;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">url path</param>
        public MyWebRequest(string url)
        {
            URL = url;
        }

        public string Read()
        {     
            CreateWebRequest(URL);
            GetWebResponse();

            return GetResponseStream();
        }

        /// <summary>
        /// Creates a webrequest to a website
        /// </summary>
        /// <param name="url">url path to the website</param>
        private void CreateWebRequest(string url)
        {
            // Create a request for the URL.
            request = WebRequest.Create(url);
            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
        }

        /// <summary>
        /// Gets the response from the website weather if it was successfull or not
        /// </summary>
        private void GetWebResponse()
        {
            // Get the response.
            response = request.GetResponse();
        }

        /// <summary>
        /// Opens the stream and gets all the websites html content
        /// </summary>
        /// <returns>returns the html content</returns>
        private string GetResponseStream()
        {
            // Get the stream containing content returned by the server.
            // The using block ensures the stream is automatically closed.
            using (Stream dataStream = response.GetResponseStream())
            {
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                return responseFromServer;
            }
        }
    }
}
