using Northwind.EntityModels;

partial class Program
{
    private static void GetCategoriesId()
    {
        using var db = new NorthwindContext();
        foreach (var category in db.Categories)
        {
            WriteLine($"{category.CategoryId}, {category.CategoryName}");
        }

    }
}
