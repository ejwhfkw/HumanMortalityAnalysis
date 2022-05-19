using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SurvivalAnalysis
{
    public partial class MainForm : Form
    {
        private readonly АнализВыживаемости _анализВыживаемости;

        private EТипВозрастныхГрупп ТипВозрастныхГрупп;

        private int Год => (int)yearComboBox.SelectedItem;
        private Территория Территория => (Территория)territoryComboBox.SelectedItem;
        private КатегорияПоселения КатегорияПоселения => (КатегорияПоселения)settlementCategoryComboBox.SelectedItem;
        private Пол Пол => (Пол)sexComboBox.SelectedItem;
        private ПричинаСмерти ПричинаСмерти => (ПричинаСмерти)causeOfDeathComboBox.SelectedItem;
        private int ВозрастнаяГруппа => (int)ageGroupComboBox.SelectedItem;
        private string ПредположениеДляИнтерполяции => (string)hypothesisComboBox.SelectedItem;

        private bool ДобавитьГрафикиКСравнению => comparePlotsCheckBox.Checked;

        public MainForm(АнализВыживаемости анализВыживаемости)
        {
            InitializeComponent();

            if (анализВыживаемости != null)
            {
                _анализВыживаемости = анализВыживаемости;
                УстановитьИсточникиДанныхДляВыпадающихСписков();
            }
            else
            {
                Enabled = false;
                infoLabel.Text = "Не удалось загрузить входные данные. Пожалуйста, добавьте файлы с входными данными в папку \"Данные\", запишите наименования файлов в параметрах конфигурации и перезапустите программу";
            }
        }

        private void УстановитьИсточникиДанныхДляВыпадающихСписков()
        {
            yearComboBox.DataSource = _анализВыживаемости.СписокГодов;

            territoryComboBox.DataSource = _анализВыживаемости.СписокТерриторий;
            territoryComboBox.DisplayMember = "Наименование";
            territoryComboBox.ValueMember = "Наименование";

            settlementCategoryComboBox.DataSource = _анализВыживаемости.СписокКатегорийПоселения;
            settlementCategoryComboBox.DisplayMember = "Наименование";
            settlementCategoryComboBox.ValueMember = "Наименование";

            sexComboBox.DataSource = _анализВыживаемости.СписокПолов;
            sexComboBox.DisplayMember = "Наименование";
            sexComboBox.ValueMember = "Наименование";

            causeOfDeathComboBox.DataSource = _анализВыживаемости.СписокПричинСмерти;
            causeOfDeathComboBox.DisplayMember = "Наименование";
            causeOfDeathComboBox.ValueMember = "Наименование";

            hypothesisComboBox.DataSource = _анализВыживаемости.СписокПредположенийДляИнтерполяции;
        }

        private void annualAgeGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ТипВозрастныхГрупп = EТипВозрастныхГрупп.Однолетние;
            ageGroupComboBox.DataSource = _анализВыживаемости.СписокОднолетнихВозрастныхГрупп;
            ageGroupComboBox.Enabled = true;
            causeOfDeathComboBox.Enabled = false;
            hypothesisComboBox.Enabled = false;
            calculateDataForLifeExpectancyTableButton.Enabled = false;
            calculateDataForNewbornLifeExpectancyPlotsButton.Enabled = true;
            calculateDataForLifeExpectancyPlotsButton.Enabled = true;

            УстановитьВозможностьВычисленияДанных();
        }

        private void quinquennialAgeGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ТипВозрастныхГрупп = EТипВозрастныхГрупп.Пятилетние;
            ageGroupComboBox.DataSource = _анализВыживаемости.СписокПятилетнихВозрастныхГрупп;
            ageGroupComboBox.Enabled = true;
            causeOfDeathComboBox.Enabled = true;
            hypothesisComboBox.Enabled = false;
            calculateDataForLifeExpectancyTableButton.Enabled = true;
            calculateDataForNewbornLifeExpectancyPlotsButton.Enabled = true;
            calculateDataForLifeExpectancyPlotsButton.Enabled = true;

            УстановитьВозможностьВычисленияДанных();
        }

        private void annualInterpolatedAgeGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ТипВозрастныхГрупп = EТипВозрастныхГрупп.ОднолетниеИнтерполированные;
            ageGroupComboBox.DataSource = _анализВыживаемости.СписокПятилетнихВозрастныхГрупп;
            ageGroupComboBox.Enabled = false;
            causeOfDeathComboBox.Enabled = true;
            hypothesisComboBox.Enabled = true;
            calculateDataForLifeExpectancyTableButton.Enabled = false;
            calculateDataForNewbornLifeExpectancyPlotsButton.Enabled = false;
            calculateDataForLifeExpectancyPlotsButton.Enabled = false;

            УстановитьВозможностьВычисленияДанных();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            УстановитьВозможностьВычисленияДанных();
        }

        private void calculateDataForMortalityTableButton_Click(object sender, EventArgs e)
        {
            List<СтрокаТаблицыСмертности> таблицаСмертности =
                _анализВыживаемости.ВычислитьДанныеДляТаблицыСмертности(ТипВозрастныхГрупп, Год, Территория, КатегорияПоселения, Пол, ПричинаСмерти, ПредположениеДляИнтерполяции);

            if (таблицаСмертности != null && таблицаСмертности.Count != 0)
            {
                double[] x = таблицаСмертности.Select(o => Convert.ToDouble(o.x)).ToArray();

                double[] px = таблицаСмертности.Select(o => o.px).ToArray();
                ОтобразитьДанныеНаГрафике(survivalProbabilityFormsPlot, x, px, "Вероятн. дожития до след. возр. гр.", "x", "\x2099p\x2093");

                double[] ex = таблицаСмертности.Select(o => o.ex).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancyFormsPlot, x, ex, "Оценка средн. продолж. жизни", "x", "e\x2093");

                mortalityTableDataGridView.DataSource = таблицаСмертности;
                infoLabel.Text = "Таблица смертности и графики успешно построены";
                outputDataTabControl.SelectedTab = mortalityTableTabPage;
            }
            else
            {
                infoLabel.Text = "При построении таблицы смертности и графиков возникли ошибки";
            }
        }

        private void calculateDataForLifeExpectancyTableButton_Click(object sender, EventArgs e)
        {
            List<СтрокаТаблицыСОжидаемойПродолжительностьюПредстоящейЖизни> таблицаСОжидаемойПродолжительностьюПредстоящейЖизни =
                _анализВыживаемости.ВычислитьДанныеДляТаблицыСОжидаемойПродолжительностьюПредстоящейЖизни(ТипВозрастныхГрупп, Год, Территория, КатегорияПоселения, Пол, ВозрастнаяГруппа);

            if (таблицаСОжидаемойПродолжительностьюПредстоящейЖизни != null && таблицаСОжидаемойПродолжительностьюПредстоящейЖизни.Count != 0)
            {
                lifeExpectancyTableDataGridView.DataSource = таблицаСОжидаемойПродолжительностьюПредстоящейЖизни;
                infoLabel.Text = "Таблица ожидаемой продолжительности предстоящей жизни человека по причинам смерти успешно построена";
                outputDataTabControl.SelectedTab = lifeExpectancyTableTabPage;
            }
            else
            {
                infoLabel.Text = "При построении таблицы ожидаемой продолжительности предстоящей жизни человека по причинам смерти возникли ошибки";
            }
        }

        private void calculateDataForNewbornLifeExpectancyPlotsButton_Click(object sender, EventArgs e)
        {
            List<ФункциональныеХарактеристикиПродолжительностиЖизни> функциональныеХарактеристикиПродолжительностиЖизниНоворожденного =
                _анализВыживаемости.ВычислитьФункциональныеХарактеристикиПродолжительностиЖизниНоворожденного(ТипВозрастныхГрупп, Год, Территория, КатегорияПоселения, Пол, ПричинаСмерти);

            if (функциональныеХарактеристикиПродолжительностиЖизниНоворожденного != null && функциональныеХарактеристикиПродолжительностиЖизниНоворожденного.Count != 0)
            {
                double[] x = функциональныеХарактеристикиПродолжительностиЖизниНоворожденного.Select(o => Convert.ToDouble(o.x)).ToArray();

                double[] sx = функциональныеХарактеристикиПродолжительностиЖизниНоворожденного.Select(o => o.s).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancySurvivalFunctionFormsPlot, x, sx, "Функция выживания", "x", "s(x)", clearPlot: !ДобавитьГрафикиКСравнению);

                double[] Fx = функциональныеХарактеристикиПродолжительностиЖизниНоворожденного.Select(o => o.F).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancyDisctributionFunctionFormsPlot, x, Fx, "Функция распределения", "x", "F(x)", clearPlot: !ДобавитьГрафикиКСравнению);

                double[] fx = функциональныеХарактеристикиПродолжительностиЖизниНоворожденного.Select(o => o.f).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancyDistributionDensityFunctionFormsPlot, x, fx, "Функция плотности распределения", "x", "f(x)", clearPlot: !ДобавитьГрафикиКСравнению);

                double[] mux = функциональныеХарактеристикиПродолжительностиЖизниНоворожденного.Select(o => o.mu).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancyRiskFunctionFormsPlot, x, mux, "Функция риска", "x", "μ(x)", clearPlot: !ДобавитьГрафикиКСравнению);

                lifeExpectancyPlotsTabPage.Text = "Графики функциональных характеристик продолжительности жизни новорожденного";
                infoLabel.Text = "Графики функциональных характеристик продолжительности жизни новорожденного успешно построены";
                outputDataTabControl.SelectedTab = lifeExpectancyPlotsTabPage;
            }
            else
            {
                infoLabel.Text = "При построении графиков функциональных характеристик продолжительности жизни новорожденного возникли ошибки";
            }
        }

        private void calculateDataForLifeExpectancyPlotsButton_Click(object sender, EventArgs e)
        {
            List<ФункциональныеХарактеристикиПродолжительностиЖизни> функциональныеХарактеристикиОстаточнойПродолжительностиЖизни =
                _анализВыживаемости.ВычислитьФункциональныеХарактеристикиОстаточнойПродолжительностиЖизни(ТипВозрастныхГрупп, Год, Территория, КатегорияПоселения, Пол, ПричинаСмерти, ВозрастнаяГруппа);

            if (функциональныеХарактеристикиОстаточнойПродолжительностиЖизни != null && функциональныеХарактеристикиОстаточнойПродолжительностиЖизни.Count != 0)
            {
                double[] x = функциональныеХарактеристикиОстаточнойПродолжительностиЖизни.Select(o => Convert.ToDouble(o.x)).ToArray();

                double[] sxt = функциональныеХарактеристикиОстаточнойПродолжительностиЖизни.Select(o => o.s).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancySurvivalFunctionFormsPlot, x, sxt, "Функция выживания", "x", "s\x2093(t)", clearPlot: !ДобавитьГрафикиКСравнению);

                double[] Fxt = функциональныеХарактеристикиОстаточнойПродолжительностиЖизни.Select(o => o.F).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancyDisctributionFunctionFormsPlot, x, Fxt, "Функция распределения", "x", "F\x2093(t)", clearPlot: !ДобавитьГрафикиКСравнению);

                double[] fxt = функциональныеХарактеристикиОстаточнойПродолжительностиЖизни.Select(o => o.f).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancyDistributionDensityFunctionFormsPlot, x, fxt, "Функция плотности распределения", "x", "f\x2093(t)", clearPlot: !ДобавитьГрафикиКСравнению);

                double[] muxt = функциональныеХарактеристикиОстаточнойПродолжительностиЖизни.Select(o => o.mu).ToArray();
                ОтобразитьДанныеНаГрафике(lifeExpectancyRiskFunctionFormsPlot, x, muxt, "Функция риска", "x", "μ\x2093(t)", clearPlot: !ДобавитьГрафикиКСравнению);

                lifeExpectancyPlotsTabPage.Text = "Графики функциональных характеристик остаточной продолжительности жизни";
                infoLabel.Text = "Графики функциональных характеристик остаточной продолжительности жизни успешно построены";
                outputDataTabControl.SelectedTab = lifeExpectancyPlotsTabPage;
            }
            else
            {
                infoLabel.Text = "При построении графиков функциональных характеристик остаточной продолжительности жизни возникли ошибки";
            }
        }

        private void performFirstComputationalExperimentButton_Click(object sender, EventArgs e)
        {
            РезультатыВычислительногоЭксперимента результатыВычислительногоЭксперимента = _анализВыживаемости.СравнитьОпытнуюТаблицуСмертностиСЭталонной();
            var списокСЧисломЖивыхПоВозрастнымГруппами = (List<ЧислоЖивыхДляВозрастнойГруппы_СравнениеОпытнойТаблицыСмертностиСЭталонной>)результатыВычислительногоЭксперимента.СписокСЧисломЖивыхПоВозрастнымГруппами;

            double[] x = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => Convert.ToDouble(o.x)).ToArray();

            double[] lx_calculated = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => o.lx_calculated).ToArray();
            ОтобразитьДанныеНаГрафике(computationalExperimentFormsPlot, x, lx_calculated, "Сравнение опытной таблицы смертности с эталонной", "x", "l\x2093", legendLabel: "Опытные значения", clearPlot: true);

            double[] lx_reference = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => o.lx_reference).ToArray();
            ОтобразитьДанныеНаГрафике(computationalExperimentFormsPlot, x, lx_reference, "Сравнение опытной таблицы смертности с эталонной", "x", "l\x2093", legendLabel: "Эталонные значения", clearPlot: false);

            computationalExperimentTextBox.Text = результатыВычислительногоЭксперимента.Вывод;

            infoLabel.Text = "Сравнение опытной таблицы смертности с эталонной успешно выполнено";
            outputDataTabControl.SelectedTab = computationalExperimentTabPage;
        }

        private void performSecondComputationalExperimentButton_Click(object sender, EventArgs e)
        {
            РезультатыВычислительногоЭксперимента результатыВычислительногоЭксперимента = _анализВыживаемости.ПодобратьПредположениеДляИнтерполяции();
            var списокСЧисломЖивыхПоВозрастнымГруппами = (List<ЧислоЖивыхДляВозрастнойГруппы_ПодборПредположенияДляИнтерполяции>)результатыВычислительногоЭксперимента.СписокСЧисломЖивыхПоВозрастнымГруппами;

            double[] x = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => Convert.ToDouble(o.x)).ToArray();

            double[] lx0 = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => o.lx0).ToArray();
            ОтобразитьДанныеНаГрафике(computationalExperimentFormsPlot, x, lx0, "Подбор предположения для интерполяции", "x", "l\x2093", legendLabel: "Реальные значения", clearPlot: true);

            double[] lx1 = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => o.lx1).ToArray();
            ОтобразитьДанныеНаГрафике(computationalExperimentFormsPlot, x, lx1, "Подбор предположения для интерполяции", "x", "l\x2093", legendLabel: "Предположение о равномерном распределении смертей", clearPlot: false);

            double[] lx2 = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => o.lx2).ToArray();
            ОтобразитьДанныеНаГрафике(computationalExperimentFormsPlot, x, lx2, "Подбор предположения для интерполяции", "x", "l\x2093", legendLabel: "Предположение постоянства интенсивности смерти", clearPlot: false);

            double[] lx3 = списокСЧисломЖивыхПоВозрастнымГруппами.Select(o => o.lx3).ToArray();
            ОтобразитьДанныеНаГрафике(computationalExperimentFormsPlot, x, lx3, "Подбор предположения для интерполяции", "x", "l\x2093", legendLabel: "Предположение Балдуччи", clearPlot: false);

            computationalExperimentTextBox.Text = результатыВычислительногоЭксперимента.Вывод;

            infoLabel.Text = "Подбор предположения для интерполяции успешно выполнен";
            outputDataTabControl.SelectedTab = computationalExperimentTabPage;
        }

        private void УстановитьВозможностьВычисленияДанных()
        {
            if (_анализВыживаемости.ВычислениеДанныхВозможно(ТипВозрастныхГрупп, Год, Территория, КатегорияПоселения, Пол, ПричинаСмерти))
            {
                calculateDataForMortalityTableButton.Enabled = true;
                calculateDataForLifeExpectancyTableButton.Enabled = quinquennialAgeGroupRadioButton.Checked;
                calculateDataForNewbornLifeExpectancyPlotsButton.Enabled = annualAgeGroupRadioButton.Checked || quinquennialAgeGroupRadioButton.Checked;
                calculateDataForLifeExpectancyPlotsButton.Enabled = annualAgeGroupRadioButton.Checked || quinquennialAgeGroupRadioButton.Checked;
                infoLabel.Text = "Вычисление данных возможно. Нажмите на желаемую кнопку, чтобы продолжить";
            }
            else
            {
                calculateDataForMortalityTableButton.Enabled = false;
                calculateDataForLifeExpectancyTableButton.Enabled = false;
                calculateDataForNewbornLifeExpectancyPlotsButton.Enabled = false;
                calculateDataForLifeExpectancyPlotsButton.Enabled = false;
                infoLabel.Text = "Вычисление данных невозможно. Выберите другие параметры";
            }
        }

        private void ОтобразитьДанныеНаГрафике(ScottPlot.FormsPlot formsPlot, double[] x, double[] y, string titleLabel, string xLabel, string yLabel, string legendLabel = "", bool clearPlot = true)
        {
            if (clearPlot)
                formsPlot.Plot.Clear();

            formsPlot.Plot.AddScatter(x, y, label: legendLabel);
            formsPlot.Plot.Title(titleLabel);
            formsPlot.Plot.XLabel(xLabel);
            formsPlot.Plot.YLabel(yLabel);
            formsPlot.Plot.Legend(location: ScottPlot.Alignment.LowerLeft);
        }
    }
}
