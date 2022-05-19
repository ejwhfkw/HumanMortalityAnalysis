using System;
using System.Collections.Generic;

namespace SurvivalAnalysis
{
    /// <summary>
    /// Среднегодовая численность населения для возрастной группы, используемая в расчетах
    /// </summary>
    public class СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы
    {
        /// <summary>
        /// Возрастная группа
        /// </summary>
        public int x { get; set; }

        /// <summary>
        /// Значение среднегодовой численности населения для возрастной группы
        /// </summary>
        public int Value { get; set; }

        public СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(int x, int value)
        {
            this.x = x;
            Value = value;
        }
    }

    public abstract class ЧисленностьНаселения
    {
        public abstract List<СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы> СоздатьСписокСреднегодовойЧисленностиНаселенияПоВозрастнымГруппам();
    }

    /// <summary>
    /// Среднегодовая численность населения по годам, территориям, типам поселений, полу и однолетним возрастным группам
    /// </summary>
    public class ЧисленностьНаселенияПоОднолетнимВозрастнымГруппам : ЧисленностьНаселения
    {
        public int Year;
        public int Reg;
        public string Group;
        public string Sex;
        public int PopDa0;
        public int PopDa1;
        public int PopDa2;
        public int PopDa3;
        public int PopDa4;
        public int PopDa5;
        public int PopDa6;
        public int PopDa7;
        public int PopDa8;
        public int PopDa9;
        public int PopDa10;
        public int PopDa11;
        public int PopDa12;
        public int PopDa13;
        public int PopDa14;
        public int PopDa15;
        public int PopDa16;
        public int PopDa17;
        public int PopDa18;
        public int PopDa19;
        public int PopDa20;
        public int PopDa21;
        public int PopDa22;
        public int PopDa23;
        public int PopDa24;
        public int PopDa25;
        public int PopDa26;
        public int PopDa27;
        public int PopDa28;
        public int PopDa29;
        public int PopDa30;
        public int PopDa31;
        public int PopDa32;
        public int PopDa33;
        public int PopDa34;
        public int PopDa35;
        public int PopDa36;
        public int PopDa37;
        public int PopDa38;
        public int PopDa39;
        public int PopDa40;
        public int PopDa41;
        public int PopDa42;
        public int PopDa43;
        public int PopDa44;
        public int PopDa45;
        public int PopDa46;
        public int PopDa47;
        public int PopDa48;
        public int PopDa49;
        public int PopDa50;
        public int PopDa51;
        public int PopDa52;
        public int PopDa53;
        public int PopDa54;
        public int PopDa55;
        public int PopDa56;
        public int PopDa57;
        public int PopDa58;
        public int PopDa59;
        public int PopDa60;
        public int PopDa61;
        public int PopDa62;
        public int PopDa63;
        public int PopDa64;
        public int PopDa65;
        public int PopDa66;
        public int PopDa67;
        public int PopDa68;
        public int PopDa69;
        public int PopDa70;
        public int PopDa71;
        public int PopDa72;
        public int PopDa73;
        public int PopDa74;
        public int PopDa75;
        public int PopDa76;
        public int PopDa77;
        public int PopDa78;
        public int PopDa79;
        public int PopDa80;
        public int PopDa81;
        public int PopDa82;
        public int PopDa83;
        public int PopDa84;
        public int PopDa85;
        public int PopDa86;
        public int PopDa87;
        public int PopDa88;
        public int PopDa89;
        public int PopDa90;
        public int PopDa91;
        public int PopDa92;
        public int PopDa93;
        public int PopDa94;
        public int PopDa95;
        public int PopDa96;
        public int PopDa97;
        public int PopDa98;
        public int PopDa99;
        public int PopDa100;

