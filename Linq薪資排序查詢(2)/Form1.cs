using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq薪資排序查詢_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] Salary = new int[] { 50000, 80000, 20000, 30000, 45000 };
        

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            var result = from s in Salary
                            select s;
            int i = 0;
            foreach (var s in result)//將s中所有資料逐行顯示在richText1控制項上
            {
                i++;
                richTextBox1.Text += $"{i}. {s}\n";
            }
            richTextBox1.Text += $"平均薪資:{result.Average()}";//顯示平均
        }
        //---按遞增排序鈕執行此事件處理函示
        private void btnSortIncrease_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "遞增排序: \n";
            var result = from s in Salary //將Salary陣列所有元素遞增排序
                         orderby s ascending
                         select s;
            int i = 0;
            
            foreach (var s in result)//將s中所有資料逐行顯示在richText1控制項上
            {
                i++;
                richTextBox1.Text += $"{i}. {s}\n";
            }
            
        }
        //---按遞減排序鈕執行此事件處理函示


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSortDecrease_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "遞減排序  : \n";
            var result = from s in Salary//將Salary陣列所有元素遞減排序
                         orderby s descending
                         select s;
            int i = 0;
            foreach (var s in result)//將s中所有資料逐行顯示在ricjhTextBox1控制項上
            {
                i++;
                richTextBox1.Text += $"{i}. {s}\n";
            }
        }

       
        //---按大於30000鈕執行此事件處理函示------
        private void btnGreater30000_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "大於30000薪資:\n";
            var result = from s in Salary //將Salary陣列中薪資大於3萬元以遞減排序
                         orderby s descending
                         where s > 30000
                         select s;
            int i = 0;
            foreach (var s in result) //將s中所有資料逐行顯示在richTextBox1控制項上
            {
                i++;
                richTextBox1.Text += $"{i}. {s}\n";
            }
            richTextBox1.Text += $"共 {result.Count()} 人";//取>30000筆數

        }
        //---按小於等於於30000鈕執行此事件處理函示------

        private void btnSmaller30000_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "小於等於30000薪資: \n";
            var result = from s in Salary //將Salary陣列中薪資小於等於3萬元以遞減排序
                         orderby s descending
                         where s <= 30000
                         select s;
            int i = 0;
            foreach (var s in result)
            {
                i++;
                richTextBox1.Text += $"{i}. {s}\n";
            }
            richTextBox1.Text += $"共 {result.Count()} 人"; //取小於等於30000筆數
        }
        //-----按平均薪資鈕執行此事件處理函示------
        private void btnAvg_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e); //呼叫Form1_Load事件處理函示，兩者事件程式碼相同
        }
        

    }
}
