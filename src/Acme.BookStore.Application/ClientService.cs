using Acme.BookStore.DTOs;
using Acme.BookStore.Interfaces;
using Acme.BookStore.Models;
using Acme.BookStore.Permissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    public class ClientService : ApplicationService, IClientService, ITransientDependency
    {
        private readonly IRepository<Client, Guid> _clientrepository;
        public ClientService(IRepository<Client, Guid> clientrepository)
        {
            _clientrepository = clientrepository;
        }

        public async Task<IActionResult> CreateAsync(ClientDTO client)
        {
            try
            {
                var clientMappedObject = ObjectMapper.Map<ClientDTO, Client>(client);
                var clientObject = await this._clientrepository.InsertAsync(clientMappedObject);
                return new OkObjectResult(clientObject);
            }
            catch (Exception ex)
            {
                return new BadRequestResult();
            }
        }

        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            await this._clientrepository.DeleteAsync(id);
            return new OkResult();
        }

        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var clientObj = await this._clientrepository.GetAsync(id);
            return new ObjectResult(clientObj);
        }
        [Authorize(BookStorePermissions.Todo.Default)]
        public async Task<IActionResult> GetListAsync()
        {
            var clientList = await this._clientrepository.GetListAsync();
            return new ObjectResult(clientList);
        }

        public async Task<IActionResult> UpdateAsync(ClientDTO client)
        {
            try
            {
                var clientObject = await this._clientrepository.FindAsync(client.Id);
                if (clientObject != null)
                {
                    ObjectMapper.Map<ClientDTO, Client>(client, clientObject);
                    var clientReturnedObject = await this._clientrepository.UpdateAsync(clientObject);

                    return new OkObjectResult(clientReturnedObject);
                }
                else
                {
                    return new BadRequestResult();
                }
            }
           
            catch (Exception ex)
                {

                    return new BadRequestResult();
                }
        }
    }
}
