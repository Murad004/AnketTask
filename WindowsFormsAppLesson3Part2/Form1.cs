using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLesson3Part2
{
    public partial class Form1 : Form
    {
        List<Human> humans = new List<Human>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            humans.Add(new Human
            {
                Name = NameTxtBox.Text,
                Surname = SurnameTxtBox.Text,
                Mail = MailTxtBox.Text,
                PhoneNumber = PhoneNumberTxtBox.Text,
                date = dateTimePicker1.Value
            });

            NamesListBox.Items.AddRange(humans.ToArray());

            NamesListBox.DisplayMember = "Name";


            NameTxtBox.Text = String.Empty;
            SurnameTxtBox.Text = String.Empty;
            MailTxtBox.Text = String.Empty;
            PhoneNumberTxtBox.Text = String.Empty;

            //var serializer = new JsonSerializer();
            //using (var sw = new StreamWriter($"{Name}.json"))
            //{
            //    using (var jw = new JsonTextWriter(sw))
            //    {
            //        jw.Formatting = Newtonsoft.Json.Formatting.Indented;
            //        serializer.Serialize(jw, employers);
            //    }
            //}
        }







        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    List<string> names = new List<string>
        //    {
        //        "Elxan","Tural","Cavid","Murad","Fidan","Anara"
        //    };
        //    checkedListBox1.Items.AddRange(names.ToArray());
        //    comboBox1.DataSource = names;
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    foreach (var item in checkedListBox1.CheckedItems)
        //    {
        //        builder.Append($"\n{item as string}");
        //    }
        //    label1.Text = builder.ToString();
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var item = comboBox1.SelectedItem as string;
        //    label1.Text = item;
        //}
    }
}