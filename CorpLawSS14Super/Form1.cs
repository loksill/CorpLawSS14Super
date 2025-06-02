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

        private void button1_Click(object sender, EventArgs e)
        {
            // Добавляем сумму
            parameterToAdd += 5;

            // Добавляем параметр к сумме
            parameterSum += parameterToAdd;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Обновляем label2 с новой суммой
            label2.Text = $"{parameterSum}";
        }
    }
}
