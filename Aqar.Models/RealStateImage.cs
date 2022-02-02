namespace Aqar.Models
{
    public class RealStateImage
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public RealStateVM RealState { get; set; }
    }
}
