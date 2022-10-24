// зад 50 Устройство для определения наличия в массиве элемента со введенным адресом
Console.Clear();
int m=new Random().Next(3,5);
int n=new Random().Next(3,5);
void PrintArray (int[,] array)
    {   for (int i=0;i<array.GetLength(0);i++)
            {   for (int j=0;j<array.GetLength(1);j++)
                    Console.Write(" "+array[i,j]);
            Console.WriteLine();}
    }
int [,] FillArray(int[,] array1)
    {  for (int i1=0;i1<array1.GetLength(0);i1++)
            for (int j1=0;j1<array1.GetLength(1);j1++)
                    array1[i1,j1]=new Random().Next(10,20);
        return array1;}
void SearchElement (int[,] array2)
    {   Console.WriteLine("Введите номер строки искомого элемента массива");
        int i2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите номер столбца искомого элемента массива");
        int j2=Convert.ToInt32(Console.ReadLine());
        if (0<=i2&&i2<array2.GetLength(0)&&0<=j2&&j2<array2.GetLength(1))
            Console.WriteLine ($"В исходном массиве найден элемент с адресом [{i2}, {j2}], его значение {array2[i2,j2]}");
        else
            Console.WriteLine ($"В исходном массиве не найден элемент с адресом [{i2}, {j2}]");}
int[,] array3=new int [m,n];
Console.WriteLine("Исходный массив");
PrintArray(FillArray(array3));
SearchElement(array3);