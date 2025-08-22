using Acme.BookStore.DTOs;
using Acme.BookStore.Interfaces;
using Acme.BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Service
{
   public class CategoriesAppService :CrudAppService<Category, CategoryDto, int, PagedAndSortedResultRequestDto,CreateUpdateCategoryDto>,
                                      ICategoriesAppService
    {
        public CategoriesAppService(IRepository<Category, int> repository) : base(repository) { }
    }
}
