using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using primeira_webapi.Context;
using primeira_webapi.Entities;

namespace primeira_webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;

        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpPost] //Cria um novo registro na tabela contato
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato); //Adiciona o novo registro dentro do contexto
            _context.SaveChanges(); //Salva as mudanças
            return Ok(contato); //Se der tudo certo, retorna o contato
        }

        [HttpPut("{id}")] //Atualiza um novo registro pelo id
        public IActionResult Update(int id, Contato contato)
        {
            var contatoUpdate = _context.Contatos.Find(id); //Faz a procura dentro da tabela

            if(contatoUpdate == null)
            {
                return NotFound(); //Caso não exista, retorna NotFound
            }

            contatoUpdate.Nome = contato.Nome;
            contatoUpdate.Telefone = contato.Telefone;
            contatoUpdate.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoUpdate); //Atualiza tabela
            _context.SaveChanges();

            return Ok(contato);
            
        }

        [HttpGet("{id}")] //Procura um registro de acordo com o id
        public IActionResult SelectById(int id)
        {
            var contato = _context.Contatos.Find(id);
            
            if(contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }

        [HttpGet("FindByName")] //Procura um registro pelo nome
        public IActionResult SelectByName(string nome)
        {
            var contatos = _context.Contatos.Where(x => x.Nome.Contains(nome));
            return Ok(contatos);
        }

        [HttpGet("FindByState")] //Procura um registro pelo estado (false/true)
        public IActionResult SelectByState(bool ativo)
        {
            var contatos = _context.Contatos.Where(x => x.Ativo == ativo);
            return Ok(contatos);
        }

        [HttpDelete("{id}")] //Deleta um registro pelo id
        public IActionResult DeleteById(int id)
        {
            var contato = _context.Contatos.Find(id);

            if(contato == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contato); //Remove o contato
            _context.SaveChanges();

            return Ok($"Objeto de id {id} removido.");
        }
    }
}