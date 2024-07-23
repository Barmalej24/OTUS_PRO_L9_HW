using OTUS_PRO_L9_HW.Interface;

namespace OTUS_PRO_L9_HW
{
    internal class ConsoleInput : IInput
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}
