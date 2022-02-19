using System.ComponentModel.DataAnnotations;

namespace InspectionAPI.Model
{
    public class Status
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string StatusOptions { get; set; } =string.Empty;
    }
}
