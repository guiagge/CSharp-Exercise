// Declares the endpoint manager and the menu option variable
EndpointManager endpointManager = new EndpointManager();
int option;

// Shows the menu options and ask for a number until 6 (exit) is given
do {
    Console.WriteLine("What would you like do to?");
    Console.WriteLine("1) Insert a new endpoint");
    Console.WriteLine("2) Edit an endpoint");
    Console.WriteLine("3) Delete an endpoint");
    Console.WriteLine("4) List all endpoints");
    Console.WriteLine("5) Find an endpoint");
    Console.WriteLine("6) Exit\n");
    // Prompts user for input
    string input = Console.ReadLine();
    if (!int.TryParse(input, out option))
        Console.WriteLine("Please enter a valid number!");
    else {
        switch (option) {   // Switches between the options
            case 1:
                endpointManager.createEndpoint();
            break;

            case 2:
                Console.WriteLine("\nPlease enter the serial number for the endpoint:");
                input = Console.ReadLine(); // Asks for the serial number
                endpointManager.editEndpoint(input);
            break;

            case 3:
                Console.WriteLine("\nPlease enter the serial number for the endpoint:");
                input = Console.ReadLine(); // Asks for the serial number
                endpointManager.deleteEndpoint(input);
            break;

            case 4:
                endpointManager.listEndpoints();
            break;

            case 5:
                Console.WriteLine("\nPlease enter the serial number for the endpoint:");
                input = Console.ReadLine(); // Asks for the serial number
                endpointManager.findEndpoint(input);
            break;

            case 6: break;

            default:    // Error message if the input is unrecognized
                Console.WriteLine("\nPlease enter a number between 1 and 6!\n");
            break;
        }
    }
} while (option != 6);  // Repeats until exiting