        public ЧисленностьНаселенияПоОднолетнимВозрастнымГруппам(string[] данные)
        {
            Year = Convert.ToInt32(данные[0]);
            Reg = Convert.ToInt32(данные[1]);
            Group = данные[2];
            Sex = данные[3];
            PopDa0 = Convert.ToInt32(данные[4]);
            PopDa1 = Convert.ToInt32(данные[5]);
            PopDa2 = Convert.ToInt32(данные[6]);
            PopDa3 = Convert.ToInt32(данные[7]);
            PopDa4 = Convert.ToInt32(данные[8]);
            PopDa5 = Convert.ToInt32(данные[9]);
            PopDa6 = Convert.ToInt32(данные[10]);
            PopDa7 = Convert.ToInt32(данные[11]);
            PopDa8 = Convert.ToInt32(данные[12]);
            PopDa9 = Convert.ToInt32(данные[13]);
            PopDa10 = Convert.ToInt32(данные[14]);
            PopDa11 = Convert.ToInt32(данные[15]);
            PopDa12 = Convert.ToInt32(данные[16]);
            PopDa13 = Convert.ToInt32(данные[17]);
            PopDa14 = Convert.ToInt32(данные[18]);
            PopDa15 = Convert.ToInt32(данные[19]);
            PopDa16 = Convert.ToInt32(данные[20]);
            PopDa17 = Convert.ToInt32(данные[21]);
            PopDa18 = Convert.ToInt32(данные[22]);
            PopDa19 = Convert.ToInt32(данные[23]);
            PopDa20 = Convert.ToInt32(данные[24]);
            PopDa21 = Convert.ToInt32(данные[25]);
            PopDa22 = Convert.ToInt32(данные[26]);
            PopDa23 = Convert.ToInt32(данные[27]);
            PopDa24 = Convert.ToInt32(данные[28]);
            PopDa25 = Convert.ToInt32(данные[29]);
            PopDa26 = Convert.ToInt32(данные[30]);
            PopDa27 = Convert.ToInt32(данные[31]);
            PopDa28 = Convert.ToInt32(данные[32]);
            PopDa29 = Convert.ToInt32(данные[33]);
            PopDa30 = Convert.ToInt32(данные[34]);
            PopDa31 = Convert.ToInt32(данные[35]);
            PopDa32 = Convert.ToInt32(данные[36]);
            PopDa33 = Convert.ToInt32(данные[37]);
            PopDa34 = Convert.ToInt32(данные[38]);
            PopDa35 = Convert.ToInt32(данные[39]);
            PopDa36 = Convert.ToInt32(данные[40]);
            PopDa37 = Convert.ToInt32(данные[41]);
            PopDa38 = Convert.ToInt32(данные[42]);
            PopDa39 = Convert.ToInt32(данные[43]);
            PopDa40 = Convert.ToInt32(данные[44]);
            PopDa41 = Convert.ToInt32(данные[45]);
            PopDa42 = Convert.ToInt32(данные[46]);
            PopDa43 = Convert.ToInt32(данные[47]);
            PopDa44 = Convert.ToInt32(данные[48]);
            PopDa45 = Convert.ToInt32(данные[49]);
            PopDa46 = Convert.ToInt32(данные[50]);
            PopDa47 = Convert.ToInt32(данные[51]);
            PopDa48 = Convert.ToInt32(данные[52]);
            PopDa49 = Convert.ToInt32(данные[53]);
            PopDa50 = Convert.ToInt32(данные[54]);
            PopDa51 = Convert.ToInt32(данные[55]);
            PopDa52 = Convert.ToInt32(данные[56]);
            PopDa53 = Convert.ToInt32(данные[57]);
            PopDa54 = Convert.ToInt32(данные[58]);
            PopDa55 = Convert.ToInt32(данные[59]);
            PopDa56 = Convert.ToInt32(данные[60]);
            PopDa57 = Convert.ToInt32(данные[61]);
            PopDa58 = Convert.ToInt32(данные[62]);
            PopDa59 = Convert.ToInt32(данные[63]);
            PopDa60 = Convert.ToInt32(данные[64]);
            PopDa61 = Convert.ToInt32(данные[65]);
            PopDa62 = Convert.ToInt32(данные[66]);
            PopDa63 = Convert.ToInt32(данные[67]);
            PopDa64 = Convert.ToInt32(данные[68]);
            PopDa65 = Convert.ToInt32(данные[69]);
            PopDa66 = Convert.ToInt32(данные[70]);
            PopDa67 = Convert.ToInt32(данные[71]);
            PopDa68 = Convert.ToInt32(данные[72]);
            PopDa69 = Convert.ToInt32(данные[73]);
            PopDa70 = Convert.ToInt32(данные[74]);
            PopDa71 = Convert.ToInt32(данные[75]);
            PopDa72 = Convert.ToInt32(данные[76]);
            PopDa73 = Convert.ToInt32(данные[77]);
            PopDa74 = Convert.ToInt32(данные[78]);
            PopDa75 = Convert.ToInt32(данные[79]);
            PopDa76 = Convert.ToInt32(данные[80]);
            PopDa77 = Convert.ToInt32(данные[81]);
            PopDa78 = Convert.ToInt32(данные[82]);
            PopDa79 = Convert.ToInt32(данные[83]);
            PopDa80 = Convert.ToInt32(данные[84]);
            PopDa81 = Convert.ToInt32(данные[85]);
            PopDa82 = Convert.ToInt32(данные[86]);
            PopDa83 = Convert.ToInt32(данные[87]);
            PopDa84 = Convert.ToInt32(данные[88]);
            PopDa85 = Convert.ToInt32(данные[89]);
            PopDa86 = Convert.ToInt32(данные[90]);
            PopDa87 = Convert.ToInt32(данные[91]);
            PopDa88 = Convert.ToInt32(данные[92]);
            PopDa89 = Convert.ToInt32(данные[93]);
            PopDa90 = Convert.ToInt32(данные[94]);
            PopDa91 = Convert.ToInt32(данные[95]);
            PopDa92 = Convert.ToInt32(данные[96]);
            PopDa93 = Convert.ToInt32(данные[97]);
            PopDa94 = Convert.ToInt32(данные[98]);
            PopDa95 = Convert.ToInt32(данные[99]);
            PopDa96 = Convert.ToInt32(данные[100]);
            PopDa97 = Convert.ToInt32(данные[101]);
            PopDa98 = Convert.ToInt32(данные[102]);
            PopDa99 = Convert.ToInt32(данные[103]);
            PopDa100 = Convert.ToInt32(данные[104]);
        }

