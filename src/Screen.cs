using Cello.TUIConsole;

class Screen
{
    private List<TUIConsoleText> AliveElements = [];
    private List<TUIConsoleText> History = [];

    public Screen()
    {
    }

    public void AddElementToEnd(TUIConsoleText consoleText)
    {
        AliveElements.Add(consoleText);
    }

    public void DisplayElements()
    {
        Thread.Sleep(100);
        Console.Clear();

        // History.AddRange(AliveElements.Where(a => a.IsDead()).ToList());
        // foreach (var consoletext in History)
        // {
        //     consoletext.Display();
        // }

        AliveElements = AliveElements.Where(a => !a.IsDead()).ToList();

        foreach (var consoletext in AliveElements)
        {
            consoletext.Display();
        }
    }
}