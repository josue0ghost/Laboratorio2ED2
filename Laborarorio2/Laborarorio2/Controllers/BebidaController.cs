using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Laborarorio2.Models;

namespace Laborarorio2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BebidaController : ControllerBase
    {
        bool FirstTime = true;
        // GET: api/Bebida
        [HttpGet]
        public IEnumerable<string> Get()
        {
            if (FirstTime)
            {
                Data.Instance.myTree = new Tree.Tree<Bebida>(7, "C://Users//Public//arbol.txt", new CreateObject());
                FirstTime = false;
            }
            else
            {
                Data.Instance.myTree = new Tree.Tree<Bebida>(7, "C://Users//Public//arbol.txt", new CreateObject(), 0);
            }
            return new string[] { "value1", "value2" };
        }

        // GET: api/Bebida/5
        [HttpGet("{id}", Name = "Get")]
        public Bebida Get(Bebida id)
        {
            return Data.Instance.myTree.Obtain(id);           
        }

        // POST: api/Bebida
        [HttpPost]
        public void Post([FromBody] Bebida value)
        {
            Data.Instance.myTree.Add(value);
        }

        // PUT: api/Bebida/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

