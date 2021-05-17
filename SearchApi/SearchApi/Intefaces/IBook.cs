using RestSharp;
using SearchApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchApi.Intefaces
{
    public interface IBook
    {
        Task<List<Book>> SearchBookByTitle(string param);
        Task<Book> SearchBookById(string bookId);
    }
}
