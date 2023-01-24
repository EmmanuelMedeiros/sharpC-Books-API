using Microsoft.AspNetCore.Mvc;
using Books_API.Models;
using Books_API.Models.Interface.InterfaceImplementation;
using Books_API.Models.Interface;

namespace Books_API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class BooksController :  ControllerBase{

        private readonly ILogger<BooksController> _logger;
        private readonly IBookInterface BookImplementation;

        
        public BooksController(ILogger<BooksController> logger, IBookInterface iBookImplementation) {
            _logger = logger;
            BookImplementation = iBookImplementation;
        }


        [HttpGet]
        public IActionResult Get() {

            return Ok(BookImplementation.FindAll());
        }

        [HttpPost] 
        public IActionResult Post([FromBody] Book book) {

            if(book == null) {
                return BadRequest();
            } else {
                return Ok(BookImplementation.Create(book));
            }

        } 


        [HttpGet("{id}")]
        public IActionResult Get(int id) {

            try {
                var book = BookImplementation.FindById(id);
                return Ok(book);
            }
            catch(Exception ex) {
                throw;
            }

        }

    }
}
