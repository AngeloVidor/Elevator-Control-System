using System;
using System.Collections.Generic;

class ElevatorController
{
    private List<Elevator> elevators;

    public ElevatorController(int numberOfElevators, PositionSensor sensor, ElevatorMotor motor)
    {
        elevators = new List<Elevator>();
        for (int i = 0; i < numberOfElevators; i++)
        {
            Elevator elevator = new Elevator(sensor, motor);
            elevators.Add(elevator);
        }
    }

    public void RequestElevator(int targetFloor)
    {
        Elevator elevator = FindNearestElevator(targetFloor);
        elevator.AddToQueue(targetFloor);
        Console.WriteLine($"Elevator requested to floor {targetFloor}");
        HandleRequests();
    }

    private Elevator FindNearestElevator(int targetFloor)
    {
        Elevator nearestElevator = elevators[0];
        int minDistance = Math.Abs(nearestElevator.CurrentFloor - targetFloor);

        foreach (Elevator elevator in elevators)
        {
            int distance = Math.Abs(elevator.CurrentFloor - targetFloor);
            if (distance < minDistance)
            {
                minDistance = distance;
                nearestElevator = elevator;
            }
        }

        return nearestElevator;
    }

    public void HandleRequests()
    {
        foreach (Elevator elevator in elevators)
        {
            if (elevator.RequestedFloors.Count > 0)
            {
                int targetFloor = elevator.RequestedFloors[0];
                elevator.MoveToFloor(targetFloor);
                elevator.OpenDoors();
                elevator.CloseDoors();
                elevator.RequestedFloors.RemoveAt(0);
            }
        }
    }

    internal void SelectFloor(int selectedFloor)
    {
        throw new NotImplementedException();
    }
}


