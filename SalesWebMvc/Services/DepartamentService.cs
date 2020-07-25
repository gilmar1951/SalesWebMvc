using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartamentService
    {
        private readonly SalesWebMvcContext _context;

        public DepartamentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        /*
        Neste caso o metodo para aplicacao quando invocado ate o termino do processamento.

        public List<Departament> FindAll()
        {
            return _context.Departament.OrderBy(x => x.Name).ToList(); //ordenado via lambida por nome
        }
        */

        /*
        Neste caso o metodo executa em segundo plano permitindo que a aplicacao continui funcionando,
        Neste caso o recurso pode melhorar a performance, mas deve ser usado com cautela.      
        */
        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync(); //ordenado via lambida por nome
        }  
    }
}
