//Найти произведение двух массивов как двух матриц
Console.WriteLine("Введите кол-во элементов по горизонтали в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во элементов по вертикали в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int [ , ] mas1 = new int [m,n];
int [ , ] mas2 = new int [m,n];
double [ , ] masrez = new double [m,n];
Random rnd = new Random();
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
        mas1[count1,count2] = rnd.Next(-15, 15);
        mas2[count1,count2] = rnd.Next(-15, 15);
        Console.Write(" " + mas1[count1,count2] + " / " + mas2[count1,count2] + " ");
    }
    Console.WriteLine();
}

int m1 = mas1.GetUpperBound(0) + 1;
int n1 = mas1.Length / m1;
for (int count3 = 0; count3 < m1; count3++)
{
   // Console.WriteLine("count3 = " + count3);
    for (int count4 = 0; count4 < n1; count4++)
    {
        //Console.WriteLine("count4 = " + count4);
        masrez [count3,count4] = mas1 [count3,count4] * mas2 [count3,count4];
    }
    
}
Console.WriteLine();
Console.WriteLine("Результирующий массив:");
for (int count1 = 0; count1 < m; count1++)
{
    for (int count2 = 0; count2 < n; count2++)
    {
       Console.Write(" " + masrez[count1,count2] + " ");
    }
    Console.WriteLine();
}

