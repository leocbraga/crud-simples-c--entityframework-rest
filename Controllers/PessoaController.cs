using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace testes_crud
{
    [ApiController]
    [Route("/api/pessoas/[controller]")]
    public class PessoaController : ControllerBase{

        [HttpGet]
        [Route("/api/pessoas/")]
        public List<Models.Pessoa> obter([FromServices] PessoasContext context){

            List<Models.Pessoa> pessoas = context.Pessoas.ToList();

            return pessoas;
        }

        [HttpPost]
        [Route("/api/pessoas/")]
        public Models.Pessoa salvar([FromServices] PessoasContext context, Models.Pessoa pessoa){

            EntityEntry<Models.Pessoa> pessoaSalva = context.Pessoas.Add(pessoa);

            context.SaveChanges();


            return pessoa;

        }

        [HttpGet]
        [Route("/api/pessoas/{id:int}")]
        public Models.Pessoa obterPorId([FromServices] PessoasContext context, int id){

            Models.Pessoa pessoa = context.Pessoas.FirstOrDefault(p => p.ID == id);

            return pessoa;

        }

        [HttpDelete]
        [Route("/api/pessoas/{id:int}")]
        public void remover([FromServices] PessoasContext context, int id){
                        
            EntityEntry<Models.Pessoa> pessoa = context.Pessoas.Remove(new Models.Pessoa {ID = id});

            context.SaveChanges();
        }


    }
}