        public override List<СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы> СоздатьСписокСреднегодовойЧисленностиНаселенияПоВозрастнымГруппам()
        {
            var списокСреднегодовойЧисленностиНаселенияПоВозрастнымГруппам = new List<СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы>
            {
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(0, PopDa0),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(1, PopDa1),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(2, PopDa2),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(3, PopDa3),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(4, PopDa4),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(5, PopDa5),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(6, PopDa6),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(7, PopDa7),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(8, PopDa8),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(9, PopDa9),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(10, PopDa10),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(11, PopDa11),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(12, PopDa12),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(13, PopDa13),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(14, PopDa14),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(15, PopDa15),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(16, PopDa16),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(17, PopDa17),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(18, PopDa18),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(19, PopDa19),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(20, PopDa20),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(21, PopDa21),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(22, PopDa22),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(23, PopDa23),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(24, PopDa24),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(25, PopDa25),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(26, PopDa26),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(27, PopDa27),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(28, PopDa28),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(29, PopDa29),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(30, PopDa30),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(31, PopDa31),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(32, PopDa32),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(33, PopDa33),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(34, PopDa34),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(35, PopDa35),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(36, PopDa36),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(37, PopDa37),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(38, PopDa38),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(39, PopDa39),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(40, PopDa40),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(41, PopDa41),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(42, PopDa42),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(43, PopDa43),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(44, PopDa44),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(45, PopDa45),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(46, PopDa46),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(47, PopDa47),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(48, PopDa48),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(49, PopDa49),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(50, PopDa50),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(51, PopDa51),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(52, PopDa52),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(53, PopDa53),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(54, PopDa54),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(55, PopDa55),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(56, PopDa56),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(57, PopDa57),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(58, PopDa58),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(59, PopDa59),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(60, PopDa60),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(61, PopDa61),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(62, PopDa62),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(63, PopDa63),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(64, PopDa64),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(65, PopDa65),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(66, PopDa66),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(67, PopDa67),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(68, PopDa68),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(69, PopDa69),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(70, PopDa70),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(71, PopDa71),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(72, PopDa72),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(73, PopDa73),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(74, PopDa74),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(75, PopDa75),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(76, PopDa76),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(77, PopDa77),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(78, PopDa78),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(79, PopDa79),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(80, PopDa80),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(81, PopDa81),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(82, PopDa82),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(83, PopDa83),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(84, PopDa84),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(85, PopDa85),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(86, PopDa86),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(87, PopDa87),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(88, PopDa88),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(89, PopDa89),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(90, PopDa90),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(91, PopDa91),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(92, PopDa92),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(93, PopDa93),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(94, PopDa94),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(95, PopDa95),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(96, PopDa96),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(97, PopDa97),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(98, PopDa98),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(99, PopDa99),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(100, PopDa100)
            };

            return списокСреднегодовойЧисленностиНаселенияПоВозрастнымГруппам;
        }
    }

