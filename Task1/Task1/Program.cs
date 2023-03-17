const int DegreesPerHour = 30;
const int DegreesPerMinute = 6;

do
{
    int hours, minutes;
    int angle = 0;

    Console.Write("Enter the hour (0-24): ");
    if (!int.TryParse(Console.ReadLine(), out hours) || hours < 0 || hours > 24)
    {
        Console.WriteLine("Invalid input for hour. Please enter a valid integer between 0 and 24.");
        continue;
    }

    Console.Write("Enter the minute (0-60): ");
    if (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0 || minutes > 60)
    {
        Console.WriteLine("Invalid input for minute. Please enter a valid integer between 0 and 60.");
        continue;
    }

    if (hours > 12 && hours < 25)
    {
        hours -= 12;
    }

    int hourAngle = hours * DegreesPerHour;
    int minuteAngle = minutes * DegreesPerMinute;
    if (hourAngle > minuteAngle)
    {
        angle = hourAngle - minuteAngle;
    }
    else if (minuteAngle > hourAngle)
    {
        angle = minuteAngle - hourAngle;
    }

    if (angle > 180)
    {
        angle = 360 - angle;
    }
    Console.WriteLine($"The angle between the hour hand and minute hand is {angle} degrees.");
    Console.Write("Do you want to continue? (y/n): ");
} while (Console.ReadLine().ToLower() == "y");