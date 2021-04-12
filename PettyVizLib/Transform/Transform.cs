using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Transform
{
    //tbr....if several renames, figure out the final result of them and have one object...
    //...maybe
    //like eventually we need to figure out a way to optimize steps, or make optimization an option 

    //a class for serializing and deserializing steps
    public abstract class TransformStep
    {
        public virtual string BuildQuerySegment()
        {
            return null;
        }
    }
}
