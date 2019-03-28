using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public class Dog:Animal
    {
        public override bool Fether { get; set; } = false;
        public override string Description()
        {
            return base.Description()+"This is about dogs";
        }
        public override string Feature()
        {
            return "Can Bark";
        }
        public override bool HasFeathers()
        {
            return false;
        }
    }
}
