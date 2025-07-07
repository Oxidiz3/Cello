using System.IO.Pipelines;
using Cello.TUIConsole;


class Program
{
    static void Main(string[] args)
    {
        var cello = new Screen();
        var progress = new ProgressBar(10, "Loading Demo...");

        cello.AddElementToEnd(new Text("CELLO DEMO :)", 3));
        cello.AddElementToEnd(progress);

        for (int i = 0; i < progress.Total; i++)
        {
            Thread.Sleep(100);
            progress.SetProgress(i);
            cello.DisplayElements();
        }

        cello.AddElementToEnd(new Text("Food Selection Demo", 3, isHeader: true));
        var selection = new Selection(["Tacos", "Pizza", "French Fries"], "Order Your Food");
        cello.AddElementToEnd(selection);

        while (!selection.IsDead())
        {
            cello.DisplayElements();
        }

        cello.AddElementToEnd(new Text($"You chose: {selection.GetChoice()}", 3));
        while (true)
        {
            cello.DisplayElements();
        }

    }
}