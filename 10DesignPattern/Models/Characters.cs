namespace _10DesignPattern.Models
{
    public class Characters
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int RankId { get; set; }
        public bool IsHero { get; set; }
        public int Power { get; set; }
        public bool DelFlg { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
