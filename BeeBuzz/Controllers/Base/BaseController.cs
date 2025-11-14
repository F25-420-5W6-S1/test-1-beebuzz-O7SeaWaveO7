using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeeBuzz.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace BeeBuzz.Controllers.Base
{
    public class BaseController<T> : Controller
    {
        private readonly ILogger<BaseController<T>> _logger;
        private readonly IBeeBuzzGenericRepository<T> _repository; 

        public BaseController(ILogger<BaseController<T>> logger, IBeeBuzzGenericRepository<T> repository)
        {
            _logger = logger;
            _repository = repository;
        }

        // GET: GetAll
        public virtual IActionResult Index()
        {
            return View(_repository.GetAll());
        }
    }
}
