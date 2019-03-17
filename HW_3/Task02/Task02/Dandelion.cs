using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Dandelion : Flowers
    {
        public string _name;
        public static int _dandelionPrice;

        public Dandelion(int Price, string name) : base(Price)
        {
            _name = name;
        }

        public override int _Price
        {
            get { return _dandelionPrice; }
            set { _dandelionPrice = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} руб. - {1}", _Price, _name, base.ToString());
        }
    }
}
