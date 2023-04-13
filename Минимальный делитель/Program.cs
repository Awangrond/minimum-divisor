int scan=0, minDiv=0, mod=1, i=1;

Console.WriteLine ("Напишите число:");
scan = Convert.ToInt32(Console.ReadLine());

    while (mod != 0)
    {   
        if (scan == 0)
        {
            i = 0;
        }

        i++;
        mod = scan % i;
    }

minDiv = i;
Console.WriteLine("Минимальный делитель");
Console.WriteLine(minDiv);