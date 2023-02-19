using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskHard2WinForm
{
    public partial class Form1 : Form
    {
        int countCityTravel;
        public static City[] DbCities()
        {
            // Обьявление городов и переменных
            City[] cities = new City[] {

                    new City  (1, "Берлин", 399, 175, 1.13),
                    new City  (2, "Прага", 300, 270),
                    new City  (3, "Париж", 350, 220),
                    new City  (4, "Рига", 250, 170),
                    new City  (5, "Лондон", 390, 270),
                    new City  (6, "Ватикан", 500, 350),
                    new City  (7, "Палермо", 230, 150),
                    new City  (8, "Варшава", 300, 190),
                    new City  (9, "Кишинев", 215, 110),
                    new City  (10, "Мадрид", 260, 190),
                    new City  (11, "Будапешт", 269, 230)
                };
            return cities;
        }




        static double CalcPriceTwo(double price, City[] cities, string firstCity, string secondCity)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (secondCity == cities[i].name)
                {
                    price += cities[i].price;
                }
            }

            if(firstCity == "Мадрид")
            {
                price += cities[2].transit;
            }

            if (secondCity == "Мадрид")
            {
                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[9].price * 1.04 - cities[9].price;
                }
            }

            if (firstCity == "Кишинев")
            {
                price += cities[10].transit;

            }

            if (firstCity == "Лондон")
            {
                price += cities[2].price;
            }

            if (firstCity == "Рига")
            {
                price += cities[7].transit;
            }

            if (secondCity == "Берлин")
            {
                price += cities[0].nalog;

                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[0].price * 1.04 - cities[0].price;
                }
            }

            if (secondCity == "Палермо")
            {
                if(firstCity == "Лондон") price *= cities[6].price * 1.07 - cities[6].price;
                if (firstCity == "Кишинев") price += cities[6].price * 1.11 - cities[6].price;

                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[6].price * 1.04 - cities[6].price;
                }
            }

            if (secondCity == "Рига")
            {
                if (firstCity == "Париж") price += cities[3].price * 1.09 - cities[3].price;

                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[3].price * 1.04 - cities[3].price;
                }
            }

            if(secondCity == "Париж")
            {
                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[2].price * 1.04 - cities[2].price;
                }
            }

            if (secondCity == "Варшава")
            {
                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[7].price * 1.04 - cities[7].price;
                }
            }

            if(secondCity == "Будапешт")
            {
                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[10].price * 1.04 - cities[10].price;
                }
            }


            if (secondCity == "Прага")
            {
                if (firstCity == "Ватикан" || firstCity == "Лондон" || firstCity == "Кишинев")
                {
                    price += cities[1].price * 1.04 - cities[1].price;
                }
            }


            if(firstCity == "Палермо" && secondCity == "Рига" || firstCity == "Рига" && secondCity == "Палермо")
            {
                price += cities[7].transit + cities[0].transit; 
            }


            return price;
        }


            public Form1()
            {
                InitializeComponent();
            }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Result_Click(object sender, EventArgs e)
        {
            City[] cities = DbCities();

            //Вводим бюджет
            int budget = Convert.ToInt32(textBox_Budget.Text);

            infoTrue();

            string[] arrCombo = new string[11];
            arrCombo[0] = comboBox_Home.Text;
            arrCombo[1] = comboBox_Travel1.Text;
            arrCombo[2] = comboBox_Travel2.Text;
            arrCombo[3] = comboBox_Travel3.Text;

            double result = 0;
            

            for (int i = 0; i < countCityTravel; i++)
            {
                double price = 0;
                int temp = countCityTravel;
                if (temp == countCityTravel)
                {
                    price = CalcPriceTwo(price, cities, arrCombo[i], arrCombo[i+1]);
                    if (comboBox_Home.Text == "Ватикан") price *= 1.5;
                    result += price; 
                }
            }


            if (result > budget)
            {
                MessageBox.Show($"Не достаточно средств для путешествия, стоимость поездки {result}");
            }
            else
            {
                MessageBox.Show($"Стоимость поездки: {result}");
            }
        }

        private void textBox_Budget_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox_Travel3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Travel1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            countCityTravel = Convert.ToInt32(textBox_Count.Text);

            if (countCityTravel < 1 && countCityTravel > 3)
            {
                MessageBox.Show("Вы вели не коректное число");
            }
            infoTrue();
        }


        public void infoTrue()
        {
            countCityTravel = Convert.ToInt32(textBox_Count.Text);

            if (countCityTravel >= 1)
            {
                label_city1.Visible = true;
                comboBox_Travel1.Visible = true;
            }

            if (countCityTravel >= 2)
            {
                label_city2.Visible = true;
                comboBox_Travel2.Visible = true;
            }

            if (countCityTravel >= 3)
            {
                label_city3.Visible = true;
                comboBox_Travel3.Visible = true;
            }
        }
    }




}

