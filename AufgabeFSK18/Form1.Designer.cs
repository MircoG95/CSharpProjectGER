
namespace AufgabeFSK18
{
    partial class Form1
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
            this.dtp_GebDat = new System.Windows.Forms.DateTimePicker();
            this.bt_pruefen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_GebDat
            // 
            this.dtp_GebDat.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtp_GebDat.Location = new System.Drawing.Point(84, 92);
            this.dtp_GebDat.Name = "dtp_GebDat";
            this.dtp_GebDat.Size = new System.Drawing.Size(370, 36);
            this.dtp_GebDat.TabIndex = 0;
            // 
            // bt_pruefen
            // 
            this.bt_pruefen.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_pruefen.Location = new System.Drawing.Point(173, 245);
            this.bt_pruefen.Name = "bt_pruefen";
            this.bt_pruefen.Size = new System.Drawing.Size(200, 78);
            this.bt_pruefen.TabIndex = 1;
            this.bt_pruefen.Text = "Jetzt Prüfen";
            this.bt_pruefen.UseVisualStyleBackColor = true;
            this.bt_pruefen.Click += new System.EventHandler(this.bt_pruefen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 381);
            this.Controls.Add(this.bt_pruefen);
            this.Controls.Add(this.dtp_GebDat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_GebDat;
        private System.Windows.Forms.Button bt_pruefen;
    }
}

