using Microsoft.AspNetCore.Mvc;
using Services.Dtos;
using Services.IServices;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }
        [HttpPost]
        public IActionResult BuyBook([FromBody] DeliveryInforDto deliveryInfor)
        {
            return Ok(_bookService.BuyBook(deliveryInfor));
        }
    }
}