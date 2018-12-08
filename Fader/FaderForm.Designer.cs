namespace Fader
{
    partial class FaderForm
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
            this.checkBoxFadeIn = new System.Windows.Forms.CheckBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxFadeOut = new System.Windows.Forms.CheckBox();
            this.numericUpDownFadeTime = new System.Windows.Forms.NumericUpDown();
            this.labelFadeTime = new System.Windows.Forms.Label();
            this.labelTimeUnit = new System.Windows.Forms.Label();
            this.comboBoxTimeUnit = new System.Windows.Forms.ComboBox();
            this.checkBoxChangeCurveType = new System.Windows.Forms.CheckBox();
            this.pictureBoxDrawArea = new System.Windows.Forms.PictureBox();
            this.comboBoxFadeInCurve = new System.Windows.Forms.ComboBox();
            this.comboBoxFadeOutCurve = new System.Windows.Forms.ComboBox();
            this.groupBoxCurves = new System.Windows.Forms.GroupBox();
            this.comboBoxScriptMode = new System.Windows.Forms.ComboBox();
            this.comboBoxApplyTo = new System.Windows.Forms.ComboBox();
            this.menuStripTopMenu = new System.Windows.Forms.MenuStrip();
            this.editScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFadeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawArea)).BeginInit();
            this.groupBoxCurves.SuspendLayout();
            this.menuStripTopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxFadeIn
            // 
            this.checkBoxFadeIn.AutoSize = true;
            this.checkBoxFadeIn.Checked = true;
            this.checkBoxFadeIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFadeIn.Location = new System.Drawing.Point(21, 36);
            this.checkBoxFadeIn.Margin = new System.Windows.Forms.Padding(10, 20, 3, 10);
            this.checkBoxFadeIn.Name = "checkBoxFadeIn";
            this.checkBoxFadeIn.Size = new System.Drawing.Size(59, 17);
            this.checkBoxFadeIn.TabIndex = 0;
            this.checkBoxFadeIn.Text = "FadeIn";
            this.checkBoxFadeIn.UseVisualStyleBackColor = true;
            this.checkBoxFadeIn.CheckedChanged += new System.EventHandler(this.checkBoxFadeIn_CheckedChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(52, 433);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(3, 30, 3, 20);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(255, 40);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxFadeOut
            // 
            this.checkBoxFadeOut.Checked = true;
            this.checkBoxFadeOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFadeOut.Location = new System.Drawing.Point(209, 36);
            this.checkBoxFadeOut.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.checkBoxFadeOut.Name = "checkBoxFadeOut";
            this.checkBoxFadeOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxFadeOut.Size = new System.Drawing.Size(67, 17);
            this.checkBoxFadeOut.TabIndex = 2;
            this.checkBoxFadeOut.Text = "FadeOut";
            this.checkBoxFadeOut.UseVisualStyleBackColor = true;
            this.checkBoxFadeOut.CheckedChanged += new System.EventHandler(this.checkBoxFadeOut_CheckedChanged);
            // 
            // numericUpDownFadeTime
            // 
            this.numericUpDownFadeTime.Location = new System.Drawing.Point(52, 73);
            this.numericUpDownFadeTime.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.numericUpDownFadeTime.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.numericUpDownFadeTime.Name = "numericUpDownFadeTime";
            this.numericUpDownFadeTime.Size = new System.Drawing.Size(121, 20);
            this.numericUpDownFadeTime.TabIndex = 3;
            // 
            // labelFadeTime
            // 
            this.labelFadeTime.AutoSize = true;
            this.labelFadeTime.Location = new System.Drawing.Point(51, 47);
            this.labelFadeTime.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelFadeTime.Name = "labelFadeTime";
            this.labelFadeTime.Size = new System.Drawing.Size(69, 13);
            this.labelFadeTime.TabIndex = 4;
            this.labelFadeTime.Text = "Fade Time In";
            // 
            // labelTimeUnit
            // 
            this.labelTimeUnit.AutoSize = true;
            this.labelTimeUnit.Location = new System.Drawing.Point(183, 47);
            this.labelTimeUnit.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelTimeUnit.Name = "labelTimeUnit";
            this.labelTimeUnit.Size = new System.Drawing.Size(52, 13);
            this.labelTimeUnit.TabIndex = 5;
            this.labelTimeUnit.Text = "Time Unit";
            // 
            // comboBoxTimeUnit
            // 
            this.comboBoxTimeUnit.FormattingEnabled = true;
            this.comboBoxTimeUnit.Location = new System.Drawing.Point(186, 72);
            this.comboBoxTimeUnit.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.comboBoxTimeUnit.Name = "comboBoxTimeUnit";
            this.comboBoxTimeUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTimeUnit.TabIndex = 6;
            // 
            // checkBoxChangeCurveType
            // 
            this.checkBoxChangeCurveType.AutoSize = true;
            this.checkBoxChangeCurveType.Location = new System.Drawing.Point(21, 183);
            this.checkBoxChangeCurveType.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.checkBoxChangeCurveType.Name = "checkBoxChangeCurveType";
            this.checkBoxChangeCurveType.Size = new System.Drawing.Size(121, 17);
            this.checkBoxChangeCurveType.TabIndex = 7;
            this.checkBoxChangeCurveType.Text = "Change Curve Type";
            this.checkBoxChangeCurveType.UseVisualStyleBackColor = true;
            this.checkBoxChangeCurveType.CheckedChanged += new System.EventHandler(this.checkBoxChangeCurveType_CheckedChanged);
            // 
            // pictureBoxDrawArea
            // 
            this.pictureBoxDrawArea.Location = new System.Drawing.Point(21, 66);
            this.pictureBoxDrawArea.Name = "pictureBoxDrawArea";
            this.pictureBoxDrawArea.Size = new System.Drawing.Size(255, 70);
            this.pictureBoxDrawArea.TabIndex = 8;
            this.pictureBoxDrawArea.TabStop = false;
            this.pictureBoxDrawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDrawArea_Paint);
            // 
            // comboBoxFadeInCurve
            // 
            this.comboBoxFadeInCurve.FormattingEnabled = true;
            this.comboBoxFadeInCurve.Location = new System.Drawing.Point(21, 149);
            this.comboBoxFadeInCurve.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxFadeInCurve.Name = "comboBoxFadeInCurve";
            this.comboBoxFadeInCurve.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFadeInCurve.TabIndex = 9;
            this.comboBoxFadeInCurve.SelectedIndexChanged += new System.EventHandler(this.comboBoxFadeInCurve_SelectedIndexChanged);
            // 
            // comboBoxFadeOutCurve
            // 
            this.comboBoxFadeOutCurve.FormattingEnabled = true;
            this.comboBoxFadeOutCurve.Location = new System.Drawing.Point(155, 149);
            this.comboBoxFadeOutCurve.Name = "comboBoxFadeOutCurve";
            this.comboBoxFadeOutCurve.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFadeOutCurve.TabIndex = 10;
            this.comboBoxFadeOutCurve.SelectedIndexChanged += new System.EventHandler(this.comboBoxFadeOutCurve_SelectedIndexChanged);
            // 
            // groupBoxCurves
            // 
            this.groupBoxCurves.Controls.Add(this.checkBoxFadeIn);
            this.groupBoxCurves.Controls.Add(this.comboBoxFadeOutCurve);
            this.groupBoxCurves.Controls.Add(this.checkBoxFadeOut);
            this.groupBoxCurves.Controls.Add(this.comboBoxFadeInCurve);
            this.groupBoxCurves.Controls.Add(this.checkBoxChangeCurveType);
            this.groupBoxCurves.Controls.Add(this.pictureBoxDrawArea);
            this.groupBoxCurves.Location = new System.Drawing.Point(31, 178);
            this.groupBoxCurves.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.groupBoxCurves.Name = "groupBoxCurves";
            this.groupBoxCurves.Size = new System.Drawing.Size(296, 222);
            this.groupBoxCurves.TabIndex = 11;
            this.groupBoxCurves.TabStop = false;
            this.groupBoxCurves.Text = "Curves";
            // 
            // comboBoxScriptMode
            // 
            this.comboBoxScriptMode.FormattingEnabled = true;
            this.comboBoxScriptMode.Location = new System.Drawing.Point(52, 106);
            this.comboBoxScriptMode.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxScriptMode.Name = "comboBoxScriptMode";
            this.comboBoxScriptMode.Size = new System.Drawing.Size(255, 21);
            this.comboBoxScriptMode.TabIndex = 11;
            this.comboBoxScriptMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxScriptMode_SelectedIndexChanged);
            // 
            // comboBoxApplyTo
            // 
            this.comboBoxApplyTo.FormattingEnabled = true;
            this.comboBoxApplyTo.Location = new System.Drawing.Point(52, 140);
            this.comboBoxApplyTo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxApplyTo.Name = "comboBoxApplyTo";
            this.comboBoxApplyTo.Size = new System.Drawing.Size(255, 21);
            this.comboBoxApplyTo.TabIndex = 12;
            // 
            // menuStripTopMenu
            // 
            this.menuStripTopMenu.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStripTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editScriptToolStripMenuItem});
            this.menuStripTopMenu.Location = new System.Drawing.Point(0, 0);
            this.menuStripTopMenu.Name = "menuStripTopMenu";
            this.menuStripTopMenu.Size = new System.Drawing.Size(358, 27);
            this.menuStripTopMenu.TabIndex = 13;
            this.menuStripTopMenu.Text = "menuStrip1";
            // 
            // editScriptToolStripMenuItem
            // 
            this.editScriptToolStripMenuItem.Name = "editScriptToolStripMenuItem";
            this.editScriptToolStripMenuItem.Size = new System.Drawing.Size(82, 23);
            this.editScriptToolStripMenuItem.Text = "Edit Script";
            this.editScriptToolStripMenuItem.Click += new System.EventHandler(this.editScriptToolStripMenuItem_Click);
            // 
            // FaderForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 520);
            this.Controls.Add(this.comboBoxApplyTo);
            this.Controls.Add(this.comboBoxScriptMode);
            this.Controls.Add(this.groupBoxCurves);
            this.Controls.Add(this.comboBoxTimeUnit);
            this.Controls.Add(this.labelTimeUnit);
            this.Controls.Add(this.labelFadeTime);
            this.Controls.Add(this.numericUpDownFadeTime);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.menuStripTopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripTopMenu;
            this.Name = "FaderForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fader";
            this.Load += new System.EventHandler(this.FaderForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FaderForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFadeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawArea)).EndInit();
            this.groupBoxCurves.ResumeLayout(false);
            this.groupBoxCurves.PerformLayout();
            this.menuStripTopMenu.ResumeLayout(false);
            this.menuStripTopMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxFadeIn;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxFadeOut;
        private System.Windows.Forms.NumericUpDown numericUpDownFadeTime;
        private System.Windows.Forms.Label labelFadeTime;
        private System.Windows.Forms.Label labelTimeUnit;
        private System.Windows.Forms.ComboBox comboBoxTimeUnit;
        private System.Windows.Forms.CheckBox checkBoxChangeCurveType;
        private System.Windows.Forms.PictureBox pictureBoxDrawArea;
        private System.Windows.Forms.ComboBox comboBoxFadeInCurve;
        private System.Windows.Forms.ComboBox comboBoxFadeOutCurve;
        private System.Windows.Forms.GroupBox groupBoxCurves;
        private System.Windows.Forms.ComboBox comboBoxScriptMode;
        private System.Windows.Forms.ComboBox comboBoxApplyTo;
        private System.Windows.Forms.MenuStrip menuStripTopMenu;
        private System.Windows.Forms.ToolStripMenuItem editScriptToolStripMenuItem;
    }
}