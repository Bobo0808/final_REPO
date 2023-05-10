//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace ClassLibrary.Models
//{
//    public class Employee_Task
//    {
//        [Key]
//        public int ET_ID { get; set; }
//        [ForeignKey("Employee")]
//        public int? E_ID { get; set; }
//        public Employee? Employee { get; set; }
//        [ForeignKey("DebugLog")]
//        public int D_ID { get; set; } = default;
//        public virtual DebugLog DebugLog { get; set; } = default!; 
//    }
//}
