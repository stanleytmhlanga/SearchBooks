using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SearchApi.Intefaces;
using SearchApi.Model;
using SearchApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.Description;

namespace SearchApi.Controllers
{
    [Route("api/[controller]")]
    public class SearchController : Controller
    {
        private IBook repository;
        public SearchController(IBook bookRepository)
        {
            this.repository = bookRepository;
        }
        // GET: api/SearchBookByTitle
        [ResponseType(typeof(IEnumerable<Book>))]
        [Route("SearchBookByTitle")]
        [HttpGet]
        public async Task<List<Book>> SearchBookByTitle(string title)
        {
            var responseFromSwevice = await repository.SearchBookByTitle(title);
            if (responseFromSwevice.Count > 0)
            {
                return responseFromSwevice;
            }
            else
            {
                return null;
            }  
        }
          
    }
}
