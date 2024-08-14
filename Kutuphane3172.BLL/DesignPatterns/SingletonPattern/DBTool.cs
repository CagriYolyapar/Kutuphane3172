using Kutuphane3172.DAL.ContextClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane3172.BLL.DesignPatterns.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }
        static KutuphaneContext _dbInstance;
        public static KutuphaneContext DbInstance { get
            {
                if(_dbInstance == null ) _dbInstance = new KutuphaneContext();
                return _dbInstance;
            }
        }
    }
}
