using ProductTypes;
using Products;
using System.Collections.Generic;

//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.
List<Product> products = new()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 54.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "French Horn",
        Price = 279.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Trombone",
        Price = 189.99M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "A Brave and Startling Truth",
        Price = 14.99M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Song of Myself",
        Price = 12.99M,
        ProductTypeId = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List.
List<ProductType> productTypes = new()
{
    new ProductType()
    {
        Name = "Brass Instrument",
        Id = 1
    },
    new ProductType()
    {
        Name = "Poetry Book",
        Id = 2
    }
};

//put your greeting here
string welcome = "\n\t\t\tWelcome to Brass and Poem\n\tThe only place to find the best poetry and brass instruments";

Console.WriteLine(welcome);
DisplayMenu();


//implement your loop here
void DisplayMenu()
{
    Console.WriteLine("\nPlease choose an option:");

    string choice = null;
    while (choice != "5")
    {
        Console.WriteLine("1. Display all products");
        Console.WriteLine("2. Delete a product");
        Console.WriteLine("3. Add a new product");
        Console.WriteLine("4. Update product properties");
        Console.WriteLine("5. Exit");

        choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Clear();
                ReturnMessage();
                Console.Clear();
                break;

            case "2":
                Console.Clear();
                ReturnMessage();
                Console.Clear();
                break;

            case "3":
                Console.Clear();
                ReturnMessage();
                Console.Clear();
                break;

            case "4":
                Console.Clear();
                ReturnMessage();
                Console.Clear();
                break;

            case "5":
                Console.Clear();
                Console.WriteLine("\nHave a great day!\n\n");
                break;

            default:
                Console.Clear();
                Console.WriteLine("\nInvalid choice. Please, input a number from the list.\n");
                break;
        }
    }
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void ReturnMessage()
{
    string returnMessage = "\nPress any key to go back to the Main Menu...";
    Console.WriteLine(returnMessage);
    Console.ReadKey();
}

// don't move or change this!
public partial class Program { }