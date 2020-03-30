using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kfz.Core.Model;
using Kfz.Core.DataAccess;
using Microsoft.Extensions.Logging;

namespace Kfz.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CostTypeController : ControllerBase
    {
        private ILogger<CostTypeController> _logger;
        private KfzContext _context;

        public CostTypeController(KfzContext context, ILogger<CostTypeController> logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: CostType
        public IEnumerable<CostType> Get()
        {
            return _context.CostType.ToList();
        }

        // GET: CostType/5
        [HttpGet("{id}")]
        public CostType Get(string id)
        {
            return _context.CostType.SingleOrDefault(costType => costType.costTypeId.Equals(id));
        }

        // POST: CostType
        [HttpPost()]
        public void Post([FromBody] CostType costType)
        {
        }

        // PUT: CostType/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CostType costType)
        {
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
