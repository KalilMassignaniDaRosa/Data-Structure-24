using HashStock;

Store store = new Store();
        
Console.WriteLine("Enter the product barcode:");
string barcode = Console.ReadLine()!;

//Verifica a string para não haver nulo
if (string.IsNullOrWhiteSpace(barcode)) {
    Console.WriteLine("Barcode cannot be empty. Please enter a valid barcode.");
    return;
}

string location = store.FindProduct(barcode);
Console.WriteLine(location);