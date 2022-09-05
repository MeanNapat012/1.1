public class Program
{
    public static void Main(string[] args){
        string nameMarket = InputNameMarket();
        string num = InputNumber();
        string name = InputName();
        string numMoney = InputMoney();
        
        PrintAll(nameMarket, num, name, numMoney);


    }

    public static string InputNameMarket(){
        Console.Write("Please input Name :  ");
        return Console.ReadLine();
    }

    public static string InputNumber(){
        Console.Write("Please input Number : ");
        return Console.ReadLine();

    }

    public static string InputName(){
        Console.Write("Please input Ower Name :  ");
        return Console.ReadLine();
    }

    public static string InputMoney(){
        Console.Write("Please input Registered Value : ");
        return Console.ReadLine();
    }


    public static void PrintAll(string nameMarket, string num, string name, string numMoney){
        Console.WriteLine();
        Console.WriteLine("---------Shop information---------");
        Console.WriteLine("Name : {0}", nameMarket);
        Console.WriteLine("Number : {0}", num);
        Console.WriteLine("Owner Name : {0}", name);
        Console.WriteLine("Registered Value : {0}", numMoney);
        Console.WriteLine("----------------------------------");
        
    }
    
}

