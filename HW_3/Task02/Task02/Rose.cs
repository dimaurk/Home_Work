using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Rose : Flowers
    {
        public string _name;
        public static int _rosePrice;

        public Rose(int Price, string name):base(Price)
        {
            _name = name;
        }

        public override int _Price
        {
            get { return _rosePrice; }
            set { _rosePrice = value; }
        }

        public override string ToString()
        {
            return string.Format("{0} руб. - {1}", _Price, _name, base.ToString());
        }
    }
}
