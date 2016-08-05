using System.Collections.Generic;
using FileProcessingWorkerRole.CsvMappingEntities;

namespace FileProcessingWorkerRole.Interfaces
{
    public interface IUserWriter
    {
        void Write(User user);
        void WriteAll(IEnumerable<User> users);
    }
}
