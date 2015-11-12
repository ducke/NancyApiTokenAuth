using Nancy;
using NancyApiTokenAuth.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NancyApiTokenAuth.Infrastructure.Nancy;
using System.IO;

namespace NancyApiTokenAuth.Modules
{
    public class TestModule : SecureModule
    {
        public PowerShell shell = PowerShell.Create();

        public TestModule()
        {
            StaticConfiguration.DisableErrorTraces = false;
            List<WebSchema> myDeserializedObjList = (List<WebSchema>)Newtonsoft.Json.JsonConvert.DeserializeObject((File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "webschema.json"))), typeof(List<WebSchema>));
            foreach (var result in myDeserializedObjList)
            {
                string method = (string)result.Method;  //["method"];
                string path = (string)result.Path; // ["path"];
                string script = (string)result.Script; // ["script"];

                //Console.WriteLine("{0} {1} {2}",method,path,script);

                switch (method.ToLower())
                {
                    case "get":
                        //Console.WriteLine("get it!");
                        Get[path] = _ =>
                        {
                            if (!IsAuthenticated)
                            {
                                return HttpStatusCode.Forbidden;
                            }
                            try
                            {
                                string command = @"function RouteBody {{ param($Parameters, $Request)
                                    {0}
                                }}";
                                string command2 = string.Format(command, script);
                                this.shell.Commands.AddScript(command2);
                                this.shell.Invoke();
                                this.shell.Commands.Clear();
                                this.shell.Commands.AddCommand("RouteBody").AddParameter("Parameters", _).AddParameter("Request", Request);
                                var output = string.Empty;
                                foreach (var item in this.shell.Invoke())
                                {
                                    output += item;
                                }
                                return output;
                            }
                            catch (System.Exception ex)
                            {
                                return ex.Message;
                            }
                        };
                        break;
                    case "post":
                        //Console.WriteLine("post it");
                        break;
                    default:
                        Console.WriteLine("this method is not supported!");
                        break;
                }
            }
        }
    }
}

