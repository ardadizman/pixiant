using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pixiant
{
    public partial class Form3 : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private bool iskalem;
        private bool issilgi;

        public Form3()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTopBorder_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pnlTopBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void pnlTopBorder_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel4.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel4.BackColor = Color.Gray;
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel5.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel5.BackColor = Color.White;
            }
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel11.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel11.BackColor = Color.Gray;
            }
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel10.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel10.BackColor = Color.White;
            }
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel15.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel15.BackColor = Color.Gray;
            }
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel14.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel14.BackColor = Color.White;
            }
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel6.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel6.BackColor = Color.White;
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel7.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel7.BackColor = Color.Gray;
            }
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel9.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel9.BackColor = Color.White;
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel8.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel8.BackColor = Color.Gray;
            }
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel13.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel13.BackColor = Color.White;
            }
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel12.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel12.BackColor = Color.Gray;
            }
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel21.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel21.BackColor = Color.Gray;
            }
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel19.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel19.BackColor = Color.White;
            }
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel20.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel20.BackColor = Color.Gray;
            }
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel18.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel18.BackColor = Color.White;
            }
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            if (iskalem == true)
            {
                panel17.BackColor = Color.Black;
            }
            else if (issilgi == true)
            {
                panel17.BackColor = Color.Gray;
            }
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            if(iskalem == true)
            {
                panel16.BackColor = Color.Black;
            }
            else if(issilgi == true)
            {
                panel16.BackColor = Color.White;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iskalem = true;
            issilgi = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            issilgi = true;
            iskalem = false;
        }
    }
}
