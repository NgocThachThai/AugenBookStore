using Microsoft.AspNetCore.Mvc;
using Services.IServices;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VendorDelivoriesController : ControllerBase
    {
        private readonly IVendorService _vendorService;
        public VendorDelivoriesController(IVendorService vendorService)
        {
            _vendorService = vendorService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_vendorService.GetPackagesAvailableInThisMonth());
        }

    }
}
