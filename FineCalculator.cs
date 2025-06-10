namespace LibraryManagement;


public class FineCalculator
{
    public int Days { get; set; }
    public double Finerate { get; set; }

    public void CalculateFine(int days)
    {

        Console.WriteLine($"Days: {Days * 5}");
        // return Days;
    }
    public void CalculateFine(int days,double Finerate)
    {

        Console.WriteLine($"Days: {Days * Finerate}");
        // return Days;
    }
    
    // public string CalculateFine(int days, double finerate,string type)
    // {
        
    //     switch (type)
    //     {
    //         case "student":
    //             Console.WriteLine(days*0.5);
    //             break;
    //         // case "Teacher":
    //         //     Console.WriteLine("Option 2 selected");
    //         //     break;
    //     }
    
}

    
   
