using System;

class PositionSensor
{
    private int currentFloor;
    private Random random;

    public PositionSensor()
    {
        random = new Random();
        currentFloor = 1;
    }

    public int GetCurrentPosition()
    {
        int newPosition = currentFloor;

        int randomValue = random.Next(-1, 2);
        newPosition += randomValue;

        newPosition = Math.Max(1, Math.Min(10, newPosition));

        currentFloor = newPosition;

        return currentFloor;
    }
}
