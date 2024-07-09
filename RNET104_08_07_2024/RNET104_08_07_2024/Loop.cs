namespace RNET104_08_07_2024;

public class Loop
{

    public static void Ronaldo()
    {
        for (int i = 0; i < 10; i++)
        {

            if(i == 3)
            {
                continue;
            }

            if(i == 4)
            {
                Console.WriteLine("Methodu bitirdi SİÜÜÜÜÜÜÜÜÜÜ");
                return;
            }



            if (i == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine(i);
            }

        }

        Console.WriteLine("Loop sındı SÜÜÜÜÜÜ");
    }
}
