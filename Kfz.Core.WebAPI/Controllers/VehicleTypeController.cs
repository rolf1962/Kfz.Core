using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kfz.Core.Model;
using Kfz.Core.DataAccess;
using Kfz.Core.Contracts;

namespace Kfz.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleTypeController : ControllerBase
    {
        private ILoggerManager _logger;
        private KfzContext _context;

        public VehicleTypeController(KfzContext context, ILoggerManager logger)
        {
            _logger = logger;
            _context = context;
        }

        // GET: VehicleType
        public IEnumerable<VehicleType> Get()
        {
            return _context.VehicleType.ToList();
        }

        // GET: VehicleType/5
        [HttpGet("{id}")]
        public VehicleType Get(string id)
        {
            return _context.VehicleType.SingleOrDefault(vehicleType => vehicleType.vehicleTypeId.Equals(id));
        }

        // POST: VehicleType
        [HttpPost()]
        public void Post([FromBody] VehicleType vehicleType)
        {
        }

        // PUT: VehicleType/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] VehicleType vehicleType)
        {
        }

        // DELETE: ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
