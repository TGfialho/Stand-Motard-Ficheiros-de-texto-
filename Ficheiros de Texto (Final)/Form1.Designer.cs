
namespace Ficheiros_de_Texto__Final_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGrelha = new System.Windows.Forms.DataGridView();
            this.tbmarca = new System.Windows.Forms.TextBox();
            this.tbmodelo = new System.Windows.Forms.TextBox();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.numano = new System.Windows.Forms.NumericUpDown();
            this.btguardar = new System.Windows.Forms.Button();
            this.bteliminar = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpreco = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpreco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(269, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stand Virtual Motard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // dgvGrelha
            // 
            this.dgvGrelha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrelha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Marca,
            this.Modelo,
            this.Ano,
            this.Estado,
            this.Preço});
            this.dgvGrelha.Location = new System.Drawing.Point(38, 220);
            this.dgvGrelha.Name = "dgvGrelha";
            this.dgvGrelha.Size = new System.Drawing.Size(730, 218);
            this.dgvGrelha.TabIndex = 5;
            // 
            // tbmarca
            // 
            this.tbmarca.Location = new System.Drawing.Point(164, 70);
            this.tbmarca.Name = "tbmarca";
            this.tbmarca.Size = new System.Drawing.Size(100, 20);
            this.tbmarca.TabIndex = 6;
            // 
            // tbmodelo
            // 
            this.tbmodelo.Location = new System.Drawing.Point(164, 106);
            this.tbmodelo.Name = "tbmodelo";
            this.tbmodelo.Size = new System.Drawing.Size(100, 20);
            this.tbmodelo.TabIndex = 7;
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Novo",
            "Usado"});
            this.cbestado.Location = new System.Drawing.Point(164, 174);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(121, 21);
            this.cbestado.TabIndex = 8;
            // 
            // numano
            // 
            this.numano.Location = new System.Drawing.Point(163, 142);
            this.numano.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numano.Minimum = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            this.numano.Name = "numano";
            this.numano.Size = new System.Drawing.Size(120, 20);
            this.numano.TabIndex = 9;
            this.numano.Value = new decimal(new int[] {
            1980,
            0,
            0,
            0});
            // 
            // btguardar
            // 
            this.btguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btguardar.Location = new System.Drawing.Point(590, 44);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(143, 46);
            this.btguardar.TabIndex = 10;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // bteliminar
            // 
            this.bteliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteliminar.Location = new System.Drawing.Point(590, 161);
            this.bteliminar.Name = "bteliminar";
            this.bteliminar.Size = new System.Drawing.Size(143, 46);
            this.bteliminar.TabIndex = 11;
            this.bteliminar.Text = "Eliminar";
            this.bteliminar.UseVisualStyleBackColor = true;
            this.bteliminar.Click += new System.EventHandler(this.bteliminar_Click);
            // 
            // bteditar
            // 
            this.bteditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.Location = new System.Drawing.Point(590, 106);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(143, 46);
            this.bteditar.TabIndex = 12;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Preço";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            // 
            // numpreco
            // 
            this.numpreco.DecimalPlaces = 1;
            this.numpreco.Location = new System.Drawing.Point(367, 105);
            this.numpreco.Maximum = new decimal(new int[] {
            -469762048,
            -590869294,
            5421010,
            0});
            this.numpreco.Name = "numpreco";
            this.numpreco.Size = new System.Drawing.Size(120, 20);
            this.numpreco.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numpreco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.bteliminar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.numano);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.tbmodelo);
            this.Controls.Add(this.tbmarca);
            this.Controls.Add(this.dgvGrelha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrelha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numpreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGrelha;
        private System.Windows.Forms.TextBox tbmarca;
        private System.Windows.Forms.TextBox tbmodelo;
        private System.Windows.Forms.ComboBox cbestado;
        private System.Windows.Forms.NumericUpDown numano;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button bteliminar;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.NumericUpDown numpreco;
    }
}

