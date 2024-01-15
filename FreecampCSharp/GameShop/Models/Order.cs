using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace GameShop.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Input your name")]
        [StringLength(50, MinimumLength =4)]//checks for checkout form
        [Required(ErrorMessage ="Name is too short, should be more than 4 sybmols")]
        public string name { get; set; }

        [Display(Name = "Input your last name")]
        [StringLength(50, MinimumLength = 4)]//checks for checkout form
        [Required(ErrorMessage = "Last Name is too short, should be more than 4 sybmols")]
        public string surname { get; set; }

        public string address { get; set; }

        [Display(Name = "Phone number")]
        [DataType(DataType.PhoneNumber)]
        [StringLength (9)]
        [Required(ErrorMessage ="Phone number should be 9 characters long")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(50, MinimumLength =5)]
        [Required(ErrorMessage = "Please input your email")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

     /*   [BindNever]
        [Required(AllowEmptyStrings = true)]
        public List<OrderDetail?> orderDetails { get; set; }//nullable type as it can be no order details*/

    }
}
