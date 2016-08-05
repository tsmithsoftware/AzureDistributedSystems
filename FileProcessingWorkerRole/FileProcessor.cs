using System.Collections.Generic;
using System.IO;
using System.Resources;
using FileProcessingWorkerRole.CsvMappingEntities;
using FileProcessingWorkerRole.Interfaces;

namespace FileProcessingWorkerRole
{
    public class FileProcessor
    {
        private IUserWriter _writer;
        public FileProcessor(IUserWriter writer)
        {
            _writer = writer;
        }

        public void CombineFilesAndWriteToOutput(string addressFileLocation, string nameFileLocation)
        {
            WriteUserListToFile(ExtractUsersFromNamesAndAddresses(addressFileLocation,nameFileLocation));
        }
        public List<User> ExtractUsersFromNamesAndAddresses(string addressFileLocation, string nameFileLocation)
        {
            var addressEngine = new FileHelpers.FileHelperEngine<Address>();
            Address[] addresses = addressEngine.ReadFile(addressFileLocation);
            var nameEngine = new FileHelpers.FileHelperEngine<Name>();
            Name[] names = nameEngine.ReadFile(nameFileLocation);
            List<User> users = new List<User>();
            if (names.Length == addresses.Length)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    users.Add(
                        new User()
                        {
                            FullName = names[i].NameValue,
                            Address = addresses[i].AddressValue
                        });
                }
            }
            //_writer.WriteAll(users);
            return users;
        }

        public void WriteUserListToFile(List<User> users)
        {
            _writer.WriteAll(users);
        }
    }
}
