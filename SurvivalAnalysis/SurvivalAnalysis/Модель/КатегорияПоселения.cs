namespace SurvivalAnalysis
{
    public class КатегорияПоселения
    {
        public string Код { get; }
        public string Наименование { get; }

        public КатегорияПоселения(string код, string наименование)
        {
            Код = код;
            Наименование = наименование;
        }
    }
}
