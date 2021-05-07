
namespace Modern_UI_audio_player
{
    partial class VisualisationSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualisationSelector));
            this.btnVis1 = new System.Windows.Forms.Button();
            this.btnVis2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVis1
            // 
            this.btnVis1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVis1.FlatAppearance.BorderSize = 0;
            this.btnVis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVis1.Image = ((System.Drawing.Image)(resources.GetObject("btnVis1.Image")));
            this.btnVis1.Location = new System.Drawing.Point(104, 105);
            this.btnVis1.Name = "btnVis1";
            this.btnVis1.Size = new System.Drawing.Size(142, 80);
            this.btnVis1.TabIndex = 0;
            this.btnVis1.UseVisualStyleBackColor = true;
            this.btnVis1.Click += new System.EventHandler(this.btnVis1_Click);
            // 
            // btnVis2
            // 
            this.btnVis2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVis2.FlatAppearance.BorderSize = 0;
            this.btnVis2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVis2.Image = ((System.Drawing.Image)(resources.GetObject("btnVis2.Image")));
            this.btnVis2.Location = new System.Drawing.Point(243, 105);
            this.btnVis2.Name = "btnVis2";
            this.btnVis2.Size = new System.Drawing.Size(142, 80);
            this.btnVis2.TabIndex = 1;
            this.btnVis2.UseVisualStyleBackColor = true;
            this.btnVis2.Click += new System.EventHandler(this.btnVis2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(219, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "VISUALISATION SELECTOR";
            // 
            // VisualisationSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVis2);
            this.Controls.Add(this.btnVis1);
            this.Name = "VisualisationSelector";
            this.Text = "VisualisationSelector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVis1;
        private System.Windows.Forms.Button btnVis2;
        private System.Windows.Forms.Label label1;
    }
}