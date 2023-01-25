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
            //Serialize to Text format
            StringBuilder TextData = DocumentData.FileInfo;
            string Text = Convert.ToString(TextData) ?? "Text Input was empty.";
            string FileName = "DocumentDataInfo.txt";
            WriteObjectToTxt.SerializeToTxtFormat(Text, FileName);
            Console.WriteLine($"Object serialized Txt Format. FileName: {FileName}");



            //Serialize to Text Json File format.
            string JsonFileName = "MetaDataInfo.json";
            WriteObjectToJson.SerializeToJsonFormat(DocumentData.@ObjectInfo, JsonFileName);
            Console.WriteLine($"=> Object serialized Json Format. File name: {JsonFileName}");

            //Serialize to PDF File format.
            string PDFfileName = "MetaDataInfo.pdf";
            WriteObjectToPDF.SerializeToPdfFormat(Text, PDFfileName);
            Console.WriteLine($"Object serialized PDF Format. File name: {PDFfileName}");
        }
    }
}
