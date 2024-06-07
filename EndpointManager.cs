// Endpoint manager class
class EndpointManager {
    private List<Endpoint> endpoints;

    public EndpointManager() {
        endpoints = new List<Endpoint>();
    }

    public void createEndpoint() {
        Console.WriteLine("\nPlease enter the Endpoint Serial Number:");
        string input = Console.ReadLine();
        // Checks if the serial number already exists
        foreach (var endpoint in endpoints) {
            if (endpoint.getSerialNumber() == input) {
                Console.WriteLine("\nThis Serial Number is already being used in an endpoint!\n");
                return;
            }
        }
        Endpoint newEndpoint = new Endpoint(input);

        Console.WriteLine("Please enter the Meter Model Id:");
        input = Console.ReadLine();
        int tempInt = 0;
        while (!int.TryParse(input, out tempInt) ||
                tempInt < 16 || tempInt > 19) {
            Console.WriteLine("Please enter a number between 16 and 19!");
            input = Console.ReadLine();
        }
        newEndpoint.setModelId(tempInt);
        
        Console.WriteLine("Please enter the Meter Number:");
        input = Console.ReadLine();
        while (!int.TryParse(input, out tempInt)) {
            Console.WriteLine("Please enter a valid number!");
            input = Console.ReadLine();
        }
        newEndpoint.setMeterNumber(tempInt);
        
        Console.WriteLine("Please enter the Firmware Version:");
        input = Console.ReadLine();
        newEndpoint.setFirmwareVersion(input);
        
        Console.WriteLine("Please enter the Switch State:");
        input = Console.ReadLine();
        while (!int.TryParse(input, out tempInt) ||
                tempInt < 0 || tempInt > 2) {
            Console.WriteLine("Please enter a valid number (0, 1 or 2)!");
            input = Console.ReadLine();
        }
        newEndpoint.setModelId(tempInt);
        endpoints.Add(newEndpoint);

        Console.WriteLine("\nEndpoint created sucessfully!\n");
    }

    // Prints all the information for an endpoint (by serial number)
    public void findEndpoint(string searchValue) {
        bool found = false;
        foreach (var endpoint in endpoints) {
            if (endpoint.getSerialNumber() == searchValue) {
                // Prints all the infomation for the endpoint
                endpoint.print();
                found = true;
            }
        }

        if (!found) // Prints an error to let the user know if the search fails
            Console.WriteLine("\nNo endpoint could be found with this Serial Number...\n");
    }

    // Prints all the infomation for each endpoint
    public void listEndpoints() {
        foreach (var endpoint in endpoints) {
            endpoint.print();
        }
    }

    // Edits an endpoint (by serial number)
    public void editEndpoint(string searchValue) {
        bool found = false;
        foreach (var endpoint in endpoints) {
            if (endpoint.getSerialNumber() == searchValue) {
                // Ask for the information to edit the endpoint
                Console.WriteLine("\nWhat value would you like to change the Switch State to?");
                string input = Console.ReadLine();
                int tempInt = 0;
                while (!int.TryParse(input, out tempInt) ||
                        tempInt < 0 || tempInt > 2) {
                    Console.WriteLine("Please enter a valid number (0, 1 or 2)!\n4");
                    input = Console.ReadLine();
                }
                endpoint.setSwitchState(tempInt);
                Console.WriteLine("\nEndpoint edited sucessfully!\n");
                found = true;
            }
        }

        if (!found) // Prints an error to let the user know if the search fails
            Console.WriteLine("\nNo endpoint could be found with this Serial Number...\n");
    }

    // Deletes an endpoint (by serial number)
    public void deleteEndpoint(string searchValue) {
        bool found = false;
        Endpoint target = null;
        foreach (var endpoint in endpoints) {
            if (endpoint.getSerialNumber() == searchValue) {
                // Mark the endpoint for deletion
                target = endpoint;
                found = true;
            }
        }
        

        if (!found) // Prints an error to let the user know if the search fails
            Console.WriteLine("\nNo endpoint could be found with this Serial Number...\n");
        else {
            endpoints.Remove(target);
            Console.WriteLine("\nEndpoint deleted sucessfully!\n");
        }
    }
}