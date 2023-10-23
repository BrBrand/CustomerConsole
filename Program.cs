using CustomerConsole.FileCustomerDataProvider.IFileCustomerDataProvider;
using CustomerConsole.FileCustomerDataProvider;
using CustomerConsole.Models;
using CustomerConsole.Data;

using (var dbContext = new ApplicationDbContext())
{
    IDataProvider<Customer> customerDataProvider = new DataProvider<Customer>(dbContext);

    // Create three customer instances
    var customer1 = new Customer { Name = "John Doe", Age = 35, Email = "john.doe@example.com" };
    var customer2 = new Customer { Name = "Jane Smith", Age = 28, Email = "jane.smith@example.com" };
    var customer3 = new Customer { Name = "Bob Johnson", Age = 45, Email = "bob.johnson@example.com" };

    // Save the customers using the DataProvider
    customerDataProvider.SaveData(customer1);
    customerDataProvider.SaveData(customer2);
    customerDataProvider.SaveData(customer3);

    var customers = customerDataProvider.GetDataList();

    Console.WriteLine("List of Customers:");
    foreach (var customer in customers)
    {
        Console.WriteLine($"Customer ID: {customer.Id}");
        Console.WriteLine($"Name: {customer.Name}");
        Console.WriteLine($"Age: {customer.Age}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine();
    }

    var customersOlderThan30 = customers.Where(customer => customer.Age > 30).ToList();

    Console.WriteLine("Customers Older Than 30:");
    foreach (var customer in customersOlderThan30)
    {
        Console.WriteLine($"Customer ID: {customer.Id}");
        Console.WriteLine($"Name: {customer.Name}");
        Console.WriteLine($"Age: {customer.Age}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine();
    }

    var customersWithDoeInName = customers.Where(customer => customer.Name.Contains("Doe")).ToList();
    foreach (var customer in customersWithDoeInName)
    {
        Console.WriteLine($"Customer ID: {customer.Id}");
        Console.WriteLine($"Name: {customer.Name}");
        Console.WriteLine($"Age: {customer.Age}");
        Console.WriteLine($"Email: {customer.Email}");
        Console.WriteLine();
    }

}