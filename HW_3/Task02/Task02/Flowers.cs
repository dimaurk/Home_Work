using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Flowers
    { 
        public virtual int _Price { get; set; }
        //public int _AllPrice = 0;

        public Flowers(int Price)
        {
            _Price = Price;
        }
        //public int GetBouquetPrice(int rosePrice, int tulipPrice, int gvozdikaPrice, int dandelionPrice, int AllPrice)
        //{
        //    Rose._rosePrice = rosePrice;
        //    Tulip._tulipPrice = tulipPrice;
        //    Gvozdika._gvozdikaPrice = gvozdikaPrice;
        //    Dandelion._dandelionPrice = dandelionPrice;
        //    for (int i = 0; i < GetBouquetPrice; i++)
        //        {
        //            AllPrice += i;
        //        }
        //    return AllPrice;
        //}
    }
}
