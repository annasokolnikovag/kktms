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
            this.buttonHeight = new System.Windows.Forms.Button();
            this.buttonWeight = new System.Windows.Forms.Button();
            this.pictureBoxWoman = new System.Windows.Forms.PictureBox();
            this.pictureBoxMan = new System.Windows.Forms.PictureBox();
            this.labelBMI = new System.Windows.Forms.Label();
            this.buttonBMI = new System.Windows.Forms.Button();
            this.trackBarBMI = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).BeginInit();
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
            this.weight.Location = new System.Drawing.Point(42, 375);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(51, 25);
            this.weight.TabIndex = 1;
            this.weight.Text = "Вес:";
            // 
            // buttonHeight
            // 
            this.buttonHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHeight.Location = new System.Drawing.Point(127, 321);
            this.buttonHeight.Name = "buttonHeight";
            this.buttonHeight.Size = new System.Drawing.Size(90, 34);
            this.buttonHeight.TabIndex = 2;
            this.buttonHeight.UseVisualStyleBackColor = true;
            // 
            // buttonWeight
            // 
            this.buttonWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWeight.Location = new System.Drawing.Point(127, 370);
            this.buttonWeight.Name = "buttonWeight";
            this.buttonWeight.Size = new System.Drawing.Size(90, 34);
            this.buttonWeight.TabIndex = 3;
            this.buttonWeight.UseVisualStyleBackColor = true;
            // 
            // pictureBoxWoman
            // 
            this.pictureBoxWoman.Image = global::_33.BMI_калькулятор.Properties.Resources._1200px_Toilet_women_svg;
            this.pictureBoxWoman.Location = new System.Drawing.Point(196, 52);
            this.pictureBoxWoman.Name = "pictureBoxWoman";
            this.pictureBoxWoman.Size = new System.Drawing.Size(128, 222);
            this.pictureBoxWoman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWoman.TabIndex = 5;
            this.pictureBoxWoman.TabStop = false;
            // 
            // pictureBoxMan
            // 
            this.pictureBoxMan.Image = global::_33.BMI_калькулятор.Properties.Resources.man_toilet_icon;
            this.pictureBoxMan.Location = new System.Drawing.Point(59, 52);
            this.pictureBoxMan.Name = "pictureBoxMan";
            this.pictureBoxMan.Size = new System.Drawing.Size(93, 222);
            this.pictureBoxMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMan.TabIndex = 4;
            this.pictureBoxMan.TabStop = false;
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBMI.Location = new System.Drawing.Point(419, 249);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(60, 25);
            this.labelBMI.TabIndex = 7;
            this.labelBMI.Text = "ИМТ:";
            // 
            // buttonBMI
            // 
            this.buttonBMI.Location = new System.Drawing.Point(485, 245);
            this.buttonBMI.Name = "buttonBMI";
            this.buttonBMI.Size = new System.Drawing.Size(243, 36);
            this.buttonBMI.TabIndex = 10;
            this.buttonBMI.UseVisualStyleBackColor = true;
            // 
            // trackBarBMI
            // 
            this.trackBarBMI.Location = new System.Drawing.Point(377, 331);
            this.trackBarBMI.Maximum = 30;
            this.trackBarBMI.Minimum = 18;
            this.trackBarBMI.Name = "trackBarBMI";
            this.trackBarBMI.Size = new System.Drawing.Size(351, 69);
            this.trackBarBMI.TabIndex = 11;
            this.trackBarBMI.Value = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trackBarBMI);
            this.Controls.Add(this.buttonBMI);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.pictureBoxWoman);
            this.Controls.Add(this.pictureBoxMan);
            this.Controls.Add(this.buttonWeight);
            this.Controls.Add(this.buttonHeight);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWoman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBMI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Button buttonHeight;
        private System.Windows.Forms.Button buttonWeight;
        private System.Windows.Forms.PictureBox pictureBoxMan;
        private System.Windows.Forms.PictureBox pictureBoxWoman;
        private System.Windows.Forms.Label labelBMI;
        private System.Windows.Forms.Button buttonBMI;
        private System.Windows.Forms.TrackBar trackBarBMI;
    }
}

