using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Interfaces
{
    public interface IHunt
    {
        public string HuntTime { get; set; }
        public void Hunt();
    }
}
