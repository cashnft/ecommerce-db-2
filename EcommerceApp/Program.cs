using System;
using EcommerceApp.Models;

//testing the database
namespace EcommerceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                //insert sample data
                var category = new Category { Name = "Electronics" };
                db.Categories.Add(category);

              
                var product = new Product
                {
                    Name = "Laptop",
                    Price = 599.99m,
                    Category = category
                };
                db.Products.Add(product);

                //insert a product rating
                
                var productRating = new ProductRating
                {
                    Product = product,
                    Rating = 5
                };
                db.ProductRatings.Add(productRating);

                // saving the changes
                db.SaveChanges();

             
                Console.WriteLine("Data inserted successfully!");

               
                foreach (var p in db.Products)
                {
                    Console.WriteLine($"Product: {p.Name}, Price: {p.Price}, Category: {p.Category.Name}");
                }

                foreach (var r in db.ProductRatings)
                {
                    Console.WriteLine($"Product: {r.Product.Name}, Rating: {r.Rating}");
                }
            }
        }
    }
}
/*
result:
Data inserted successfully!
Product: Laptop, Price: 599,99, Category: Electronics
Product: Laptop, Rating: 5 
yay!
*/
