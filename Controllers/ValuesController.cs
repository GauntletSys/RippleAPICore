using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace RippleAPICore.Controllers
{
    public class ValuesController : Controller
    {
        private INodeServices _nodeServices;

        public ValuesController(INodeServices nodeServices)
        {
            _nodeServices = nodeServices;
        }

        public async Task<long> Add(int x = 11, int y = 31)
        {
            return await _nodeServices.InvokeAsync<long>("Scripts/Add.js", x, y);
        }

        public IActionResult exports(int x)
        {
            return View("Index");
        }

    }
}