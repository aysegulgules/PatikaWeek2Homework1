//for uygulama 1
for (int i=1;i<=10;i++)
{
    Console.WriteLine($"{i}- Kendime inanıyorum, ben bu yazılım işini hallederim!");

}
Console.Write("\n--------------------------------\n ");



//for uygulama 2
Console.WriteLine("\n\n 1 ile 20 arasındaki sayılar\n");
for (int i = 1; i <= 20; i++)
{
    Console.Write($"{i}  ");

}
Console.Write("\n--------------------------------\n ");



//for uygulama 3
Console.WriteLine("\n\n 1 ile 20 arasındaki çift sayılar\n");
for (int i = 1; i <= 20; i++)
{
    if(i%2==0)
    Console.Write($"{i}  ");

}
Console.Write("\n--------------------------------\n ");



//for uygulama 4
Console.Write("\n\n 50 ile 150 arasındaki sayıların toplamı...:");
int sum = 0;
for (int i = 50; i <=150; i++)
{
    sum += i;
}
Console.WriteLine($"{sum}");
Console.Write("\n--------------------------------\n ");


//for uygulama 5
Console.WriteLine("\n\n 1 ile 120 arasındaki tek ve çift sayıların toplamları\n");
int evenNumbers = 0;
int oddNumbers = 0;
for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
        evenNumbers += i;
    else

        oddNumbers += i;

}
Console.WriteLine($"Tek sayıların toplamı...={oddNumbers}");
Console.WriteLine($"Çift sayıların toplamı...={evenNumbers}");

