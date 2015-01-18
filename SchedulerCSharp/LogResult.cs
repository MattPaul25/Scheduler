using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SchedulerCSharp
{
    class LogResult
    {   

        public void txtfile()
        {
            StreamWriter File = new StreamWriter ("RunScheduler.txt");
            File.Write("Hello");
            File.Close();

            
           
        }

  
    }
}
