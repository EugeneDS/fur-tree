    using System;
class Program
{
    public Program()
    {
        void WriteHello(string someName)
        {
            Console.WriteLine("Hello " + someName);
        }
        WriteHello("Jo");
        WriteHello("Don");
        WriteHello("Peter");
        WriteHello("You");
    } 
}