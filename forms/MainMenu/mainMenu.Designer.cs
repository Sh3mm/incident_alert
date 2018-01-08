using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using NotificationLibrary;

namespace AlertManagement
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        public static Abonements _abonements;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.label2 = new Label();
            this.label3 = new Label();
            this.label4 = new Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new Point(334, 25);
            this.label1.Name = "label1";
            this.label1.Size = new Size(276, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alert Managment";
            // 
            // button1
            // 
            this.button1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new Point(166, 117);
            this.button1.Name = "button1";
            this.button1.Size = new Size(300, 150);
            this.button1.TabIndex = 2;
            this.button1.Text = "X Personnel TI\r\n\r\nX Usagers Critiques\r\n\r\nX usagers à souscription\r\n";
            this.button1.TextAlign = ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new Point(516, 117);
            this.button2.Name = "button2";
            this.button2.Size = new Size(300, 150);
            this.button2.TabIndex = 3;
            this.button2.Text = "X Applications";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new Point(273, 335);
            this.button3.Name = "button3";
            this.button3.Size = new Size(450, 150);
            this.button3.TabIndex = 4;
            this.button3.Text = "X Current alerts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new Point(161, 89);
            this.label2.Name = "label2";
            this.label2.Size = new Size(173, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User Management";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new Point(511, 89);
            this.label3.Name = "label3";
            this.label3.Size = new Size(178, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apps Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new Point(414, 307);
            this.label4.Name = "label4";
            this.label4.Size = new Size(172, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Alert Management";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new SizeF(9F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(978, 544);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new Size(1000, 600);
            this.MinimumSize = new Size(1000, 600);
            this.Name = "MainMenu";
            this.Text = "mainMenu";
            this.Load += new EventHandler(this.mainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}