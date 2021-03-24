
namespace Biblioteca
{
    partial class Biblioteca
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.mostra_tots = new System.Windows.Forms.Button();
            this.mostra_un = new System.Windows.Forms.Button();
            this.Llibres_tots = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lambresia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(624, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biblioteca de Llibres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mostra_tots
            // 
            this.mostra_tots.Location = new System.Drawing.Point(129, 124);
            this.mostra_tots.Name = "mostra_tots";
            this.mostra_tots.Size = new System.Drawing.Size(211, 37);
            this.mostra_tots.TabIndex = 1;
            this.mostra_tots.Text = "Visualitzar tots els llibres";
            this.mostra_tots.UseVisualStyleBackColor = true;
            this.mostra_tots.Click += new System.EventHandler(this.Mostra_tots_Click);
            // 
            // mostra_un
            // 
            this.mostra_un.Location = new System.Drawing.Point(344, 124);
            this.mostra_un.Name = "mostra_un";
            this.mostra_un.Size = new System.Drawing.Size(211, 37);
            this.mostra_un.TabIndex = 2;
            this.mostra_un.Text = "Visualitzar els libres un a un";
            this.mostra_un.UseVisualStyleBackColor = true;
            this.mostra_un.Click += new System.EventHandler(this.Mostra_un_Click);
            // 
            // Llibres_tots
            // 
            this.Llibres_tots.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Llibres_tots.Location = new System.Drawing.Point(129, 180);
            this.Llibres_tots.Multiline = true;
            this.Llibres_tots.Name = "Llibres_tots";
            this.Llibres_tots.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Llibres_tots.Size = new System.Drawing.Size(426, 258);
            this.Llibres_tots.TabIndex = 3;
            this.Llibres_tots.Visible = false;
            this.Llibres_tots.TextChanged += new System.EventHandler(this.Llibres_tots_TextChanged);
            // 
            // Biblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 493);
            this.Controls.Add(this.Llibres_tots);
            this.Controls.Add(this.mostra_un);
            this.Controls.Add(this.mostra_tots);
            this.Controls.Add(this.label1);
            this.Name = "Biblioteca";
            this.Text = "Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mostra_tots;
        private System.Windows.Forms.Button mostra_un;
        private System.Windows.Forms.TextBox Llibres_tots;
    }
}

