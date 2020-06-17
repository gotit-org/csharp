﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GotIt.BLL.Managers;
using GotIt.BLL.ViewModels;
using GotIt.Common.Enums;
using GotIt.Common.GlobalFilters;
using GotIt.Common.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GotIt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly ItemManager _manager;
        private readonly RequestAttributes _requestAttributes;

        public ItemController(RequestAttributes requestAttributes, ItemManager manager)
        {
            _requestAttributes = requestAttributes;
            _manager = manager;
        }

        [HttpGet]
        public Result<object> GetItems()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("{id}")]
        public Result<object> GetItem([FromRoute] int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Result<object> AddItem()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("{id}")]
        [Authrization(EUserType.regular)]
        public Result<bool> EditItem([FromRoute] int id, [FromBody] ItemViewModel item)
        {
            return _manager.EditItem(_requestAttributes.Id, id, item);
        }

        [HttpDelete]
        [Route("{id}")]
        [Authrization(EUserType.regular)]
        public Result<bool> DeleteItem([FromRoute] int id)
        {
            return _manager.DeleteItem(id);
        }

        [HttpPost]
        [Route("request")]
        public Result<object> ItemRequest()
        {
            throw new NotImplementedException();
        }
    }
}
