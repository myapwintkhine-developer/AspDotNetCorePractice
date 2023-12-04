int count = 100;
do
{
    Console.Write("Hi ");
    if (count % 2 == 0) Console.Write(count + " ");
    count++;
} while (count < 0);
Console.WriteLine();

for(int i = 1; i <= 7; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        Console.Write(i * j + " ");
    }
    Console.WriteLine();
}



int[] marks = new int[100];
for(int i = 0; i < marks.Length; i++)
{
    marks[i] = new Random().Next(100);
}

for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}

foreach(int i in marks)
{
    Console.WriteLine(i);
}

Console.WriteLine("2D");

int[,] examMark = new int[6, 8];
for(int column=0; column<6; column++)
{
    for(int row = 0; row < 8; row++)
    {
        examMark[column, row] = new Random().Next(10);
    }
}

foreach(int data in examMark) { Console.WriteLine(data); }




