using ObjectContent.Application;
using ObjectSerializer;
using ObjectContent;
using ObjectWriter;
using System.Text;
using ObjectWriter.UI.Serializer.UI;

namespace ObjectWriter.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DocumentData.GetDocs();
            SerializerApp.SerializerRun();


        }
    }
}