Console.Write("Введите кол-во элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] m = new string[n];

    for(int i = 0; i < n; i++)
    {
        Console.Write($"m[{i}] = ");
        m[i] = Console.ReadLine();
    }