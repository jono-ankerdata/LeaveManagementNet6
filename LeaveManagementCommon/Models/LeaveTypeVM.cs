using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Common.Models;

public class LeaveTypeVM
{
    public int Id { get; set; }
    [Display(Name = "Leave Type Name")]
    [Required]
    public string Name { get; set; }

    [Display(Name = "Default Number Of Days")]
    [Required]
    [Range(1,50, ErrorMessage = "Please Enter A Valid Number. Numbers in Range 1-50 Accepted.")]
    public int DefaultDays { get; set; }
}
