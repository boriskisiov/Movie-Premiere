string movietype = Console.ReadLine();
double rows = double.Parse(Console.ReadLine());
double countseats = double.Parse(Console.ReadLine());
double total = rows * countseats;

if (movietype == "Premiere")
{
    total = total * 12;
}else if (movietype == "Normal")
{
    total = total * 7.50;
}else if(movietype == "Diskount")
{
    total = total * 5.00;
}
Console.WriteLine($"{total:f2}");