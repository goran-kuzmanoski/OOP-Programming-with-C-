using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     class Bird:Animal
    {
        public override bool Fether { get; set; } = true;
        public override string Description()
        {
            return base.Description() + "This is the birds";
        }
        public override string Feature()
        {
            return "Can fly";
        }
        public override bool HasFeathers()
        {
            return true;
        }
    }
}
