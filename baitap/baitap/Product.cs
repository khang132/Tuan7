using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class Product
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int code;

        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        private int gia;

        public int Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        public Product(string name, int code, int gia)
        {
            this.name = name;
            this.code = code;
            this.gia = gia;
        }

        public int getCode()
        {
            return code;
        }

        public string getName()
        {
            return Name;
        }

        public int getGia()
        {
            return Gia;
        }
    }
}
