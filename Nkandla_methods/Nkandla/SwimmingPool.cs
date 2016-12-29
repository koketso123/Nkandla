using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    class SwimmingPool
    {
        private int height;
        private int width;

        public SwimmingPool()
        {

        }

        public int getHeight()
        {
            return this.height; 
        }

        public int getWidth()
        {
            return this.width;
        }

        public void setHeight(int height)
        {
            this.height = height;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }
    }
}
