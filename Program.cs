Console.Write("Введите кол-во элементов в массиве: ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] m = new string[n];

    for(int i = 0; i < n; i++)
    {
        Console.Write($"m[{i}] = ");
        m[i] = Console.ReadLine();
    }

    string[] m_res = new string[] {};

    int len = 0;
    for(int i = 0; i < n; i++)
    {
        if (m[i].Length <=3)
        {
            Array.Resize(ref m_res, len+1);
            m_res[len] = m[i];
            len += 1;
        }
    }
    
    for(int i = 0; i < m_res.Length; i++)
    {
        Console.Write($"m_res[{i}] = {m_res[i]} ");
    }