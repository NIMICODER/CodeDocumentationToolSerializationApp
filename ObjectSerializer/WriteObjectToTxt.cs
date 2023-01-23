using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ObjectSerializer
{
    public static class WriteObjectToTxt
    {
        public static void SerializeToTxtFormat(string text, string fileName)
        {
            using (StreamWriter writer = File.CreateText(fileName))
            {
                writer.Write(text);
                writer.Write(writer.NewLine);
            }
        }
    }
}
