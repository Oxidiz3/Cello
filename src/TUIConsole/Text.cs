namespace Cello.TUIConsole
{
    public class Text(string txt) : ITUIConsoleText
    {
        readonly string Txt = txt;

        public bool Dead => false;

        public void Run()
        {
            Console.WriteLine(Txt);
        }
    }
}