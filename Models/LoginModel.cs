using System.ComponentModel.DataAnnotations;

namespace WebChat.Models
{
    public class LoginModel
    {
        //用户名
        [Required(ErrorMessage="用户名不能为空")]
        public string UserName { get; set; }
        //密码
        [Required(ErrorMessage="密码不能为空")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //记住登录
        public bool RememberMe { get; set; }
    }
}
