//уровень:сложный, вариант:17

Console.Write("Bведите текст: ");



char[] mas = Console.ReadLine().ToCharArray();

Random r = new Random();
double l = 0;


double  u=0 ;



for (int i = 0; i < mas.Length; i++)
{

    bool lw= (char.IsLower(mas[i])) ;
    bool up = (char.IsUpper(mas[i]));
    if (lw) l++;
    if (up) u++;

   
}



Console.WriteLine();

if (l > u) for (int i = 0; i < mas.Length; i++)
    {
        if (char.IsUpper(mas[i])) mas[i] = char.ToLower(mas[i]);
        Console.Write(mas[i]);
    };

Console.WriteLine();
 if (u>l) for (int i = 0; i < mas.Length; i++)
    {
        if (char.IsLower(mas[i])) mas[i] = char.ToUpper(mas[i]);
        Console.Write(mas[i]);
    };
if (l==u) for (int i = 0;i<mas.Length; i++)
    {
        Console.Write(mas[i]+" ");
    }
