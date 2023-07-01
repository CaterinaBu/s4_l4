using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace s4_l4
{
    public partial class _Default : Page
    {
        public List<DiaryProduct> DiaryProducts = new List<DiaryProduct>();
        public void addProduct(DiaryProduct diary)
        {
            diary.Name = TextBox1.Text;
            string temp = TextBox2.Text;
            diary.VendorCode = Convert.ToDecimal(temp);
            temp=TextBox3.Text;
            diary.Price = Convert.ToDecimal(temp);
            diary.date[0] = Calendar1.SelectedDate;
            diary.date[1] = Calendar2.SelectedDate;
            ListBox1.Items.Add(diary.Name);
        }

        //Добавление элемента
        public void Button1_click(object sender, EventArgs e)
        {
            DiaryProduct diary = new DiaryProduct("", 1, 1, DateTime.Today, DateTime.Today);
            addProduct(diary);
            DiaryProducts.Add(diary);
        }

        //Редактирование элемента
        public void Button2_click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != 0)
            {
                Edit(DiaryProducts[ListBox1.SelectedIndex], ListBox1.SelectedIndex);
            }
        }

        public void Edit(DiaryProduct diary, int itemIndex)
        {
            ListBox1.Items.RemoveAt(itemIndex);

            diary.Name = TextBox1.Text;
            string temp = TextBox2.Text;
            diary.VendorCode = Convert.ToDecimal(temp);
            temp = TextBox3.Text;
            diary.Price = Convert.ToDecimal(temp);
            diary.date[0] = Calendar1.SelectedDate;
            diary.date[1] = Calendar2.SelectedDate;
            DiaryProducts[itemIndex] = diary;
            ListBox1.Items.Insert(itemIndex, diary.Name);
        }

        //Удаление элемента
        public void Button3_click(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex != 0)
            {
                Del(ListBox1.SelectedIndex);
            }
        }
        public void Del(int index)
        {
            DiaryProducts.RemoveAt(index);
            ListBox1.Items.RemoveAt(index);
        }
    }
}