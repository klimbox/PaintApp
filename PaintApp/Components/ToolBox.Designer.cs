namespace PaintApp.Components
{
    partial class ToolBox
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Type_groupBox = new System.Windows.Forms.GroupBox();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRect = new System.Windows.Forms.Button();
            this.btnRRect = new System.Windows.Forms.Button();
            this.Width_groupBox = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnLineColor = new System.Windows.Forms.Button();
            this.Text_groupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxTxtSize = new System.Windows.Forms.ComboBox();
            this.comboBoxTxtAlign = new System.Windows.Forms.ComboBox();
            this.comboBoxFont = new System.Windows.Forms.ComboBox();
            this.btnTxtColor = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAlign = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelFont = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SaveLoad_groupBox = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.Type_groupBox.SuspendLayout();
            this.Width_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.Text_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SaveLoad_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Type_groupBox
            // 
            this.Type_groupBox.Controls.Add(this.btnEllipse);
            this.Type_groupBox.Controls.Add(this.btnLine);
            this.Type_groupBox.Controls.Add(this.btnRect);
            this.Type_groupBox.Controls.Add(this.btnRRect);
            this.Type_groupBox.Location = new System.Drawing.Point(6, 3);
            this.Type_groupBox.Name = "Type_groupBox";
            this.Type_groupBox.Size = new System.Drawing.Size(160, 80);
            this.Type_groupBox.TabIndex = 0;
            this.Type_groupBox.TabStop = false;
            this.Type_groupBox.Text = "Type";
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(5, 47);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(72, 25);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(5, 17);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(72, 25);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnRect
            // 
            this.btnRect.Location = new System.Drawing.Point(83, 17);
            this.btnRect.Name = "btnRect";
            this.btnRect.Size = new System.Drawing.Size(72, 25);
            this.btnRect.TabIndex = 2;
            this.btnRect.Text = "Rectangle";
            this.btnRect.UseVisualStyleBackColor = true;
            // 
            // btnRRect
            // 
            this.btnRRect.Location = new System.Drawing.Point(83, 47);
            this.btnRRect.Name = "btnRRect";
            this.btnRRect.Size = new System.Drawing.Size(72, 25);
            this.btnRRect.TabIndex = 3;
            this.btnRRect.Text = "RoundRect";
            this.btnRRect.UseVisualStyleBackColor = true;
            // 
            // Width_groupBox
            // 
            this.Width_groupBox.Controls.Add(this.numericUpDown1);
            this.Width_groupBox.Controls.Add(this.btnLineColor);
            this.Width_groupBox.Location = new System.Drawing.Point(6, 83);
            this.Width_groupBox.Name = "Width_groupBox";
            this.Width_groupBox.Size = new System.Drawing.Size(160, 55);
            this.Width_groupBox.TabIndex = 4;
            this.Width_groupBox.TabStop = false;
            this.Width_groupBox.Text = "Color / Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(94, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLineColor
            // 
            this.btnLineColor.Location = new System.Drawing.Point(7, 20);
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.Size = new System.Drawing.Size(72, 25);
            this.btnLineColor.TabIndex = 0;
            this.btnLineColor.Text = "Color";
            this.btnLineColor.UseVisualStyleBackColor = true;
            // 
            // Text_groupBox
            // 
            this.Text_groupBox.Controls.Add(this.comboBoxTxtSize);
            this.Text_groupBox.Controls.Add(this.comboBoxTxtAlign);
            this.Text_groupBox.Controls.Add(this.comboBoxFont);
            this.Text_groupBox.Controls.Add(this.btnTxtColor);
            this.Text_groupBox.Controls.Add(this.trackBar1);
            this.Text_groupBox.Controls.Add(this.label1);
            this.Text_groupBox.Controls.Add(this.labelAlign);
            this.Text_groupBox.Controls.Add(this.labelSize);
            this.Text_groupBox.Controls.Add(this.labelFont);
            this.Text_groupBox.Controls.Add(this.textBox1);
            this.Text_groupBox.Location = new System.Drawing.Point(6, 138);
            this.Text_groupBox.Name = "Text_groupBox";
            this.Text_groupBox.Size = new System.Drawing.Size(160, 195);
            this.Text_groupBox.TabIndex = 5;
            this.Text_groupBox.TabStop = false;
            this.Text_groupBox.Text = "Text";
            // 
            // comboBoxTxtSize
            // 
            this.comboBoxTxtSize.FormattingEnabled = true;
            this.comboBoxTxtSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "24",
            "36"});
            this.comboBoxTxtSize.Location = new System.Drawing.Point(49, 63);
            this.comboBoxTxtSize.Name = "comboBoxTxtSize";
            this.comboBoxTxtSize.Size = new System.Drawing.Size(105, 21);
            this.comboBoxTxtSize.TabIndex = 12;
            // 
            // comboBoxTxtAlign
            // 
            this.comboBoxTxtAlign.FormattingEnabled = true;
            this.comboBoxTxtAlign.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Up",
            "Down",
            "Center"});
            this.comboBoxTxtAlign.Location = new System.Drawing.Point(49, 87);
            this.comboBoxTxtAlign.Name = "comboBoxTxtAlign";
            this.comboBoxTxtAlign.Size = new System.Drawing.Size(105, 21);
            this.comboBoxTxtAlign.TabIndex = 11;
            // 
            // comboBoxFont
            // 
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Items.AddRange(new object[] {
            "Times New Roman",
            "Arial",
            "Calibri",
            "Broad Way"});
            this.comboBoxFont.Location = new System.Drawing.Point(49, 39);
            this.comboBoxFont.Name = "comboBoxFont";
            this.comboBoxFont.Size = new System.Drawing.Size(105, 21);
            this.comboBoxFont.TabIndex = 10;
            // 
            // btnTxtColor
            // 
            this.btnTxtColor.Location = new System.Drawing.Point(39, 161);
            this.btnTxtColor.Name = "btnTxtColor";
            this.btnTxtColor.Size = new System.Drawing.Size(76, 25);
            this.btnTxtColor.TabIndex = 9;
            this.btnTxtColor.Text = "Color";
            this.btnTxtColor.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(11, 123);
            this.trackBar1.Maximum = 36;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(143, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rotate:";
            // 
            // labelAlign
            // 
            this.labelAlign.AutoSize = true;
            this.labelAlign.Location = new System.Drawing.Point(8, 90);
            this.labelAlign.Name = "labelAlign";
            this.labelAlign.Size = new System.Drawing.Size(33, 13);
            this.labelAlign.TabIndex = 3;
            this.labelAlign.Text = "Align:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(7, 66);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 13);
            this.labelSize.TabIndex = 2;
            this.labelSize.Text = "Size:";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(7, 42);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(31, 13);
            this.labelFont.TabIndex = 1;
            this.labelFont.Text = "Font:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 0;
            // 
            // SaveLoad_groupBox
            // 
            this.SaveLoad_groupBox.Controls.Add(this.btnLoad);
            this.SaveLoad_groupBox.Controls.Add(this.btnSave);
            this.SaveLoad_groupBox.Location = new System.Drawing.Point(6, 333);
            this.SaveLoad_groupBox.Name = "SaveLoad_groupBox";
            this.SaveLoad_groupBox.Size = new System.Drawing.Size(160, 50);
            this.SaveLoad_groupBox.TabIndex = 6;
            this.SaveLoad_groupBox.TabStop = false;
            this.SaveLoad_groupBox.Text = "Save / Load";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(82, 17);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(72, 25);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(5, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ToolBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveLoad_groupBox);
            this.Controls.Add(this.Text_groupBox);
            this.Controls.Add(this.Width_groupBox);
            this.Controls.Add(this.Type_groupBox);
            this.Name = "ToolBox";
            this.Size = new System.Drawing.Size(171, 390);
            this.Type_groupBox.ResumeLayout(false);
            this.Width_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.Text_groupBox.ResumeLayout(false);
            this.Text_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.SaveLoad_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Type_groupBox;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnRRect;
        private System.Windows.Forms.Button btnRect;
        private System.Windows.Forms.GroupBox Width_groupBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnLineColor;
        private System.Windows.Forms.GroupBox Text_groupBox;
        private System.Windows.Forms.Label labelAlign;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTxtColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox SaveLoad_groupBox;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox comboBoxTxtSize;
        private System.Windows.Forms.ComboBox comboBoxTxtAlign;
        private System.Windows.Forms.ComboBox comboBoxFont;
    }
}
