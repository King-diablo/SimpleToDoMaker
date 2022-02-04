List<string> ToDos = new List<string>();
string currentPath = @"C:\Users\uer\Documents\Projects\ToDoProgram\ToDoProgram\SavedToDo.txt";

StartProgram();

void StartProgram()
{
    Console.WriteLine("Press 0 to create and write notes or press 1 to read notes or 2 to delete files: write help to show guide");
    Console.Write("Input Code: ");
    string input = Console.ReadLine();

    if (input == "0")
    {
        CreateToDo();
    }
    else if (input == "1")
    {
        ReadToDo();
    }
    else if(input == "2")
    {
        Console.Write("Input Index: ");
        string index = Console.ReadLine();
        if (input == "Quit".ToLower() || input == "Exit".ToLower())
            return;
        else
        {
            int result = 0;
            bool isInt = int.TryParse(index, out result);
            DeleteToDo(result);
        }
    }
    else if(input == "help".ToLower())
    {
        Console.Clear();
        Console.WriteLine("0 - Create Note");
        Console.WriteLine("1 - Read/SeeNote");
        Console.WriteLine("2 - Delete A Note ");
        Console.WriteLine("Quit/Exit - To Exit Program ");
        Console.WriteLine("\n");
        StartProgram();
    }
    else if(input == "Quit".ToLower() || input == "Exit".ToLower())
    {
        return;
    }

}
void CreateToDo()
{
    Console.Write("Input Note: ");
    string note = Console.ReadLine();
    if(note == "Exit".ToLower() || note == "Quit".ToLower() || note == null)
    {
        Console.Clear();
        StartProgram();
        return;
    }
    else
    {
        ToDos.Add(note);
        CreateToDo();
    }
}

void ReadToDo()
{
    Console.Clear();
    if (ToDos.Count == 0)
    {
        Console.WriteLine("You Dont Have Notes");
    }
    else
    {
        foreach (var item in ToDos)
        {
            Console.WriteLine(item);
        }
    }
    StartProgram();
}

void DeleteToDo(int index)
{
    Console.Clear();
    try
    {
        if (ToDos.Count > 0)
        {
            Console.WriteLine($"You Removed {ToDos[index]} From Your List");
            ToDos.Remove(ToDos[index]);
            StartProgram();
        }
        else
        {
            Console.WriteLine("No File Detected.... Start By Creating A File");
            StartProgram();
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Wrong Input");
        StartProgram();
    }
}
