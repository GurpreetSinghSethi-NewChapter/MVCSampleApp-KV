using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DepartmentMetaData
    {
        [Display(Name = "Department Name")]
        public string Name { get; set; }
    }
    [MetadataType(typeof(DepartmentMetaData))]
    public partial class Department
    {
        //public string Name { get; set; }
    }
}
