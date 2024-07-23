using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW
{
    internal class ConsoleOutput : IOutput
    {
        public void WriteOutput(string message)
        {
            Console.WriteLine(message);
        }
    }
}
