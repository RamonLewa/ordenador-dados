namespace ordenador_dados
{
    partial class FOrdenador
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
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblTempo = new System.Windows.Forms.Label();
            this.btnBubbleSort = new System.Windows.Forms.Button();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.btnBogoSort = new System.Windows.Forms.Button();
            this.btnCocktailSort = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblValores = new System.Windows.Forms.Label();
            this.lblTempoDecorrido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(12, 65);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 121);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(368, 180);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.TabStop = false;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTempo.Location = new System.Drawing.Point(273, 105);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(59, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "Tempo MS";
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBubbleSort.Location = new System.Drawing.Point(12, 307);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(110, 62);
            this.btnBubbleSort.TabIndex = 2;
            this.btnBubbleSort.Text = "Bubble sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectionSort.Location = new System.Drawing.Point(270, 307);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(110, 62);
            this.btnSelectionSort.TabIndex = 4;
            this.btnSelectionSort.Text = "Selection sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertionSort.Location = new System.Drawing.Point(141, 375);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(110, 62);
            this.btnInsertionSort.TabIndex = 6;
            this.btnInsertionSort.Text = "Insertion sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickSort.Location = new System.Drawing.Point(141, 307);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(110, 62);
            this.btnQuickSort.TabIndex = 3;
            this.btnQuickSort.Text = "Quick sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnBogoSort
            // 
            this.btnBogoSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBogoSort.Location = new System.Drawing.Point(12, 375);
            this.btnBogoSort.Name = "btnBogoSort";
            this.btnBogoSort.Size = new System.Drawing.Size(110, 62);
            this.btnBogoSort.TabIndex = 5;
            this.btnBogoSort.Text = "Bogo sort";
            this.btnBogoSort.UseVisualStyleBackColor = true;
            this.btnBogoSort.Click += new System.EventHandler(this.btnBogoSort_Click);
            // 
            // btnCocktailSort
            // 
            this.btnCocktailSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCocktailSort.Location = new System.Drawing.Point(270, 375);
            this.btnCocktailSort.Name = "btnCocktailSort";
            this.btnCocktailSort.Size = new System.Drawing.Size(110, 62);
            this.btnCocktailSort.TabIndex = 7;
            this.btnCocktailSort.Text = "Cocktail sort";
            this.btnCocktailSort.UseVisualStyleBackColor = true;
            this.btnCocktailSort.Click += new System.EventHandler(this.btnCocktailSort_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblQuantidade.Location = new System.Drawing.Point(12, 49);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblTitulo.Location = new System.Drawing.Point(77, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 29);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Ordenador de dados";
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblValores.Location = new System.Drawing.Point(12, 105);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(42, 13);
            this.lblValores.TabIndex = 11;
            this.lblValores.Text = "Valores";
            // 
            // lblTempoDecorrido
            // 
            this.lblTempoDecorrido.AutoSize = true;
            this.lblTempoDecorrido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTempoDecorrido.Location = new System.Drawing.Point(177, 105);
            this.lblTempoDecorrido.Name = "lblTempoDecorrido";
            this.lblTempoDecorrido.Size = new System.Drawing.Size(97, 13);
            this.lblTempoDecorrido.TabIndex = 12;
            this.lblTempoDecorrido.Text = "Tempo necessário:";
            // 
            // FOrdenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(391, 449);
            this.Controls.Add(this.lblTempoDecorrido);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.btnCocktailSort);
            this.Controls.Add(this.btnBogoSort);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.btnInsertionSort);
            this.Controls.Add(this.btnSelectionSort);
            this.Controls.Add(this.btnBubbleSort);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtQtde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FOrdenador";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FOrdenador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Button btnBubbleSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.Button btnBogoSort;
        private System.Windows.Forms.Button btnCocktailSort;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblValores;
        private System.Windows.Forms.Label lblTempoDecorrido;
    }
}

