using LinqueryTakeSkipFindMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqueryTakeSkipFindMethod.SingletonPattern
{
    class DBTool
    {
        private DBTool() { }
        
        private static NorthwindEntities _dbInstance;

        public static NorthwindEntities DbInstance
        {
            get
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new NorthwindEntities();
                }
                return _dbInstance;
            }
        }
    }
}
