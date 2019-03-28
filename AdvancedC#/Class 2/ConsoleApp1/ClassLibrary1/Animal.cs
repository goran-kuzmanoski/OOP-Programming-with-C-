using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Animal
    {
        public abstract bool Fether { get; set; }
        public virtual string Description()
        {
            return "Basic info about animals";
        }
        public abstract string Feature();
        public abstract bool HasFeathers();

         
    }
}
