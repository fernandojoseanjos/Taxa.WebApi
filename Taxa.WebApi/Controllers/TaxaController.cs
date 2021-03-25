using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Taxa.Application.UseCases;

namespace Taxa.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxaController : ControllerBase
    {
        private readonly ITaxaUseCase _taxaUseCase;

        public TaxaController(ITaxaUseCase taxaUseCase)
        {
            _taxaUseCase = taxaUseCase;
        }

        /// <summary>
        /// Get taxa de juros
        /// </summary>
        /// <returns></returns>
        [HttpGet("taxaJuros")]
        public async Task<IActionResult> Get()
        {
            var output = _taxaUseCase.Execute();
            return new JsonResult(output);
        }
    }
}
