using CRUD_HW;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;

//using (Db db = new Db())
//{
//    await db.Products.AddRangeAsync(
//            new Product() { Title = "product_1", Description = "description_1", Price = 129.99 },
//            new Product() { Title = "product_2", Price = 139.99 },
//            new Product() { Title = "product_3", Description = "description_3", Price = 149.99 }
//        );

//    await db.SaveChangesAsync();
//}

Product? p = null;

using (Db db = new Db())
{
   p = await db.Products.FirstAsync(p => p.Title == "Title_1");
}

using (Db db = new Db())
{
    p.Title = "product_1";
    db.Products.Update(p);
    await db.SaveChangesAsync();
}

using (Db db = new Db())
{
    List<Product> products = db.Products.ToList<Product>();
    products.ForEach(p => Console.WriteLine(p));
}