namespace Aqar.Models
{
    public class RealStateImage
    {
        public int Id { get; set; }

        public string ImageUrl  { get; set; }

        public RealState RealState { get; set; }
    }
}
