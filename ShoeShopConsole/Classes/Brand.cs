using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeShopConsole.Classes
{
    internal class Brand
    {
        string _name;
        DateTime _establishedDate;

        public string Name 
        { 
            get 
            { 
                return _name; 
            } 
            set 
            { 
                _name = value; 
            } 
        }
        public int EstablishedDate
        {
            get
            {
                return _establishedDate.Year;
            }
            set
            {
                _establishedDate = new DateTime(value < 0 ? 0 : value > DateTime.Now.Year ? DateTime.Now.Year : value, 01, 01);
            }
        }
        public Brand(string name,int establishedDate)
        {
            _name = name;
            EstablishedDate = establishedDate;
        }
        public Brand(string name,DateTime establishedDate)
        {
            _name = name;
            _establishedDate = establishedDate;
        }
    }
}
