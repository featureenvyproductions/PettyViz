using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PettyVizLib;

/* Ok here's a better description now that other people might see this and want to know what it is.
 * This program will just demonstrate things essentially...
 * The real meat is in PettyVizLb, which is a framework that will make 
 * ETL easier for developers by allowing them to define a set of steps in a file
 * then have queries constructed from the basic steps.
 * My goal is to design this with basic functionality, and basic database connectivity,
 * but then make it extendable so it is simple to create one's own classes for their needs
 * instead of having to hack things and figure out how they work.
 * */
namespace PettyViz
{
    class Program
    {
        static void Main(string[] args)
        {
            //create the i/o connection objects desired
            //then pass them to the desired data transformer object
            //then run the transform
            DataTransformer t = new DataTransformer();
            Console.ReadLine();            
        }
    }
}
