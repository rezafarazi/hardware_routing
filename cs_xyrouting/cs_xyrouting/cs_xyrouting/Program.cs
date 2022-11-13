//Main Function Start
main();
static void main()
{

    Console.Write("Enter count of x : ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Enter count of y : ");
    int y = int.Parse(Console.ReadLine());

    Console.Write("Enter current x location : ");
    int cureent_x= int.Parse(Console.ReadLine());
    Console.Write("Enter current y location : ");
    int cureent_y = int.Parse(Console.ReadLine());

    Console.Write("Enter target x location : ");
    int target_x = int.Parse(Console.ReadLine());
    Console.Write("Enter target y location : ");
    int target_y = int.Parse(Console.ReadLine());

    while(true)
    {
        XY_Result result = route(x, y, cureent_x, cureent_y, target_x, target_y);
        Console.WriteLine(result.x);
        Console.WriteLine(result.y);
        cureent_x = result.x;
        cureent_y = result.y;
        if (cureent_x == target_x && cureent_y == target_y)
            break;
    }

}
//Main Function End




//Route function Start
static XY_Result route(int lenx, int leny, int current_x, int current_y, int target_x, int target_y)
{

    if (current_x > target_x && current_x > 0)
        current_x-= 1;
    else if (current_x < target_x && current_x < lenx)
        current_x += 1;

    if (current_y > target_y && current_y > 0)
        current_y -= 1;
    else if (current_y < target_y && current_y < leny)
        current_y += 1;

    XY_Result result = new XY_Result();
    result.x = current_x;
    result.y = current_y;

    return result;
}
//Route function End




//Xy result Start
public struct XY_Result
{
    public int x;
    public int y;
}
//Xy result End