using FileHelpers;

namespace FileProcessingWorkerRole.CsvMappingEntities
{
    [DelimitedRecord(",")]
    public class Address
    {
        public int RecordId;
        public string AddressValue;
    }
}
