using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorpLawSS14Super
{
    public partial class Form1 : Form

    {

        private int parameterSum = 0; // Текущая сумма
        private int parameterToAdd = 0; // Параметр, который будет добавляться

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

        private void button1_Click(object sender, EventArgs e)
        {
            // Берём число, которое добавляем
            parameterToAdd += 5;

            // Добавляем параметр к сумме
            parameterSum += parameterToAdd;

            // Обновляем label2 с новой суммой
            label2.Text = $"Текущая сумма: {parameterSum}";

            // Обнуляем значение
            parameterToAdd = 0;
        }
    }
}
