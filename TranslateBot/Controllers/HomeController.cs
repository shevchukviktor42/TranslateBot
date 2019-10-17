using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TranslateBot.Data;
using TranslateBot.Models;
using TranslateBot.Repositories;

namespace TranslateBot.Controllers
{
    public class HomeController : Controller
    {
        private readonly LocalDbContext _context;
        private IRepository _repository;
        public List<Phrase> phrases;
        public HomeController(IRepository repository, LocalDbContext context)
        {
            _context = context;
            _repository = repository;
            phrases = _repository.GetAll().ToList();
        }
            public IActionResult Index()
        {
            return View(phrases);
        }
    }
}