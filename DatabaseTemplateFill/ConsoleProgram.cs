using System.Threading.Tasks;

namespace DatabaseTemplateFill
{
    class ConsoleProgram
    {
        static async Task Main(string[] args)
        {
            DatabaseFill fillData = new DatabaseFill();
            await fillData.ReadSourceAsync();
        }
    }
}