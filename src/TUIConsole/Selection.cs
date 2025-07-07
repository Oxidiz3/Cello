namespace Cello.TUIConsole;

class Selection(string[] choices, string title) : TUIConsoleText
{
    private readonly string[] Choices = choices;
    private string Title = title;
    private int SelectedChoice = 0;
    private bool SelectionMade = false;

    public string GetChoice() => Choices[SelectedChoice];

    public override bool IsDead() => SelectionMade;

    public override void Display()
    {
        Console.WriteLine(Title);
        for (int i = 0; i < Choices.Length; i++)
        {
            if (i == SelectedChoice)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"[x] {Choices[i]}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"[ ] {Choices[i]}");
            }
        }

        Console.WriteLine($"You've selected: {Choices[SelectedChoice]} (press ENTER to confirm)");

        GetInput();
    }

    public void GetInput()
    {
        var input = Console.ReadKey(true);
        switch (input.Key)
        {
            case ConsoleKey.J:
            case ConsoleKey.DownArrow:
                SelectedChoice++;
                if (SelectedChoice >= Choices.Length)
                {
                    SelectedChoice = 0;

                }
                break;

            case ConsoleKey.K:
            case ConsoleKey.UpArrow:
                SelectedChoice--;
                if (SelectedChoice < 0)
                {
                    SelectedChoice = Choices.Length - 1;
                }
                break;

            case ConsoleKey.Enter:
                SelectionMade = true;
                break;


            default:
                break;
        }
    }
}