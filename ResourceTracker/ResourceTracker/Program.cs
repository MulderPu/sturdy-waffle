using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Resource resource1 = new Resource("W600", true, Resource.ResourceCategory.Worker);
            //resource1.Deploy();

            Resource[] myResources = new Resource[3];
            myResources[0] = new Resource("W600", true, Resource.ResourceCategory.Worker);
            myResources[1] = new Resource("D700", false, Resource.ResourceCategory.Document);
            myResources[2] = new Resource("V800", true, Resource.ResourceCategory.Vehicle);

            DeployAll(myResources);

            // prevent quit
            Console.ReadLine();
        }
        
        private static void DeployAll(Resource[] resources)
        {
            int i = 0;
            foreach (var item in resources)
            {
                Console.WriteLine("ID: {0}", item.ID);
                Console.WriteLine("Status: {0}", item.Status);
                Console.WriteLine("Category: {0}", item.Category);
                Console.WriteLine(resources[i].Deploy());
                Console.WriteLine("----------------------------------");
                i++;
            }
        }
    }

    class Resource
    {

        public enum ResourceCategory
        {
            Document,
            Worker,
            Product,
            Vehicle
        }

        private string _id;
        private bool _status;
        private ResourceCategory _category;

        public Resource(string id, bool status, ResourceCategory category)
        {
            _id = id;
            _status = status;
            _category = category;
        }

        public string ID
        {
            get
            {
                return _id;
            }
        }

        public bool Status
        {
            get
            {
                return _status;
            }
        }

        public ResourceCategory Category
        {
            get
            {
                return _category;
            }
        }

        public string Deploy()
        {
            string messages = "Resource failed to deploy";

            if (_status)
            {
                switch (_category)
                {
                    case ResourceCategory.Document:
                        messages = "Please timely update the report!";
                        break;
                    case ResourceCategory.Worker:
                        messages = "Be alert on the hours worked!";
                        break;
                    case ResourceCategory.Product:
                        messages = "Check the availability before deploy!";
                        break;
                    case ResourceCategory.Vehicle:
                        messages = "Lorry/truck deployed!";
                        break;
                    default:
                        messages = "";
                        break;
                }
            }

            return messages;
        }
    }
}
