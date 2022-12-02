using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdEye.Entities;

namespace ThirdEye.DAL
{
    public class MasterDAL : IMasterDAL
    {
        ThirdEyeContext _db = new ThirdEyeContext();

        public MasterDAL(ThirdEyeContext db)
        {
            _db = db;
        }
        public IList<Objects> GetObjects()
        {
            var objects = _db.ObjectMasters.ToList();
            IList<Objects> result = new List<Objects>();
            foreach (var obj in objects)
            {
                Objects objects1 = new Objects();
                objects1.Id = obj.Id;
                objects1.Shape = obj.Shape;
                result.Add(objects1);
            }
            return result;
            
        }
        public IList<string> GetPositions()
        {
            var positions = _db.PositionMasters.Select(x=>x.PositionId).Distinct();
            IList<string> result = new List<string>();
            foreach (var obj in positions)
            {
                result.Add(obj);
            }
            return result;
        }
        public IList<Position> GetPositionsById(string Id)
        {
            var positions = _db.PositionMasters.Where(x => x.PositionId == Id).ToList();
            IList<Position> result = new List<Position>();
            foreach (var obj in positions)
            {
                Position objects1 = new Position();
                objects1.positionId = obj.PositionId;
                objects1.shape = obj.Shape;
                objects1.x = obj.X;
                objects1.y = obj.Y;
                result.Add(objects1);
            }
            return result;

        }
        public bool SavePositions(List<Position> positions)
        {
            _db.Database.EnsureCreated();
            var posId = DateTime.Now.ToString("yyyyMMddHHmmss");
            foreach (var position in positions)
            {
                PositionMaster positionMaster = new PositionMaster();
                if(position.positionId == "")
                {
                positionMaster.PositionId = posId;
                }
                else
                {
                    positionMaster.PositionId = position.positionId;
                }
                positionMaster.X = position.x;
                positionMaster.Y = position.y;
                positionMaster.Shape = position.shape;
                _db.PositionMasters.Add(positionMaster);
            }
            _db.SaveChanges();

            return true;
        }
    }
}
