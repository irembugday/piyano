using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        
        string belge;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            belge = "68437__pinkyfinger__piano-a.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            belge = "68438__pinkyfinger__piano-b.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            belge = "68438__pinkyfinger__piano-b.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            belge = "68439__pinkyfinger__piano-bb.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            belge = "68440__pinkyfinger__piano-c.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            belge = "68441__pinkyfinger__piano-c.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            belge = "68442__pinkyfinger__piano-d.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            belge = "68443__pinkyfinger__piano-e.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            belge = "68444__pinkyfinger__piano-eb.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            belge = "68445__pinkyfinger__piano-f.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            belge = "68446__pinkyfinger__piano-f.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            belge = "68447__pinkyfinger__piano-g.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            belge = "68448__pinkyfinger__piano-g.wav";
            ses.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + belge;
            ses.Play();
        }
    }
}
