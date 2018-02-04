using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public class DriverAuth
    {
        public Authorization Auth;
        public Driver Driver;

        public DriverAuth(Authorization auth, Driver driver)
        {
            Auth = auth;
            Driver = driver;
        }
    }
}
