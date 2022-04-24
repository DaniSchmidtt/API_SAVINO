using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using API_Filmes.Models;


namespace API_Filmes.Controllers
{
    [RoutePrefix("api/filme")]

    public class FilmeController : ApiController
    {
        private static List<FilmeModel> listaFilmes = new List<FilmeModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarFilme")]
        public string CadastrarUsuario(FilmeModel filme)
        {
            listaFilmes.Add(filme);
            return "Filme cadastrado com sucesso!";
        }
        [AcceptVerbs("PUT")]
        [Route("AlterarFilme")]
        public string AlterarFilme(FilmeModel filme)
        {
            listaFilmes.Where(n => n.Id ==
            filme.Id)
            .Select(s =>
            {
                s.Name = filme.Name;
                s.Note = filme.Note;
                s.Author = filme.Author;
                s.Description = filme.Description;
                s.Genre = filme.Genre;
                return s;
            }).ToList();
            return "Filme alterado com sucesso!";
        }

    
    [AcceptVerbs("DELETE")]
    [Route("ExcluirFilme/{codigo}")]
    public string ExcluirFilme(int codigo)
    {
        FilmeModel filme = listaFilmes.Where(n => n.Id == codigo)
        .Select(n => n)
        .First();
        listaFilmes.Remove(filme);
        return "Registro excluido com sucesso!";
    }
    [AcceptVerbs("GET")]
    [Route("ConsultarFilmePorCodigo/{codigo}")]
    public FilmeModel ConsultarUsuarioPorCodigo(int codigo)
    {
        FilmeModel filme = listaFilmes.Where(n => n.Id == codigo)
        .Select(n => n)
        .FirstOrDefault();
        return filme;
    }
    [AcceptVerbs("GET")]
    [Route("ConsultarFilmes")]
    public List<FilmeModel> ConsultarFilmes()
    {
        CarregarFilmes();
        return listaFilmes;
    }
    private void CarregarFilmes()
    {
        listaFilmes.Clear();
        listaFilmes.Add(new FilmeModel(1, "Pequena sereia","Filme da disney da ariel","Fantasia",4.2,"Disney"));
    }
}
} 