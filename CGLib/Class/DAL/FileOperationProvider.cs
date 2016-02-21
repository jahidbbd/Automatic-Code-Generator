using MODI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;

namespace AutomaticCodeGenerator.Class.DAL
{
    /// <summary>
    /// Automatic Code Generator
    /// Developed by: Abdullah Al-Muzahid
    /// </summary>
    /// 
    internal class FileOperationProvider
    {

        internal bool createFile(string filePath, string fileName, string content)
        {
          
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }


                using (StreamWriter w = File.AppendText(filePath + "\\" + fileName))
                {
                    w.Write(content);
                    w.Flush();
                    w.Close();
                }
              
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            return true;
        }


        internal bool createProjectTemplate(string projectPath)
        {
            try
            {
                //If the template does not exist
                if (!Directory.Exists(Path.Combine(projectPath, "App_Code")))
                {
                    string templatesPath = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Templates");
                    string templateProject = Path.Combine(templatesPath, "ProjectTemplate.zip");

                    ///System.IO.Compression.ZipFile.CreateFromDirectory(startPath, zipPath);
                    System.IO.Compression.ZipFile.ExtractToDirectory(templateProject, projectPath);
                }
            }
            catch(Exception Ex)
            {
                throw Ex;
            }

            return true;

        }

        internal List<Entity> extractERDDiagram(string path, out string message)
        {
            message = string.Empty;
          

            if (string.IsNullOrEmpty(path))
            {
                message = "Must select a file";
                return null;
            }

            List<Entity> entities = new List<Entity>();

            string extension = Path.GetExtension(path);

            //Parsing From Image
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp")
            {
                Document modiDocument = new Document();
                modiDocument.Create(path);
                modiDocument.OCR(MiLANGUAGES.miLANG_ENGLISH);
                MODI.Image modiImage = (modiDocument.Images[0] as MODI.Image);
                string extractedText = modiImage.Layout.Text;
                modiDocument.Close();
                entities.Add(parseStringToEntity(extractedText));                
            }
            else if (extension == ".vdx")
            {             

                //MS VISIO XML Parsing 
                XDocument xdoc = XDocument.Load(path);
                var elements = xdoc.Elements().Elements();
                XName pageXName = XName.Get("Page", "http://schemas.microsoft.com/visio/2003/core");
                var pages = elements.Elements(pageXName);

                foreach (XElement page in pages)
                {
                    XName shapeXName = XName.Get("Shape", "http://schemas.microsoft.com/visio/2003/core");
                    var shapes = from shape in page.Elements().Elements(shapeXName)
                                 where shape.Attribute("Type").Value == "Group"
                                 select shape;

                    foreach (XElement shape in shapes)
                    {
                        try
                        {
                            Entity entity = new Entity();


                            var shapeShapes = shape.Elements();
                            List<XElement> textShapes = shapeShapes.Elements(shapeXName).ToList();

                            XName textXName = XName.Get("Text", "http://schemas.microsoft.com/visio/2003/core");
                            XName cpXName = XName.Get("Text", "http://schemas.microsoft.com/visio/2003/core");

                            string tableName = textShapes[0].Elements(textXName).SingleOrDefault().Value;
                            string columns = textShapes[1].Elements(textXName).SingleOrDefault().Value;

                            entity.Name = tableName.Replace("\n", "");
                            entity.Attributes = parseStringToAttributes(columns);
                            entities.Add(entity);
                        }
                        catch { }
                    }
                }
               
            }
            else
            {
                message = "File format invalid!";
                return null;
            }

            return entities;
        }



        private Entity parseStringToEntity(string text)
        {
            Entity entity = new Entity();

            string[] lineSeperators = { Environment.NewLine };
            string[] wordSeperator = { " " };

            string[] lines = text.Split(lineSeperators, StringSplitOptions.RemoveEmptyEntries);

            entity.Name = lines[0];

            for (int i = 1; i < lines.Count(); i++)
            {
                Attribute attr = new Attribute();

                string[] words = lines[i].Split(wordSeperator, StringSplitOptions.RemoveEmptyEntries);

                attr.Name = words[0];
                attr.Type = words[1].ToLower();

                if (words.Count() >= 3)
                {
                    attr.Size = Convert.ToInt32(words[2]);
                }

                entity.Attributes.Add(attr);
            }

            return entity;
        }


        private List<Attribute> parseStringToAttributes(string attriburesInText)
        {
            List<Attribute> attributes = new List<Attribute>();

            string[] lineSeperators = { Environment.NewLine, "\n" };
            string[] wordSeperator = { " ", "\t", "(", ")" };

            string[] lines = attriburesInText.Split(lineSeperators, StringSplitOptions.RemoveEmptyEntries);


            for (int i = 0; i < lines.Count(); i++)
            {
                try
                {
                    int fromCount = 0;

                    Attribute attr = new Attribute();

                    string[] words = lines[i].Split(wordSeperator, StringSplitOptions.RemoveEmptyEntries);

                    if (words[0].ToUpper() == "PK")
                    {
                        fromCount = 1;
                        attr.PrimaryKey = true;
                    }
                    else 
                    {
                        attr.PrimaryKey = false;
                    }

                    if (words[0].ToUpper().Contains("FK"))
                    {
                        fromCount = 1;
                    }

                    attr.Name = words[fromCount];

                    if (words.Count() >= 2)
                    {
                        attr.Type = words[fromCount + 1].ToLower();
                    }

                    if (words.Count() >= 3)
                    {
                        attr.Size = Convert.ToInt32(words[fromCount + 2]);
                    }

                    attributes.Add(attr);
                }
                catch { }
            }

            return attributes;

        }


    }
}
