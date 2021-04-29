
namespace OrderSystem
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
            this.addbutton = new System.Windows.Forms.Button();
            this.Subbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.Inportbutton = new System.Windows.Forms.Button();
            this.Exportbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Data1 = new System.Windows.Forms.DataGridView();
            this.Data2 = new System.Windows.Forms.DataGridView();
            this.OrderNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).BeginInit();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(13, 13);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(94, 29);
            this.addbutton.TabIndex = 0;
            this.addbutton.Text = "增加订单";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // Subbutton
            // 
            this.Subbutton.Location = new System.Drawing.Point(188, 12);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(94, 29);
            this.Subbutton.TabIndex = 1;
            this.Subbutton.Text = "删除订单";
            this.Subbutton.UseVisualStyleBackColor = true;
            this.Subbutton.Click += new System.EventHandler(this.Subbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(288, 13);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(94, 29);
            this.updatebutton.TabIndex = 2;
            this.updatebutton.Text = "修改订单";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // Inportbutton
            // 
            this.Inportbutton.Location = new System.Drawing.Point(388, 12);
            this.Inportbutton.Name = "Inportbutton";
            this.Inportbutton.Size = new System.Drawing.Size(94, 29);
            this.Inportbutton.TabIndex = 3;
            this.Inportbutton.Text = "导入订单";
            this.Inportbutton.UseVisualStyleBackColor = true;
            this.Inportbutton.Click += new System.EventHandler(this.Inportbutton_Click);
            // 
            // Exportbutton
            // 
            this.Exportbutton.Location = new System.Drawing.Point(488, 12);
            this.Exportbutton.Name = "Exportbutton";
            this.Exportbutton.Size = new System.Drawing.Size(94, 29);
            this.Exportbutton.TabIndex = 4;
            this.Exportbutton.Text = "导出订单";
            this.Exportbutton.UseVisualStyleBackColor = true;
            this.Exportbutton.Click += new System.EventHandler(this.Exportbutton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(700, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "按商品查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(834, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "按客户查询";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(681, 27);
            this.textBox1.TabIndex = 7;
            // 
            // Data1
            // 
            this.Data1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data1.Location = new System.Drawing.Point(13, 85);
            this.Data1.Name = "Data1";
            this.Data1.RowHeadersWidth = 51;
            this.Data1.RowTemplate.Height = 29;
            this.Data1.Size = new System.Drawing.Size(469, 356);
            this.Data1.TabIndex = 8;
            // 
            // Data2
            // 
            this.Data2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data2.Location = new System.Drawing.Point(488, 85);
            this.Data2.Name = "Data2";
            this.Data2.RowHeadersWidth = 51;
            this.Data2.RowTemplate.Height = 29;
            this.Data2.Size = new System.Drawing.Size(482, 356);
            this.Data2.TabIndex = 9;
            // 
            // OrderNum
            // 
            this.OrderNum.Location = new System.Drawing.Point(114, 13);
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Size = new System.Drawing.Size(68, 27);
            this.OrderNum.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.OrderNum);
            this.Controls.Add(this.Data2);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Exportbutton);
            this.Controls.Add(this.Inportbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.Subbutton);
            this.Controls.Add(this.addbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button Inportbutton;
        private System.Windows.Forms.Button Exportbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView Data1;
        private System.Windows.Forms.DataGridView Data2;
        private System.Windows.Forms.TextBox OrderNum;
    }
}

