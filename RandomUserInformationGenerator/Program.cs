using System;
using System.Collections.Generic;
using System.IO;
using RandomNameGenerator;

namespace RandomUserInformationGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> randomUserList = new List<User>();
            Random random = new Random();
            for (int i = 0; i < 25; i++)
            {
                randomUserList.Add(
                    new User()
                    {
                        Address = AddressGenerator.GenerateAddress(random),
                        FullName = NameGenerator.Generate(Gender.Male)
            });
            }

            using (StreamWriter nameWriter = new StreamWriter(new FileStream("UserNames.csv", FileMode.Create)))
            {
                using (StreamWriter addressWriter = new StreamWriter(new FileStream("UserAddresses.csv", FileMode.Create)))
                {
                    int recordNumber = 1;
                    foreach (User user in randomUserList)
                    {
                        nameWriter.WriteLine($"{recordNumber},{user.FullName}");
                        addressWriter.WriteLine($"{recordNumber},{user.Address}");
                        recordNumber++;
                    }
                }
            }
        }
    }
}
