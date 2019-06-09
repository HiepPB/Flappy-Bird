using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int DoChenhLechGiua2OngCong = 250;

        int x_cap1, x_cap2;

        int y_ongtren1;
        int y_ongduoi1;

        int y_ongtren2;
        int y_ongduoi2;

        int x_conchim, y_conchim;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // MessageBox.Show("Width = " + this.Width + " & Height = " + this.Height);

            x_cap1 = this.Width + 300;

           
            y_ongtren1 = -700;
            ongtren1.Size = new Size(270, 1000);
            ongtren1.Location = new Point(x_cap1, y_ongtren1);
            y_ongduoi1 = (1000 + y_ongtren1) + DoChenhLechGiua2OngCong;
            ongduoi1.Size = new Size(270, 1000);
            ongduoi1.Location = new Point(x_cap1, y_ongduoi1);
            x_cap2 = x_cap1 + ongtren1.Width + 400;        
            y_ongtren2 = -700;
            ongtren2.Size = new Size(270, 1000);
            ongtren2.Location = new Point(x_cap2, y_ongtren2);

            
            y_ongduoi2 = (1000 + y_ongtren2) + DoChenhLechGiua2OngCong;
            ongduoi2.Size = new Size(270, 1000);
            ongduoi2.Location = new Point(x_cap2, y_ongduoi2);

            conchim.Size = new Size(127, 100);
            x_conchim = conchim.Location.X;
            y_conchim = conchim.Location.Y;

            nutplay.Size = new System.Drawing.Size(50, 50);

            lblDiemSo.Location = new Point(0, this.Height - 50);          
        }
        }
}