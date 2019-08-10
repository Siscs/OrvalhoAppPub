using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrvalhoApp.Application.Interfaces;

namespace OrvalhoApp.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {

        private readonly ICategoriaApp _app;

        public CategoriaController(ICategoriaApp categoriaApp)
        {
            _app = categoriaApp;
        }


        [HttpGet]
        public ActionResult Get() 
        {
            var lista = _app.ObterTodos().ToList();
            return new OkObjectResult(lista);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id) 
        {
            var categoria = _app.Obter(id).Result;

            if(categoria != null) return Ok(categoria);

            return NotFound();
        }

        [HttpPost]
        public ActionResult Post([FromBody] object obj) 
        {
            return new OkResult();
        }

        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] object obj) 
        {
            return new OkResult();
        }

        [HttpDelete("{id}") ]
        public ActionResult Delete(int id) 
        {
            return new OkResult();
        }


        
    }
}