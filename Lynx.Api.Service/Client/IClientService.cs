﻿using Lynx.Api.Models;
using Lynx.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lynx.Api.Services
{
    public interface IClientService
    {
        IQueryable<Client> Get();
        Task<Client> Get(int id);
        Task<Client> Create(ClientModel model);
        Task<Client> Update(int id, ClientModel model);
        Task Remove(int id);
    }
}
