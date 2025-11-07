using System;

public class Program
{
    private int data;
    private static int alive = 0;
    public Program()
    {
        System.Console.WriteLine("Constructor Called");
        alive++;
        System.Console.WriteLine("Alive Objects: " + alive);
    }

    public void set_data(int x)
    {
        this.data = x;
    }

    public void show_data()
    {
        System.Console.WriteLine("Data: " + this.data);
    }
    ~Program()
    {
        System.Console.WriteLine("Object with value " + this.data + " Destroyed");
        alive--;
        System.Console.WriteLine("Alive Objects: " + alive);
    }

    public static void Test()
    {
        Program p1 = new Program();
        p1.set_data(10);
        Program p2 = new Program();
        p2.set_data(20);
        Program p3 = new Program();
        p3.set_data(30);

        p1.show_data();
        p2.show_data();
        p3.show_data();
    }

    public static void Main(string[] args)
    {
        Test();
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
