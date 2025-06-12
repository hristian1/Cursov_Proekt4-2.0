using Cursov_Proekt4.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursov_Proekt4
{
    public partial class Form1 : Form
    {
        DishTypeController types = new DishTypeController();
        DishController dishes = new DishController();
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadRecord(Dish dish)
        {
            textBox1.BackColor = Color.LightSalmon;
            textBox1.Text = dish.Id.ToString();
            textBox2.Text = dish.DishName;
            textBox3.Text = dish.Description;
            textBox4.Text = dish.Price.ToString();
            textBox5.Text = dish.Weight.ToString();
            comboBox1.Text = dish.DishType.DishName;
        }

        private void ClearScreen()
        {
            textBox1.BackColor = Color.LightSalmon;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<DishType> allDishTypes = types.GetAllDishTypes();
            comboBox1.DataSource = allDishTypes;
            comboBox1.DisplayMember = "DishName";
            comboBox1.ValueMember = "Id";

            btnAll_Click(sender, e);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text) || textBox2.Text == "")
            {
                MessageBox.Show("Въведете данни!");
                textBox2.Focus();
                return;
            }
            Dish newDish = new Dish();
            newDish.Weight = int.Parse(textBox5.Text);
            newDish.DishName = textBox2.Text;
            newDish.Description = textBox3.Text;
            newDish.Price = decimal.Parse(textBox4.Text);
            newDish.DishTypeId = (int)comboBox1.SelectedValue;

            dishes.Create(newDish);
            MessageBox.Show("Записът е успешно добавен!");
            ClearScreen();
            btnAll_Click(sender, e);
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            List<Dish> allDishes = dishes.GetAll();
            listBox1.Items.Clear();
            foreach (var item in allDishes)
            {
                listBox1.Items.Add($"{item.Id}. {item.DishName} - weight: {item.Weight}  - Price:{item.Price}");
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                textBox1.BackColor = Color.Red;
                textBox1.Focus();
                return;
            }
            else
            {
                findId = int.Parse(textBox1.Text);
            }
            //Ако няма намерен запис търсим по Id и визуализираме на екрана
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                Dish findedDog = dishes.Get(findId);
                if (findedDog == null)
                {
                    MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                    textBox1.BackColor = Color.Red;
                    textBox1.Focus();
                    return;
                }
                LoadRecord(findedDog);
            }
            else //Ако има намерен вече запис променяме по полетата
            {
                Dish updatedDish = new Dish();
                updatedDish.DishName = textBox2.Text;
                updatedDish.Description = textBox3.Text;
                updatedDish.Price = decimal.Parse(textBox4.Text);
                updatedDish.Weight = int.Parse(textBox5.Text);
                updatedDish.DishTypeId = (int)comboBox1.SelectedValue;

                dishes.Update(findId, updatedDish);
            }

            btnAll_Click(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int findId = 0;
            if (string.IsNullOrEmpty(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
            {
                MessageBox.Show("Въведете Id за търсене!");
                textBox1.BackColor = Color.LightSalmon;
                textBox1.Focus();
                return;
            }
            else
            {
                findId = int.Parse(textBox1.Text);
            }
            Dish findedDish = dishes.Get(findId);
            if (findedDish == null)
            {
                MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                textBox1.BackColor = Color.LightSalmon;
                textBox1.Focus();
                return;
            }
            LoadRecord(findedDish);
        }

        private void btnDelate_Click(object sender, EventArgs e)
        {
            {
                int findId = 0;
                if (string.IsNullOrEmpty(textBox1.Text) || !textBox1.Text.All(char.IsDigit))
                        {
                    MessageBox.Show("Въведете Id за търсене!");
                    textBox1.BackColor = Color.Red;
                    textBox1.Focus();
                    return;
                }
                else
                {
                    findId = int.Parse(textBox1.Text);
                }
                Dish findedDish = dishes.Get(findId);
                if (findedDish == null)
                {
                    MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!"); textBox1.BackColor = Color.Red;
                    textBox1.Focus();
                    return;
                }
                LoadRecord(findedDish);

                DialogResult answer = MessageBox.Show("Наистина ли искате да изтриете запис № " + findId + " ?",
                "PROMPT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    dishes.Delete(findId);
                }

                btnAll_Click(sender, e);
            }

        }
    }
}

