
using Acme.BookStore.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BookStore.Interfaces
{
    public interface IClientService
    {
        Task<IActionResult> GetListSync();
        Task<IActionResult> GetByIdAsync(Guid id);
        Task<IActionResult> CreateAsync(ClientDTO client);
        Task<IActionResult> UpdateAsync(ClientDTO client);
        Task<IActionResult> DeleteAsync(Guid id);
    }
}
