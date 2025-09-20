namespace Cello.TUIConsole;

public abstract class IConsoleText
{
    public abstract void Display();
    public abstract bool IsDead();
    public DateTime CreationTime { get; set; } = DateTime.Now;
}
