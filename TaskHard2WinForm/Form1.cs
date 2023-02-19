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
                    new City  (2, "Прага", 300, 175),
                    new City  (3, "Париж", 350, 220),
                    new City  (4, "Рига", 250, 170),
                    new City  (5, "Лондон", 390, 270),
                    new City  (6, "Ватикан", 500, 350),
                    new City  (7, "Палермо", 230, 150),
                    new City  (8, "Варшава", 300, 190),
                    new City  (9, "Кишинев", 215, 110),
                    new City  (10, "Мадрид", 260, 190),
                    new City  (11, "Будапешт", 399, 175)
                };
            return cities;
        }

        public static City[] SelectCity(City[] cities, int countSelectedCity)
        {
            City[] select = new City[countSelectedCity];

            int temp = 0;
            bool isException = false;

            for (int i = 1; i <= countSelectedCity; i++)
            {
                do
                {
                    if (i == 1)
                    {
                        Console.Write($"Введите номер города из которого начнете путешествие: ");
                    }
                    else
                    {
                        Console.Write($"Введите номер {i - 1} города: ");
                    }

                    try
                    {
                        temp = Convert.ToInt32(Console.ReadLine());
                        select[i - 1] = cities[temp];
                        isException = false;
                    }
                    catch
                    {
                        Console.WriteLine("Введи правильный номер города");
                        isException = true;
                    }
                } while (isException);
            }
            return select;
        }




        static double CalcPrice(double price, City[] cities, string firstCity, string secondCity)
        {
            for (int i = 1; i < 11; i++)
            {
                if (secondCity == cities[i].name)
                {
                    price += cities[i].price;
                }
            }

            if (secondCity == "Берлин")
            {
                price += cities[1].price * cities[1].nalog - cities[1].price;
                price += cities[1].price * 1.04 - cities[1].price;
            }

            if (secondCity == "Прага")
                price += cities[2].price * 1.04 - cities[2].price;

            if (secondCity == "Париж")
                price += cities[3].price * 1.04 - cities[3].price;

            if (secondCity == "Рига")
            {
                price += cities[8].transit;
                if (firstCity == "Париж") price += cities[4].price * 1.09 - cities[4].price;
                price += cities[4].price * 1.04 - cities[4].price;
                if (firstCity == "Палермо") price += cities[8].transit + cities[1].transit;
            }

            if (secondCity == "Лондон")
                price += cities[3].price;

            if (secondCity == "Палермо")
            {
                if (firstCity == "Лондон") price += cities[7].price * 1.07 - cities[7].price;
                if (firstCity == "Кишинев") price += cities[7].price * 1.11 - cities[7].price;
                price += cities[7].price * 1.04 - cities[7].price;
                if (firstCity == "Рига") price += cities[8].transit + cities[1].transit;
            }

            if (secondCity == "Варшава")
                price += cities[8].price * 1.04 - cities[8].price;

            if (secondCity == "Кишинев")
                price += cities[11].transit;

            if (secondCity == "Мадрид")
            {
                price += cities[3].transit;
                price += cities[10].price * 1.04 - cities[10].price;
            }

            if (secondCity == "Будапешт")
                price += cities[11].price * 1.04 - cities[11].price;

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

            string[] arrCombo = new string[10];
            arrCombo[0] = comboBox_Travel1.Text;
            arrCombo[1] = comboBox_Travel2.Text;
            arrCombo[2] = comboBox_Travel3.Text;


            double price = 0;

            for (int i = 0; i < countCityTravel; i++)
            {
                int temp = countCityTravel;
                if (temp == countCityTravel)
                {
                    price += CalcPrice(price, cities, comboBox_Home.Text, arrCombo[i]);
                    if (comboBox_Home.Text == "Ватикан") price *= 1.5;
                }
            }
 
            Console.WriteLine($"Стоимость поездки: {price}");

            if (price > budget)
            {
                MessageBox.Show($"Не достаточно средств для путешествия, стоимость поездки {price}");
            }
            else
            {
                MessageBox.Show($"Стоимость поездки: {price}");
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

