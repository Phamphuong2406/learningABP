using Acme.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Data.DataSeeder
{
    public class CategoriesDataSeeder : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Category, int> categoriesRepository;

        public CategoriesDataSeeder(IRepository<Category, int> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }

        public Task SeedAsync(DataSeedContext context)
        {
            var categories = new List<Category>
            {
                new Category(id:1,
                    nameAr:"ddd",
                    nameEn:"sssss",
                    descriptionAr:"ffff",
                    descriptionEn:"dddd"
                    )
            };
            return this.categoriesRepository.InsertManyAsync(categories);
        }
    }
}
