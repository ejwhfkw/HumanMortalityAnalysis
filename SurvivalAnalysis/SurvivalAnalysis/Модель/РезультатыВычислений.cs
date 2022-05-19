using System;
using System.Collections.Generic;

namespace SurvivalAnalysis
{
    public class ЧислоУмершихДляВозрастнойГруппы
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Число умерших для возрастной группы
        /// </summary>
        public double dx
        {
            get => _dx;
            set => _dx = Math.Round(value);
        }
        private double _dx;

        // dx = mx * Lx, где
        // dx - число умерших для возрастной группы,
        // mx - коэффициенты смертности для возрастной группы,
        // Lx - среднегодовая численность населения для возрастной группы
        public ЧислоУмершихДляВозрастнойГруппы(int x, double mx, int Lx)
        {
            this.x = x;
            dx = mx * Lx;
        }
    }

    public class ЧислоЖивыхДляВозрастнойГруппы : ICloneable
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Число живых для возрастной группы
        /// </summary>
        public double lx
        {
            get => _lx;
            set => _lx = value;
        }
        private double _lx;

        // lx = lx_next + dx, где
        // lx - число живых для возрастной группы,
        // lx_next - число живых для следующей возрастной группы,
        // dx - число умерших для возрастной группы
        public ЧислоЖивыхДляВозрастнойГруппы(int x, double lx_next, double dx)
        {
            this.x = x;
            lx = lx_next + dx;
        }

        public ЧислоЖивыхДляВозрастнойГруппы(int x, double lx)
        {
            this.x = x;
            this.lx = lx;
        }

        public object Clone()
        {
            return new ЧислоЖивыхДляВозрастнойГруппы(x, lx);
        }
    }

    /// <summary>
    /// Суммарное среднее число лет, прожитое членами совокупности в возрасте от х до х + 1, при предположении, что в течение года время смерти равномерно распределено
    /// </summary>
    public class СуммарноеСреднееЧислоЛетПрожитоеЧленамиСовокупности
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Суммарное среднее число лет Lx, прожитое членами совокупности в возрасте от х до х + 1
        /// </summary>
        public double Lx
        {
            get => _Lx;
            set => _Lx = Math.Round(value);
        }
        private double _Lx;

        public СуммарноеСреднееЧислоЛетПрожитоеЧленамиСовокупности(int x, int x_next, double lx, double lx_next)
        {
            this.x = x;
            Lx = (lx + lx_next) / 2 * (x_next - x);
        }
    }

    public class ОбщееСреднееЧислоЛетКДожитию
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Общее среднее число человеко-лет Tx, которые предстоит прожить лицам из совокупности lх от возраста х до предельного возраста w
        /// </summary>
        public double Tx
        {
            get => _Tx;
            set => _Tx = Math.Round(value);
        }
        private double _Tx;

        public ОбщееСреднееЧислоЛетКДожитию(int x, double Tx)
        {
            this.x = x;
            this.Tx = Tx;
        }
    }

    public class СтрокаТаблицыСмертности
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Число живых в возрастной группе x до нормализации
        /// </summary>
        public double lx_original { get; set; }

        /// <summary>
        /// Число живых в возрастной группе x после нормализации
        /// </summary>
        public double lx { get; set; }

        /// <summary>
        /// Число умерших в возрастной группе x
        /// </summary>
        public double dx { get; set; }

        /// <summary>
        /// Суммарное среднее число лет Lx, прожитое членами совокупности lx в возрасте от х до х+1
        /// Примечане: название свойства было заменено с Lx на Lxxx для того, чтобы не возникало проблем при его отображении в DataGridView
        /// </summary>
        public double Lxxx { get; set; }

        /// <summary>
        /// Общее среднее число человеко-лет Tx, которые предстоит прожить членам совокупности lх от возраста х до предельного возраста w
        /// </summary>
        public double Tx { get; set; }

        /// <summary>
        /// Вероятность того, что человек в возрастной группе x доживет до следующей возрастной группы
        /// </summary>
        public double px
        {
            get => _px;
            set => _px = Math.Round(value, 5);
        }
        private double _px;

        /// <summary>
        /// Вероятность того, что человек в возрастной группе x скончается до наступления следующей возрастной группы
        /// </summary>
        public double qx
        {
            get => _qx;
            set => _qx = Math.Round(value, 5);
        }
        private double _qx;

        /// <summary>
        /// Ожидаемая продолжительность предстоящей жизни человека в возрастной группе x
        /// </summary>
        public double ex
        {
            get => _ex;
            set => _ex = Math.Round(value, 5);
        }
        private double _ex;

        public СтрокаТаблицыСмертности(int x, double lx_original, double lx, double lx_next, double Lx, double Tx)
        {
            this.x = x;
            this.lx_original = lx_original;
            this.lx = lx;
            dx = lx - lx_next;
            this.Lxxx = Lx;
            this.Tx = Tx;
            px = lx != 0 ? lx_next / lx : 0;
            qx = lx != 0 ? 1 - lx_next / lx : 1;
            ex = lx != 0 ? Tx / lx : 0;
        }
    }

    public class СтрокаТаблицыСОжидаемойПродолжительностьюПредстоящейЖизни
    {
        public string НаименованиеПричиныСмерти { get; set; }

        /// <summary>
        /// Вероятность того, что человек в возрастной группе x скончается до наступления следующей возрастной группы
        /// </summary>
        public double qx
        {
            get => _qx;
            set => _qx = Math.Round(value, 5);
        }
        private double _qx;

        /// <summary>
        /// Ожидаемая продолжительность предстоящей жизни человека в возрастной группе x
        /// </summary>
        public double ex
        {
            get => _ex;
            set => _ex = Math.Round(value, 5);
        }
        private double _ex;

        public СтрокаТаблицыСОжидаемойПродолжительностьюПредстоящейЖизни(string наименованиеПричиныСмерти, double qx, double ex)
        {
            НаименованиеПричиныСмерти = наименованиеПричиныСмерти;
            this.qx = qx;
            this.ex = ex;
        }
    }

    public class ФункциональныеХарактеристикиПродолжительностиЖизни
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Функция выживания или дожития
        /// </summary>
        public double s
        {
            get => _s;
            set => _s = Math.Round(value, 5);
        }
        private double _s;

        /// <summary>
        /// Функция распределения
        /// </summary>
        public double F
        {
            get => _F;
            set => _F = Math.Round(value, 5);
        }
        private double _F;

        /// <summary>
        /// Функция плотности распределения (кривая смертей)
        /// </summary>
        public double f
        {
            get => _f;
            set => _f = Math.Round(value, 5);
        }
        private double _f;

        /// <summary>
        /// Интенсивность смертности или функция риска
        /// </summary>
        public double mu
        {
            get => _mu;
            set => _mu = Math.Round(value, 5);
        }
        private double _mu;

        public ФункциональныеХарактеристикиПродолжительностиЖизни(int x, double lx, double lx_fixed, double dx)
        {
            this.x = x;
            s = lx / lx_fixed;
            F = 1 - lx / lx_fixed;
            f = dx / lx_fixed;
            mu = lx != 0 ? dx / lx : 1.25; // При делении на lx = 0 значение функции mu должно быть равно бесконечности.
            // Из-за технических ограничений бесконечность невозможно показать на графике.
            // Бесконечность заменена на значение 1.25, которое уходит за границы графика.
        }
    }

    public interface IЧислоЖивыхДляВозрастнойГруппы_ВычислительныйЭксперимент { }

    public class ЧислоЖивыхДляВозрастнойГруппы_СравнениеОпытнойТаблицыСмертностиСЭталонной : IЧислоЖивыхДляВозрастнойГруппы_ВычислительныйЭксперимент
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Вычисленное значение числа живых для однолетней возрастной группы
        /// </summary>
        public double lx_calculated
        {
            get => _lx_calculated;
            set => _lx_calculated = value;
        }
        private double _lx_calculated;

        /// <summary>
        /// Эталонное значение числа живых для однолетней возрастной группы
        /// </summary>
        public double lx_reference
        {
            get => _lx_reference;
            set => _lx_reference = value;
        }
        private double _lx_reference;

        public ЧислоЖивыхДляВозрастнойГруппы_СравнениеОпытнойТаблицыСмертностиСЭталонной(int x, double lx_calculated, double lx_reference)
        {
            this.x = x;
            this.lx_calculated = lx_calculated;
            this.lx_reference = lx_reference;
        }
    }

    public class ЧислоЖивыхДляВозрастнойГруппы_ПодборПредположенияДляИнтерполяции : IЧислоЖивыхДляВозрастнойГруппы_ВычислительныйЭксперимент
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Число живых для однолетней возрастной группы
        /// </summary>
        public double lx0
        {
            get => _lx0;
            set => _lx0 = value;
        }
        private double _lx0;

        /// <summary>
        /// Число живых для однолетней интерполированной возрастной группы (предположение о равномерном распределении смертей)
        /// </summary>
        public double lx1
        {
            get => _lx1;
            set => _lx1 = value;
        }
        private double _lx1;

        /// <summary>
        /// Число живых для однолетней интерполированной возрастной группы (предположение постоянства интенсивности смерти)
        /// </summary>
        public double lx2
        {
            get => _lx2;
            set => _lx2 = value;
        }
        private double _lx2;

        /// <summary>
        /// Число живых для однолетней интерполированной возрастной группы (предположение Балдуччи)
        /// </summary>
        public double lx3
        {
            get => _lx3;
            set => _lx3 = value;
        }
        private double _lx3;

        public ЧислоЖивыхДляВозрастнойГруппы_ПодборПредположенияДляИнтерполяции(int x, double lx0, double lx1, double lx2, double lx3)
        {
            this.x = x;
            this.lx0 = lx0;
            this.lx1 = lx1;
            this.lx2 = lx2;
            this.lx3 = lx3;
        }
    }

    public class РезультатыВычислительногоЭксперимента
    {
        public IEnumerable<IЧислоЖивыхДляВозрастнойГруппы_ВычислительныйЭксперимент> СписокСЧисломЖивыхПоВозрастнымГруппами { get; private set; }

        public string Вывод { get; private set; }

        public РезультатыВычислительногоЭксперимента(IEnumerable<IЧислоЖивыхДляВозрастнойГруппы_ВычислительныйЭксперимент> списокСЧисломЖивыхПоВозрастнымГруппами, string результаты)
        {
            СписокСЧисломЖивыхПоВозрастнымГруппами = списокСЧисломЖивыхПоВозрастнымГруппами;
            Вывод = результаты;
        }
    }
}
