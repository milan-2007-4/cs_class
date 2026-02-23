using System;

class TicketMachine
{
    static void Main()
    {
        int pricePerKm =5;   // ₹ per KM
        int distance = 0;
        string route = "";

        Console.WriteLine("=== AMRELI TICKET MACHINE ===");
        Console.WriteLine("Select Route:");
        Console.WriteLine("1. Amreli to Dhari");
        Console.WriteLine("2. Amreli to Nandadepo");
        Console.WriteLine("3. Amreli to Chital");
        Console.WriteLine("4. Amreli to Lathi");
        Console.WriteLine("5. Amreli to Junagadh");
		Console.WriteLine("6. Amreli to damnager");
        Console.WriteLine("7. Amreli to dive");
        Console.WriteLine("8. Amreli to valsad");
        Console.WriteLine("9. Amreli to vapi");
        Console.WriteLine("10. Amreli to karmbili");

        Console.Write("Enter choice (1-10): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                route = "Amreli to Dhari";
                distance = 35;
                break;

            case 2:
                route = "Amreli to Nandadepo";
                distance = 12;
                break;

            case 3:
                route = "Amreli to Chital";
                distance = 28;
                break;

            case 4:
                route = "Amreli to Lathi";
                distance = 35;
                break;

            case 5:
                route = "Amreli to Junagadh";
                distance = 60;
                break;          
			case 6:
                route = "6. Amreli to damnager";
                distance = 60;
                break;
				
		    case 7:
                route = "7. Amreli to dive";
                distance = 60;
                break;
			case 8:
                route = "8. Amreli to valsad";
                distance = 60;
                break;
			case 9:
                route = "9. Amreli to vapi";
                distance = 60;
                break;
			case 10:
                route = "10. Amreli to karmbili";
                distance = 60;
                break;
				default:
                Console.WriteLine("Invalid Selection!");
                return;
        }

        int price = distance * pricePerKm;

        Console.WriteLine("\nRoute: " + route);
        Console.WriteLine("Distance: " + distance + " KM");
        Console.WriteLine("Ticket Price: ₹" + price);

        Console.Write("Insert Money: ₹");
        int money = int.Parse(Console.ReadLine());

        if (money < price)
        {
            Console.WriteLine("Not enough money! Ticket cancelled.");
        }
        else
        {
            Console.WriteLine("Ticket Issued Successfully!");
            Console.WriteLine("Change Returned: ₹" + (money - price));
        }
    }
}
