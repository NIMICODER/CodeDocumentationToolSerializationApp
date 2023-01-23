using ObjectContent.Model;
using System;
using System.Collections.Generic;
using System.Reflection;
using ObjectContent.CustomDocumentDescriptionAttribute;
using System.Text;
using static ObjectContent.CustomDocumentDescriptionAttribute.DocumentAttribute;

namespace ObjectContent.Application
{
    [Description("This class holds all information about implementing  the Document data.")]
    public static  class DocumentData
    {
        public readonly static StringBuilder FileInfo = new StringBuilder();
          static List<ObjectInfo> @ObjectInfo { get; set; } = new List<ObjectInfo>();

        //public static List<ObjectInfo> objectInfo { get; set; } = new List<ObjectInfo>();
        [Description("This method return the all the description and information in the assemblies illustrated by the default attribute.")]
        public static void GetDocs()
        {
            var assembly = Assembly.GetExecutingAssembly();

            Console.WriteLine($"Assembly name: {assembly.FullName}");
            Console.WriteLine();

            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                PrintTypes(type);
                PrintType(type);
                PrintMethods(type);
                PrintProperties(type);
            }

        }

        static void PrintTypes(Type type)
        {
            var Attribute = (DescriptionAttribute)type.GetCustomAttribute(typeof(DescriptionAttribute));
            if (Attribute != null && type.IsClass && type.IsEnum && type.IsInterface)
            {
                Console.WriteLine($"Class: {type.Name} || Description: {Attribute._Description} || ");
                FileInfo.AppendLine(type.Name);
                Console.WriteLine($"Class:Description: {Attribute._Description}");
                FileInfo.AppendLine(Attribute._Description);
                ObjectInfo.Add(new ObjectInfo { Name = type.Name, Description = Attribute._Description, Input = Attribute._Input, Output = Attribute._Output  });

            }
        } 
        static void PrintType(Type type)
        {

            var Attribute = (DescriptionAttribute)type.GetCustomAttribute(typeof(DescriptionAttribute));

            if (Attribute != null && type.IsClass)
            {
                Console.WriteLine($"Class: {type.Name}");
                FileInfo.AppendLine(type.Name);

                Console.WriteLine($"Description: {Attribute._Description}");
                FileInfo.AppendLine(Attribute._Description);
                @ObjectInfo.Add(new ObjectInfo { Name = type.Name, Description = Attribute._Description, Input = Attribute._Input, Output = Attribute._Output });
            }
            else if (Attribute != null && type.IsEnum)
            {
                Console.WriteLine($"Enum: {type.Name}");
                FileInfo.AppendLine(type.Name);

                Console.WriteLine($"Description: {Attribute._Description}\n");
                FileInfo.AppendLine(Attribute._Description);
                @ObjectInfo.Add(new ObjectInfo { Name = type.Name, Description = Attribute._Description, Input = Attribute._Input, Output = Attribute._Output });
            }
            else if (Attribute != null && type.IsInterface)
            {
                Console.WriteLine($"Interface: {type.Name}");
                FileInfo.AppendLine(type.Name);
                Console.WriteLine($"Description: {Attribute._Description}\n");
                FileInfo.AppendLine(Attribute._Description);
                @ObjectInfo.Add(new ObjectInfo { Name = type.Name, Description = Attribute._Description, Input = Attribute._Input, Output = Attribute._Output });

            }
        }
        static void PrintMethods(Type type)
        {
            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                var Attribute = (DescriptionAttribute)method.GetCustomAttribute(typeof(DescriptionAttribute));

                if (Attribute != null)
                {
                    Console.WriteLine($"\t Method: {method.Name}");
                    FileInfo.AppendLine(method.Name);

                    Console.WriteLine($"\t Description: {Attribute._Description}");
                   FileInfo.AppendLine(Attribute._Description);

                    if (!string.IsNullOrEmpty(Attribute._Input))
                    {
                        Console.WriteLine($"\t Input: {Attribute._Input}");
                        FileInfo.AppendLine(Attribute._Input);
                    }

                    if (!string.IsNullOrEmpty(Attribute._Output))
                    {
                        Console.WriteLine($"\t Output: {Attribute._Output}\n");
                        FileInfo.AppendLine(Attribute._Output);
                    }

                    @ObjectInfo.Add(new ObjectInfo { Name = method.Name, Description = Attribute._Description, Input = Attribute._Input, Output = Attribute._Output });
                }
            }
        }
        static void PrintProperties(Type type)
        {
            var properties = type.GetProperties();

            foreach (var property in properties)
            {
                //Gets custom attribute  to property variable. The returned attribute is then being assigned to the documentattribute variable.
                var Attribute = (DescriptionAttribute)property.GetCustomAttribute(typeof(DescriptionAttribute));

                if (Attribute != null)
                {
                    Console.WriteLine($"\t Property: {property.Name}");
                   FileInfo.AppendLine(property.Name);

                    Console.WriteLine($"\t Description: {Attribute._Description}\n");
                    FileInfo.AppendLine(Attribute._Description);
                    @ObjectInfo.Add(new ObjectInfo { Name = property.Name, Description = Attribute?._Description, Input = Attribute?._Input, Output = Attribute?._Output });
                }


            }
        }
    }
}
