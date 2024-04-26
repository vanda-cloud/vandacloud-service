using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAD.CoreService.Service.Demo
{
    public interface IDemoService
    {
        /// <summary>
        /// Display welcome message just for the purpose of demo to the team
        /// </summary>
        /// <returns>Welcome message string</returns>
        string Welcome();
    }
}
