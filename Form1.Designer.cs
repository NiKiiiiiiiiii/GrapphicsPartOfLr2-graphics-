namespace GrapphicsPartOfLr2_graphics_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lengthReader = new System.Windows.Forms.TextBox();
            this.cordMatrixReader = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthApplyButton = new System.Windows.Forms.Button();
            this.rotationCoefReader = new System.Windows.Forms.TextBox();
            this.OxCoefreader = new System.Windows.Forms.TextBox();
            this.xyReader = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.drawArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cordMatrixReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthReader
            // 
            this.lengthReader.Location = new System.Drawing.Point(22, 26);
            this.lengthReader.Name = "lengthReader";
            this.lengthReader.Size = new System.Drawing.Size(100, 20);
            this.lengthReader.TabIndex = 0;
            this.lengthReader.Text = "Input rows count";
            // 
            // cordMatrixReader
            // 
            this.cordMatrixReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cordMatrixReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.cordMatrixReader.Location = new System.Drawing.Point(22, 86);
            this.cordMatrixReader.Name = "cordMatrixReader";
            this.cordMatrixReader.Size = new System.Drawing.Size(90, 462);
            this.cordMatrixReader.TabIndex = 1;
            this.cordMatrixReader.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column2.Width = 25;
            // 
            // lengthApplyButton
            // 
            this.lengthApplyButton.Location = new System.Drawing.Point(22, 52);
            this.lengthApplyButton.Name = "lengthApplyButton";
            this.lengthApplyButton.Size = new System.Drawing.Size(100, 23);
            this.lengthApplyButton.TabIndex = 2;
            this.lengthApplyButton.Text = "Done";
            this.lengthApplyButton.UseVisualStyleBackColor = true;
            this.lengthApplyButton.Click += new System.EventHandler(this.lengthApplyButton_Click);
            // 
            // rotationCoefReader
            // 
            this.rotationCoefReader.Location = new System.Drawing.Point(22, 555);
            this.rotationCoefReader.Name = "rotationCoefReader";
            this.rotationCoefReader.Size = new System.Drawing.Size(90, 20);
            this.rotationCoefReader.TabIndex = 3;
            this.rotationCoefReader.Text = "Input discret rotation angle";
            // 
            // OxCoefreader
            // 
            this.OxCoefreader.Location = new System.Drawing.Point(22, 582);
            this.OxCoefreader.Name = "OxCoefreader";
            this.OxCoefreader.Size = new System.Drawing.Size(90, 20);
            this.OxCoefreader.TabIndex = 4;
            this.OxCoefreader.Text = "Imput ox coef";
            // 
            // xyReader
            // 
            this.xyReader.Location = new System.Drawing.Point(22, 608);
            this.xyReader.Name = "xyReader";
            this.xyReader.Size = new System.Drawing.Size(90, 20);
            this.xyReader.TabIndex = 5;
            this.xyReader.Text = "Input xy coef ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 634);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Input oy coef ";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(130, 594);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(99, 34);
            this.drawButton.TabIndex = 7;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // drawArea
            // 
            this.drawArea.Enabled = false;
            this.drawArea.Location = new System.Drawing.Point(235, 34);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(918, 620);
            this.drawArea.TabIndex = 8;
            this.drawArea.TabStop = false;
            this.drawArea.Visible = false;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawArea_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 658);
            this.Controls.Add(this.drawArea);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.xyReader);
            this.Controls.Add(this.OxCoefreader);
            this.Controls.Add(this.rotationCoefReader);
            this.Controls.Add(this.lengthApplyButton);
            this.Controls.Add(this.cordMatrixReader);
            this.Controls.Add(this.lengthReader);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cordMatrixReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lengthReader;
        private System.Windows.Forms.DataGridView cordMatrixReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button lengthApplyButton;
        private System.Windows.Forms.TextBox rotationCoefReader;
        private System.Windows.Forms.TextBox OxCoefreader;
        private System.Windows.Forms.TextBox xyReader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.PictureBox drawArea;
    }
}

