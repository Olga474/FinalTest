Console.Write("Введите кол-во элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] m = new int[n];

    for(int i = 0; i < n; i++)
    {
        Console.Write($"m[{i + 1}] = ");
        m[i] = Convert.ToInt32(Console.ReadLine());
    }