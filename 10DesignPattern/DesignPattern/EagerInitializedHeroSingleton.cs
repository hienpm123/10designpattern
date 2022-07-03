namespace _10DesignPattern.DesignPattern
{
    public class EagerInitializedHeroSingleton
    {
        private static EagerInitializedHeroSingleton INSTANCE = new EagerInitializedHeroSingleton();
        private EagerInitializedHeroSingleton()
        {
            Name = "Saitama";
            Power = 9999999;
        }
        public static EagerInitializedHeroSingleton getInstance()
        {
            return INSTANCE;
        }

        public string Name { get; }
        public int Power { get; }
    }
}
