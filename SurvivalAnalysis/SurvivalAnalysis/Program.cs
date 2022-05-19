using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace SurvivalAnalysis
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            АнализВыживаемости анализВыживаемости;
            try
            {
                Конфигурация конфигурация = ЗагрузитьКонфигурацию(@"Конфигурация\Конфигурация.json");
                анализВыживаемости = new АнализВыживаемости(ЗагрузитьДанные(конфигурация.ФайлСДаннымиОЧисленностиНаселенияПоОднолетнимВозрастнымГруппам),
                                                            ЗагрузитьДанные(конфигурация.ФайлСДаннымиОСмертностиПоОднолетнимВозрастнымГруппам),
                                                            ЗагрузитьДанные(конфигурация.ФайлСДаннымиОЧисленностиНаселенияПоПятилетнимВозрастнымГруппам),
                                                            ЗагрузитьДанные(конфигурация.ФайлСДаннымиОСмертностиПоПятилетнимВозрастнымГруппам),
                                                            ЗагрузитьДанные(конфигурация.ФайлСПеречнемТерриторий),
                                                            ЗагрузитьДанные(конфигурация.ФайлСПеречнемПричинСмерти));
            }
            catch (Exception)
            {
                анализВыживаемости = null;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(анализВыживаемости));
        }

        private static Конфигурация ЗагрузитьКонфигурацию(string файл)
        {
            JObject json = JObject.Parse(File.ReadAllText(файл));
            var конфигурация = json.ToObject<Конфигурация>();
            return конфигурация;
        }

        private static string[] ЗагрузитьДанные(string файл)
        {
            return File.ReadAllLines(файл);
        }
    }
}
