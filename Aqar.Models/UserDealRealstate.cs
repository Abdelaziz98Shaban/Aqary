using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aqar.Models
{
    public class UserDealRealstate
    {
        
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public User User { get; set; }



        [ForeignKey(nameof(RealState))]
        public int RealStateId { get; set; }

        public RealState RealState { get; set; }



        [Required(ErrorMessage = "DealDate Is Required"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        //DealDate as the operation of buying or selling the realstate 
        public DateTime DealDate { get; set; }

    }
}
