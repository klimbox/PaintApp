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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToolBox));
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
            resources.ApplyResources(this.Type_groupBox, "Type_groupBox");
            this.Type_groupBox.Controls.Add(this.btnEllipse);
            this.Type_groupBox.Controls.Add(this.btnLine);
            this.Type_groupBox.Controls.Add(this.btnRect);
            this.Type_groupBox.Controls.Add(this.btnRRect);
            this.Type_groupBox.Name = "Type_groupBox";
            this.Type_groupBox.TabStop = false;
            // 
            // btnEllipse
            // 
            resources.ApplyResources(this.btnEllipse, "btnEllipse");
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            // 
            // btnLine
            // 
            resources.ApplyResources(this.btnLine, "btnLine");
            this.btnLine.Name = "btnLine";
            this.btnLine.UseVisualStyleBackColor = true;
            // 
            // btnRect
            // 
            resources.ApplyResources(this.btnRect, "btnRect");
            this.btnRect.Name = "btnRect";
            this.btnRect.UseVisualStyleBackColor = true;
            // 
            // btnRRect
            // 
            resources.ApplyResources(this.btnRRect, "btnRRect");
            this.btnRRect.Name = "btnRRect";
            this.btnRRect.UseVisualStyleBackColor = true;
            // 
            // Width_groupBox
            // 
            resources.ApplyResources(this.Width_groupBox, "Width_groupBox");
            this.Width_groupBox.Controls.Add(this.numericUpDown1);
            this.Width_groupBox.Controls.Add(this.btnLineColor);
            this.Width_groupBox.Name = "Width_groupBox";
            this.Width_groupBox.TabStop = false;
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
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
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLineColor
            // 
            resources.ApplyResources(this.btnLineColor, "btnLineColor");
            this.btnLineColor.Name = "btnLineColor";
            this.btnLineColor.UseVisualStyleBackColor = true;
            // 
            // Text_groupBox
            // 
            resources.ApplyResources(this.Text_groupBox, "Text_groupBox");
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
            this.Text_groupBox.Name = "Text_groupBox";
            this.Text_groupBox.TabStop = false;
            // 
            // comboBoxTxtSize
            // 
            resources.ApplyResources(this.comboBoxTxtSize, "comboBoxTxtSize");
            this.comboBoxTxtSize.FormattingEnabled = true;
            this.comboBoxTxtSize.Items.AddRange(new object[] {
            resources.GetString("comboBoxTxtSize.Items"),
            resources.GetString("comboBoxTxtSize.Items1"),
            resources.GetString("comboBoxTxtSize.Items2"),
            resources.GetString("comboBoxTxtSize.Items3"),
            resources.GetString("comboBoxTxtSize.Items4"),
            resources.GetString("comboBoxTxtSize.Items5"),
            resources.GetString("comboBoxTxtSize.Items6"),
            resources.GetString("comboBoxTxtSize.Items7")});
            this.comboBoxTxtSize.Name = "comboBoxTxtSize";
            // 
            // comboBoxTxtAlign
            // 
            resources.ApplyResources(this.comboBoxTxtAlign, "comboBoxTxtAlign");
            this.comboBoxTxtAlign.FormattingEnabled = true;
            this.comboBoxTxtAlign.Items.AddRange(new object[] {
            resources.GetString("comboBoxTxtAlign.Items"),
            resources.GetString("comboBoxTxtAlign.Items1"),
            resources.GetString("comboBoxTxtAlign.Items2"),
            resources.GetString("comboBoxTxtAlign.Items3"),
            resources.GetString("comboBoxTxtAlign.Items4")});
            this.comboBoxTxtAlign.Name = "comboBoxTxtAlign";
            // 
            // comboBoxFont
            // 
            resources.ApplyResources(this.comboBoxFont, "comboBoxFont");
            this.comboBoxFont.FormattingEnabled = true;
            this.comboBoxFont.Items.AddRange(new object[] {
            resources.GetString("comboBoxFont.Items"),
            resources.GetString("comboBoxFont.Items1"),
            resources.GetString("comboBoxFont.Items2"),
            resources.GetString("comboBoxFont.Items3")});
            this.comboBoxFont.Name = "comboBoxFont";
            // 
            // btnTxtColor
            // 
            resources.ApplyResources(this.btnTxtColor, "btnTxtColor");
            this.btnTxtColor.Name = "btnTxtColor";
            this.btnTxtColor.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            resources.ApplyResources(this.trackBar1, "trackBar1");
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Maximum = 36;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Value = 18;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelAlign
            // 
            resources.ApplyResources(this.labelAlign, "labelAlign");
            this.labelAlign.Name = "labelAlign";
            // 
            // labelSize
            // 
            resources.ApplyResources(this.labelSize, "labelSize");
            this.labelSize.Name = "labelSize";
            // 
            // labelFont
            // 
            resources.ApplyResources(this.labelFont, "labelFont");
            this.labelFont.Name = "labelFont";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // SaveLoad_groupBox
            // 
            resources.ApplyResources(this.SaveLoad_groupBox, "SaveLoad_groupBox");
            this.SaveLoad_groupBox.Controls.Add(this.btnLoad);
            this.SaveLoad_groupBox.Controls.Add(this.btnSave);
            this.SaveLoad_groupBox.Name = "SaveLoad_groupBox";
            this.SaveLoad_groupBox.TabStop = false;
            // 
            // btnLoad
            // 
            resources.ApplyResources(this.btnLoad, "btnLoad");
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // ToolBox
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaveLoad_groupBox);
            this.Controls.Add(this.Text_groupBox);
            this.Controls.Add(this.Width_groupBox);
            this.Controls.Add(this.Type_groupBox);
            this.Name = "ToolBox";
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
