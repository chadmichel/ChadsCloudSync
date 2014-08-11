using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChadsCloudSyncWin
{
    public class BaseService
    {
        private Factory _factory;
        public Factory Factory
        {
            get
            {
                if (_factory == null)
                {
                    _factory = new Factory();
                }
                return _factory;
            }
        }

    }
}
