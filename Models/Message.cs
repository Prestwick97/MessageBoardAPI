using System;
using System.ComponentModel.DataAnnotations;
namespace MessageBoard.Models
{
  public class Message
  {
    public int MessageId { get; set; }
    [Required]
    [StringLength(1000, ErrorMessage = "stop")]
    public string Content { get; set; }
    [Required]
    [StringLength(25, ErrorMessage = "Don't")]
    public string Group { get; set; }
    // [DisplayFormat(DataFormatString="{0:MM/dd/yyyy}")]
    public DateTime PostDate { get; set; }
    public string UserName { get; set; }
  }
}