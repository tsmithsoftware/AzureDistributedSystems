using FileHelpers;

namespace FileProcessingWorkerRole.CsvMappingEntities
{
    [DelimitedRecord(",")]
    public class Name
    {
        public int RecordId;
        public string NameValue;
    }
}
