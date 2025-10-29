 
        int a = 5, b = 10;
        Console.WriteLine("Before: a=" + a + " b=" + b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("After:  a=" + a + " b=" + b);
    }
}