using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class StaffMember
    {

        private int ageValue;

        public int Age
        {
            set
            {
                if (value > 0 && value < 120)
                {
                    this.ageValue = value;
                }
            }
            get
            {
                return this.ageValue * 2;
            }
        }
        public int aim
        {
            get
            {
                return this.ageValue * 12;
            }
        }
    }
}
