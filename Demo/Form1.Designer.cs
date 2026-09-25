namespace Demo
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
            HoLotButton = new Button();
            TenButton = new Button();
            HovaTenButton = new Button();
            Exitbutton = new Button();
            textHo = new TextBox();
            textTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelHovaTen = new Label();
            SuspendLayout();
            // 
            // HoLotButton
            // 
            HoLotButton.Location = new Point(189, 371);
            HoLotButton.Name = "HoLotButton";
            HoLotButton.Size = new Size(141, 50);
            HoLotButton.TabIndex = 0;
            HoLotButton.Text = "Họ lót";
            HoLotButton.UseVisualStyleBackColor = true;
            HoLotButton.Click += button1_Click;
            // 
            // TenButton
            // 
            TenButton.Location = new Point(411, 371);
            TenButton.Name = "TenButton";
            TenButton.Size = new Size(141, 50);
            TenButton.TabIndex = 1;
            TenButton.Text = "Tên";
            TenButton.UseVisualStyleBackColor = true;
            TenButton.Click += button2_Click;
            // 
            // HovaTenButton
            // 
            HovaTenButton.Location = new Point(662, 371);
            HovaTenButton.Name = "HovaTenButton";
            HovaTenButton.Size = new Size(141, 50);
            HovaTenButton.TabIndex = 2;
            HovaTenButton.Text = "Họ và tên";
            HovaTenButton.UseVisualStyleBackColor = true;
            HovaTenButton.Click += button3_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.Location = new Point(337, 468);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(361, 50);
            Exitbutton.TabIndex = 3;
            Exitbutton.Text = "Thoát chương trình";
            Exitbutton.UseVisualStyleBackColor = true;
            Exitbutton.Click += Exitbutton_Click;
            // 
            // textHo
            // 
            textHo.Location = new Point(387, 215);
            textHo.Name = "textHo";
            textHo.Size = new Size(390, 31);
            textHo.TabIndex = 4;
            // 
            // textTen
            // 
            textTen.Location = new Point(387, 279);
            textTen.Name = "textTen";
            textTen.Size = new Size(390, 31);
            textTen.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 215);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 6;
            label1.Text = "Họ lót";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 279);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 7;
            label2.Text = "Tên";
            // 
            // labelHovaTen
            // 
            labelHovaTen.BackColor = SystemColors.ActiveCaption;
            labelHovaTen.Location = new Point(12, 18);
            labelHovaTen.Name = "labelHovaTen";
            labelHovaTen.Size = new Size(898, 104);
            labelHovaTen.TabIndex = 8;
            labelHovaTen.Text = "HIển thị";
            labelHovaTen.TextAlign = ContentAlignment.MiddleCenter;
            labelHovaTen.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 626);
            Controls.Add(labelHovaTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textTen);
            Controls.Add(textHo);
            Controls.Add(Exitbutton);
            Controls.Add(HovaTenButton);
            Controls.Add(TenButton);
            Controls.Add(HoLotButton);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button HoLotButton;
        private Button TenButton;
        private Button HovaTenButton;
        private Button Exitbutton;
        private TextBox textHo;
        private TextBox textTen;
        private Label label1;
        private Label label2;
        private Label labelHovaTen;
    }
}
