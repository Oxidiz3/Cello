using Cello;
using Cello.TUIConsole;


class Program
{
    static void Main(string[] args)
    {
        var cello = new Screen();
        var progress = new ProgressBar(100, 0);

        cello.AddElementToEnd(new Text("CELLO DEMO :)"));
        cello.AddElementToEnd(progress);

        for (int i = 0; i < 100; i++)
        {
            Thread.Sleep(100);
            progress.UpdateProgress(i);
            cello.Display();
        }
    }
}