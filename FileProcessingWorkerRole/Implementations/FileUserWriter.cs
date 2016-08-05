using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileProcessingWorkerRole.CsvMappingEntities;
using FileProcessingWorkerRole.Interfaces;

namespace FileProcessingWorkerRole.Implementations
{
    public class FileUserWriter:IUserWriter
    {
        private readonly string _location;
        public FileUserWriter(string location)
        {
            _location = location;
        }
        public void Write(User user)
        {
            using (var writer = File.AppendText(_location))
            {
                writer.WriteLine($"{user.FullName},{user.Address}");
            }
        }

        public void WriteAll(IEnumerable<User> users)
        {
            foreach (User user in users)
            {
                Write(user);
            }
        }
    }
}
