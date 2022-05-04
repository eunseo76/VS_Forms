// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> lst = new List<int>();
int[] arr = new int[10];
double[] arrd = new double[10];

Random r = new Random();
for (int i = 0; i < 10; i++)
{
    arrd[i] = r.NextDouble();     // 0~1 미만
    arr[i] = r.Next(100);
    lst.Add(arr[i]);
}

Console.WriteLine();
Print(arr);
Print(arrd);
PrintList(lst);

lst.Sort();
Array.Sort(arr);
Array.Sort(arrd);

Console.WriteLine();
Print(arr);
Print(arrd);
PrintList(lst);

void PrintList(List<int> lst)
{
    foreach (var i in lst)
        Console.Write(i + " ");
    Console.WriteLine();
}

void Print<T>(T[] a)
{
    foreach (var item in a)
        Console.Write(item + " ");
    Console.WriteLine();
}


// 시험문제 90%