using System;

class ElevatorUI
{
    private ElevatorController controller;

    public ElevatorUI(ElevatorController controller)
    {
        this.controller = controller;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Elevator Control System Menu");
        Console.WriteLine("1. Request Elevator");
        Console.WriteLine("2. Select Floor");
        Console.WriteLine("3. Exit");
    }

    public int GetUserChoice()
    {
        Console.Write("Enter your choice: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice;
        }
        return -1;
    }

    public int GetTargetFloor()
    {
        Console.Write("Enter the target floor: ");
        if (int.TryParse(Console.ReadLine(), out int floor))
        {
            return floor;
        }
        return -1;
    }
}
