namespace Ollopa
{
    partial class MainForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Oxygen = new System.Windows.Forms.Timer(this.components);
            this.Blikačka = new System.Windows.Forms.Timer(this.components);
            this.kysliknapalubce4 = new System.Windows.Forms.PictureBox();
            this.panelydisplej = new System.Windows.Forms.PictureBox();
            this.PalubniPC4 = new System.Windows.Forms.PictureBox();
            this.charging = new System.Windows.Forms.PictureBox();
            this.Ledlight = new System.Windows.Forms.PictureBox();
            this.pressur = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tprt = new System.Windows.Forms.PictureBox();
            this.Paka1 = new System.Windows.Forms.PictureBox();
            this.Button3 = new System.Windows.Forms.PictureBox();
            this.Button2 = new System.Windows.Forms.PictureBox();
            this.Button1 = new System.Windows.Forms.PictureBox();
            this.Enginebutton = new System.Windows.Forms.PictureBox();
            this.PalubniPC2 = new System.Windows.Forms.PictureBox();
            this.PalubniPC1 = new System.Windows.Forms.PictureBox();
            this.PalubniPC3 = new System.Windows.Forms.PictureBox();
            this.Kokpit = new System.Windows.Forms.PictureBox();
            this.extended = new System.Windows.Forms.PictureBox();
            this.kyslikleft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kysliknapalubce4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelydisplej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ledlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tprt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paka1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enginebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kokpit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extended)).BeginInit();
            this.SuspendLayout();
            // 
            // Oxygen
            // 
            this.Oxygen.Interval = 1000;
            this.Oxygen.Tick += new System.EventHandler(this.Oxygen_Tick);
            // 
            // Blikačka
            // 
            this.Blikačka.Interval = 400;
            this.Blikačka.Tick += new System.EventHandler(this.Blikačka_Tick);
            // 
            // kysliknapalubce4
            // 
            this.kysliknapalubce4.Image = global::Ollopa.Properties.Resources.off;
            this.kysliknapalubce4.Location = new System.Drawing.Point(1089, 250);
            this.kysliknapalubce4.Name = "kysliknapalubce4";
            this.kysliknapalubce4.Size = new System.Drawing.Size(34, 16);
            this.kysliknapalubce4.TabIndex = 20;
            this.kysliknapalubce4.TabStop = false;
            // 
            // panelydisplej
            // 
            this.panelydisplej.Image = global::Ollopa.Properties.Resources.panely;
            this.panelydisplej.Location = new System.Drawing.Point(774, 399);
            this.panelydisplej.Name = "panelydisplej";
            this.panelydisplej.Size = new System.Drawing.Size(45, 46);
            this.panelydisplej.TabIndex = 19;
            this.panelydisplej.TabStop = false;
            // 
            // PalubniPC4
            // 
            this.PalubniPC4.BackColor = System.Drawing.Color.Black;
            this.PalubniPC4.Image = global::Ollopa.Properties.Resources.Palubnipc4_2;
            this.PalubniPC4.Location = new System.Drawing.Point(1015, 248);
            this.PalubniPC4.Name = "PalubniPC4";
            this.PalubniPC4.Size = new System.Drawing.Size(112, 117);
            this.PalubniPC4.TabIndex = 18;
            this.PalubniPC4.TabStop = false;
            // 
            // charging
            // 
            this.charging.Image = global::Ollopa.Properties.Resources.charg;
            this.charging.Location = new System.Drawing.Point(638, 266);
            this.charging.Name = "charging";
            this.charging.Size = new System.Drawing.Size(50, 17);
            this.charging.TabIndex = 17;
            this.charging.TabStop = false;
            // 
            // Ledlight
            // 
            this.Ledlight.Image = global::Ollopa.Properties.Resources.blik;
            this.Ledlight.Location = new System.Drawing.Point(924, 146);
            this.Ledlight.Name = "Ledlight";
            this.Ledlight.Size = new System.Drawing.Size(22, 22);
            this.Ledlight.TabIndex = 16;
            this.Ledlight.TabStop = false;
            // 
            // pressur
            // 
            this.pressur.BackColor = System.Drawing.Color.Black;
            this.pressur.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pressur.Image = global::Ollopa.Properties.Resources.high;
            this.pressur.Location = new System.Drawing.Point(925, 253);
            this.pressur.Name = "pressur";
            this.pressur.Size = new System.Drawing.Size(38, 16);
            this.pressur.TabIndex = 14;
            this.pressur.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Ollopa.Properties.Resources.yes;
            this.pictureBox3.Location = new System.Drawing.Point(737, 280);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(754, 280);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(770, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tprt
            // 
            this.tprt.BackColor = System.Drawing.Color.Black;
            this.tprt.Cursor = System.Windows.Forms.Cursors.Cross;
            this.tprt.Image = global::Ollopa.Properties.Resources.low;
            this.tprt.Location = new System.Drawing.Point(925, 275);
            this.tprt.Name = "tprt";
            this.tprt.Size = new System.Drawing.Size(38, 16);
            this.tprt.TabIndex = 10;
            this.tprt.TabStop = false;
            // 
            // Paka1
            // 
            this.Paka1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Paka1.Image = global::Ollopa.Properties.Resources.pakadole;
            this.Paka1.Location = new System.Drawing.Point(721, 363);
            this.Paka1.Name = "Paka1";
            this.Paka1.Size = new System.Drawing.Size(49, 82);
            this.Paka1.TabIndex = 9;
            this.Paka1.TabStop = false;
            this.Paka1.Click += new System.EventHandler(this.Paka1_Click);
            // 
            // Button3
            // 
            this.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3.Location = new System.Drawing.Point(770, 313);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(16, 16);
            this.Button3.TabIndex = 6;
            this.Button3.TabStop = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Location = new System.Drawing.Point(748, 313);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(16, 16);
            this.Button2.TabIndex = 5;
            this.Button2.TabStop = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.Location = new System.Drawing.Point(731, 313);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(16, 16);
            this.Button1.TabIndex = 4;
            this.Button1.TabStop = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Enginebutton
            // 
            this.Enginebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Enginebutton.Location = new System.Drawing.Point(439, 340);
            this.Enginebutton.Name = "Enginebutton";
            this.Enginebutton.Size = new System.Drawing.Size(18, 13);
            this.Enginebutton.TabIndex = 3;
            this.Enginebutton.TabStop = false;
            this.Enginebutton.Click += new System.EventHandler(this.Enginebutton_Click);
            // 
            // PalubniPC2
            // 
            this.PalubniPC2.BackColor = System.Drawing.Color.Black;
            this.PalubniPC2.Image = global::Ollopa.Properties.Resources.palubka2_1;
            this.PalubniPC2.Location = new System.Drawing.Point(576, 239);
            this.PalubniPC2.Name = "PalubniPC2";
            this.PalubniPC2.Size = new System.Drawing.Size(115, 115);
            this.PalubniPC2.TabIndex = 2;
            this.PalubniPC2.TabStop = false;
            // 
            // PalubniPC1
            // 
            this.PalubniPC1.BackColor = System.Drawing.Color.Black;
            this.PalubniPC1.Image = global::Ollopa.Properties.Resources.palubka1off;
            this.PalubniPC1.Location = new System.Drawing.Point(576, 389);
            this.PalubniPC1.Name = "PalubniPC1";
            this.PalubniPC1.Size = new System.Drawing.Size(115, 115);
            this.PalubniPC1.TabIndex = 1;
            this.PalubniPC1.TabStop = false;
            // 
            // PalubniPC3
            // 
            this.PalubniPC3.BackColor = System.Drawing.Color.Black;
            this.PalubniPC3.Image = global::Ollopa.Properties.Resources.palubnipc3;
            this.PalubniPC3.Location = new System.Drawing.Point(850, 244);
            this.PalubniPC3.Name = "PalubniPC3";
            this.PalubniPC3.Size = new System.Drawing.Size(125, 117);
            this.PalubniPC3.TabIndex = 8;
            this.PalubniPC3.TabStop = false;
            // 
            // Kokpit
            // 
            this.Kokpit.Image = global::Ollopa.Properties.Resources.Kokpit_finallightoff;
            this.Kokpit.Location = new System.Drawing.Point(12, 12);
            this.Kokpit.Name = "Kokpit";
            this.Kokpit.Size = new System.Drawing.Size(1235, 858);
            this.Kokpit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Kokpit.TabIndex = 0;
            this.Kokpit.TabStop = false;
            // 
            // extended
            // 
            this.extended.Image = global::Ollopa.Properties.Resources.Extended;
            this.extended.Location = new System.Drawing.Point(1077, 309);
            this.extended.Name = "extended";
            this.extended.Size = new System.Drawing.Size(51, 20);
            this.extended.TabIndex = 21;
            this.extended.TabStop = false;
            // 
            // kyslikleft
            // 
            this.kyslikleft.AutoSize = true;
            this.kyslikleft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kyslikleft.ForeColor = System.Drawing.Color.Aqua;
            this.kyslikleft.Location = new System.Drawing.Point(1082, 276);
            this.kyslikleft.Name = "kyslikleft";
            this.kyslikleft.Size = new System.Drawing.Size(0, 13);
            this.kyslikleft.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.kyslikleft);
            this.Controls.Add(this.extended);
            this.Controls.Add(this.kysliknapalubce4);
            this.Controls.Add(this.panelydisplej);
            this.Controls.Add(this.charging);
            this.Controls.Add(this.Ledlight);
            this.Controls.Add(this.pressur);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tprt);
            this.Controls.Add(this.Paka1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Enginebutton);
            this.Controls.Add(this.PalubniPC2);
            this.Controls.Add(this.PalubniPC1);
            this.Controls.Add(this.PalubniPC3);
            this.Controls.Add(this.PalubniPC4);
            this.Controls.Add(this.Kokpit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ollopa";
            ((System.ComponentModel.ISupportInitialize)(this.kysliknapalubce4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelydisplej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ledlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tprt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paka1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enginebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PalubniPC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kokpit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extended)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Kokpit;
        private System.Windows.Forms.PictureBox PalubniPC1;
        private System.Windows.Forms.PictureBox PalubniPC2;
        private System.Windows.Forms.PictureBox Enginebutton;
        private System.Windows.Forms.Timer Oxygen;
        private System.Windows.Forms.PictureBox Button1;
        private System.Windows.Forms.PictureBox Button2;
        private System.Windows.Forms.PictureBox Button3;
        private System.Windows.Forms.PictureBox PalubniPC3;
        private System.Windows.Forms.PictureBox Paka1;
        private System.Windows.Forms.PictureBox tprt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pressur;
        private System.Windows.Forms.Timer Blikačka;
        private System.Windows.Forms.PictureBox Ledlight;
        private System.Windows.Forms.PictureBox charging;
        private System.Windows.Forms.PictureBox PalubniPC4;
        private System.Windows.Forms.PictureBox panelydisplej;
        private System.Windows.Forms.PictureBox kysliknapalubce4;
        private System.Windows.Forms.PictureBox extended;
        private System.Windows.Forms.Label kyslikleft;
    }
}

