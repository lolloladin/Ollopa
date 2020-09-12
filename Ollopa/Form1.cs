using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Ollopa
{
    
    public partial class MainForm : Form
    {
        int power;
        int paka;
        int pressure;
        int temperature;
        int pr1;
        int pr2;
        bool blikanec;
        bool blikej;
        int alarm;
        int alarm2;
        int counter;
        int kyslik;
        int stopka = 0;

        SoundPlayer splayer = new SoundPlayer(Properties.Resources.S1);
        SoundPlayer splayer2 = new SoundPlayer(Properties.Resources.S2);
        SoundPlayer splayer3 = new SoundPlayer(Properties.Resources.S3);
        SoundPlayer splayer4 = new SoundPlayer(Properties.Resources.S4);
        SoundPlayer splayer5 = new SoundPlayer(Properties.Resources.S5);
        SoundPlayer splayer6 = new SoundPlayer(Properties.Resources.S6);


        public MainForm()
        {
            InitializeComponent();

            kyslik = 30;
            power = 0;
            Kokpit.Image = Properties.Resources.Kokpit_finallightoff2;
            PalubniPC1.Image = Properties.Resources.palubka1off;
            PalubniPC2.Visible = false;
            Enginebutton.Image = Properties.Resources.enginebutton;
            Button1.Visible = false;
            Button2.Visible = false;
            Button3.Visible = false;
            Paka1.Visible = false;
            PalubniPC3.Visible = false;
            tprt.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pressur.Visible = false;
            Ledlight.Visible = false;
            Ledlight.Image = Properties.Resources.blik;
            charging.Image = Properties.Resources.charg;
            charging.Visible = false;
            panelydisplej.Image = Properties.Resources.panely;
            panelydisplej.Visible = false;
            kysliknapalubce4.Image = Properties.Resources.off;
            kysliknapalubce4.Visible = false;
            PalubniPC4.Visible = false;
            PalubniPC4.Image = Properties.Resources.Palubnipc4_2;
            extended.Image = Properties.Resources.Extended;
            extended.Visible = false;
            kyslikleft.Visible = false;
            blikej = false;

            splayer.PlayLooping();


            /*System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer() { Interval = 100, Enabled = true };
            timer.Tick += new EventHandler(Blikačka_Tick);

            System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer() { Interval = 1000, Enabled = true };
            timer2.Tick += new EventHandler(Oxygen_Tick);*/

        }
        

        private void Enginebutton_Click(object sender, EventArgs e)
        {
            power = 1;
            paka = 0;
            pressure = 0;
            temperature = 0;
            pr1 = 0;
            pr2 = 0;
            blikanec = false;
            alarm = 0;
            alarm2 = 0;
            counter = 0;


            Task.Run(() =>
            {
                splayer2.Play();
                Thread.Sleep(100);
                splayer3.PlayLooping();
            });

            Kokpit.Image = Properties.Resources.Kokpit_final;
            PalubniPC1.Image = Properties.Resources.palubka1;
            PalubniPC2.Visible = true;
            PalubniPC2.Image = Properties.Resources.palubka2_1;
            Paka1.Image = Properties.Resources.pakadole;
            Paka1.Visible = true;
            Enginebutton.Image = Properties.Resources.enginebutton;
            Enginebutton.Visible = false;
            PalubniPC3.Visible = true;
            PalubniPC3.Image = Properties.Resources.palubnipc3;
            
            tprt.Visible = true;
            tprt.Image = Properties.Resources.low;


            Button1.Image = Properties.Resources.Kokpit_final___kopie;
            Button2.Image = Properties.Resources.Kokpit_final___kopie;
            Button3.Image = Properties.Resources.Kokpit_final___kopie;
            Button1.Visible = true;
            Button2.Visible = true;
            Button3.Visible = true;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox1.Image = Properties.Resources.no;
            pictureBox2.Image = Properties.Resources.no;
            pictureBox3.Image = Properties.Resources.no;
            pressur.Visible = true;
            pressur.Image = Properties.Resources.low;
            kysliknapalubce4.Visible = true;
            PalubniPC4.Visible = true;
            kyslikleft.Visible = true;


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            splayer2.Play();
            Thread.Sleep(80);
            splayer3.PlayLooping();
            if (pr1 == 0)
            {

                pressure ++;
                pictureBox3.Image = Properties.Resources.yes;
                pr1 = 1;
            }
            else if (pr1==1)
            {

                pressure --;                              
                pictureBox3.Image = Properties.Resources.no;
                pr1 = 0;
            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }

            if (pressure == 0)
            {
                pressur.Visible = true;
                pressur.Image = Properties.Resources.low;
               
            }
            else if (pressure == 1)
            {
                pressur.Visible = false;
               
            }
            else if (pressure == 2)
            {
                pressur.Visible = true;
                pressur.Image = Properties.Resources.high;
                

            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            splayer2.Play();
            Thread.Sleep(80);
            splayer3.PlayLooping();
            if (pr2 == 0)
            {

                pressure++;
                pictureBox2.Image = Properties.Resources.yes;
                pr2 = 1;
            }
            else if (pr2 == 1)
            {

                pressure--;
                pictureBox2.Image = Properties.Resources.no;
                pr2 = 0;
            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }
            if (pressure == 0)
            {
                pressur.Visible = true;
                pressur.Image = Properties.Resources.low;
               
            }
            else if (pressure == 1)
            {
                pressur.Visible = false;
                
            }
            else if (pressure == 2)
            {
                pressur.Visible = true;
                pressur.Image = Properties.Resources.high;
                
            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            splayer2.Play();
            Thread.Sleep(80);
            splayer3.PlayLooping();
            if (temperature == 0)
            {
             
                temperature = 1;
                tprt.Visible = false;
                pictureBox1.Image = Properties.Resources.yes;
            }
            else if (temperature == 1)
            {
               
                temperature = 0;
                tprt.Image = Properties.Resources.low;
                tprt.Visible = true;
                pictureBox1.Image = Properties.Resources.no;
            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }

        }

       

        private void Paka1_Click(object sender, EventArgs e)
        {
            if (paka == 0)
            {
                Paka1.Image = Properties.Resources.pakanahore;
                paka = 1;
               
                charging.Visible = true;
                panelydisplej.Visible = true;
                extended.Visible = true;
            }
            else if (paka == 1)
            {
                Paka1.Image = Properties.Resources.pakadole;
                paka = 0;
                charging.Visible = false;
                panelydisplej.Visible = false;
                extended.Visible = false;

            }
            else
            {
                MessageBox.Show("ERROR", "ERROR");
            }
        }
        
        private void Blikačka_Tick(object sender, EventArgs e)
        {
            if (pressure == 2)
            {
                if (alarm == 0)
                {
                    splayer5.Play();
                    alarm = 1;
                    counter = 0;
                }

                counter++;

                blikej = true;
            }
            else
            {
                if (alarm == 1)
                {
                    splayer3.PlayLooping();
                }
                alarm = 0;
                Ledlight.Visible = false;                
                counter = 0;

                //blikej = false; // ASI, zkontroluj
            }
            if (counter == 24)
            {
                splayer6.PlaySync();
                Kokpit.Image = Properties.Resources.Kokpit1;
                PalubniPC1.Image = Properties.Resources.palubka1off;
                PalubniPC2.Visible = false;
                Enginebutton.Image = Properties.Resources.enginebutton;
                Button1.Visible = false;
                Button2.Visible = false;
                Button3.Visible = false;
                Paka1.Visible = false;
                PalubniPC3.Visible = false;
                tprt.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pressur.Visible = false;
                charging.Visible = false;
                panelydisplej.Visible = false;
                blikej = false;
                Ledlight.Visible = false;

                MessageBox.Show("Konec hry: Loď explodovala, kvůli vysokému tlaku","Konec");
                Application.Exit();
            }
        }

        private void Oxygen_Tick(object sender, EventArgs e)
        {
            blikej = kyslik < 16 && kyslik < 0;
            
            
            if (kyslik == 0 && stopka ==0)
            {
                stopka = 1;
                splayer3.Stop();
                kyslikleft.Visible = false;
                MessageBox.Show("Konec hry: Udusil jsi se, kvůli nedostatku kyslíku", "Konec");
                Application.Exit();
                
            }
            else
            {
                if(stopka != 1)
                {
                    kyslik--;
                    kyslikleft.Text = $"{kyslik / 3} %";
                }
                else
                {
                    kyslikleft.Text = "0 %";
                }
                               
            }
        }

        private void Blinker_Tick(object sender, EventArgs e)
        {
            if (blikej)
            {
                blikanec = !blikanec;
                Ledlight.Visible = blikanec;
            }
            else
            {
                Ledlight.Visible = false;
            }
        }
    }
}
