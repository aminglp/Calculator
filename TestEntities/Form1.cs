using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestEntities.Core.Repository.Interfaces;
using TestEntities.Core.Repository.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestEntities
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private IUser _user=new UserService();


        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _user.GetAllUser();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // label1.Text = _user.GetUserById(2).UserName;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                UserName = "ali",
                FullName = "mamad",
                Email = "amks@gmail.com",
                ParentId = 2
            };
            _user.AddUSer(user);
            MessageBox.Show ( "sabt shod");
            dataGridView1.DataSource = _user.GetAllUser();

        }

        private void Update_Click(object sender, EventArgs e)
        {
            User user=_user.GetUserById(2);
            user.UserName = "qweqsd";
             user.FullName = "mafsdasd";
            user.Email = "amks@gmail.com";
            MessageBox.Show("update shod");
            dataGridView1.DataSource = _user.GetAllUser();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            User user = _user.GetUserById(2);
            _user.Delete(user);
            MessageBox.Show("delete shod");
            dataGridView1.DataSource = _user.GetAllUser(); 
        }

        private void showParents_Click(object sender, EventArgs e)
        {
            label2.Text = _user.GetParentNameByUser(2);
        }

        private void showparntuser_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = _user.GetParentNameByUser(2).ToList();
        }
    }
}
