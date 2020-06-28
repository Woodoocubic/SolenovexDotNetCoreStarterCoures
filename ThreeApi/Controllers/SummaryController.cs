using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThreeApi.Repositories;

namespace ThreeApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class SummaryController:ControllerBase
    {
        private readonly ISummaryRepository _summaryRepository;

        public SummaryController(ISummaryRepository summaryRepository)
        {
            _summaryRepository = summaryRepository;
        }

        public async Task<IActionResult> Get()
        {
            var result = await _summaryRepository.GetCompanySummary();
            return Ok(result);
        }
    }
}
