namespace Cello.TUIConsole;

class ProgressBar(int total, string title) : TUIConsoleText
{
    public readonly int Total = total;
    public readonly string Title = title;
    private int Progress = 0;

    private decimal PercentProgress() => Math.Round(100 * (decimal)(Progress + 1) / Total) / 100;
    private readonly int TotalNumberOfBars = 50;

    public void SetProgress(int newProgress)
    {
        Progress = newProgress;
    }

    public override void Display()
    {
        // We want there to be 25 bars for seeing progress so that it can fit in a small 
        // terminal without having to wrap like this
        // ||||||============== 20%
        Console.WriteLine($"{Title}");

        var barsCompleted = (int)Math.Round(PercentProgress() * TotalNumberOfBars);

        // Print done bars
        Console.Write(string.Concat(Enumerable.Repeat('|', barsCompleted)));

        // Print bars to be finished
        Console.Write(string.Concat(Enumerable.Repeat('=', TotalNumberOfBars - barsCompleted)));

        // Print progress percentage
        Console.Write($"{(int)(PercentProgress() * 100)}%");
    }

    public override bool IsDead() => Progress >= Total - 1;

}