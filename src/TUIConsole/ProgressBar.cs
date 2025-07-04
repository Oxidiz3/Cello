namespace Cello.TUIConsole;

class ProgressBar(int total, int progress) : ITUIConsoleText
{
    readonly int Total = total;
    int Progress = progress;
    bool ITUIConsoleText.Dead { get => Progress >= Total; }

    public void Run()
    {
        Console.WriteLine("Progress:");
        // Print done bars
        if (Progress != 0)
        {
            Console.Write(string.Concat(Enumerable.Repeat('|', Progress - 1)));
        }
        // Print progress percentage
        Console.Write($"{Math.Round((decimal)(Progress + 1) * 100 / Total)}%");
        // Print bars to be finished
        Console.Write(string.Concat(Enumerable.Repeat('=', Total - 1 - Progress)));
    }

    public void UpdateProgress(int newProgress)
    {
        Progress = newProgress;
    }
}