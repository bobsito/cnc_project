using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        float getValue(string value)// conversion from string to float
        {
            if (value == "")
                return 9999;
            float ValueX = 0;
            ValueX = float.Parse(value);
            if (ValueX > 9999.9)
                return 9999;
           
            return ValueX;
        }

        string getAxis(string line, char a)
        {
            int X = 0, Y = 0, Z = 0;
            string x = "";
            string y = "";
            for(int j=0;j<line.Length;j++)
            {
                if (line[j] == '.')
                {
                    y += ',';
                    continue;
                }
                if (line[j] == ';')
                {
                    y += ' ';
                    continue;
                }
                y += line[j];

            }
            

            int Size = y.Length;
            for (int i = 0; i < Size; i++)
            {
               

                if (y[i] == 'X')
                {
                    X = 1;
                    Y = 0;
                    Z = 0;
                }
                if (y[i] == 'Y')
                {
                    X = 0;
                    Y = 1;
                    Z = 0;
                }
                if (y[i] == 'Z')
                {
                    X = 0;
                    Y = 0;
                    Z = 1;
                }
                switch (a)
                {
                    case 'X':
                        if (X == 1 && y[i] != a)
                        {
                           
                            x += y[i];
                           
                        }
                       
                            break;
                        
                    case 'Y':
                        if (Y == 1 && y[i] != a)
                        {
                                x += y[i];

                        }
                       
                        break;
                    case 'Z':
                        if (Z == 1 && y[i] != a)
                        { 
                           
                           
                                x += line[i];

                        }
                      
                        break;



                }
            }


            return x;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
               
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {

            Color a = Color.Red;
            CloseButton.BackColor = a;
            RunButton.BackColor = Color.LawnGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = default(Color);

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Color a = Color.Chocolate;
            RunButton.BackColor = a;
            CloseButton.BackColor = default(Color);
        }
       

        private void button1_MouseLeave_1(object sender, EventArgs e)
        {
            RunButton.BackColor =Color.LawnGreen;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label15.Text = panel3.Width.ToString();
            label16.Text = panel3.Height.ToString();
            if (panel3.Visible == false)
            {
                panel3.Visible = true;
                richTextBox1.Visible = false;
                label15.Visible = true;
                label16.Visible = true;
            }
            else
            {
                richTextBox1.Visible = true;
                panel3.Visible = false;
                label15.Visible = false;
                label16.Visible = false;
            }
            panel4.BackColor = Color.Aqua;
            panel7.BackColor = default(Color);
            panel5.BackColor = default(Color);
            panel6.BackColor = default(Color);
            panel8.BackColor = default(Color);
            SettingPanel.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            panel3.Visible = false;
            label15.Visible=false;
            label16.Visible = false;
            openFileDialog1.ShowDialog();
            panel7.BackColor = Color.Aqua;
            panel4.BackColor = default(Color);
            panel5.BackColor = default(Color);
            panel6.BackColor = default(Color);
            panel8.BackColor = default(Color);
            SettingPanel.Visible = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            panel6.BackColor = Color.Aqua;
            panel4.BackColor = default(Color);
            panel5.BackColor = default(Color);
            panel7.BackColor = default(Color);
            panel8.BackColor = default(Color);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            panel3.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            panel4.BackColor = default(Color);
            panel7.BackColor = default(Color);
            panel6.BackColor = default(Color);
            panel8.BackColor = default(Color);
            SettingPanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            panel8.BackColor = Color.Aqua;
            panel4.BackColor = default(Color);
            panel5.BackColor = default(Color);
            panel6.BackColor = default(Color);
            panel7.BackColor = default(Color);
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(p>99)
            {
                timer1.Enabled = false;
                return ;
            }
            p++;
            circularProgressBar2.Value=p;
            circularProgressBar2.Text = p.ToString();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            timer2.Enabled = false;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int x = panel3.Width;
            int y = panel3.Height;
            Pen redPen = new Pen(Color.Red, 4);
            e.Graphics.DrawLine(redPen, 0, y - 1, 4, y - 1);
            e.Graphics.DrawLine(redPen, 0, y, 0, y - 4); 
            e.Graphics.DrawLine(redPen, 0, y - 4, 4, y -4);
            e.Graphics.DrawLine(redPen, 4, y, 4, y - 4);
            redPen.Dispose();
            Pen yellowPen = new Pen(Color.YellowGreen, 2);
            e.Graphics.DrawLine(yellowPen, 0, 0, x, 0);
            e.Graphics.DrawLine(yellowPen, 0, 0, 0, y);
            e.Graphics.DrawLine(yellowPen, 0, y, x, y);
            e.Graphics.DrawLine(yellowPen, x, y, x, 0);
            yellowPen.Dispose();

            for (int j = 0; j < (licznik-1); ++j)
            {

                Pen bluePen = new Pen(Color.Aqua, 1);
                e.Graphics.DrawLine(bluePen, tabx[j], 200-taby[j], tabx[j+1], 200-taby[j+1]);
                bluePen.Dispose();
            }
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }


        float[] tabx = new float[1000];
        float[] taby = new float[1000];
        int licznik = 0;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var sp = new StreamReader(openFileDialog1.FileName);
           
            foreach (string line in File.ReadLines(openFileDialog1.FileName))
            {
                if (line != String.Empty) ++licznik;
            }
            float x = 0;
            float y = 0;
            string axisX;
            string axisY;

            for (int i = 0; i < licznik; i++)
            {
                string linia = sp.ReadLine();
                axisX = getAxis(linia, 'X');
                axisY = getAxis(linia, 'Y');
               
                    
                if (axisX == "" && i==0 )
                 {
                   tabx[i] = 0;
                 }
                if (axisY == "" && i == 0)
                {
                   taby[i] = 0;
                }
                if (axisX == "" && i != 0)
                {
                    tabx[i] = tabx[i - 1];                    
                }
                if (axisY == "" && i != 0)
                {
                    taby[i] = taby[i - 1];   
                }
                if(axisY!="")
                {
                    y = getValue(axisY);
                    taby[i] = y/2;
                }
                if (axisX != "")
                {
                    x = getValue(axisX);
                    tabx[i] = x/2;
                }
               
            }
            var sr = new StreamReader(openFileDialog1.FileName);
            SetText(sr.ReadToEnd());
            panel3.Refresh();


        }
        private void SetText(string text)
        {
            richTextBox1.Text = text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string abc = "X234.34Y342.45Z34.23";
            string x = getAxis(abc,'X');
            
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            panel3.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            panel5.BackColor = Color.Aqua;
            panel4.BackColor = default(Color);
            panel7.BackColor = default(Color);
            panel8.BackColor = default(Color);
            panel6.BackColor = default(Color);
            SettingPanel.Visible = true;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string PortName = comboBox1.SelectedItem.ToString();
            serialPort1.PortName = PortName;
            label18.Text = PortName;
        }
    }
}
