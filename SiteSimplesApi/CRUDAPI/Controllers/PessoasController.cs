using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDAPI.Context;
using CRUDAPI.Models;

namespace CRUDAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly CrudApiContext _context;

        public PessoasController(CrudApiContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Pessoa>> GetAll()
        {
            var pessoas = _context.Pessoas.ToList();
            if (pessoas is null)
            {
                return NotFound("Pessoas Não encontradas");
            }
            return pessoas;
        }

        [HttpGet("{pessoaId}", Name = "ObterPessoa")]
        public ActionResult<Pessoa> GetPessoa(int pessoaId)
        {
            var pessoa = _context.Pessoas.FirstOrDefault(p => p.PessoaId == pessoaId);
            if (pessoa == null)
            {
                return NotFound("Pessoa não encontrada");
            }
            return pessoa;
        }

        [HttpPost]
        public ActionResult<Pessoa> Post(Pessoa pessoa)
        {
            if (pessoa is null)
            {
                return BadRequest();
            }

            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public ActionResult PutPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{pessoaId}")]
        public ActionResult DeletePessoa(int pessoaId)
        {
            var pessoa = _context.Pessoas.FirstOrDefault(p => p.PessoaId == pessoaId);
            if (pessoa is null)
            {
                return NotFound("Pessoa não enconrtada");
            }
            _context.Remove(pessoa);
            _context.SaveChanges();
            return Ok();
        }
    }
}