using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Task3
{
    class SingleCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Камера: одна основна камера");
        }
    }
}
