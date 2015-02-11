using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCISHandBook
{
    public partial class Form1 : Form
    {
       

        /*speech bubble*/
        Label[] labels = new Label[100];
        int ctr = 0;
        int ptX = 0;
        int ptY = 0;
        //Image sb_input = Image.FromFile(@"C:/Users/Conrad1/Documents/Visual Studio 2013/Projects/CCISHandBook/CCISHandBook/" + "input.png");
        //Image sb_output = Image.FromFile(@"C:/Users/Conrad1/Documents/Visual Studio 2013/Projects/CCISHandBook/CCISHandBook/" + "out.png");
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatBotProcess chatbot = new ChatBotProcess();
            inSpeech(textBox1.Text);
            Thread.Sleep(2000);
            outSpeech(chatbot.ChatBotAnswer(textBox1.Text));
            textBox1.Text = "";
            //ScrollToBottom(panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inSpeech(string input)
        {
            labels[ctr] = new Label();
            labels[ctr].Size = new Size(300, 100);
            labels[ctr].Image = Properties.Resources._in;
            labels[ctr].ImageAlign = ContentAlignment.TopLeft;
            labels[ctr].TextAlign = ContentAlignment.MiddleCenter;
            labels[ctr].Text = input;
            labels[ctr].ForeColor = Color.White;
            labels[ctr].BackColor = Color.Transparent;
            labels[ctr].Location = new Point(ptX, ptY);
            panel1.Controls.Add(labels[ctr]);
            ctr++;
            ptX = 100;
            ptY += 100;
            panel1.Refresh();
        }

        private void outSpeech(string output)
        {
            labels[ctr] = new Label();
            labels[ctr].Size = new Size(300, 100);
            labels[ctr].Image = Properties.Resources._out;
            labels[ctr].ImageAlign = ContentAlignment.TopLeft;
            labels[ctr].TextAlign = ContentAlignment.MiddleCenter;
            labels[ctr].Text = output;
            labels[ctr].ForeColor = Color.White;
            labels[ctr].BackColor = Color.Transparent;
            labels[ctr].Location = new Point(ptX, ptY);
            panel1.Controls.Add(labels[ctr]);
            ctr++;
            ptX -= 100;
            ptY += 100;
            panel1.Refresh();
        }

        public void ScrollToBottom(Panel p)
        {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Bottom })
            {
                p.ScrollControlIntoView(c);
                c.Parent = null;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                ChatBotProcess chatbot = new ChatBotProcess();
                inSpeech(textBox1.Text);
                Thread.Sleep(2000);
                outSpeech(chatbot.ChatBotAnswer(textBox1.Text));
                textBox1.Text = "";

            }
        }
    }
}
