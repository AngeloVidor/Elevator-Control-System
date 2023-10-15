using System;

class ElevatorMotor
{
    public void MoveElevator(int currentFloor, int targetFloor)
    {
        Console.WriteLine($"Moving elevator from floor {currentFloor} to floor {targetFloor}.");
        for (int floor = currentFloor; floor < targetFloor; floor++)
        {
            Console.WriteLine($"Passing floor {floor + 1}");
        }
    }
}