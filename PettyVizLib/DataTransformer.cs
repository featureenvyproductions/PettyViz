using System;
using System.Collections.Generic;
using System.Linq;
using PettyVizLib.Connect;
using PettyVizLib.Transform;

namespace PettyVizLib
{
    //tbd....add error checking etc
    public class DataTransformer
    {
        private string _filename = null;
        private IConnection _inputConnection = null;
        private IConnection _outputConnection = null;
        private string _inputQuery = "";
        private string _outputQuery = "";

        //connections can be to a file or database just the execution and connect will be different
        public DataTransformer(IConnection inputConnection, IConnection outputConnection, string transformsFile)
        {
            _inputConnection = inputConnection;
            _outputConnection = outputConnection;
            _filename = transformsFile;
            //set stuff and do init.
            if (Init() != 0) throw new Exception("Could not initialize transformer object");
        }

        public DataTransformer()
        {
            Console.Write("init data transformer test code");
        }

        //initialize everything needed to run....So transforms and connection maybe
        protected int Init()
        {
            BuildTransform();
            //also verify connection info but we don't need to open a connection yet.
            return 0;
        }

        protected List<TransformStep> LoadTransforms()
        {
            //load the transform data
            //get a connection info object and an array of step objects.
            string data = null;

            //load and deserialize and turn into list of objects
            List<TransformStep> transforms = new List<TransformStep>();
            return transforms;
        }

        protected int BuildTransform()
        {
            //load the transforms file and create a query based on the "transforms"
            List<TransformStep> transforms = LoadTransforms();
            string _inputQuery = "";
            foreach (TransformStep t in transforms)
            {
                _inputQuery += t.BuildQuerySegment();
            }
            return 0;
        }

        protected int Connect(IConnection connection)
        {
            //connect to the database
            connection.Connect();
            return 0;
        }

        protected int Execute(string query, IConnection connection)
        {
            connection.Execute(query);
            return 0;
        }

        protected int Execute(string query, IConnection connection, out Object data)
        {
            //we should have built the query and connected during init
            //so try to run it.
            connection.Execute(query, out data);
            //tbr....don't know what to do with data yet really
            return 0;
        }

        protected void BuildOutputQuery(Object data)
        {
            //build based on connection info and data
            //we'll need to put data into VALUES rows and create a table probably.
            //tbd
        }

        protected void Close()
        {
            _inputConnection.Close();
            _outputConnection.Close();
        }

        //Makin this easy....All you have to do is run the thing.
        //when the object is constructed, you pass it your transform steps file name (or a list of transform steps)
        //and your input connect info or output info.
        //then you can run the steps with this if that goes ok.
        public int RunTransforms()
        {
            try
            {
                Object data;
                if (Connect(_inputConnection) == 0
                    && Execute(_inputQuery, _inputConnection, out data) == 0)
                {
                    if (data != null)
                    {
                        BuildOutputQuery(data);
                        return Execute(_outputQuery, _outputConnection);
                    }
                }
            }
            catch (Exception ex)
            {
                return -1;
            }

            return -1;
        }
    }
}
