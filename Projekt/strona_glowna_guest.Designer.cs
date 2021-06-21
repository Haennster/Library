
namespace Projekt
{
    partial class strona_glowna_guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(strona_glowna_guest));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wypozyczone = new System.Windows.Forms.CheckBox();
            this.category = new System.Windows.Forms.ComboBox();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categories = new Projekt.categories();
            this.author = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.kategorieTableAdapter = new Projekt.categoriesTableAdapters.KategorieTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categories)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 189);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(585, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kategoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(612, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(615, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tytuł:";
            // 
            // wypozyczone
            // 
            this.wypozyczone.AutoSize = true;
            this.wypozyczone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wypozyczone.Location = new System.Drawing.Point(664, 102);
            this.wypozyczone.Name = "wypozyczone";
            this.wypozyczone.Size = new System.Drawing.Size(115, 21);
            this.wypozyczone.TabIndex = 20;
            this.wypozyczone.Text = "Wypożyczone";
            this.wypozyczone.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            this.category.DataSource = this.kategorieBindingSource;
            this.category.DisplayMember = "nazwa";
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(664, 75);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(115, 21);
            this.category.TabIndex = 19;
            // 
            // kategorieBindingSource
            // 
            this.kategorieBindingSource.DataMember = "Kategorie";
            this.kategorieBindingSource.DataSource = this.categories;
            // 
            // categories
            // 
            this.categories.DataSetName = "categories";
            this.categories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(664, 49);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(115, 20);
            this.author.TabIndex = 18;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(664, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(115, 20);
            this.title.TabIndex = 17;
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.clear_btn.Location = new System.Drawing.Point(664, 129);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(115, 28);
            this.clear_btn.TabIndex = 16;
            this.clear_btn.Text = "Czyść filtry";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exit_btn.Location = new System.Drawing.Point(26, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(109, 28);
            this.exit_btn.TabIndex = 14;
            this.exit_btn.Text = "Wyjdź";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // kategorieTableAdapter
            // 
            this.kategorieTableAdapter.ClearBeforeFill = true;
            // 
            // strona_glowna_guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wypozyczone);
            this.Controls.Add(this.category);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.exit_btn);
            this.Name = "strona_glowna_guest";
            this.Text = "strona_glowna_guest";
            this.Load += new System.EventHandler(this.strona_glowna_guest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox wypozyczone;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button exit_btn;
        private categories categories;
        private System.Windows.Forms.BindingSource kategorieBindingSource;
        private categoriesTableAdapters.KategorieTableAdapter kategorieTableAdapter;
    }
}