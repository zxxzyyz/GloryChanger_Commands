using GloryChanger_Commands.Commands;

namespace GloryChanger_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = new SerialComm();
            port.Open("COM1", 9600);
            var c31 = new Cmd31();
            c31.SetData("00999");
            port.Send(c31.ToFrame());
        }
    }
}
