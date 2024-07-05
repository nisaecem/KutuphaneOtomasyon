
namespace KütüphaneOtomasyon
{
    partial class ÜyeSayfası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÜyeSayfası));
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_yenile = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayınevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayısı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basımyılı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_çikiş = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(12, 21);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(75, 23);
            this.btn_ara.TabIndex = 0;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_yenile
            // 
            this.btn_yenile.Location = new System.Drawing.Point(220, 21);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(75, 23);
            this.btn_yenile.TabIndex = 0;
            this.btn_yenile.Text = "YENİLE";
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 20);
            this.textBox3.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.kitapisim,
            this.kitapyazar,
            this.kitapdili,
            this.yayınevi,
            this.tür,
            this.adet,
            this.sayfasayısı,
            this.basımyılı});
            this.dataGridView3.Location = new System.Drawing.Point(12, 65);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(473, 179);
            this.dataGridView3.TabIndex = 2;
            // 
            // id
            // 
            this.id.HeaderText = "Kitap İd";
            this.id.Name = "id";
            // 
            // kitapisim
            // 
            this.kitapisim.HeaderText = "Kitap İsmi";
            this.kitapisim.Name = "kitapisim";
            // 
            // kitapyazar
            // 
            this.kitapyazar.HeaderText = "Kitap Yazar";
            this.kitapyazar.Name = "kitapyazar";
            // 
            // kitapdili
            // 
            this.kitapdili.HeaderText = "Dil";
            this.kitapdili.Name = "kitapdili";
            // 
            // yayınevi
            // 
            this.yayınevi.HeaderText = "Yayın Evi";
            this.yayınevi.Name = "yayınevi";
            // 
            // tür
            // 
            this.tür.HeaderText = "Tür";
            this.tür.Name = "tür";
            // 
            // adet
            // 
            this.adet.HeaderText = "Adet";
            this.adet.Name = "adet";
            // 
            // sayfasayısı
            // 
            this.sayfasayısı.HeaderText = "Sayfa Sayısı";
            this.sayfasayısı.Name = "sayfasayısı";
            // 
            // basımyılı
            // 
            this.basımyılı.HeaderText = "Basım Yılı";
            this.basımyılı.Name = "basımyılı";
            // 
            // btn_çikiş
            // 
            this.btn_çikiş.Location = new System.Drawing.Point(12, 264);
            this.btn_çikiş.Name = "btn_çikiş";
            this.btn_çikiş.Size = new System.Drawing.Size(75, 23);
            this.btn_çikiş.TabIndex = 3;
            this.btn_çikiş.Text = "ÇIKIŞ YAP";
            this.btn_çikiş.UseVisualStyleBackColor = true;
            this.btn_çikiş.Click += new System.EventHandler(this.btn_çikiş_Click);
            // 
            // ÜyeSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 299);
            this.Controls.Add(this.btn_çikiş);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_ara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÜyeSayfası";
            this.Text = "ÜyeSayfası";
            this.Load += new System.EventHandler(this.ÜyeSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Button btn_yenile;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_çikiş;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayınevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayısı;
        private System.Windows.Forms.DataGridViewTextBoxColumn basımyılı;
    }
}