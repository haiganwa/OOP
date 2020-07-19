using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PeopleCurRepository database = new PeopleCurRepository();

            this.dataGridView.DataSource = database.GetAll();

        }

        class PeopleCurRepository : RepositoryBase<People> { }

        class People : DomainModel
        {       //成员方法
            public void Eat(int foodsize)
            {
                HungerIndex = HungerIndex + foodsize / 2;
               
            }

            //成员变量或成员属性
            public int HungerIndex;
            //唯一标识符
            public string Name;
            public int Age;
            public bool Gender;
            public DateTime Birthday;


        }

    }
}
