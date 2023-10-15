using System.Collections.Generic;
using System;

class Elevator
{
    public int CurrentFloor { get; private set; }
    public List<int> RequestedFloors { get; private set; }

    public Elevator(PositionSensor sensor, ElevatorMotor motor)
    {
        CurrentFloor = 1;
        RequestedFloors = new List<int>();
        PositionSensor = sensor;
        ElevatorMotor = motor;
    }


    public PositionSensor PositionSensor { get; set; }
    public ElevatorMotor ElevatorMotor { get; set; }

    public void MoveToFloor(int targetFloor)
    {
        int currentPosition = PositionSensor.GetCurrentPosition();
        if (currentPosition != CurrentFloor)
        {
            ElevatorMotor.MoveElevator(CurrentFloor, currentPosition);
            CurrentFloor = currentPosition;
        }

        ElevatorMotor.MoveElevator(CurrentFloor, targetFloor);
        CurrentFloor = targetFloor;
    }

    public void AddToQueue(int targetFloor)
    {
        RequestedFloors.Add(targetFloor);
    }

    public void OpenDoors()
    {
        Console.WriteLine("Opening elevator doors.");
    }

    public void CloseDoors()
    {
        Console.WriteLine("Closing elevator doors.");
    }
}