using ControllerAspDotnetCore.Models;

namespace ControllerAspDotnetCore.Repository
{
    public static class CategoryRepository
    {
        private static List<Category> _categories = new List<Category> {
            new Category{ Id=1,Name="Beverage",Description="Beverage Category"},
            new Category{ Id=2,Name="Bakery",Description="Bakery Category"},
            new Category{ Id=3,Name="Meat",Description="Meat Category"},
        };

        public static void AddCategory(Category category)
        {
            var _maxId=_categories.Max(x => x.Id);
            category.Id = _maxId+1;
            _categories.Add(category);
        
        }

        public static List<Category> GetCategories() => _categories;

        public static Category? GetCategory(int categoryId)
        { 
            var category = _categories.FirstOrDefault(x=>x.Id==categoryId);
            if (category != null)
            { 
                return new Category { Id=category.Id,Name=category.Name,Description=category.Description};
            }

            return null;
        }

        public static void UpdateCategory(int categoryId, Category category)
        {
            var categoryToUpdate = _categories.FirstOrDefault(x=>x.Id==categoryId);
            if (categoryToUpdate != null)
            { 
                categoryToUpdate.Name=category.Name;
                categoryToUpdate.Description=category.Description;  
            }
        }

        public static void DeleteCategory(int categoryId)
        {
            var cat = _categories.FirstOrDefault(x => x.Id == categoryId);
            if (cat != null)
            { 
                _categories.Remove(cat);
            }
        }
    }
}
