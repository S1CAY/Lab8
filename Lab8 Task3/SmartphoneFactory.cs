using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Task3
{
    class SmartphoneFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new AMOLED();
        }

        public override Processor CreateProcessor()
        {
            return new Snapdragon();
        }

        public override Camera CreateCamera()
        {
            return new DualCamera();
        }
    }

}
