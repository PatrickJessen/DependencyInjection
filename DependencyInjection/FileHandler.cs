using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    /// <summary>
    /// This class reads from a file
    /// </summary>
    class FileHandler : IReader
    {
        public string Path { get; set; }

        public FileHandler(string path)
        {
            Path = path;
        }

        public string Read()
        {
            return GetFileContent();
        }

        /// <summary>
        /// Gets content from a file
        /// </summary>
        /// <returns>returns all the files content</returns>
        private string GetFileContent()
        {
            using (StreamReader reader = new StreamReader(Path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
