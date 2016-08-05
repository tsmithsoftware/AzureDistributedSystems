using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomUserInformationGenerator
{
    public class AddressGenerator
    {
        static readonly string[] RoadPrefix = new[] {"Station", "Oak", "Ash", "Misty", "Elm", "Main"};
        static string[] RoadSuffix = new[] {"Road", "Drive", "Close", "Boulevard"};
        static string[] Towns = new[] {"Camberley", "Fleet", "Oakhelm", "Dark Avocado Town"};
        static string[] Postcode = new[] {"GU17 8DH", "JS10 8DS", "IS90 2DS", "SJ38 9DS"};

        public static string GenerateAddress(Random random)
        {
            int houseNumber = random.Next(25) + 1;
            return $"{houseNumber} " +
                   $"{RoadPrefix[random.Next(RoadPrefix.Length-1)]} " +
                   $"{RoadSuffix[random.Next(RoadSuffix.Length-1)]} " +
                   $"{Towns[random.Next(Towns.Length - 1)]} " +
                   $"{Postcode[random.Next(Postcode.Length - 1)]}";
        }
    }
}
