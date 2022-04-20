//введите номер четверти


Console.Clear();

Console.WriteLine("Ведите номер четверти");
int num = int.Parse(Console.ReadLine());

switch(num) 
{
    case 1:
    {
        Console.WriteLine("x>0 y>0");
    break;
    }
    case 2:
    {
        Console.WriteLine("x<0 y>0");
    break;
    }
    case 3:
    {
        Console.WriteLine("x<0 y<0");
    break;
    }
    case 24:
    {
        Console.WriteLine("x>0 y<0");
    break;
    }

    default:
    {
        Console.WriteLine("введено не правильное число!");
        break;
    }
}
