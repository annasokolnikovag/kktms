namespace _33.BMI_калькулятор
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.height = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.trackBarBMI = new System.Windows.Forms.TrackBar();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonOtmena = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonBMI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWoman = new System.Windows.Forms.PictureBox();
            this.pictureBoxMan = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).BeginInit();
            this.SuspendLayout();
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height.Location = new System.Drawing.Point(42, 326);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(63, 25);
            this.height.TabIndex = 0;
            this.height.Text = "Рост:";
            this.height.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight.Location = new System.Drawing.Point(42, 374);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(51, 25);
            this.weight.TabIndex = 1;
            this.weight.Text = "Вес:";
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBMI.Location = new System.Drawing.Point(438, 326);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(60, 25);
            this.labelBMI.TabIndex = 7;
            this.labelBMI.Text = "ИМТ:";
            // 
            // trackBarBMI
            // 
            this.trackBarBMI.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarBMI.LargeChange = 0;
            this.trackBarBMI.Location = new System.Drawing.Point(387, 398);
            this.trackBarBMI.Maximum = 50;
            this.trackBarBMI.Minimum = 14;
            this.trackBarBMI.Name = "trackBarBMI";
            this.trackBarBMI.Size = new System.Drawing.Size(442, 69);
            this.trackBarBMI.TabIndex = 11;
            this.trackBarBMI.TabStop = false;
            this.trackBarBMI.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBMI.Value = 18;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalculate.Location = new System.Drawing.Point(39, 432);
            this.buttonCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(112, 35);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonOtmena
            // 
            this.buttonOtmena.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonOtmena.Location = new System.Drawing.Point(174, 432);
            this.buttonOtmena.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOtmena.Name = "buttonOtmena";
            this.buttonOtmena.Size = new System.Drawing.Size(112, 35);
            this.buttonOtmena.TabIndex = 13;
            this.buttonOtmena.Text = "Отмена";
            this.buttonOtmena.UseVisualStyleBackColor = false;
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHeight.Location = new System.Drawing.Point(128, 325);
            this.textBoxHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(148, 28);
            this.textBoxHeight.TabIndex = 14;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeight.Location = new System.Drawing.Point(128, 372);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(148, 28);
            this.textBoxWeight.TabIndex = 15;
            // 
            // buttonBMI
            // 
            this.buttonBMI.Location = new System.Drawing.Point(507, 322);
            this.buttonBMI.Name = "buttonBMI";
            this.buttonBMI.Size = new System.Drawing.Size(243, 35);
            this.buttonBMI.TabIndex = 10;
            this.buttonBMI.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_33.BMI_калькулятор.Properties.Resources.шкала;
            this.pictureBox1.Location = new System.Drawing.Point(387, 432);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxWoman
            // 
            this.pictureBoxWoman.Image = global::_33.BMI_калькулятор.Properties.Resources._1200px_Toilet_women_svg;
            this.pictureBoxWoman.Location = new System.Drawing.Point(174, 52);
            this.pictureBoxWoman.Name = "pictureBoxWoman";
            this.pictureBoxWoman.Size = new System.Drawing.Size(128, 222);
            this.pictureBoxWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWoman.TabIndex = 5;
            this.pictureBoxWoman.TabStop = false;
            // 
            // pictureBoxMan
            // 
            this.pictureBoxMan.Image = global::_33.BMI_калькулятор.Properties.Resources.man_toilet_icon;
            this.pictureBoxMan.Location = new System.Drawing.Point(39, 52);
            this.pictureBoxMan.Name = "pictureBoxMan";
            this.pictureBoxMan.Size = new System.Drawing.Size(93, 222);
            this.pictureBoxMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMan.TabIndex = 4;
            this.pictureBoxMan.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = global::_33.BMI_калькулятор.Properties.Resources.man_toilet_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(418, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 222);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.BackgroundImage = global::_33.BMI_калькулятор.Properties.Resources._1200px_Toilet_women_svg;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(561, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 222);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 525);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonOtmena);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.trackBarBMI);
            this.Controls.Add(this.buttonBMI);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.pictureBoxWoman);
            this.Controls.Add(this.pictureBoxMan);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.PictureBox pictureBoxMan;
        private System.Windows.Forms.PictureBox pictureBoxWoman;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.TrackBar trackBarBMI;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonOtmena;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonBMI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

