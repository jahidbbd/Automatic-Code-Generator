using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticCodeGenerator
{
    /// <summary>
    /// Automatic Code Generator
    /// Developed by: Abdullah Al-Muzahid
    /// </summary>
    /// 
    public class Entity
    {
        public string Name { get; set; }
        public List<Attribute> Attributes { get; set; }
    }
}
