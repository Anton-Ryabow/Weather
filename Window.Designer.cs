namespace Weather
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            labelCurrent = new Label();
            labelTime = new Label();
            pictureBox = new PictureBox();
            labelTemp = new Label();
            labelFeelslike = new Label();
            labelDesc = new Label();
            labelWind = new Label();
            labelWindValue = new Label();
            labelHumidityValue = new Label();
            labelHumidity = new Label();
            labelPrecipValue = new Label();
            labelPrecip = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // labelCurrent
            // 
            labelCurrent.AutoSize = true;
            labelCurrent.Font = new Font("Microsoft Tai Le", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelCurrent.Location = new Point(55, 38);
            labelCurrent.Name = "labelCurrent";
            labelCurrent.Size = new Size(201, 30);
            labelCurrent.TabIndex = 0;
            labelCurrent.Text = "Текущая погода";
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ForeColor = SystemColors.WindowFrame;
            labelTime.Location = new Point(60, 79);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(52, 21);
            labelTime.TabIndex = 1;
            labelTime.Text = "label2";
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(55, 127);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(100, 93);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // labelTemp
            // 
            labelTemp.AutoSize = true;
            labelTemp.Font = new Font("Microsoft Tai Le", 42F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemp.Location = new Point(157, 142);
            labelTemp.Name = "labelTemp";
            labelTemp.Size = new Size(145, 71);
            labelTemp.TabIndex = 3;
            labelTemp.Text = "11 С";
            // 
            // labelFeelslike
            // 
            labelFeelslike.AutoSize = true;
            labelFeelslike.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFeelslike.ForeColor = SystemColors.ControlDarkDark;
            labelFeelslike.Location = new Point(359, 181);
            labelFeelslike.Name = "labelFeelslike";
            labelFeelslike.Size = new Size(52, 21);
            labelFeelslike.TabIndex = 4;
            labelFeelslike.Text = "label4";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelDesc.Location = new Point(359, 151);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(52, 21);
            labelDesc.TabIndex = 5;
            labelDesc.Text = "label5";
            // 
            // labelWind
            // 
            labelWind.AutoSize = true;
            labelWind.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelWind.Location = new Point(66, 290);
            labelWind.Name = "labelWind";
            labelWind.Size = new Size(62, 23);
            labelWind.TabIndex = 6;
            labelWind.Text = "Ветер";
            // 
            // labelWindValue
            // 
            labelWindValue.AutoSize = true;
            labelWindValue.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelWindValue.ForeColor = SystemColors.ControlDarkDark;
            labelWindValue.Location = new Point(68, 328);
            labelWindValue.Name = "labelWindValue";
            labelWindValue.Size = new Size(52, 21);
            labelWindValue.TabIndex = 7;
            labelWindValue.Text = "label7";
            // 
            // labelHumidityValue
            // 
            labelHumidityValue.AutoSize = true;
            labelHumidityValue.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHumidityValue.ForeColor = SystemColors.ControlDarkDark;
            labelHumidityValue.Location = new Point(196, 328);
            labelHumidityValue.Name = "labelHumidityValue";
            labelHumidityValue.Size = new Size(52, 21);
            labelHumidityValue.TabIndex = 9;
            labelHumidityValue.Text = "label8";
            // 
            // labelHumidity
            // 
            labelHumidity.AutoSize = true;
            labelHumidity.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelHumidity.Location = new Point(194, 290);
            labelHumidity.Name = "labelHumidity";
            labelHumidity.Size = new Size(103, 23);
            labelHumidity.TabIndex = 8;
            labelHumidity.Text = "Влажность";
            // 
            // labelPrecipValue
            // 
            labelPrecipValue.AutoSize = true;
            labelPrecipValue.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrecipValue.ForeColor = SystemColors.ControlDarkDark;
            labelPrecipValue.Location = new Point(340, 328);
            labelPrecipValue.Name = "labelPrecipValue";
            labelPrecipValue.Size = new Size(61, 21);
            labelPrecipValue.TabIndex = 11;
            labelPrecipValue.Text = "label10";
            // 
            // labelPrecip
            // 
            labelPrecip.AutoSize = true;
            labelPrecip.Font = new Font("Microsoft Tai Le", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrecip.Location = new Point(338, 290);
            labelPrecip.Name = "labelPrecip";
            labelPrecip.Size = new Size(73, 23);
            labelPrecip.TabIndex = 10;
            labelPrecip.Text = "Осадки";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrecipValue);
            Controls.Add(labelPrecip);
            Controls.Add(labelHumidityValue);
            Controls.Add(labelHumidity);
            Controls.Add(labelWindValue);
            Controls.Add(labelWind);
            Controls.Add(labelDesc);
            Controls.Add(labelFeelslike);
            Controls.Add(labelTemp);
            Controls.Add(pictureBox);
            Controls.Add(labelTime);
            Controls.Add(labelCurrent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Window";
            Text = "Погода";
            Load += Window_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCurrent;
        private Label labelTime;
        private PictureBox pictureBox;
        private Label labelTemp;
        private Label labelFeelslike;
        private Label labelDesc;
        private Label labelWind;
        private Label labelWindValue;
        private Label labelHumidityValue;
        private Label labelHumidity;
        private Label labelPrecipValue;
        private Label labelPrecip;
    }
}