
Console.WriteLine("Enter Frist number ");
    double number1 =double.Parse(Console.ReadLine());
Console.WriteLine("Choees The Opration ");
 char Opration = char.Parse(Console.ReadLine());
Console.WriteLine("Enter Frist number ");
double number2 = double.Parse(Console.ReadLine());
if (Opration == '+'|| Opration == '-' || Opration == '*' || Opration == '/' )
{

    double total;

    switch (Opration)
    {
       case '+':  total = number1 + number2;
            Console.WriteLine("The totle is :"+total+"");
            break;
        case '-':  total = number1 + number2;
            Console.WriteLine("The totle is :" + total + "");
            break;
        case '*':
            total = number1 * number2;
            Console.WriteLine("The totle is :" + total + "");
            break;
        case '/':
            if (number2 == 0)
            {

                Console.WriteLine("Can not diveion by zero");

            }
            else
            {
                total = number1 / number2;
                Console.WriteLine("The totle is :" + total + "");
            }
            break;
default:
        Console.Write("Invalid Opration tray agin ");
        break;  

    }



}
else
    Console.WriteLine("The opration is erro ");