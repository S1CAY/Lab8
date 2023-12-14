using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Task3
{
    class LaptopFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new LCD();
        }

        public override Processor CreateProcessor()
        {
            return new Exynos();
        }

        public override Camera CreateCamera()
        {
            return new SingleCamera();
        }
    }

}
