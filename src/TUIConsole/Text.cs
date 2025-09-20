namespace Cello.TUIConsole
{
    public class Text(string txt, double howLongToDisplayFor, bool isHeader = false) : IConsoleText
    {
        readonly string Txt = txt;
        private readonly double HowLongToDisplayFor = howLongToDisplayFor;

        public override bool IsDead()
        {
            return Utilities.TimeToNow(CreationTime) > HowLongToDisplayFor;
        }

        public override void Display()
        {
            if (isHeader)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Txt);
                Console.ResetColor();
                return;
            }

            Console.WriteLine(Txt);
        }
    }
}
