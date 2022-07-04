namespace _10DesignPattern.Models
{
    public class Ranks
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int PowerRequired { get; set; }
        public string Note { get; set; }
        public bool DelFlg { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
