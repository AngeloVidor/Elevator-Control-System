using System;

class Program
{
    static void Main(string[] args)
    {
        PositionSensor sensor = new PositionSensor();
        ElevatorMotor motor = new ElevatorMotor();

        ElevatorController controller = new ElevatorController(2, sensor, motor);

        ElevatorUI ui = new ElevatorUI(controller);

        int choice;
        do
        {
            ui.DisplayMenu();
            choice = ui.GetUserChoice();

            switch (choice)
            {
                case 1:
                    int targetFloor = ui.GetTargetFloor();
                    if (targetFloor != -1)
                    {
                        controller.RequestElevator(targetFloor);
                    }
                    break;
                case 2:
                    int selectedFloor = ui.GetTargetFloor();
                    if (selectedFloor != -1)
                    {
                        controller.SelectFloor(selectedFloor);
                    }
                    break;
                case 3:
                    Console.WriteLine("Exiting the Elevator Control System.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (choice != 3);
    }
}
