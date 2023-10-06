namespace Ultra_Sum
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tabControl = new TabControl();
            tabPageCalc = new TabPage();
            numericUpDownDecimalPlaces = new NumericUpDown();
            textBoxResult = new TextBox();
            buttonCalculate = new Button();
            radioButtonDivide = new RadioButton();
            radioButtonMultiply = new RadioButton();
            radioButtonSubtract = new RadioButton();
            radioButtonAdd = new RadioButton();
            maskedTextBoxNum2 = new MaskedTextBox();
            maskedTextBoxNum1 = new MaskedTextBox();
            tabPageAbout = new TabPage();
            richTextBox1 = new RichTextBox();
            tabControl.SuspendLayout();
            tabPageCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDecimalPlaces).BeginInit();
            tabPageAbout.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tabPageCalc);
            tabControl.Controls.Add(tabPageAbout);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(484, 426);
            tabControl.TabIndex = 0;
            // 
            // tabPageCalc
            // 
            tabPageCalc.Controls.Add(numericUpDownDecimalPlaces);
            tabPageCalc.Controls.Add(textBoxResult);
            tabPageCalc.Controls.Add(buttonCalculate);
            tabPageCalc.Controls.Add(radioButtonDivide);
            tabPageCalc.Controls.Add(radioButtonMultiply);
            tabPageCalc.Controls.Add(radioButtonSubtract);
            tabPageCalc.Controls.Add(radioButtonAdd);
            tabPageCalc.Controls.Add(maskedTextBoxNum2);
            tabPageCalc.Controls.Add(maskedTextBoxNum1);
            tabPageCalc.Location = new Point(4, 29);
            tabPageCalc.Name = "tabPageCalc";
            tabPageCalc.Padding = new Padding(3);
            tabPageCalc.Size = new Size(476, 393);
            tabPageCalc.TabIndex = 0;
            tabPageCalc.Text = "Calculator";
            tabPageCalc.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDecimalPlaces
            // 
            numericUpDownDecimalPlaces.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numericUpDownDecimalPlaces.Enabled = false;
            numericUpDownDecimalPlaces.Location = new Point(400, 71);
            numericUpDownDecimalPlaces.Maximum = new decimal(new int[] { 268435456, 1042612833, 542101086, 0 });
            numericUpDownDecimalPlaces.Name = "numericUpDownDecimalPlaces";
            numericUpDownDecimalPlaces.Size = new Size(70, 27);
            numericUpDownDecimalPlaces.TabIndex = 9;
            numericUpDownDecimalPlaces.Tag = "Number of Decimal Places";
            numericUpDownDecimalPlaces.ThousandsSeparator = true;
            // 
            // textBoxResult
            // 
            textBoxResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxResult.Location = new Point(6, 174);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Both;
            textBoxResult.Size = new Size(464, 213);
            textBoxResult.TabIndex = 7;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCalculate.Location = new Point(6, 139);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(464, 29);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "=";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // radioButtonDivide
            // 
            radioButtonDivide.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonDivide.Appearance = Appearance.Button;
            radioButtonDivide.CheckAlign = ContentAlignment.TopCenter;
            radioButtonDivide.Location = new Point(324, 70);
            radioButtonDivide.Name = "radioButtonDivide";
            radioButtonDivide.Size = new Size(77, 30);
            radioButtonDivide.TabIndex = 5;
            radioButtonDivide.TabStop = true;
            radioButtonDivide.Text = "÷";
            radioButtonDivide.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonDivide.UseVisualStyleBackColor = true;
            radioButtonDivide.CheckedChanged += radioButtonDivide_CheckedChanged;
            // 
            // radioButtonMultiply
            // 
            radioButtonMultiply.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonMultiply.Appearance = Appearance.Button;
            radioButtonMultiply.CheckAlign = ContentAlignment.TopCenter;
            radioButtonMultiply.Location = new Point(218, 70);
            radioButtonMultiply.Name = "radioButtonMultiply";
            radioButtonMultiply.Size = new Size(100, 30);
            radioButtonMultiply.TabIndex = 4;
            radioButtonMultiply.TabStop = true;
            radioButtonMultiply.Text = "x";
            radioButtonMultiply.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonMultiply.UseVisualStyleBackColor = true;
            // 
            // radioButtonSubtract
            // 
            radioButtonSubtract.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            radioButtonSubtract.Appearance = Appearance.Button;
            radioButtonSubtract.CheckAlign = ContentAlignment.TopCenter;
            radioButtonSubtract.Location = new Point(112, 70);
            radioButtonSubtract.Name = "radioButtonSubtract";
            radioButtonSubtract.Size = new Size(100, 30);
            radioButtonSubtract.TabIndex = 3;
            radioButtonSubtract.TabStop = true;
            radioButtonSubtract.Text = "-";
            radioButtonSubtract.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonSubtract.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdd
            // 
            radioButtonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            radioButtonAdd.Appearance = Appearance.Button;
            radioButtonAdd.CheckAlign = ContentAlignment.TopCenter;
            radioButtonAdd.Location = new Point(6, 70);
            radioButtonAdd.Name = "radioButtonAdd";
            radioButtonAdd.Size = new Size(100, 30);
            radioButtonAdd.TabIndex = 2;
            radioButtonAdd.TabStop = true;
            radioButtonAdd.Text = "+";
            radioButtonAdd.TextAlign = ContentAlignment.MiddleCenter;
            radioButtonAdd.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxNum2
            // 
            maskedTextBoxNum2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxNum2.Location = new Point(6, 106);
            maskedTextBoxNum2.Mask = resources.GetString("maskedTextBoxNum2.Mask");
            maskedTextBoxNum2.Name = "maskedTextBoxNum2";
            maskedTextBoxNum2.Size = new Size(464, 27);
            maskedTextBoxNum2.TabIndex = 1;
            maskedTextBoxNum2.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNum2.ValidatingType = typeof(int);
            maskedTextBoxNum2.Enter += maskedTextBoxNum2_Enter;
            // 
            // maskedTextBoxNum1
            // 
            maskedTextBoxNum1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBoxNum1.Location = new Point(6, 37);
            maskedTextBoxNum1.Mask = resources.GetString("maskedTextBoxNum1.Mask");
            maskedTextBoxNum1.Name = "maskedTextBoxNum1";
            maskedTextBoxNum1.Size = new Size(464, 27);
            maskedTextBoxNum1.TabIndex = 0;
            maskedTextBoxNum1.TextAlign = HorizontalAlignment.Center;
            maskedTextBoxNum1.ValidatingType = typeof(int);
            maskedTextBoxNum1.Enter += maskedTextBoxNum1_Enter;
            // 
            // tabPageAbout
            // 
            tabPageAbout.Controls.Add(richTextBox1);
            tabPageAbout.Location = new Point(4, 29);
            tabPageAbout.Name = "tabPageAbout";
            tabPageAbout.Padding = new Padding(3);
            tabPageAbout.Size = new Size(476, 393);
            tabPageAbout.TabIndex = 1;
            tabPageAbout.Text = "About";
            tabPageAbout.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.BackColor = SystemColors.Control;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(6, 6);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(464, 381);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FormMain
            // 
            AcceptButton = buttonCalculate;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UltraSum v.20220222";
            tabControl.ResumeLayout(false);
            tabPageCalc.ResumeLayout(false);
            tabPageCalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDecimalPlaces).EndInit();
            tabPageAbout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPageCalc;
        private TabPage tabPageAbout;
        private MaskedTextBox maskedTextBoxNum2;
        private MaskedTextBox maskedTextBoxNum1;
        private RadioButton radioButtonAdd;
        private RadioButton radioButtonDivide;
        private RadioButton radioButtonMultiply;
        private RadioButton radioButtonSubtract;
        private TextBox textBoxResult;
        private Button buttonCalculate;
        private NumericUpDown numericUpDownDecimalPlaces;
        private RichTextBox richTextBox1;
    }
}