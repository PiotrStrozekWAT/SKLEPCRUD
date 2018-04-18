namespace SKLEPCRUD
{
    partial class LaptopyLista
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
            this.gridLaptopy = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridLaptopy)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLaptopy
            // 
            this.gridLaptopy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLaptopy.Location = new System.Drawing.Point(12, 12);
            this.gridLaptopy.Name = "gridLaptopy";
            this.gridLaptopy.Size = new System.Drawing.Size(812, 324);
            this.gridLaptopy.TabIndex = 0;
            this.gridLaptopy.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridLaptopy_RowHeaderMouseDoubleClick);
            // 
            // LaptopyLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 424);
            this.Controls.Add(this.gridLaptopy);
            this.Name = "LaptopyLista";
            this.Text = "Lista laptopów";
            this.Load += new System.EventHandler(this.LaptopyLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLaptopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLaptopy;
    }
}