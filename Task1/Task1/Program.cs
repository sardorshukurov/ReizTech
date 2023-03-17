int hours, minutes;
int result = 0;

Console.Write("Input hours: ");
hours = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minutes: ");
minutes = Convert.ToInt32(Console.ReadLine());


hours *= 30;
minutes *= 6;

if (hours > minutes)
{
    result = hours - minutes;
}
else
{
    result = minutes - hours;
}

if (result > 180)
{
    Console.WriteLine(360 - result);
    Console.ReadLine();
}
Console.WriteLine(result);
