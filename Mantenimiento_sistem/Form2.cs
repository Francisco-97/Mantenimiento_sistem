using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Mantenimiento_sistem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;


        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;

        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Barra_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void SubM_despegable_Paint(object sender, PaintEventArgs e)
        {
            SubM_despegable.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SubM_despegable.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SubM_despegable.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SubM_despegable.Visible = true;

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            /*Menu_p1 p1 = new Menu_p1();
            p1.Show();
            Hide();
            */
            Application.Exit();

        }
        private void abrirfomulario(object formulario)
        {

            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fc = formulario as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fc);
            this.Contenedor.Tag=fc;
            fc.Show();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            abrirfomulario(new Form3());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Fecha y Hora 
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToShortDateString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrirfomulario(new Form4());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            abrirfomulario(new Form5());
        }
    }

    }

