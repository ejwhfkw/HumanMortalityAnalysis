using System;

namespace SurvivalAnalysis
{
    public class Территория
    {
        public int Код { get; }
        public string Наименование { get; }

        public Территория(string[] данные)
        {
            Код = Convert.ToInt32(данные[0]);
            Наименование = данные[1];
        }
    }
}
