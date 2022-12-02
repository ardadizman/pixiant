namespace Pixiant
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlTopBorder = new System.Windows.Forms.Panel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.pnlTopBorder.SuspendLayout();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBorder
            // 
            this.pnlTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTopBorder.Controls.Add(this.Button1);
            this.pnlTopBorder.Controls.Add(this.Label1);
            this.pnlTopBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBorder.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBorder.Name = "pnlTopBorder";
            this.pnlTopBorder.Size = new System.Drawing.Size(1280, 28);
            this.pnlTopBorder.TabIndex = 1;
            this.pnlTopBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBorder_MouseDown);
            this.pnlTopBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBorder_MouseMove);
            this.pnlTopBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBorder_MouseUp);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(1253, 3);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(25, 24);
            this.Button1.TabIndex = 1;
            this.Button1.Text = "X";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(9, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 21);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Pixiant";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.Panel2.Controls.Add(this.Button4);
            this.Panel2.Controls.Add(this.Button3);
            this.Panel2.Controls.Add(this.Button2);
            this.Panel2.Controls.Add(this.PictureBox1);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel2.Location = new System.Drawing.Point(0, 28);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1280, 105);
            this.Panel2.TabIndex = 2;
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button4.Location = new System.Drawing.Point(113, 71);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(97, 26);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "Recover Files";
            this.Button4.UseVisualStyleBackColor = true;
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button3.Location = new System.Drawing.Point(113, 39);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(97, 26);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "New Folder";
            this.Button3.UseVisualStyleBackColor = true;
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("Bahnschrift Light", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Button2.Location = new System.Drawing.Point(113, 7);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(97, 26);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "New File";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(3, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(104, 99);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.Panel4.Controls.Add(this.Panel3);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.Panel1);
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel4.Location = new System.Drawing.Point(0, 133);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(1280, 507);
            this.Panel4.TabIndex = 4;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.Color.White;
            this.Panel3.Location = new System.Drawing.Point(888, 35);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(380, 460);
            this.Panel3.TabIndex = 2;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label3.Location = new System.Drawing.Point(884, 9);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(62, 23);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "News:";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Location = new System.Drawing.Point(9, 47);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(712, 448);
            this.Panel1.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.Location = new System.Drawing.Point(4, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(119, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Recent Files:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 640);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.pnlTopBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.pnlTopBorder.ResumeLayout(false);
            this.pnlTopBorder.PerformLayout();
            this.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlTopBorder;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button Button4;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
    }
}

