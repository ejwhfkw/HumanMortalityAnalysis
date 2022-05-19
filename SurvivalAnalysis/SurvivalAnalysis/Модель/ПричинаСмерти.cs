using System;

namespace SurvivalAnalysis
{
    public class ПричинаСмерти
    {
        public int Код { get; }
        public string Наименование { get; }

        public ПричинаСмерти(string[] данные)
        {
            Код = Convert.ToInt32(данные[0]);
            Наименование = данные[1];
        }
    }
}
