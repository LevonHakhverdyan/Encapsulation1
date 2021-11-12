using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    public class Custtomer
    {
        public Custtomer()
        {
            
        }
        public Custtomer (string name)
        {
            _name = name;
            _id =Guid.NewGuid();
            _balance = default;
        }
        private string _name;

        public string Name
        {
            get { return _name; }
        }

        private Guid _id;
        public Guid Id
        {
            get { return _id; }
        }

        private double _balance;

        protected double Balance
        {
            get { return _balance; }
            set { _balance = value; }
            
        }
        

    }
}
