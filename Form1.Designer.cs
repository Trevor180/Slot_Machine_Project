namespace WootenT_SlotMach
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fruitImageList = new System.Windows.Forms.ImageList(this.components);
            this.leftPictureBox = new System.Windows.Forms.PictureBox();
            this.middlePictureBox = new System.Windows.Forms.PictureBox();
            this.rightPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.userAmountTextBox = new System.Windows.Forms.TextBox();
            this.spinButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fruitImageList
            // 
            this.fruitImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitImageList.ImageStream")));
            this.fruitImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitImageList.Images.SetKeyName(0, "Apple.jpg");
            this.fruitImageList.Images.SetKeyName(1, "Banana.jpg");
            this.fruitImageList.Images.SetKeyName(2, "Cherries.jpg");
            this.fruitImageList.Images.SetKeyName(3, "Grapes.jpg");
            this.fruitImageList.Images.SetKeyName(4, "Lemon.jpg");
            this.fruitImageList.Images.SetKeyName(5, "Lime.jpg");
            this.fruitImageList.Images.SetKeyName(6, "Orange.jpg");
            this.fruitImageList.Images.SetKeyName(7, "Pear.jpg");
            this.fruitImageList.Images.SetKeyName(8, "Strawberry.jpg");
            this.fruitImageList.Images.SetKeyName(9, "Watermelon.jpg");
            // 
            // leftPictureBox
            // 
            this.leftPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leftPictureBox.Location = new System.Drawing.Point(33, 44);
            this.leftPictureBox.Name = "leftPictureBox";
            this.leftPictureBox.Size = new System.Drawing.Size(168, 166);
            this.leftPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftPictureBox.TabIndex = 0;
            this.leftPictureBox.TabStop = false;
            // 
            // middlePictureBox
            // 
            this.middlePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.middlePictureBox.Location = new System.Drawing.Point(233, 44);
            this.middlePictureBox.Name = "middlePictureBox";
            this.middlePictureBox.Size = new System.Drawing.Size(168, 166);
            this.middlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.middlePictureBox.TabIndex = 1;
            this.middlePictureBox.TabStop = false;
            this.middlePictureBox.Click += new System.EventHandler(this.middlePictureBox_Click);
            // 
            // rightPictureBox
            // 
            this.rightPictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rightPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPictureBox.Location = new System.Drawing.Point(430, 44);
            this.rightPictureBox.Name = "rightPictureBox";
            this.rightPictureBox.Size = new System.Drawing.Size(168, 166);
            this.rightPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightPictureBox.TabIndex = 2;
            this.rightPictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount Inserted $:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userAmountTextBox
            // 
            this.userAmountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAmountTextBox.Location = new System.Drawing.Point(346, 260);
            this.userAmountTextBox.Multiline = true;
            this.userAmountTextBox.Name = "userAmountTextBox";
            this.userAmountTextBox.Size = new System.Drawing.Size(147, 32);
            this.userAmountTextBox.TabIndex = 4;
            this.userAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // spinButton
            // 
            this.spinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinButton.Location = new System.Drawing.Point(145, 318);
            this.spinButton.Name = "spinButton";
            this.spinButton.Size = new System.Drawing.Size(112, 34);
            this.spinButton.TabIndex = 5;
            this.spinButton.Text = "Spin";
            this.spinButton.UseVisualStyleBackColor = true;
            this.spinButton.Click += new System.EventHandler(this.spinButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(346, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 34);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.spinButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(610, 364);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.spinButton);
            this.Controls.Add(this.userAmountTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightPictureBox);
            this.Controls.Add(this.middlePictureBox);
            this.Controls.Add(this.leftPictureBox);
            this.Name = "Form1";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.leftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.middlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList fruitImageList;
        private System.Windows.Forms.PictureBox leftPictureBox;
        private System.Windows.Forms.PictureBox middlePictureBox;
        private System.Windows.Forms.PictureBox rightPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userAmountTextBox;
        private System.Windows.Forms.Button spinButton;
        private System.Windows.Forms.Button exitButton;
    }
}

