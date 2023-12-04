Console.WriteLine("Hello, World!");
string msg = "Today is Saturday";
int i = 10;
int result = i + 10;
byte b = 10;
Console.WriteLine($"i value is {i}");

float f = 1.5f;
Console.WriteLine(f);

decimal d = 2.0m;
Console.WriteLine(d);

double doub = 30.0;
Console.WriteLine(doub);

float f2 = 20.2f + 10.0f;
Console.WriteLine(f2);

float f3 = i + b;
Console.WriteLine(f3);

decimal pie = 3.14m;
int myPie = Convert.ToInt32(pie);
Console.WriteLine(myPie);

int me = (int)pie;
Console.WriteLine(me);

bool isPass = false;
if (isPass)
{
    Console.WriteLine("Pass exam");
}
else
{
    {
        Console.WriteLine("Fail exam");
    }
}

int value = 0;
if(value%2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}

switch (value)
{
    case 0: Console.WriteLine("OK");goto case 1;
    case 1: Console.WriteLine("HI");goto case 3;
    case 2: Console.WriteLine("Hey");goto case 0;
    case 3: Console.WriteLine("Hello");break;
    default: Console.WriteLine("you");break;
}
