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
            this.SuspendLayout();
            // 
            // txtQtde
            // 
            this.txtQtde.Location = new System.Drawing.Point(116, 103);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.Size = new System.Drawing.Size(100, 20);
            this.txtQtde.TabIndex = 0;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(116, 152);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(295, 180);
            this.txtResultado.TabIndex = 1;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(433, 358);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(35, 13);
            this.lblTempo.TabIndex = 2;
            this.lblTempo.Text = "label1";
            // 
            // btnBubbleSort
            // 
            this.btnBubbleSort.Location = new System.Drawing.Point(504, 50);
            this.btnBubbleSort.Name = "btnBubbleSort";
            this.btnBubbleSort.Size = new System.Drawing.Size(110, 62);
            this.btnBubbleSort.TabIndex = 3;
            this.btnBubbleSort.Text = "Bubble sort";
            this.btnBubbleSort.UseVisualStyleBackColor = true;
            this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Location = new System.Drawing.Point(504, 130);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(110, 62);
            this.btnSelectionSort.TabIndex = 4;
            this.btnSelectionSort.Text = "Selection sort";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Location = new System.Drawing.Point(504, 209);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(110, 62);
            this.btnInsertionSort.TabIndex = 5;
            this.btnInsertionSort.Text = "Insertion sort";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Location = new System.Drawing.Point(642, 50);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(110, 62);
            this.btnQuickSort.TabIndex = 6;
            this.btnQuickSort.Text = "Quick sort";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // btnBogoSort
            // 
            this.btnBogoSort.Location = new System.Drawing.Point(642, 129);
            this.btnBogoSort.Name = "btnBogoSort";
            this.btnBogoSort.Size = new System.Drawing.Size(110, 62);
            this.btnBogoSort.TabIndex = 7;
            this.btnBogoSort.Text = "Bogo sort";
            this.btnBogoSort.UseVisualStyleBackColor = true;
            this.btnBogoSort.Click += new System.EventHandler(this.btnBogoSort_Click);
            // 
            // btnCocktailSort
            // 
            this.btnCocktailSort.Location = new System.Drawing.Point(642, 209);
            this.btnCocktailSort.Name = "btnCocktailSort";
            this.btnCocktailSort.Size = new System.Drawing.Size(110, 62);
            this.btnCocktailSort.TabIndex = 8;
            this.btnCocktailSort.Text = "Cocktail sort";
            this.btnCocktailSort.UseVisualStyleBackColor = true;
            this.btnCocktailSort.Click += new System.EventHandler(this.btnCocktailSort_Click);
            // 
            // FOrdenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

