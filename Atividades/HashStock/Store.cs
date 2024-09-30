using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HashStock
{
    public class Store
    {
        //Criando dicionario de chave string e valor Produto
        //Por ser privado usar _
        private Dictionary<string, Product> _products; 

        public Store()
        {
            _products = new Dictionary<string, Product>();
            LoadProducts(); 
        }

        private void LoadProducts()
        {
            //135 products in total

            //A1
            AddProduct(new Product(){
                Name = "Apple",
                Location = "A1"
            });
            AddProduct(new Product(){
                Name = "Orange",
                Location = "A1"
            });
            AddProduct(new Product(){
                Name = "Banana",
                Location = "A1"
            });
            AddProduct(new Product(){
                Name = "Grape",
                Location = "A1"
            });
            AddProduct(new Product(){
                Name = "Lemon",
                Location = "A1"
            });

            //A2
            AddProduct(new Product(){
                Name = "Milk",
                Location = "A2"
            });
            AddProduct(new Product(){
                Name = "Cheese",
                Location = "A2"
            });
            AddProduct(new Product(){
                Name = "Yogurt",
                Location = "A2"
            });
            AddProduct(new Product(){
                Name = "Butter",
                Location = "A2"
            });
            AddProduct(new Product(){
                Name = "Eggs",
                Location = "A2"
            });

            //A3
            AddProduct(new Product(){
                Name = "Chicken",
                Location = "A3"
            });
            AddProduct(new Product(){
                Name = "Beef",
                Location = "A3"
            });
            AddProduct(new Product(){
                Name = "Ground meat",
                Location = "A3"
            });
            AddProduct(new Product(){
                Name = "Fish",
                Location = "A3"
            });
            AddProduct(new Product(){
                Name = "Bacon",
                Location = "A3"
            });

            //A4
            AddProduct(new Product(){
                Name = "Rice",
                Location = "A4"
            });
            AddProduct(new Product(){
                Name = "Beans",
                Location = "A4"
            });
            AddProduct(new Product(){
                Name = "Lentils",
                Location = "A4"
            });
            AddProduct(new Product(){
                Name = "Oats", //Aveia
                Location = "A4"
            });
            AddProduct(new Product(){
                Name = "Quinoa",
                Location = "A4"
            });

            //A5
            AddProduct(new Product(){
                Name = "Mineral water",
                Location = "A5"
            });
            AddProduct(new Product(){
                Name = "Soft drinks", //Refrigerante 
                Location = "A5"
            });
            AddProduct(new Product(){
                Name = "Juices",
                Location = "A5"
            });
            AddProduct(new Product(){
                Name = "Beer",
                Location = "A5"
            });
            AddProduct(new Product(){
                Name = "Energy Drink",
                Location = "A5"
            });

            //A6
            AddProduct(new Product(){
                Name = "Dish soap", //Sabão para louça
                Location = "A6"
            });
            AddProduct(new Product(){
                Name = "Laundry detergent",
                Location = "A6"
            });
            AddProduct(new Product(){
                Name = "Disinfectant",
                Location = "A6"
            });
            AddProduct(new Product(){
                Name = "Surface cleaner",
                Location = "A6"
            });
            AddProduct(new Product(){
                Name = "Sponges",
                Location = "A6"
            });

            //A7
            AddProduct(new Product(){
                Name = "Soap",
                Location = "A7"
            });
            AddProduct(new Product(){
                Name = "Shampoo",
                Location = "A7"
            });
            AddProduct(new Product(){
                Name = "Toothpaste",
                Location = "A7"
            });
            AddProduct(new Product(){
                Name = "Deodorant",
                Location = "A7"
            });
            AddProduct(new Product(){
                Name = "Toilet paper",
                Location = "A7"
            });

            //A8
            AddProduct(new Product(){
                Name = "Potato chips",
                Location = "A8"
            });
            AddProduct(new Product(){
                Name = "Chocolates",
                Location = "A8"
            });
            AddProduct(new Product(){
                Name = "Cookies",
                Location = "A8"
            });
            AddProduct(new Product(){
                Name = "Nuts",
                Location = "A8"
            });
            AddProduct(new Product(){
                Name = "Granola bars",
                Location = "A8"
            });

            //A9
            AddProduct(new Product(){
                Name = "Ice cream",
                Location = "A9"
            });
            AddProduct(new Product(){
                Name = "Frozen vegetables",
                Location = "A9"
            });
            AddProduct(new Product(){
                Name = "Frozen pizzas",
                Location = "A9"
            });
            AddProduct(new Product(){
                Name = "Frozen meals",
                Location = "A9"
            });
            AddProduct(new Product(){
                Name = "Frozen fruits",
                Location = "A9"
            });

            //B1
            AddProduct(new Product(){
                Name = "Bread",
                Location = "B1"
            });
            AddProduct(new Product(){
                Name = "Biscuits",
                Location = "B1"
            });
            AddProduct(new Product(){
                Name = "Cakes",
                Location = "B1"
            });
            AddProduct(new Product(){
                Name = "Bagels",
                Location = "B1"
            });
            AddProduct(new Product(){
                Name = "Muffins",
                Location = "B1"
            });

            //B2
            AddProduct(new Product(){
                Name = "Salt",
                Location = "B2"
            });
            AddProduct(new Product(){
                Name = "Pepper",
                Location = "B2"
            });
            AddProduct(new Product(){
                Name = "Olive oil",
                Location = "B2"
            });
            AddProduct(new Product(){
                Name = "Ketchup",
                Location = "B2"
            });
            AddProduct(new Product(){
                Name = "Mustard",
                Location = "B2"
            });

            //B3
            AddProduct(new Product(){
                Name = "Whole grains", //Grãos Integrais
                Location = "B3"
            });
            AddProduct(new Product(){
                Name = "Dried fruits",
                Location = "B3"
            });
            AddProduct(new Product(){
                Name = "Nuts",
                Location = "B3"
            });
            AddProduct(new Product(){
                Name = "Organic snacks",
                Location = "B3"
            });
            AddProduct(new Product(){
                Name = "Honey",
                Location = "B3"
            });

            //B4
            AddProduct(new Product(){
                Name = "Canned soups",
                Location = "B4"
            });
            AddProduct(new Product(){
                Name = "Frozen dinners",
                Location = "B4"
            });
            AddProduct(new Product(){
                Name = "Pasta sauces",
                Location = "B4"
            });
            AddProduct(new Product(){
                Name = "Salad dressings", //Molhos para salada
                Location = "B4"
            });
            AddProduct(new Product(){
                Name = "Ready-to-eat meals",
                Location = "B4"
            });

            //B5
            AddProduct(new Product(){
                Name = "Coffee",
                Location = "B5"
            });
            AddProduct(new Product(){
                Name = "Tea",
                Location = "B5"
            });
            AddProduct(new Product(){
                Name = "Hot chocolate",
                Location = "B5"
            });
            AddProduct(new Product(){
                Name = "Herbal tea",
                Location = "B5"
            });
            AddProduct(new Product(){
                Name = "Instant coffee",
                Location = "B5"
            });

            //B6
            AddProduct(new Product(){
                Name = "Diapers", //Fraudas
                Location = "B6"
            });
            AddProduct(new Product(){
                Name = "Baby formula",
                Location = "B6"
            });
            AddProduct(new Product(){
                Name = "Baby food",
                Location = "B6"
            });
            AddProduct(new Product(){
                Name = "Wipes",
                Location = "B6"
            });
            AddProduct(new Product(){
                Name = "Bottles",
                Location = "B6"
            });

            //B7
            AddProduct(new Product(){
                Name = "Dog food",
                Location = "B7"
            });
            AddProduct(new Product(){
                Name = "Cat food",
                Location = "B7"
            });
            AddProduct(new Product(){
                Name = "Pet treats", //Petisco de animais
                Location = "B7"
            });
            AddProduct(new Product(){
                Name = "Birdseed", //Alpiste
                Location = "B7"
            });
            AddProduct(new Product(){
                Name = "Cat litter", //Areia para gatos
                Location = "B7"
            });

            //B8
            AddProduct(new Product(){
                Name = "Pots",
                Location = "B8"
            });
            AddProduct(new Product(){
                Name = "Cutlery", //Talheres
                Location = "B8"
            });
            AddProduct(new Product(){
                Name = "Glassware", //Artigos de vidro
                Location = "B8"
            });
            AddProduct(new Product(){
                Name = "Baking sheets", //Assadeiras
                Location = "B8"
            });
            AddProduct(new Product(){
                Name = "Mixing bowls",
                Location = "B8"
            });

            //B9
            AddProduct(new Product(){
                Name = "Discounted items",
                Location = "B9"
            });
            AddProduct(new Product(){
                Name = "Seasonal products",
                Location = "B9"
            });
            AddProduct(new Product(){
                Name = "Special deals",
                Location = "B9"
            });
            AddProduct(new Product(){
                Name = "Bulk items", //Itens em massa, coisas pesadas
                Location = "B9"
            });
            AddProduct(new Product(){
                Name = "Clearance items", //Itens de liquidação
                Location = "B9"
            });

            //C1
            AddProduct(new Product(){
                Name = "Supplements",
                Location = "C1"
            });
            AddProduct(new Product(){
                Name = "Vitamins",
                Location = "C1"
            });
            AddProduct(new Product(){
                Name = "Protein powder",
                Location = "C1"
            });
            AddProduct(new Product(){
                Name = "Herbal remedies",
                Location = "C1"
            });
            AddProduct(new Product(){
                Name = "First aid supplies",
                Location = "C1"
            });

            //C2
            AddProduct(new Product(){
                Name = "Pain relievers", //Analgésico
                Location = "C2"
            });
            AddProduct(new Product(){
                Name = "Cold medicine",
                Location = "C2"
            });
            AddProduct(new Product(){
                Name = "Allergy medication",
                Location = "C2"
            });
            AddProduct(new Product(){
                Name = "Band-aids",
                Location = "C2"
            });
            AddProduct(new Product(){
                Name = "Thermometers",
                Location = "C2"
            });

            //C3
            AddProduct(new Product(){
                Name = "Makeup",
                Location = "C3"
            });
            AddProduct(new Product(){
                Name = "Perfumes",
                Location = "C3"
            });
            AddProduct(new Product(){
                Name = "Skincare products",
                Location = "C3"
            });
            AddProduct(new Product(){
                Name = "Hair products",
                Location = "C3"
            });
            AddProduct(new Product(){
                Name = "Nail polish", //Esmalte
                Location = "C3"
            });

            //C4
            AddProduct(new Product(){
                Name = "Small kitchen appliances",
                Location = "C4"
            });
            AddProduct(new Product(){
                Name = "Vacuum cleaners",
                Location = "C4"
            });
            AddProduct(new Product(){
                Name = "Coffee makers",
                Location = "C4"
            });
            AddProduct(new Product(){
                Name = "Toasters",
                Location = "C4"
            });
            AddProduct(new Product(){
                Name = "Blenders",
                Location = "C4"
            });

            //C5
            AddProduct(new Product(){
                Name = "Children’s toys",
                Location = "C5"
            });
            AddProduct(new Product(){
                Name = "Board games",
                Location = "C5"
            });
            AddProduct(new Product(){
                Name = "Puzzles",
                Location = "C5"
            });
            AddProduct(new Product(){
                Name = "Action figures",
                Location = "C5"
            });
            AddProduct(new Product(){
                Name = "Dolls",
                Location = "C5"
            });

            //C6
            AddProduct(new Product(){
                Name = "Notebooks",
                Location = "C6"
            });
            AddProduct(new Product(){
                Name = "Pens and pencils",
                Location = "C6"
            });
            AddProduct(new Product(){
                Name = "Binders", //Fichários
                Location = "C6"
            });
            AddProduct(new Product(){
                Name = "Markers",
                Location = "C6"
            });
            AddProduct(new Product(){
                Name = "Highlighters", //Espécie de marcadores
                Location = "C6"
            });

            //C7
            AddProduct(new Product(){
                Name = "Fiction books",
                Location = "C7"
            });
            AddProduct(new Product(){
                Name = "Non-fiction books",
                Location = "C7"
            });
            AddProduct(new Product(){
                Name = "Cookbooks",
                Location = "C7"
            });
            AddProduct(new Product(){
                Name = "Magazines",
                Location = "C7"
            });
            AddProduct(new Product(){
                Name = "Children's books",
                Location = "C7"
            });

            //C8
            AddProduct(new Product(){
                Name = "Home accessories",
                Location = "C8"
            });
            AddProduct(new Product(){
                Name = "Candles",
                Location = "C8"
            });
            AddProduct(new Product(){
                Name = "Picture frames",
                Location = "C8"
            });
            AddProduct(new Product(){
                Name = "Plants",
                Location = "C8"
            });
            AddProduct(new Product(){
                Name = "Wall art",
                Location = "C8"
            });

            //C9
            AddProduct(new Product(){
                Name = "Jewelry",
                Location = "C9"
            });
            AddProduct(new Product(){
                Name = "Bags",
                Location = "C9"
            });
            AddProduct(new Product(){
                Name = "Sunglasses",
                Location = "C9"
            });
            AddProduct(new Product(){
                Name = "Scarves", //Cachecol
                Location = "C9"
            });
            AddProduct(new Product(){
                Name = "Hats",
                Location = "C9"
            });
        }

       private void AddProduct(Product product)
        {
            if (product.Barcode == null)
            {
                Console.WriteLine("Barcode cannot be null!");
                return;
            }
            if (!_products.ContainsKey(product.Barcode))
            {
                _products[product.Barcode] = product; 
            }
        }

        public string FindProduct(string barcode)
        {
            //Verifica o dicionario products pela chave pesquisada
            if (_products.ContainsKey(barcode))
            {
                //[] indica a chave
                var product = _products[barcode];
                return $"Product Name: {product.Name}\nLocation: {product.Location}"; 
            }
            else
            {
                return "Product not found!\nPlease check the barcode";
            }
        }
    }
}