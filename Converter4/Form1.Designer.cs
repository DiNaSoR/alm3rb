namespace Converter4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Exit = new System.Windows.Forms.Button();
            this.Us = new System.Windows.Forms.Button();
            this.en_to_ar = new System.Windows.Forms.Button();
            this.ar_to_en = new System.Windows.Forms.Button();
            this.Up_Side_Down = new System.Windows.Forms.Button();
            this.transform = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkVisited = true;
            this.linkLabel1.Location = new System.Drawing.Point(80, 450);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 15);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.2DQ8.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(194, 436);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 27);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "????";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Us
            // 
            this.Us.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Us.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Us.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Us.Location = new System.Drawing.Point(194, 404);
            this.Us.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Us.Name = "Us";
            this.Us.Size = new System.Drawing.Size(116, 27);
            this.Us.TabIndex = 7;
            this.Us.Text = "?? ???";
            this.Us.UseVisualStyleBackColor = false;
            this.Us.Click += new System.EventHandler(this.Us_Click);
            // 
            // en_to_ar
            // 
            this.en_to_ar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.en_to_ar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.en_to_ar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.en_to_ar.Location = new System.Drawing.Point(330, 436);
            this.en_to_ar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.en_to_ar.Name = "en_to_ar";
            this.en_to_ar.Size = new System.Drawing.Size(116, 29);
            this.en_to_ar.TabIndex = 6;
            this.en_to_ar.Text = "??????? ??? ????";
            this.en_to_ar.UseVisualStyleBackColor = false;
            this.en_to_ar.Click += new System.EventHandler(this.en_to_ar_Click);
            // 
            // ar_to_en
            // 
            this.ar_to_en.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ar_to_en.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ar_to_en.Enabled = false;
            this.ar_to_en.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ar_to_en.Location = new System.Drawing.Point(330, 404);
            this.ar_to_en.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ar_to_en.Name = "ar_to_en";
            this.ar_to_en.Size = new System.Drawing.Size(116, 27);
            this.ar_to_en.TabIndex = 5;
            this.ar_to_en.Text = "???? ??? ???????";
            this.ar_to_en.UseVisualStyleBackColor = false;
            this.ar_to_en.Click += new System.EventHandler(this.ar_to_en_Click);
            // 
            // Up_Side_Down
            // 
            this.Up_Side_Down.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Up_Side_Down.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Up_Side_Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Up_Side_Down.Location = new System.Drawing.Point(464, 436);
            this.Up_Side_Down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Up_Side_Down.Name = "Up_Side_Down";
            this.Up_Side_Down.Size = new System.Drawing.Size(116, 29);
            this.Up_Side_Down.TabIndex = 4;
            this.Up_Side_Down.Text = "???";
            this.Up_Side_Down.UseVisualStyleBackColor = false;
            this.Up_Side_Down.Click += new System.EventHandler(this.Up_Side_Down_Click);
            // 
            // transform
            // 
            this.transform.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transform.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transform.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transform.Location = new System.Drawing.Point(464, 404);
            this.transform.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(116, 27);
            this.transform.TabIndex = 3;
            this.transform.Text = "?????";
            this.transform.UseVisualStyleBackColor = false;
            this.transform.Click += new System.EventHandler(this.transform_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(20, 216);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.MaxLength = 0;
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(552, 157);
            this.textBox2.TabIndex = 2;
            this.textBox2.Tag = "";
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(20, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.MaxLength = 0;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(552, 160);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Converter4.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(591, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Us);
            this.Controls.Add(this.en_to_ar);
            this.Controls.Add(this.ar_to_en);
            this.Controls.Add(this.Up_Side_Down);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragonarab [2DQ8.com] ???? ????? ???????";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Us;
        private System.Windows.Forms.Button en_to_ar;
        private System.Windows.Forms.Button ar_to_en;
        private System.Windows.Forms.Button Up_Side_Down;
        private System.Windows.Forms.Button transform;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;

    }
}

