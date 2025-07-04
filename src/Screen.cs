using Cello.TUIConsole;

class Screen
{
    private List<ITUIConsoleText> AliveElements = [];

    public Screen()
    {
    }

    public void AddElementToEnd(ITUIConsoleText consoleText)
    {
        AliveElements.Add(consoleText);
    }

    public void Display()
    {
        Console.Clear();
        AliveElements = AliveElements.Where(a => !a.Dead).ToList();
        foreach (var consoletext in AliveElements)
        {
            consoletext.Run();
        }
    }
}