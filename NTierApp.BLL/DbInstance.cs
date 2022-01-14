using NTierApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierApp.BLL
{
    public class DbInstance
    {
        private static DataContext _instance;
        public static DataContext Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataContext();
                }
                return _instance;
            }
        }
    }
}
