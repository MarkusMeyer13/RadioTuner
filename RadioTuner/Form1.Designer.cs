namespace RadioTuner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbScala = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.pbMagicEyeBak = new System.Windows.Forms.PictureBox();
            this.pbMagicEyeLeft = new System.Windows.Forms.PictureBox();
            this.pbMagicEyeRigth = new System.Windows.Forms.PictureBox();
            this.pbPointer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbScala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicEyeBak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicEyeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicEyeRigth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPointer)).BeginInit();
            this.SuspendLayout();
            // 
            // pbScala
            // 
            this.pbScala.Image = ((System.Drawing.Image)(resources.GetObject("pbScala.Image")));
            this.pbScala.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbScala.InitialImage")));
            this.pbScala.Location = new System.Drawing.Point(50, 133);
            this.pbScala.Margin = new System.Windows.Forms.Padding(2);
            this.pbScala.Name = "pbScala";
            this.pbScala.Size = new System.Drawing.Size(660, 52);
            this.pbScala.TabIndex = 0;
            this.pbScala.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(423, 198);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = ">>";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(263, 198);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // pbMagicEyeBak
            // 
            this.pbMagicEyeBak.BackColor = System.Drawing.Color.DarkGreen;
            this.pbMagicEyeBak.Location = new System.Drawing.Point(215, 68);
            this.pbMagicEyeBak.Name = "pbMagicEyeBak";
            this.pbMagicEyeBak.Size = new System.Drawing.Size(330, 50);
            this.pbMagicEyeBak.TabIndex = 3;
            this.pbMagicEyeBak.TabStop = false;
            // 
            // pbMagicEyeLeft
            // 
            this.pbMagicEyeLeft.BackColor = System.Drawing.Color.Lime;
            this.pbMagicEyeLeft.Location = new System.Drawing.Point(215, 68);
            this.pbMagicEyeLeft.Name = "pbMagicEyeLeft";
            this.pbMagicEyeLeft.Size = new System.Drawing.Size(5, 50);
            this.pbMagicEyeLeft.TabIndex = 4;
            this.pbMagicEyeLeft.TabStop = false;
            // 
            // pbMagicEyeRigth
            // 
            this.pbMagicEyeRigth.BackColor = System.Drawing.Color.Lime;
            this.pbMagicEyeRigth.Location = new System.Drawing.Point(540, 68);
            this.pbMagicEyeRigth.Name = "pbMagicEyeRigth";
            this.pbMagicEyeRigth.Size = new System.Drawing.Size(5, 50);
            this.pbMagicEyeRigth.TabIndex = 5;
            this.pbMagicEyeRigth.TabStop = false;
            // 
            // pbPointer
            // 
            this.pbPointer.BackColor = System.Drawing.Color.Red;
            this.pbPointer.Location = new System.Drawing.Point(275, 133);
            this.pbPointer.Name = "pbPointer";
            this.pbPointer.Size = new System.Drawing.Size(5, 50);
            this.pbPointer.TabIndex = 6;
            this.pbPointer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 379);
            this.Controls.Add(this.pbPointer);
            this.Controls.Add(this.pbMagicEyeRigth);
            this.Controls.Add(this.pbMagicEyeLeft);
            this.Controls.Add(this.pbMagicEyeBak);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.pbScala);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbScala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicEyeBak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicEyeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicEyeRigth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPointer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbScala;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.PictureBox pbMagicEyeBak;
        private System.Windows.Forms.PictureBox pbMagicEyeLeft;
        private System.Windows.Forms.PictureBox pbMagicEyeRigth;
        private System.Windows.Forms.PictureBox pbPointer;
    }
}

