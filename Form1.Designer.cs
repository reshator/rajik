namespace sred
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.twosBox = new System.Windows.Forms.TextBox();
            this.two = new System.Windows.Forms.Label();
            this.threesBox = new System.Windows.Forms.TextBox();
            this.foursBox = new System.Windows.Forms.TextBox();
            this.three = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.Label();
            this.fives = new System.Windows.Forms.Label();
            this.fivesBox = new System.Windows.Forms.TextBox();
            this.calcButton = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.twosBox);
            this.panel1.Controls.Add(this.two);
            this.panel1.Controls.Add(this.threesBox);
            this.panel1.Controls.Add(this.foursBox);
            this.panel1.Controls.Add(this.three);
            this.panel1.Controls.Add(this.four);
            this.panel1.Controls.Add(this.fives);
            this.panel1.Controls.Add(this.fivesBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 418);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(472, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Округлить до";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "6",
            "8"});
            this.comboBox1.Location = new System.Drawing.Point(596, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "2";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // twosBox
            // 
            this.twosBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.twosBox.BackColor = System.Drawing.Color.Ivory;
            this.twosBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twosBox.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.twosBox.Location = new System.Drawing.Point(273, 243);
            this.twosBox.Name = "twosBox";
            this.twosBox.Size = new System.Drawing.Size(293, 37);
            this.twosBox.TabIndex = 7;
            // 
            // two
            // 
            this.two.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.two.AutoSize = true;
            this.two.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.two.Location = new System.Drawing.Point(90, 243);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(115, 33);
            this.two.TabIndex = 6;
            this.two.Text = "Двойки";
            // 
            // threesBox
            // 
            this.threesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threesBox.BackColor = System.Drawing.Color.Ivory;
            this.threesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.threesBox.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.threesBox.Location = new System.Drawing.Point(273, 180);
            this.threesBox.Name = "threesBox";
            this.threesBox.Size = new System.Drawing.Size(293, 37);
            this.threesBox.TabIndex = 5;
            // 
            // foursBox
            // 
            this.foursBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.foursBox.BackColor = System.Drawing.Color.Ivory;
            this.foursBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.foursBox.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foursBox.Location = new System.Drawing.Point(273, 117);
            this.foursBox.Name = "foursBox";
            this.foursBox.Size = new System.Drawing.Size(293, 37);
            this.foursBox.TabIndex = 4;
            // 
            // three
            // 
            this.three.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.three.AutoSize = true;
            this.three.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.three.Location = new System.Drawing.Point(90, 180);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(112, 33);
            this.three.TabIndex = 3;
            this.three.Text = "Тройки";
            // 
            // four
            // 
            this.four.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.four.AutoSize = true;
            this.four.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.four.Location = new System.Drawing.Point(90, 117);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(138, 33);
            this.four.TabIndex = 2;
            this.four.Text = "Четверки";
            // 
            // fives
            // 
            this.fives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fives.AutoSize = true;
            this.fives.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fives.Location = new System.Drawing.Point(90, 54);
            this.fives.Name = "fives";
            this.fives.Size = new System.Drawing.Size(125, 33);
            this.fives.TabIndex = 1;
            this.fives.Text = "Пятерки";
            // 
            // fivesBox
            // 
            this.fivesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fivesBox.BackColor = System.Drawing.Color.Ivory;
            this.fivesBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fivesBox.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fivesBox.Location = new System.Drawing.Point(273, 54);
            this.fivesBox.Name = "fivesBox";
            this.fivesBox.Size = new System.Drawing.Size(293, 37);
            this.fivesBox.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(90)))));
            this.calcButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.calcButton.FlatAppearance.BorderSize = 0;
            this.calcButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcButton.Font = new System.Drawing.Font("Monocraft", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calcButton.ForeColor = System.Drawing.Color.Snow;
            this.calcButton.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.calcButton.IconColor = System.Drawing.Color.Lavender;
            this.calcButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.calcButton.Location = new System.Drawing.Point(0, 349);
            this.calcButton.Margin = new System.Windows.Forms.Padding(0);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(666, 69);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Рассчитать";
            this.calcButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 418);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Средняя оценка учеников";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox fivesBox;
        private TextBox threesBox;
        private TextBox foursBox;
        private Label three;
        private Label four;
        private Label fives;
        private TextBox twosBox;
        private Label two;
        private ComboBox comboBox1;
        private Label label1;
        private FontAwesome.Sharp.IconButton calcButton;
    }
}