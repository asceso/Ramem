namespace DatabaseTemplateFill
{
    class ConsoleProgram
    {
        static void Main(string[] args)
        {
            DatabaseFill fillData = new DatabaseFill();
            fillData.ReadSource();
        }
    }
}