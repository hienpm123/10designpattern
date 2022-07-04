using _10DesignPattern.Models;

namespace _10DesignPattern.Services
{
    public interface IRankService
    {
        List<Ranks> Search(string keyword);
        Ranks Create(Ranks model);
    }
}
