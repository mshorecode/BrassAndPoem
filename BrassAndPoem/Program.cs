using ProductTypes;
using Products;

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
        Title = "Brass Instrument",
        Id = 1
    },
    new ProductType()
    {
        Title = "Poetry Book",
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
                DisplayAllProducts(products, productTypes);
                ReturnMessage();
                Console.Clear();
                break;

            case "2":
                Console.Clear();
                DeleteProduct(products, productTypes);
                ReturnMessage();
                Console.Clear();
                break;

            case "3":
                Console.Clear();
                AddProduct(products, productTypes);
                ReturnMessage();
                Console.Clear();
                break;

            case "4":
                Console.Clear();
                UpdateProduct(products, productTypes);
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
    for (int i = 0; i < products.Count; i++)
    {
        string title = productTypes.First(p => p.Id == products[i].ProductTypeId).Title;
        
        Console.WriteLine($"{i}. {products[i].Name} Price: {products[i].Price:C} Type: {title}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    bool readResult = false;
    Console.WriteLine($"Please choose a product to delete (0-{products.Count - 1}):\n");
    DisplayAllProducts(products, productTypes);

    while (!readResult)
    {
        readResult = int.TryParse(Console.ReadLine(), out int choice);
        if (readResult && choice >= 0 && choice < products.Count)
        {
            products.RemoveAt(choice);

            Console.WriteLine($"Product Removed");
        }
        else
        {
            Console.WriteLine($"You entered and invalid option. Please try again using 0-{products.Count - 1}.");
        }
    }    
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    bool readResult = false;
    string name = null;    
    decimal price = 0M;
    int productTypeId = 0;
    

    while (!readResult)
    {
        Console.WriteLine("Please enter a name for the product:");
        name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Input cannot be blank. Please try again\n");
        }
        else
        {
            readResult = true;
        }
    }
    
    readResult = false;
    while(!readResult)
    {
        Console.WriteLine("\nPlease enter a price for the product:");
        readResult = decimal.TryParse(Console.ReadLine(), out price);
        if (!readResult)
        {
            Console.WriteLine("\nPlease only input numbers.");
        }
    }

    readResult = false;
    while(!readResult)
    {
        Console.WriteLine("\nPlease choose a product type: ");
        for (int i = 0; i < productTypes.Count; i++)
        {
            Console.WriteLine($"{productTypes[i].Id}. {productTypes[i].Title}");
        }
        readResult = int.TryParse(Console.ReadLine(), out productTypeId);
        if (!readResult)
        {
            Console.WriteLine($"\nPlease select only the numbers listed");
        }
    }

    Product newProduct = new()
    {
        Name = name,
        Price = price,
        ProductTypeId = productTypeId
    };

    products.Add(newProduct);

    Console.WriteLine($"{name} has been added");
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    bool readResult = false;
    
    Console.WriteLine($"Please enter the number of the product you would like to update (1-{products.Count}):");
    DisplayAllProducts(products, productTypes);

    while (!readResult)
    {
        string updatedName = null;
        decimal updatedPrice = 0M;
        int updatedProductTypeId = 0;

        readResult = int.TryParse(Console.ReadLine(), out int choice);
        if (readResult && choice >= 0 && choice < products.Count)
        {
            do
            {    
                Product productUpdate = products[choice];

                Console.WriteLine("Please enter updated product name:\n");
                updatedName = Console.ReadLine();
                if (!string.IsNullOrEmpty(updatedName))
                {
                    productUpdate.Name = updatedName;
                }

                Console.WriteLine("Please enter updated product price:\n");
                string price = Console.ReadLine();
                if (!string.IsNullOrEmpty(price))
                {
                    if (decimal.TryParse(price, out updatedPrice))
                    {
                        productUpdate.Price = updatedPrice;
                    }
                }

                Console.WriteLine("\nPlease choose updated product type: ");
                for (int i = 0; i < productTypes.Count; i++)
                {
                    Console.WriteLine($"{productTypes[i].Id}. {productTypes[i].Title}");
                }
                string productTypeId = Console.ReadLine();
                if (!string.IsNullOrEmpty(productTypeId))
                {
                    if(int.TryParse(productTypeId, out updatedProductTypeId))
                    {
                        productUpdate.ProductTypeId = updatedProductTypeId;
                    }
                }

                Console.WriteLine("Product details updated");
                readResult = true;
            }
            while(!readResult);
        }
    }

}

void ReturnMessage()
{
    string returnMessage = "\nPress any key to go back to the Main Menu...";
    Console.WriteLine(returnMessage);
    Console.ReadKey();
}

// don't move or change this!
public partial class Program { }