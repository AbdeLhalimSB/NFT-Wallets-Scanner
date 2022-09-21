
namespace NFT_Wallets_Scanner
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.label1 = new System.Windows.Forms.Label();
            this.source = new System.Windows.Forms.RichTextBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.wcount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.api = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Put wallets addresses here";
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(38, 69);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(291, 320);
            this.source.TabIndex = 1;
            this.source.Text = "";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(461, 68);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(291, 348);
            this.result.TabIndex = 3;
            this.result.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(458, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Results";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Location = new System.Drawing.Point(395, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 476);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(33, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wallet loaded count :";
            // 
            // wcount
            // 
            this.wcount.AutoSize = true;
            this.wcount.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcount.ForeColor = System.Drawing.Color.Lime;
            this.wcount.Location = new System.Drawing.Point(290, 468);
            this.wcount.Name = "wcount";
            this.wcount.Size = new System.Drawing.Size(20, 20);
            this.wcount.TabIndex = 6;
            this.wcount.Text = "0";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(516, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(34, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "API Key :";
            // 
            // api
            // 
            this.api.Location = new System.Drawing.Point(149, 418);
            this.api.Name = "api";
            this.api.Size = new System.Drawing.Size(134, 20);
            this.api.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(289, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 30);
            this.button2.TabIndex = 10;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.api);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.source);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NFT Wallets Scanner";
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox source;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label wcount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox api;
        private System.Windows.Forms.Button button2;
    }
}

