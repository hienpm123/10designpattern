using _10DesignPattern.Models;

namespace _10DesignPattern.Services
{
    public class RankService : IRankService
    {
        private HeroDBContext heroContext;

        public RankService(HeroDBContext dBContext)
        {
            this.heroContext = dBContext;
        }
        public List<Ranks> Search(string keyword)
        {
            return heroContext.Ranks.Where(s => !s.DelFlg && s.Name.Contains(keyword)).ToList();
        }
        public Ranks Create(Ranks model)
        {
            try
            {
                //check name unique
                var dataCheck = heroContext.Ranks.Where(s => s.Name == model.Name).ToList();
                if (dataCheck.Count > 0)
                {
                    throw new Exception("Duplicate name");
                }
                var nextId = 0;
                if (heroContext.Ranks.Any())
                    nextId = heroContext.Ranks.Max(s => s.Id);

                model.Id = nextId + 1;
                model.DelFlg = false;

                var result = heroContext.Ranks.Add(model);
                heroContext.SaveChanges();
                return result.Entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
