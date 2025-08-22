using Acme.BookStore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Interfaces
{
    public interface ICategoriesAppService: ICrudAppService
        <CategoryDto, int, PagedAndSortedResultRequestDto, CreateUpdateCategoryDto>
    {
    }
}
