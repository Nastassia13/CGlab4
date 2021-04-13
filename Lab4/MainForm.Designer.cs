namespace Lab4
{
    partial class MainForm
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
            this.topPanelTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.heightInput = new System.Windows.Forms.NumericUpDown();
            this.widthInput = new System.Windows.Forms.NumericUpDown();
            this.bitmapPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.sizeInfoLabel = new System.Windows.Forms.Label();
            this.circleRadiusInput = new System.Windows.Forms.NumericUpDown();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.circleConfigLabel = new System.Windows.Forms.Label();
            this.circleBresenhamButton = new System.Windows.Forms.RadioButton();
            this.lineBresenhamButton = new System.Windows.Forms.RadioButton();
            this.lineDDAButton = new System.Windows.Forms.RadioButton();
            this.lineStepButton = new System.Windows.Forms.RadioButton();
            this.toolsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusInput)).BeginInit();
            this.SuspendLayout();
            // 
            // heightInput
            // 
            this.heightInput.AutoSize = true;
            this.heightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heightInput.Location = new System.Drawing.Point(161, 60);
            this.heightInput.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.heightInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.heightInput.Name = "heightInput";
            this.heightInput.Size = new System.Drawing.Size(70, 28);
            this.heightInput.TabIndex = 2;
            this.topPanelTooltip.SetToolTip(this.heightInput, "edit to expand or shrink sample");
            this.heightInput.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.heightInput.ValueChanged += new System.EventHandler(this.heightInput_ValueChanged);
            // 
            // widthInput
            // 
            this.widthInput.AutoSize = true;
            this.widthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.widthInput.Location = new System.Drawing.Point(58, 60);
            this.widthInput.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.widthInput.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.widthInput.Name = "widthInput";
            this.widthInput.Size = new System.Drawing.Size(70, 28);
            this.widthInput.TabIndex = 1;
            this.topPanelTooltip.SetToolTip(this.widthInput, "edit to expand or shrink sample");
            this.widthInput.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.widthInput.ValueChanged += new System.EventHandler(this.widthInput_ValueChanged);
            // 
            // bitmapPanel
            // 
            this.bitmapPanel.Location = new System.Drawing.Point(369, 12);
            this.bitmapPanel.Name = "bitmapPanel";
            this.bitmapPanel.Size = new System.Drawing.Size(762, 609);
            this.bitmapPanel.TabIndex = 2;
            this.bitmapPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bitmapPanel_Paint);
            this.bitmapPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bitmapPanel_MouseClick);
            this.bitmapPanel.Resize += new System.EventHandler(this.bitmapPanel_Resize);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(134, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "x";
            // 
            // sizeInfoLabel
            // 
            this.sizeInfoLabel.AutoSize = true;
            this.sizeInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sizeInfoLabel.ForeColor = System.Drawing.Color.White;
            this.sizeInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.sizeInfoLabel.Name = "sizeInfoLabel";
            this.sizeInfoLabel.Size = new System.Drawing.Size(228, 25);
            this.sizeInfoLabel.TabIndex = 9;
            this.sizeInfoLabel.Text = "Scale (width x height):";
            // 
            // circleRadiusInput
            // 
            this.circleRadiusInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleRadiusInput.Location = new System.Drawing.Point(100, 439);
            this.circleRadiusInput.Maximum = new decimal(new int[] {
            2048,
            0,
            0,
            0});
            this.circleRadiusInput.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.circleRadiusInput.Name = "circleRadiusInput";
            this.circleRadiusInput.Size = new System.Drawing.Size(70, 28);
            this.circleRadiusInput.TabIndex = 2;
            this.circleRadiusInput.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radiusLabel.ForeColor = System.Drawing.Color.White;
            this.radiusLabel.Location = new System.Drawing.Point(13, 440);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(73, 24);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "Radius:";
            this.radiusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // circleConfigLabel
            // 
            this.circleConfigLabel.AutoSize = true;
            this.circleConfigLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleConfigLabel.ForeColor = System.Drawing.Color.White;
            this.circleConfigLabel.Location = new System.Drawing.Point(12, 349);
            this.circleConfigLabel.Name = "circleConfigLabel";
            this.circleConfigLabel.Size = new System.Drawing.Size(73, 25);
            this.circleConfigLabel.TabIndex = 5;
            this.circleConfigLabel.Text = "Сircle:";
            this.circleConfigLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // circleBresenhamButton
            // 
            this.circleBresenhamButton.AutoSize = true;
            this.circleBresenhamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.circleBresenhamButton.ForeColor = System.Drawing.Color.White;
            this.circleBresenhamButton.Location = new System.Drawing.Point(17, 391);
            this.circleBresenhamButton.Name = "circleBresenhamButton";
            this.circleBresenhamButton.Size = new System.Drawing.Size(181, 28);
            this.circleBresenhamButton.TabIndex = 4;
            this.circleBresenhamButton.TabStop = true;
            this.circleBresenhamButton.Text = "Circle Bresenham";
            this.circleBresenhamButton.UseVisualStyleBackColor = true;
            this.circleBresenhamButton.CheckedChanged += new System.EventHandler(this.circleBresenhamButton_CheckedChanged);
            // 
            // lineBresenhamButton
            // 
            this.lineBresenhamButton.AutoSize = true;
            this.lineBresenhamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineBresenhamButton.ForeColor = System.Drawing.Color.White;
            this.lineBresenhamButton.Location = new System.Drawing.Point(17, 251);
            this.lineBresenhamButton.Name = "lineBresenhamButton";
            this.lineBresenhamButton.Size = new System.Drawing.Size(169, 28);
            this.lineBresenhamButton.TabIndex = 3;
            this.lineBresenhamButton.TabStop = true;
            this.lineBresenhamButton.Text = "Line Bresenham";
            this.lineBresenhamButton.UseVisualStyleBackColor = true;
            this.lineBresenhamButton.CheckedChanged += new System.EventHandler(this.lineBresenhamButton_CheckedChanged);
            // 
            // lineDDAButton
            // 
            this.lineDDAButton.AutoSize = true;
            this.lineDDAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineDDAButton.ForeColor = System.Drawing.Color.White;
            this.lineDDAButton.Location = new System.Drawing.Point(17, 217);
            this.lineDDAButton.Name = "lineDDAButton";
            this.lineDDAButton.Size = new System.Drawing.Size(111, 28);
            this.lineDDAButton.TabIndex = 2;
            this.lineDDAButton.TabStop = true;
            this.lineDDAButton.Text = "Line DDA";
            this.lineDDAButton.UseVisualStyleBackColor = true;
            this.lineDDAButton.CheckedChanged += new System.EventHandler(this.lineDDAButton_CheckedChanged);
            // 
            // lineStepButton
            // 
            this.lineStepButton.AutoSize = true;
            this.lineStepButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lineStepButton.ForeColor = System.Drawing.Color.White;
            this.lineStepButton.Location = new System.Drawing.Point(17, 183);
            this.lineStepButton.Name = "lineStepButton";
            this.lineStepButton.Size = new System.Drawing.Size(172, 28);
            this.lineStepButton.TabIndex = 1;
            this.lineStepButton.TabStop = true;
            this.lineStepButton.Text = "Line step by step";
            this.lineStepButton.UseVisualStyleBackColor = true;
            this.lineStepButton.CheckedChanged += new System.EventHandler(this.lineStepButton_CheckedChanged);
            // 
            // toolsLabel
            // 
            this.toolsLabel.AutoSize = true;
            this.toolsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolsLabel.ForeColor = System.Drawing.Color.White;
            this.toolsLabel.Location = new System.Drawing.Point(12, 127);
            this.toolsLabel.Name = "toolsLabel";
            this.toolsLabel.Size = new System.Drawing.Size(309, 25);
            this.toolsLabel.TabIndex = 0;
            this.toolsLabel.Text = "Algorithm selection for the line:";
            this.toolsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1143, 633);
            this.Controls.Add(this.sizeInfoLabel);
            this.Controls.Add(this.heightInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthInput);
            this.Controls.Add(this.circleRadiusInput);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.circleConfigLabel);
            this.Controls.Add(this.circleBresenhamButton);
            this.Controls.Add(this.lineBresenhamButton);
            this.Controls.Add(this.lineDDAButton);
            this.Controls.Add(this.lineStepButton);
            this.Controls.Add(this.toolsLabel);
            this.Controls.Add(this.bitmapPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Name = "MainForm";
            this.Text = "Lab 4";
            ((System.ComponentModel.ISupportInitialize)(this.heightInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circleRadiusInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip topPanelTooltip;
        private System.Windows.Forms.Panel bitmapPanel;
        private System.Windows.Forms.Label toolsLabel;
        private System.Windows.Forms.RadioButton lineStepButton;
        private System.Windows.Forms.RadioButton lineDDAButton;
        private System.Windows.Forms.RadioButton lineBresenhamButton;
        private System.Windows.Forms.RadioButton circleBresenhamButton;
        private System.Windows.Forms.Label circleConfigLabel;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.NumericUpDown circleRadiusInput;
        private System.Windows.Forms.Label sizeInfoLabel;
        private System.Windows.Forms.NumericUpDown widthInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown heightInput;
    }
}

