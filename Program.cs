
﻿public class HaloGeneric
{
    public void SapaUser(string x)
    {
        Console.WriteLine("Halo User " + x);
    }
}

﻿public class DataGeneric<T>
{
    public T Data { get; set; }
    public DataGeneric(T data) 
    {
        Data = data;    
    }

    public void printdata()
    {
        Console.WriteLine("Data yang tersimpan adalah: " +  Data);
    }
}

class Program
{
    static void Main(string[] args)
    {
        DataGeneric<string> stringData = new DataGeneric<string>("1302220079");
        stringData.printdata();

        HaloGeneric haloGeneric = new HaloGeneric();
        string x = "Hashfi";
        haloGeneric.SapaUser(x);
    }
}