using DripDoodle.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text;

namespace DripDoodle.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoodleController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public DoodleController(IHttpClientFactory factory, IConfiguration config)
        {
            _httpClient = factory.CreateClient();
            _config = config;
        }

        [HttpPost("generate-doodle")]
        public async Task<IActionResult> GenerateDoodle([FromBody] DoodleRequest request)
        {
            // MOCK: Use a placeholder doodle image instead of OpenAI
            var fileName = $"mock_doodle_{DateTime.UtcNow.Ticks}.png";
            var sourceImagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Mockup", "sample-doodle.png");
            var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);

            System.IO.File.Copy(sourceImagePath, destinationPath, true);

            var localImageUrl = $"{Request.Scheme}://{Request.Host}/images/{fileName}";
            return Ok(new DoodleResponse { ImageUrl = localImageUrl });
        }

        /*This code is if you have a API Key for now we are using a place holder and trying it out*/

        //var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");

        //var response = await _httpClient.PostAsync("https://api.openai.com/v1/images/generations", content);

        //if (!response.IsSuccessStatusCode)
        //{
        //    var errorDetails = await response.Content.ReadAsStringAsync();
        //    return StatusCode((int)response.StatusCode, $"Failed to generate image: {errorDetails}");
        //}

        //var resultJson = await response.Content.ReadAsStringAsync();
        //using var doc = JsonDocument.Parse(resultJson);
        //var imageUrl = doc.RootElement.GetProperty("data")[0].GetProperty("url").GetString();

        ////NEW: Download the image from the URL and save it to wwwroot/images
        //var imageBytes = await _httpClient.GetByteArrayAsync(imageUrl);
        //var fileName = $"doodle_{DateTime.UtcNow.Ticks}.png";
        //var savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", fileName);
        //await System.IO.File.WriteAllBytesAsync(savePath, imageBytes);

        //// Return local URL (served by your ASP.NET app)
        //var localImageUrl = $"{Request.Scheme}://{Request.Host}/images/{fileName}";

        //return Ok(new DoodleResponse { ImageUrl = localImageUrl });

















    }
}
