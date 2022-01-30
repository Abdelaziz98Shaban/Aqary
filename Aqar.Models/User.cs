using System.ComponentModel.DataAnnotations;

namespace Aqar.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "FirstName Is Required"), Display(Name = "First Name"), StringLength(50), RegularExpression(pattern: "[a-zA-Z]{3,}",
                           ErrorMessage = "name must be char only and more than 2 characters")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "LastName Is Required"), Display(Name = "Last Name"), StringLength(50), RegularExpression(pattern: "[a-zA-Z]{3,}",
                           ErrorMessage = "name must be char only and more than 2 characters")]

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email Is Required"), EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        //[DataType(DataType.Password), RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{7,15}$",
        //         ErrorMessage = " Password must be at least 8 characters, no more than 15 characters, and must include at least one upper case letter," +
        //         " one lower case letter, and one numeric digit.")]
        //public string Password { get; set; }

        [Required(ErrorMessage = "Address Is Required"), MaxLength(50)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone Is Required"), DataType(DataType.PhoneNumber), RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]

        public int Phone { get; set; }

        /* no action problem search */

        // get method for calculating fullname and display it as username
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + ", " + LastName; }
        }
    }
}
