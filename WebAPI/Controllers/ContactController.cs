using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Entities;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Contact([FromBody] ContactMe request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Dữ liệu không hợp lệ.");
            }

            //  Bạn có thể lưu vào DB, gửi email hoặc log lại ở đây.
            // Ví dụ (tạm thời):
            Console.WriteLine($"📨 Contact from {request.Name} - {request.Email}");
            Console.WriteLine($"Subject: {request.Subject}");
            Console.WriteLine($"Message: {request.Message}");

            // Trả về thành công
            return Ok(new { message = "Liên hệ đã được gửi thành công." });
        }
    }
}
