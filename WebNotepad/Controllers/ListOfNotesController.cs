using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using WebNotepad.Models;

namespace WebNotepad.Controllers
{
    public class ListOfNotesController : Controller
    {
        SqlConnection _db;
        public IConfiguration Configuration { get; }
        public ListOfNotesController(IConfiguration configuration)
        {
            Configuration = configuration;

            _db = new SqlConnection(configuration.GetConnectionString("DefaultConnection"));
        }
        public IActionResult Index()
        {
            IEnumerable<Note> list;

            try
            {
                var query = @"select * from Notes";
                var res = _db.Query<List<Note>>(query, null);
            }
            catch
            {

            }

            //IEnumerable<Note> list = 

            return View();
        }
    }
}
