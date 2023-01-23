using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ObjectSerializer
{
    public static class WriteObjectToXML
    {

        public static void SerializeToXmlFormat<T>(T objGraph, string fileName)
        {
            //Must declare type in the constructor of the XmlSerializer
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
            using (Stream fStream = new FileStream(fileName,
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
        }
    }
}
