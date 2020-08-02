namespace DatabaseCreating
{
    class ConsoleProgram
    {
        static void Main(string[] args)
        {
            CreateDatabase create = new CreateDatabase();
            create.StartCreating();
        }
    }
}
