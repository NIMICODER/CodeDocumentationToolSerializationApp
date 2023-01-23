using ObjectContent.Application;
using ObjectSerializer;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ObjectWriter.UI.Serializer.UI
{
    public static class SerializerApp
    {
        public static void SerializerRun()
        {
            StringBuilder TextData = DocumentData.FileInfo;
            string Text = Convert.ToString(TextData) ?? "Text Input was empty.";
            string FileName = "DocumentDataInfo.txt";
            WriteObjectToTxt.SerializeToTxtFormat(Text, FileName);
            Console.WriteLine($"Object serialized Txt Format. FileName: {FileName}");



            ////Creating a Json File.
            //string JsonFileName = "MetaDataInfo.json";
            //WriteObjectToJson.SerializeToJsonFormat(DocumentData.@ObjectInfo, JsonFileName);
            //Console.WriteLine($"=> Object serialized Json Format. File name: {JsonFileName}");

            ////Creating an XML File. 
            //string XMLFileName = "MetaDataInfo.xml";
            //WriteObjectToXML.SerializeToXmlFormat(MetaData.@ObjectInfo, XMLFileName);
            //Console.WriteLine($"=> Object serialized Xml Format. File name: {XMLFileName}");

            //Creating a PDF File.
            string PDFfileName = "MetaDataInfo.pdf";
            WriteObjectToPDF.SerializeToPdfFormat(Text, PDFfileName);
            Console.WriteLine($"Object serialized PDF Format. File name: {PDFfileName}");
        }
    }
}
