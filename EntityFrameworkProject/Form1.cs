using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkProject
{
    public partial class Form1 : Form
    {
        AppDbContext _context;
        public Form1()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _context.Students.ToList();
           //var users =  _context.Users.ToList();
           //var student =  _context.Students.ToList();
        }
    }
}
