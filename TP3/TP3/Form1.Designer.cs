namespace TP3
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
        private void InitializeComponent() //Method yang dibuat otomatis buat setup tampilan GUI
        {
            this.textBox2 = new System.Windows.Forms.TextBox(); // Bikin TextBox buat input nama
            this.button2 = new System.Windows.Forms.Button();    // Bikin Button buat Submit
            this.label2 = new System.Windows.Forms.Label();     // Bikin Label buat nampilin output
            this.SuspendLayout();                              // Pause Layout biar ga flicker pas disusun
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 49); // Posisi TextBox di Form
            this.textBox2.Name = "textBox2";                             // Nama variabel textbox
            this.textBox2.Size = new System.Drawing.Size(100, 20);       // Ukuran panjang 100, tinggi 20
            this.textBox2.TabIndex = 0;                                  // Index buat navigasi
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 49);   // Posisi Button di Form
            this.button2.Name = "button2";                               // Nama variabel Button
            this.button2.Size = new System.Drawing.Size(75, 23);         // Ukuran Lebar dan Tinggi
            this.button2.TabIndex = 1;                                   // Index buat navigasi
            this.button2.Text = "Submit";                                 // Teks yang tampil di Button
            this.button2.UseVisualStyleBackColor = true;                  // Style Button pake background default
            this.button2.Click += new System.EventHandler(this.button2_Click); // Event saat tombol di klik Panggil method `button2_Click()`
            // 
            // label2
            // 
            this.label2.AutoSize = true;                                  // Label otomatis menyesuaikan ukuran teks
            this.label2.Location = new System.Drawing.Point(153, 102);    // Posisi Label di Form
            this.label2.Name = "label2";                                  // Nama variabel Label
            this.label2.Size = new System.Drawing.Size(35, 13);           // Ukuran default
            this.label2.TabIndex = 2;                                     // Index navigasi (urutan tab)
            this.label2.Text = "Nama akan muncul disini"; // Teks default yang bakal muncul sebelum di klik
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(569, 259);          // Ukuran Form (569x259)
            this.Controls.Add(this.label2);                               // Tambahin Label ke Form
            this.Controls.Add(this.button2);                              // Tambahin Button ke Form
            this.Controls.Add(this.textBox2);                             // Tambahin TextBox ke Form
            this.Name = "Form1";                                         // Nama Form
            this.ResumeLayout(false);                                     // Balikin Layout
            this.PerformLayout();                                         // Force Layout biar komponen disusun ulang
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

