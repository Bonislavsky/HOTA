namespace HOTA
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            Notedo = new Label();
            NoteRe = new Label();
            NoteMe = new Label();
            NoteFa = new Label();
            NoteSol = new Label();
            NoteL = new Label();
            NoteS = new Label();
            colorTimer = new System.Windows.Forms.Timer(components);
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 118);
            label1.Name = "label1";
            label1.Size = new Size(292, 15);
            label1.TabIndex = 0;
            label1.Text = "---------------------------------------------------------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 45);
            label2.Name = "label2";
            label2.Size = new Size(292, 15);
            label2.TabIndex = 1;
            label2.Text = "---------------------------------------------------------";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 19);
            label3.Name = "label3";
            label3.Size = new Size(292, 15);
            label3.TabIndex = 2;
            label3.Text = "---------------------------------------------------------";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 69);
            label4.Name = "label4";
            label4.Size = new Size(292, 15);
            label4.TabIndex = 3;
            label4.Text = "---------------------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 93);
            label5.Name = "label5";
            label5.Size = new Size(292, 15);
            label5.TabIndex = 4;
            label5.Text = "---------------------------------------------------------";
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(2, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 117);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Notedo
            // 
            Notedo.AutoSize = true;
            Notedo.FlatStyle = FlatStyle.System;
            Notedo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Notedo.Location = new Point(97, 113);
            Notedo.Name = "Notedo";
            Notedo.Size = new Size(20, 21);
            Notedo.TabIndex = 7;
            Notedo.Text = "C";
            // 
            // NoteRe
            // 
            NoteRe.AutoSize = true;
            NoteRe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoteRe.Location = new Point(114, 92);
            NoteRe.Name = "NoteRe";
            NoteRe.Size = new Size(21, 21);
            NoteRe.TabIndex = 8;
            NoteRe.Text = "D";
            // 
            // NoteMe
            // 
            NoteMe.AutoSize = true;
            NoteMe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoteMe.Location = new Point(144, 78);
            NoteMe.Name = "NoteMe";
            NoteMe.Size = new Size(18, 21);
            NoteMe.TabIndex = 9;
            NoteMe.Text = "E";
            // 
            // NoteFa
            // 
            NoteFa.AutoSize = true;
            NoteFa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoteFa.Location = new Point(179, 63);
            NoteFa.Name = "NoteFa";
            NoteFa.Size = new Size(18, 21);
            NoteFa.TabIndex = 10;
            NoteFa.Text = "F";
            // 
            // NoteSol
            // 
            NoteSol.AutoSize = true;
            NoteSol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoteSol.Location = new Point(215, 45);
            NoteSol.Name = "NoteSol";
            NoteSol.Size = new Size(21, 21);
            NoteSol.TabIndex = 11;
            NoteSol.Text = "G";
            // 
            // NoteL
            // 
            NoteL.AutoSize = true;
            NoteL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoteL.Location = new Point(251, 34);
            NoteL.Name = "NoteL";
            NoteL.Size = new Size(20, 21);
            NoteL.TabIndex = 12;
            NoteL.Text = "A";
            // 
            // NoteS
            // 
            NoteS.AutoSize = true;
            NoteS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NoteS.Location = new Point(291, 14);
            NoteS.Name = "NoteS";
            NoteS.Size = new Size(19, 21);
            NoteS.TabIndex = 13;
            NoteS.Text = "B";
            // 
            // colorTimer
            // 
            colorTimer.Interval = 2000;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(375, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(100, 111);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(481, 142);
            Controls.Add(richTextBox1);
            Controls.Add(NoteS);
            Controls.Add(NoteL);
            Controls.Add(NoteSol);
            Controls.Add(NoteFa);
            Controls.Add(NoteMe);
            Controls.Add(NoteRe);
            Controls.Add(Notedo);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label Notedo;
        private Label NoteRe;
        private Label NoteMe;
        private Label NoteFa;
        private Label NoteSol;
        private Label NoteL;
        private Label NoteS;
        private System.Windows.Forms.Timer colorTimer;
        private RichTextBox richTextBox1;
    }
}