namespace TreeOdevi
{
    partial class Form1
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
            this.levellist = new System.Windows.Forms.ListBox();
            this.Ekletxt = new System.Windows.Forms.TextBox();
            this.Eklebtn = new System.Windows.Forms.Button();
            this.Maxtxt = new System.Windows.Forms.TextBox();
            this.Maxbtn = new System.Windows.Forms.Button();
            this.Mınbtn = new System.Windows.Forms.Button();
            this.Mıntxt = new System.Windows.Forms.TextBox();
            this.Bosaltbtn = new System.Windows.Forms.Button();
            this.Levelbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // levellist
            // 
            this.levellist.FormattingEnabled = true;
            this.levellist.Location = new System.Drawing.Point(12, 12);
            this.levellist.Name = "levellist";
            this.levellist.Size = new System.Drawing.Size(220, 303);
            this.levellist.TabIndex = 0;
            // 
            // Ekletxt
            // 
            this.Ekletxt.Location = new System.Drawing.Point(257, 12);
            this.Ekletxt.Name = "Ekletxt";
            this.Ekletxt.Size = new System.Drawing.Size(100, 20);
            this.Ekletxt.TabIndex = 1;
            // 
            // Eklebtn
            // 
            this.Eklebtn.BackColor = System.Drawing.Color.Transparent;
            this.Eklebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eklebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Eklebtn.Location = new System.Drawing.Point(257, 47);
            this.Eklebtn.Name = "Eklebtn";
            this.Eklebtn.Size = new System.Drawing.Size(100, 23);
            this.Eklebtn.TabIndex = 2;
            this.Eklebtn.Text = "EKLE";
            this.Eklebtn.UseVisualStyleBackColor = false;
            this.Eklebtn.Click += new System.EventHandler(this.Eklebtn_Click);
            // 
            // Maxtxt
            // 
            this.Maxtxt.Location = new System.Drawing.Point(257, 128);
            this.Maxtxt.Name = "Maxtxt";
            this.Maxtxt.Size = new System.Drawing.Size(100, 20);
            this.Maxtxt.TabIndex = 3;
            // 
            // Maxbtn
            // 
            this.Maxbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Maxbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Maxbtn.Location = new System.Drawing.Point(257, 99);
            this.Maxbtn.Name = "Maxbtn";
            this.Maxbtn.Size = new System.Drawing.Size(100, 25);
            this.Maxbtn.TabIndex = 4;
            this.Maxbtn.Text = "MAX";
            this.Maxbtn.UseVisualStyleBackColor = true;
            this.Maxbtn.Click += new System.EventHandler(this.Maxbtn_Click);
            // 
            // Mınbtn
            // 
            this.Mınbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Mınbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mınbtn.Location = new System.Drawing.Point(257, 167);
            this.Mınbtn.Name = "Mınbtn";
            this.Mınbtn.Size = new System.Drawing.Size(100, 25);
            this.Mınbtn.TabIndex = 6;
            this.Mınbtn.Text = "MIN";
            this.Mınbtn.UseVisualStyleBackColor = true;
            this.Mınbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Mıntxt
            // 
            this.Mıntxt.Location = new System.Drawing.Point(257, 196);
            this.Mıntxt.Name = "Mıntxt";
            this.Mıntxt.Size = new System.Drawing.Size(100, 20);
            this.Mıntxt.TabIndex = 5;
            this.Mıntxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Bosaltbtn
            // 
            this.Bosaltbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bosaltbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bosaltbtn.Location = new System.Drawing.Point(257, 248);
            this.Bosaltbtn.Name = "Bosaltbtn";
            this.Bosaltbtn.Size = new System.Drawing.Size(100, 23);
            this.Bosaltbtn.TabIndex = 7;
            this.Bosaltbtn.Text = "BOŞALT";
            this.Bosaltbtn.UseVisualStyleBackColor = true;
            this.Bosaltbtn.Click += new System.EventHandler(this.Bosaltbtn_Click);
            // 
            // Levelbtn
            // 
            this.Levelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Levelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Levelbtn.Location = new System.Drawing.Point(257, 292);
            this.Levelbtn.Name = "Levelbtn";
            this.Levelbtn.Size = new System.Drawing.Size(100, 23);
            this.Levelbtn.TabIndex = 8;
            this.Levelbtn.Text = "Level Order";
            this.Levelbtn.UseVisualStyleBackColor = true;
            this.Levelbtn.Click += new System.EventHandler(this.Levelbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(402, 346);
            this.Controls.Add(this.Levelbtn);
            this.Controls.Add(this.Bosaltbtn);
            this.Controls.Add(this.Mınbtn);
            this.Controls.Add(this.Mıntxt);
            this.Controls.Add(this.Maxbtn);
            this.Controls.Add(this.Maxtxt);
            this.Controls.Add(this.Eklebtn);
            this.Controls.Add(this.Ekletxt);
            this.Controls.Add(this.levellist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox levellist;
        private System.Windows.Forms.TextBox Ekletxt;
        private System.Windows.Forms.Button Eklebtn;
        private System.Windows.Forms.TextBox Maxtxt;
        private System.Windows.Forms.Button Maxbtn;
        private System.Windows.Forms.Button Mınbtn;
        private System.Windows.Forms.TextBox Mıntxt;
        private System.Windows.Forms.Button Bosaltbtn;
        private System.Windows.Forms.Button Levelbtn;
    }
}

