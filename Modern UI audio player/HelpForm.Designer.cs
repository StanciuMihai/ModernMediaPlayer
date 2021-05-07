
namespace Modern_UI_audio_player
{
    partial class HelpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseInnerForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.label1.Location = new System.Drawing.Point(121, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thank you very much for trying out Modern Media Player!";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(219, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Made by StanciuMihai";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(178, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(462, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Make sure to follow me on GitHub!";
            // 
            // btnCloseInnerForm
            // 
            this.btnCloseInnerForm.FlatAppearance.BorderSize = 0;
            this.btnCloseInnerForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseInnerForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseInnerForm.ForeColor = System.Drawing.Color.LightGray;
            this.btnCloseInnerForm.Location = new System.Drawing.Point(12, 12);
            this.btnCloseInnerForm.Name = "btnCloseInnerForm";
            this.btnCloseInnerForm.Size = new System.Drawing.Size(35, 30);
            this.btnCloseInnerForm.TabIndex = 10;
            this.btnCloseInnerForm.Text = "X";
            this.btnCloseInnerForm.UseVisualStyleBackColor = true;
            this.btnCloseInnerForm.Click += new System.EventHandler(this.btnCloseInnerForm_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(684, 431);
            this.Controls.Add(this.btnCloseInnerForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseInnerForm;
    }
}