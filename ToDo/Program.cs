bool isExitTriggered = false;
List<string> toDoList = new List<string>();

do
{
  Console.WriteLine("Hello!");
  Console.WriteLine("What do you want to do?");
  Console.WriteLine("[S] See all TODO");
  Console.WriteLine("[A] Add a TODO");
  Console.WriteLine("[R] Remove a TODO");
  Console.WriteLine("[E] Exit");

  string operation = Console.ReadLine();

  switch (operation.ToUpper())
  {
    case "S":
      ListToDo(toDoList);
      break;
    case "A":
      toDoList = AddToDo(toDoList);
      break;
    case "R":
      toDoList = RemoveToDo(toDoList);
      break;
    case "E":
      isExitTriggered = true;
      break;
    default:
      Console.WriteLine("Invalid operation");
      break;
  }

} while (!isExitTriggered);

void ListToDo(List<string> toDoList)
{
  if (IsToDoEmpty(toDoList))
  {
    Console.WriteLine("The to do list is empty");
    return;
  }
  for (int i = 0; i < toDoList.Count; i++)
  {
    string toDo = toDoList[i];
    Console.WriteLine($"{i + 1}: {toDo}");
  }
}

List<string> AddToDo(List<string> toDoList)
{
  bool isLoopDone = false;
  do
  {
    Console.WriteLine("Enter TODO Description:");
    string toDoDesc = Console.ReadLine();

    if (toDoDesc.Length == 0)
    {
      Console.WriteLine("The Description cannot be empty");
      continue;
    }

    if (toDoList.Contains(toDoDesc))
    {
      Console.WriteLine("The Description needs to be unique");
      continue;
    }

    toDoList.Add(toDoDesc);
    Console.WriteLine($"{toDoDesc} has been added to the list!");
    isLoopDone = true;

  } while (!isLoopDone);

  return toDoList;
}
List<string> RemoveToDo(List<string> toDoList)
{
  if (IsToDoEmpty(toDoList))
  {
    Console.WriteLine("Theres nothing to remove as the TODO list is empty");
    return toDoList;
  }

  bool isParsable = false;
  do
  {
    Console.WriteLine("Please select the index of the todo");
    string userInput = Console.ReadLine();
    if (userInput.Length == 0)
    {
      Console.WriteLine("Selected index cannot be empty");
      continue;
    }

    isParsable = int.TryParse(userInput, out int removeIndex);
    if (isParsable)
    {
      int offsetIndex = removeIndex - 1;
      if (!IndexInRange(toDoList, offsetIndex))
      {
        Console.WriteLine("Index is out of range");
        isParsable = false;
        continue;
      }
     
      string toDo = toDoList[offsetIndex];
      Console.WriteLine($"Removing {toDo}");
      toDoList.RemoveAt(offsetIndex);
      Console.WriteLine($"TODO removed: {toDo}");
    }
    else
    {
      Console.WriteLine("Index is non parsable");
    }

  } while (!isParsable);

  return toDoList;
}

bool IndexInRange(List<string> toDoList, int index)
{
  return (0 <= index && index < toDoList.Count);
}
bool IsToDoEmpty(List<string> toDoList)
{
  return toDoList.Count == 0;
}