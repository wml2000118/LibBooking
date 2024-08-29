
namespace LibBooking.Models
{
    public class EmailValidationViewModel
    {
        public string Room { get; set; }
        public int ID { get; set; }  // 修改为ID，匹配数据库字段
        public int Time { get; set; }
        public DateTime Date { get; set; }
        public string Email { get; set; }
        public string LibrarianName { get; set; }  // 新增的属性
        public string LibrarianEmail { get; set; }  // 新增的属性
    }

}
