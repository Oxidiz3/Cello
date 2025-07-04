namespace Cello.TUIConsole;

interface ITUIConsoleText
{
    abstract void Run();
    bool Dead { get; }
}