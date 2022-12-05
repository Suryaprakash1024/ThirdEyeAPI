using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ThirdEye.DAL;
using ThirdEye.Entities;

namespace ThirdEye.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    [EnableCors("Cors")]
    public class MasterController : Controller
    {
        private readonly IMasterDAL _masterDal;
        public MasterController(IMasterDAL masterDAL)
        {
            this._masterDal = masterDAL;
        }
        [HttpGet(Name = "GetObjects")]
        public IList<Objects> GetObjects()
        {
            var res = _masterDal.GetObjects();
            var date = DateTime.Now;
            return res;
        }
        [HttpGet(Name = "GetPositions")]
        public IList<string> GetPositions()
        {
            var res = _masterDal.GetPositions();
            return res;
        }
        [HttpGet(Name = "GetPositionsById/{Id}")]
        public IList<Position> GetPositionsById(string Id)
        {
            var res = _masterDal.GetPositionsById(Id);
            return res;
        }
        [HttpPost(Name = "SavePositions/{positions}")]
        public bool SavePositions(string positions)
        {
            var data = JsonConvert.DeserializeObject<List<Position>>(positions);
            var res = _masterDal.SavePositions(data);
            return res;
        }
        [HttpPost(Name = "UpdatePositions/{positions}")]
        public bool UpdatePositions(string positions)
        {
            var data = JsonConvert.DeserializeObject<Position>(positions);
            var res = _masterDal.UpdatePositions(data);
            return res;
        }
    }
}
