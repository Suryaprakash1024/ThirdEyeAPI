using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdEye.Entities;

namespace ThirdEye.DAL
{
    public interface IMasterDAL
    {
        public IList<Objects> GetObjects();
        public IList<string> GetPositions();
        public IList<Position> GetPositionsById(string Id);
        public bool SavePositions(List<Position> positions);

    }
}
