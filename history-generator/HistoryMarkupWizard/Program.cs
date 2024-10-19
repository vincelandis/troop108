using HistoryMarkupWizard.Helpers;

// welcome
Utility.WriteHostMessage("Welcome to the History Markup Wizard. Press any key to continue.");

// main menu
Console.ReadKey();

FileWriter writer = new(path: "output");

var selection = string.Empty;
while (!selection.Equals(SelectionOption.EXIT, StringComparison.OrdinalIgnoreCase))
{
    Utility.WriteHostMessage(
        $"History Markup Wizard main menu:\n" +
        $"({SelectionOption.UPDATE}) - update year reports in local store\n" +
        $"({SelectionOption.GENERATE}) - generate markup from latest edits\n" +
        $"({SelectionOption.EXIT}) - exit application\n" +
        $"Enter keycode followed by Enter Key to proceed."
    );

    selection = Console.ReadLine()?.Trim() ?? string.Empty;

    if (selection.Equals(SelectionOption.GENERATE, StringComparison.OrdinalIgnoreCase))
    {
        writer.GenerateMarkup();
    }
    else if (selection.Equals(SelectionOption.UPDATE, StringComparison.OrdinalIgnoreCase))
    {
        writer.UpdateLocalStore();
    }
    else if (!selection.Equals(SelectionOption.EXIT, StringComparison.OrdinalIgnoreCase))
    {
        Utility.WriteHostMessage("Invalid entry. Try again.");
        Console.ReadKey();
    }
}

// exit
Utility.WriteHostMessage("Application terminated. Press any key to quit.");
Console.ReadKey();