    /// <summary>
    /// Среднегодовая численность населения по годам, территориям, типам поселений, полу и пятилетним возрастным группам
    /// </summary>
    public class ЧисленностьНаселенияПоПятилетнимВозрастнымГруппам : ЧисленностьНаселения
    {
        /// <summary>
        /// Год
        /// </summary>
        public int Year;
        /// <summary>
        /// Код территории
        /// </summary>
        public int Reg;
        /// <summary>
        /// Тип поселений
        /// </summary>
        public string Group;
        /// <summary>
        /// Пол
        /// </summary>
        public string Sex;
        /// <summary>
        /// Численность населения в возрасте 0 лет
        /// </summary>
        public int PopD5a0;
        /// <summary>
        /// Численность населения в возрасте 1-4 года
        /// </summary>
        public int PopD5a1;
        /// <summary>
        /// Численность населения в возрасте 5-9 лет
        /// </summary>
        public int PopD5a5;
        /// <summary>
        /// Численность населения в возрасте 10-14 лет
        /// </summary>
        public int PopD5a10;
        /// <summary>
        /// Численность населения в возрасте 15-19 лет
        /// </summary>
        public int PopD5a15;
        /// <summary>
        /// Численность населения в возрасте 20-24 года
        /// </summary>
        public int PopD5a20;
        /// <summary>
        /// Численность населения в возрасте 25-29 лет
        /// </summary>
        public int PopD5a25;
        /// <summary>
        /// Численность населения в возрасте 30-34 года
        /// </summary>
        public int PopD5a30;
        /// <summary>
        /// Численность населения в возрасте 35-39 лет
        /// </summary>
        public int PopD5a35;
        /// <summary>
        /// Численность населения в возрасте 40-44 года
        /// </summary>
        public int PopD5a40;
        /// <summary>
        /// Численность населения в возрасте 45-49 лет
        /// </summary>
        public int PopD5a45;
        /// <summary>
        /// Численность населения в возрасте 50-54 года
        /// </summary>
        public int PopD5a50;
        /// <summary>
        /// Численность населения в возрасте 55-59 лет
        /// </summary>
        public int PopD5a55;
        /// <summary>
        /// Численность населения в возрасте 60-64 года
        /// </summary>
        public int PopD5a60;
        /// <summary>
        /// Численность населения в возрасте 65-69 лет
        /// </summary>
        public int PopD5a65;
        /// <summary>
        /// Численность населения в возрасте 70-74 года
        /// </summary>
        public int PopD5a70;
        /// <summary>
        /// Численность населения в возрасте 75-79 лет
        /// </summary>
        public int PopD5a75;
        /// <summary>
        /// Численность населения в возрасте 80-84 года
        /// </summary>
        public int PopD5a80;
        /// <summary>
        /// Численность населения в возрасте 85 лет и старше
        /// </summary>
        public int PopD5a85;

        public ЧисленностьНаселенияПоПятилетнимВозрастнымГруппам(string[] данные)
        {
            Year = Convert.ToInt32(данные[0]);
            Reg = Convert.ToInt32(данные[1]);
            Group = данные[2];
            Sex = данные[3];
            PopD5a0 = Convert.ToInt32(данные[4]);
            PopD5a1 = Convert.ToInt32(данные[5]);
            PopD5a5 = Convert.ToInt32(данные[6]);
            PopD5a10 = Convert.ToInt32(данные[7]);
            PopD5a15 = Convert.ToInt32(данные[8]);
            PopD5a20 = Convert.ToInt32(данные[9]);
            PopD5a25 = Convert.ToInt32(данные[10]);
            PopD5a30 = Convert.ToInt32(данные[11]);
            PopD5a35 = Convert.ToInt32(данные[12]);
            PopD5a40 = Convert.ToInt32(данные[13]);
            PopD5a45 = Convert.ToInt32(данные[14]);
            PopD5a50 = Convert.ToInt32(данные[15]);
            PopD5a55 = Convert.ToInt32(данные[16]);
            PopD5a60 = Convert.ToInt32(данные[17]);
            PopD5a65 = Convert.ToInt32(данные[18]);
            PopD5a70 = Convert.ToInt32(данные[19]);
            PopD5a75 = Convert.ToInt32(данные[20]);
            PopD5a80 = Convert.ToInt32(данные[21]);
            PopD5a85 = Convert.ToInt32(данные[22]);
        }

        public override List<СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы> СоздатьСписокСреднегодовойЧисленностиНаселенияПоВозрастнымГруппам()
        {
            var списокСреднегодовойЧисленностиНаселенияПоВозрастнымГруппам = new List<СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы>
            {
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(0, PopD5a0),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(1, PopD5a1),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(5, PopD5a5),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(10, PopD5a10),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(15, PopD5a15),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(20, PopD5a20),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(25, PopD5a25),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(30, PopD5a30),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(35, PopD5a35),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(40, PopD5a40),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(45, PopD5a45),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(50, PopD5a50),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(55, PopD5a55),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(60, PopD5a60),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(65, PopD5a65),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(70, PopD5a70),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(75, PopD5a75),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(80, PopD5a80),
                new СреднегодоваяЧисленностьНаселенияДляВозрастнойГруппы(85, PopD5a85)
            };

            return списокСреднегодовойЧисленностиНаселенияПоВозрастнымГруппам;
        }
    }
}
