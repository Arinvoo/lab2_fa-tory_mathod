namespace lab2_faсtory_mathod
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnCreateRubberTrack;
        private System.Windows.Forms.Button btnCreatePlasticTrack;
        private System.Windows.Forms.Label lblTrackType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnCreateRubberTrack = new System.Windows.Forms.Button();
            this.btnCreatePlasticTrack = new System.Windows.Forms.Button();
            this.lblTrackType = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // btnCreateRubberTrack
            this.btnCreateRubberTrack.Location = new System.Drawing.Point(20, 20);
            this.btnCreateRubberTrack.Name = "btnCreateRubberTrack";
            this.btnCreateRubberTrack.Size = new System.Drawing.Size(150, 40);
            this.btnCreateRubberTrack.TabIndex = 0;
            this.btnCreateRubberTrack.Text = "Створити гумову доріжку";
            this.btnCreateRubberTrack.UseVisualStyleBackColor = true;
            this.btnCreateRubberTrack.Click += new System.EventHandler(this.btnCreateRubberTrack_Click);

            // btnCreatePlasticTrack
            this.btnCreatePlasticTrack.Location = new System.Drawing.Point(180, 20);
            this.btnCreatePlasticTrack.Name = "btnCreatePlasticTrack";
            this.btnCreatePlasticTrack.Size = new System.Drawing.Size(150, 40);
            this.btnCreatePlasticTrack.TabIndex = 1;
            this.btnCreatePlasticTrack.Text = "Створити пластикову доріжку";
            this.btnCreatePlasticTrack.UseVisualStyleBackColor = true;
            this.btnCreatePlasticTrack.Click += new System.EventHandler(this.btnCreatePlasticTrack_Click);

            // lblTrackType
            this.lblTrackType.AutoSize = true;
            this.lblTrackType.Location = new System.Drawing.Point(20, 80);
            this.lblTrackType.Name = "lblTrackType";
            this.lblTrackType.Size = new System.Drawing.Size(50, 20);
            this.lblTrackType.TabIndex = 2;
            this.lblTrackType.Text = "Track:";

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.btnCreateRubberTrack);
            this.Controls.Add(this.btnCreatePlasticTrack);
            this.Controls.Add(this.lblTrackType);
            this.Name = "MainForm";
            this.Text = "Короткі дистанції - Фабричний метод";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

