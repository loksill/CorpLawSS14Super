using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CorpLawSS14Super
{
    public partial class Form1 : Form

    {

        private int parameterSum = 0; // Текущая сумма
        private int parameterToAdd = 0; // Параметр, который будет добавляться
        private int parameterBackSum = 0; // Удаление лишнего
        private int parameterMod = 0; // Модификаторы
        private string parameterOther = "Высшие меры:"; // Высшие меры
        private string parameterBackOther = ""; // Удаление лишнего в высших мерах

        public Form1()
        {
            InitializeComponent();
        }

        //    { "xx1", 5 },
        //    { "xx2", 10 },
        //    { "xx3", 15 },
        //    { "xx4", 25 },
        //    { "xx5", -1 }, // Пожизненное
        //    { "xx6", -2 },  // Казнь
        //    { "Преступление против должностного лица", 10},
        //    { "Расизм", 10},
        //    { "Рецидив", 5},
        //    //{ "Явка с повинной", -5},
        //    { "Организатор", 10},
        //    //{ "Неосторожность", -5}

        private void button1_Click(object sender, EventArgs e) // XX1 | 5 минут
        {
            // Берём число, которое добавляем
            parameterToAdd += 5;

            // Добавляем параметр к сумме
            parameterSum += parameterToAdd;

            // Обновляем label2 с новой суммой
            label2.Text = $"Время: {parameterSum}";

            // Обнуляем значение
            parameterToAdd = 0;
        }

        private void button2_Click(object sender, EventArgs e) // XX2 | 10 минут
        {
            // Берём число, которое добавляем
            parameterToAdd += 10;

            // Добавляем параметр к сумме
            parameterSum += parameterToAdd;

            // Обновляем label2 с новой суммой
            label2.Text = $"Время: {parameterSum}";

            // Обнуляем значение
            parameterToAdd = 0;
        }

        private void button3_Click(object sender, EventArgs e) // XX3 | 15 минут
        {
            // Берём число, которое добавляем
            parameterToAdd += 15;

            // Добавляем параметр к сумме
            parameterSum += parameterToAdd;

            // Обновляем label2 с новой суммой
            label2.Text = $"Время: {parameterSum}";

            // Обнуляем значение
            parameterToAdd = 0;
        }

        private void button4_Click(object sender, EventArgs e) // XX4 | 25 минут
        {
            // Берём число, которое добавляем
            parameterToAdd += 25;

            // Добавляем параметр к сумме
            parameterSum += parameterToAdd;

            // Обновляем label2 с новой суммой
            label2.Text = $"Время: {parameterSum}";

            // Обнуляем значение
            parameterToAdd = 0;
        }

        private void button5_Click(object sender, EventArgs e) // XX5 | Пожизненное
        {
            // Добавляем вердикт
            parameterOther += " пожизненное,";

            // Обновляем label6
            label6.Text = $"{parameterOther}";
        }

        private void button6_Click(object sender, EventArgs e) // XX6 | Смертная казнь
        {
            // Добавляем вердикт
            parameterOther += " cмертная казнь,";

            // Обновляем label6
            label6.Text = $"{parameterOther}";
        }

        private void button7_Click(object sender, EventArgs e) // Очистка
        {
            // Обнуляем переменные
            parameterSum = 0; // Текущая сумма
            parameterToAdd = 0; // Параметр, который будет добавляться
            parameterOther = "Высшие меры:"; // Высшие меры
            parameterBackSum = 0; // Удаление лишнего
            parameterBackOther = "Вот такие пироги"; // Удаление лишнего в высших мерах

            // Обновляем метки
            label6.Text = $"{parameterOther}";
            label2.Text = $"Время: {parameterSum}";
        }

        private void button8_Click(object sender, EventArgs e) // XX1 | 5 минут
        {
            // Решаем, сколько убираем
            parameterBackSum += 5; // XX1 | 5 минут

            // Убираем это из срока
            parameterSum -= parameterBackSum;

            // Обновляем метку
            label2.Text = $"Время: {parameterSum}";

            // Очищаем убираемое
            parameterBackSum = 0;
        }

        private void button9_Click(object sender, EventArgs e) // XX2 | 10 минут
        {
            // Решаем, сколько убираем
            parameterBackSum += 10; // XX2 | 10 минут

            // Убираем это из срока
            parameterSum -= parameterBackSum;

            // Обновляем метку
            label2.Text = $"Время: {parameterSum}";

            // Очищаем убираемое
            parameterBackSum = 0;
        }

        private void button10_Click(object sender, EventArgs e) // XX3 | 15 минут
        {
            // Решаем, сколько убираем
            parameterBackSum += 15; // XX3 | 15 минут

            // Убираем это из срока
            parameterSum -= parameterBackSum;

            // Обновляем метку
            label2.Text = $"Время: {parameterSum}";

            // Очищаем убираемое
            parameterBackSum = 0;
        }

        private void button11_Click(object sender, EventArgs e) // XX4 | 25 минут
        {
            // Решаем, сколько убираем
            parameterBackSum += 25; // XX4 | 25 минут

            // Убираем это из срока
            parameterSum -= parameterBackSum;

            // Обновляем метку
            label2.Text = $"Время: {parameterSum}";

            // Очищаем убираемое
            parameterBackSum = 0;
        }

        private void button12_Click(object sender, EventArgs e) // XX5 | Пожизненное
        {
            // Решаем, что убирать
            parameterBackOther = " пожизненное,";

            // Убираем, что хотим
            string result = parameterOther.Replace(parameterBackOther, "");

            // Обновляем метку
            label6.Text = $"{result}";

            // Обновляем переменные
            parameterBackOther = "";
            parameterOther = result;
        }

        private void button13_Click(object sender, EventArgs e) // XX6 | Смертная казнь
        {
            // Решаем, что убирать
            parameterBackOther = " cмертная казнь,";

            // Убираем, что хотим
            string result = parameterOther.Replace(parameterBackOther, "");

            // Обновляем метку
            label6.Text = $"{result}";

            // Обновляем переменные
            parameterBackOther = "";
            parameterOther = result;
        }

        private void button17_Click(object sender, EventArgs e) // Организатор | +10 минут
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = 10;

            // Применяем модификатор
            parameterSum += parameterMod;

            // Обновляем label2
            label2.Text = $"Время: {parameterSum}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button21_Click(object sender, EventArgs e) // Расизм | +10 минут
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = 10;

            // Применяем модификатор
            parameterSum += parameterMod;

            // Обновляем label2
            label2.Text = $"Время: {parameterSum}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button22_Click(object sender, EventArgs e) // Должностное преступление | +10 минут
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = 10;

            // Применяем модификатор
            parameterSum += parameterMod;

            // Обновляем label2
            label2.Text = $"Время: {parameterSum}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button23_Click(object sender, EventArgs e) // Против должностного лица | +10 минут
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = 10;

            // Применяем модификатор
            parameterSum += parameterMod;

            // Обновляем label2
            label2.Text = $"Время: {parameterSum}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button15_Click(object sender, EventArgs e) // Рецедив | +5 минут
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = 5;

            // Применяем модификатор
            parameterSum += parameterMod;

            // Обновляем label2
            label2.Text = $"Время: {parameterSum}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button14_Click(object sender, EventArgs e) // Неосторожность | -5 минут
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = -5;

            // Применяем модификатор
            parameterSum += parameterMod;

            // Обновляем label2
            label2.Text = $"Время: {parameterSum}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button16_Click(object sender, EventArgs e) // Отсутствие вины | Сятие обвинений
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = -parameterSum;

            // Применяем модификатор
            parameterSum += parameterMod;
            parameterOther = "Высшие меры:"; // Снимаем пожизненные и казни

            // Обновляем метки
            label2.Text = $"Время: {parameterSum}";
            label6.Text = $"{parameterOther}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button18_Click(object sender, EventArgs e) // Крайняя необходимость | Сятие обвинений
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = -parameterSum;

            // Применяем модификатор
            parameterSum += parameterMod;
            parameterOther = "Высшие меры:"; // Снимаем пожизненные и казни

            // Обновляем метки
            label2.Text = $"Время: {parameterSum}";
            label6.Text = $"{parameterOther}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button19_Click(object sender, EventArgs e) // Гипноз | Сятие обвинений
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = -parameterSum;

            // Применяем модификатор
            parameterSum += parameterMod;
            parameterOther = "Высшие меры:"; // Снимаем пожизненные и казни

            // Обновляем метки
            label2.Text = $"Время: {parameterSum}";
            label6.Text = $"{parameterOther}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button20_Click(object sender, EventArgs e) // Допустимая самооборона | Сятие обвинений
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = -parameterSum;

            // Применяем модификатор
            parameterSum += parameterMod;
            parameterOther = "Высшие меры:"; // Снимаем пожизненные и казни

            // Обновляем метки
            label2.Text = $"Время: {parameterSum}";
            label6.Text = $"{parameterOther}";

            // Очищаем переременную
            parameterMod = 0;
        }

        private void button24_Click(object sender, EventArgs e) // Явка с повинной | -5 минут
        {
            // Выбираем, сколько хотим убрать/добавить
            parameterMod = -5;

            // Применяем модификатор
            parameterSum += parameterMod;

            // Обновляем label2
            label2.Text = $"Время: {parameterSum}";

            // Очищаем переременную
            parameterMod = 0;
        }
    }
}
