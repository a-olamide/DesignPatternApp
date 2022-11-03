namespace TemplateMethodPattern
{
    public class ExcelFile : DataProcessor
    {
       
        public override void ReadData()
        {
            Console.WriteLine("Read data from Excel file");
        }

        public override void ProcessData()
        {
            Console.WriteLine("process data from Excel file");
        }

    }
}