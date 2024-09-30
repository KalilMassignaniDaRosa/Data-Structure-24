using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashStock
{
    public class Product
    {
    public string? Name { get; set; } 
    public string? Barcode { get; set; } 
    public string? Location { get; set; }

    //Variavel estatica para incrementar o codigo de barras
    private static int _nextBarcode = 1;

    public Product(string name, string location)
    {
        Name = name;
        //Convete para string com 3 casas
        //Exemplo: 1 = 001
        Barcode = _nextBarcode.ToString("D3"); 
        Location = location;
        //Incrementa para o proximo codigo de barras
        _nextBarcode++; 
    }

    public Product(){
        Barcode = _nextBarcode.ToString("D3"); 
        _nextBarcode++; 
    }
    }
}