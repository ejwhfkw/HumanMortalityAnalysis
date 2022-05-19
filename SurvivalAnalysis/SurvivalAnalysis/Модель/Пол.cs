namespace SurvivalAnalysis
{
    public class Пол
    {
        public string Код { get; }
        public string Наименование { get; }

        public Пол(string код, string наименование)
        {
            Код = код;
            Наименование = наименование;
        }
    }
}
