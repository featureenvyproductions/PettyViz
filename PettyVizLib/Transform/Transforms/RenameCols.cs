using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PettyVizLib.Transform.Transforms
{
    //class representing the rename columns step
    public class RenameCols : TransformStep
    {
        Dictionary<string, string> cols = new Dictionary<string, string>();
        string clause = "";

        //note: indexes should be the same for renaming
        //tbr because i may have rename pairs in this step
        //which would take out the need for columns
        public RenameCols(string[] newColNames, string[] oldColNames)
        {
            if (newColNames.Length != oldColNames.Length) ;//eventually throw an error AND return.
                                                           //add the columns along with their new names
            for (int i = 0; i < oldColNames.Length; i++)
            {
                cols.Add(oldColNames[i], newColNames[i]);
            }
        }

        public override string BuildQuerySegment()
        {
            string renameCols = " " + clause;

            //add each name to the clause
            foreach (KeyValuePair<string, string> p in cols)
            {
                string segment = " " + p.Key + " as " + p.Value;

                //add a comma except for the last entry
                if (cols.Last().Key != p.Key)
                {
                    segment += ", ";
                }

                renameCols += segment;
            }

            return renameCols;
        }

        //tbr....need a method to consoidate/collapse rename steps where possible
    }
}
