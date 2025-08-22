using Acme.BookStore.DTOs;
using Acme.BookStore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BookStore.Mapping
{
    public class CategoryMappingProfile: Profile
    {
        public CategoryMappingProfile() {
            CreateMap<Category, CategoryDto>();
            CreateMap<CreateUpdateCategoryDto, Category>();
        }
    }
}
