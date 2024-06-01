using BookStore.POC.Api.Models.Books;
using BookStore.POC.Api.Services.Orchestrations;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.POC.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookOrchestrationService bookOrchestrationService;

        public BookController(IBookOrchestrationService bookOrchestrationService)
        {
            this.bookOrchestrationService = bookOrchestrationService;
        }

        [HttpPost]
        public async ValueTask<Book> PostBookAsync(Book book) =>
            await this.bookOrchestrationService.ProcessBookAsync(book);
    }
}
