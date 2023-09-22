using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.ViewModel.Products
{
    public class VM_Update_Product
    {
        public String Id{ get; set; }
        public String Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
    }
}
