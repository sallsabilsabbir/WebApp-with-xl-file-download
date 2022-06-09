using Fingers10.ExcelExport.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Category
    {
        [IncludeInReport(Order =1)]
        [Key]
        public int Id { get; set; }
        [IncludeInReport(Order = 2)]
        [Required]
        public string Name { get; set; }
        [IncludeInReport(Order = 3)]
        [DisplayName("Display Order")]
        [Range(1, 500, ErrorMessage = "Display Order must be between 1 and 500 only!!")]
        public int DisplayOrder { get; set; }
        [IncludeInReport(Order = 4)]
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
