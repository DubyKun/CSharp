
namespace CayleyTree
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.TextBox();
            this.rangle = new System.Windows.Forms.TextBox();
            this.langle = new System.Windows.Forms.TextBox();
            this.rbranch = new System.Windows.Forms.TextBox();
            this.lbranch = new System.Windows.Forms.TextBox();
            this.Draw = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(282, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 425);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.depth);
            this.panel2.Controls.Add(this.length);
            this.panel2.Controls.Add(this.rangle);
            this.panel2.Controls.Add(this.langle);
            this.panel2.Controls.Add(this.rbranch);
            this.panel2.Controls.Add(this.lbranch);
            this.panel2.Controls.Add(this.Draw);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 425);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "主干长度（int）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "递归深度（int）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "右分支角度[0,180]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "左分支角度[0,180]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "右分支长度比[0,1]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "左分支长度比[0,1]";
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(138, 295);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(125, 27);
            this.depth.TabIndex = 6;
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(138, 231);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(125, 27);
            this.length.TabIndex = 5;
            // 
            // rangle
            // 
            this.rangle.Location = new System.Drawing.Point(138, 155);
            this.rangle.Name = "rangle";
            this.rangle.Size = new System.Drawing.Size(125, 27);
            this.rangle.TabIndex = 4;
            // 
            // langle
            // 
            this.langle.Location = new System.Drawing.Point(0, 155);
            this.langle.Name = "langle";
            this.langle.Size = new System.Drawing.Size(125, 27);
            this.langle.TabIndex = 3;
            // 
            // rbranch
            // 
            this.rbranch.Location = new System.Drawing.Point(138, 51);
            this.rbranch.Name = "rbranch";
            this.rbranch.Size = new System.Drawing.Size(125, 27);
            this.rbranch.TabIndex = 2;
            // 
            // lbranch
            // 
            this.lbranch.Location = new System.Drawing.Point(0, 51);
            this.lbranch.Name = "lbranch";
            this.lbranch.Size = new System.Drawing.Size(125, 27);
            this.lbranch.TabIndex = 1;
            // 
            // Draw
            // 
            this.Draw.Location = new System.Drawing.Point(0, 374);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(263, 51);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.TextBox rangle;
        private System.Windows.Forms.TextBox langle;
        private System.Windows.Forms.TextBox rbranch;
        private System.Windows.Forms.TextBox lbranch;
        private System.Windows.Forms.Button Draeaaa;
        private System.Windows.Forms.TextBox depth;
        private System.Windows.Forms.ComboBox C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

