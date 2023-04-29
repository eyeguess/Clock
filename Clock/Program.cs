namespace Clock;

public class Program
{
    public static void Main(string[] args)
    {
        bool y = true;
        Operation operation = new Operation();
        Console.WriteLine("Ju lutem jepni oren. (00-23)");
        try
        {
            operation.AA = Convert.ToInt32(Console.ReadLine());
        
            while (y)
            {
                if (operation.AA > -1 && operation.AA <= 24)
                {
                    Console.WriteLine("Ju lutem jepni minutat. (00-59)");
                    operation.BB = Convert.ToInt32(Console.ReadLine());

                    if (operation.BB > -1 && operation.BB <= 60)
                    {
                        operation.Dothemath(operation.AA, operation.BB);
                        y = false;
                    }
                    else
                    {
                        Console.WriteLine("Numer jo i vlefshem, ju lutem provoni perseri");
                        operation.BB = Convert.ToInt32(Console.ReadLine());
                    }

                    y = false;


                }
                else
                {
                    Console.WriteLine("Numer jo i vlefshem, ju lutem provoni perseri");
                    operation.AA = Convert.ToInt32(Console.ReadLine());

                }
            }
        }
        catch
        {
            Console.WriteLine("Inputi ka pas nje numer jashte kufizave e procesimit e programi edhe/ose \nu identifikuan shkronjat tek vlera. Rihapeni programin ju lutem.");
            return;
        }
        
    }
        
}