const int DegreesPerHour = 30;
const int DegreesPerMinute = 6;

do
{
    int hours, minutes;
    float angle = 0;

    Console.Write("Enter the hour (0-23): ");
    if (!int.TryParse(Console.ReadLine(), out hours) || hours < 0 || hours > 23)
    {
        Console.WriteLine("Invalid input for hour. Please enter a valid integer between 0 and 23.");
        continue;
    }

    Console.Write("Enter the minute (0-59): ");
    if (!int.TryParse(Console.ReadLine(), out minutes) || minutes < 0 || minutes > 59)
    {
        Console.WriteLine("Invalid input for minute. Please enter a valid integer between 0 and 59.");
        continue;
    }

    if (hours >= 12)
    {
        hours -= 12;
    }

    float hourAngle = (hours % 12) * DegreesPerHour + (float)minutes / 2;
    float minuteAngle = minutes * DegreesPerMinute;
    angle = Math.Abs(hourAngle - minuteAngle);
    if (angle > 180)
    {
        angle = 360 - angle;
    }
    Console.WriteLine($"The angle between the hour hand and minute hand is {angle} degrees.");
    Console.Write("Do you want to continue? (y/n): ");
} while (Console.ReadLine().ToLower() == "y");
