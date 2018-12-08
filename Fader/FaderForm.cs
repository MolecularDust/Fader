using ScriptPortal.Vegas;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Fader
{
    public partial class FaderForm : Form
    {
        Settings Settings { get; set; }

        Graphics DrawArea;
        Pen Pen;
        PictureBox Box;
        int BoxRight;
        int BoxBottom;
        int BoxLeft;
        int BoxTop;

        public FaderForm(Settings settings)
        {
            InitializeComponent();

            Settings = settings;

            DrawArea = pictureBoxDrawArea.CreateGraphics();
            DrawArea.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Box = pictureBoxDrawArea;
            BoxLeft = 1;
            BoxTop = 1;
            BoxRight = Box.Width - 2;
            BoxBottom = Box.Height - 2;
            Pen = new Pen(Color.LightGray, 4);

            this.numericUpDownFadeTime.DataBindings.Add("Value", Settings, "FadeTime", false, DataSourceUpdateMode.OnPropertyChanged);

            this.comboBoxTimeUnit.DataSource = Enum.GetValues(typeof(TimeUnit));
            this.comboBoxTimeUnit.DataBindings.Add("SelectedItem", Settings, "TimeUnit", false, DataSourceUpdateMode.OnPropertyChanged);

            this.comboBoxScriptMode.DataSource = new BindingSource(Settings.ScriptModesList, null);
            this.comboBoxScriptMode.DisplayMember = "Value";
            this.comboBoxScriptMode.ValueMember = "Key";
            this.comboBoxScriptMode.DataBindings.Add("SelectedValue", Settings, "ScriptMode", false, DataSourceUpdateMode.OnPropertyChanged);

            this.comboBoxApplyTo.DataSource = new BindingSource(Settings.ApplyToList, null);
            this.comboBoxApplyTo.DisplayMember = "Value";
            this.comboBoxApplyTo.ValueMember = "Key";
            this.comboBoxApplyTo.DataBindings.Add("SelectedValue", Settings, "ApplyTo", false, DataSourceUpdateMode.OnPropertyChanged);

            this.checkBoxFadeIn.DataBindings.Add("Checked", Settings, "FadeIn", false, DataSourceUpdateMode.OnPropertyChanged);
            this.checkBoxFadeOut.DataBindings.Add("Checked", Settings, "FadeOut", false, DataSourceUpdateMode.OnPropertyChanged);

            this.checkBoxChangeCurveType.DataBindings.Add("Checked", Settings, "ChangeCurveType", false, DataSourceUpdateMode.OnPropertyChanged);

            this.comboBoxFadeInCurve.DataSource = new BindingSource(Settings.CurveTypeList, null);
            this.comboBoxFadeInCurve.DisplayMember = "Value";
            this.comboBoxFadeInCurve.ValueMember = "Key";
            this.comboBoxFadeInCurve.DataBindings.Add("SelectedValue", Settings, "FadeInCurveType", false, DataSourceUpdateMode.OnPropertyChanged);
            this.comboBoxFadeInCurve.DataBindings.Add("Enabled", Settings, "ChangeCurveType", false, DataSourceUpdateMode.OnPropertyChanged);


            this.comboBoxFadeOutCurve.DataSource = new BindingSource(Settings.CurveTypeList, null);
            this.comboBoxFadeOutCurve.DisplayMember = "Value";
            this.comboBoxFadeOutCurve.ValueMember = "Key";
            this.comboBoxFadeOutCurve.DataBindings.Add("SelectedValue", Settings, "FadeOutCurveType", false, DataSourceUpdateMode.OnPropertyChanged);
            this.comboBoxFadeOutCurve.DataBindings.Add("Enabled", Settings, "ChangeCurveType", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FaderForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.I:
                    this.checkBoxFadeIn.Checked = !this.checkBoxFadeIn.Checked;
                    break;
                case Keys.O:
                    this.checkBoxFadeOut.Checked = !this.checkBoxFadeOut.Checked;
                    break;
            }
        }

        private void FaderForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = this.numericUpDownFadeTime;
            this.numericUpDownFadeTime.Select(0, numericUpDownFadeTime.Text.Length);
        }



        private void pictureBoxDrawArea_Paint(object sender, PaintEventArgs e)
        {
            DrawCurves(e.Graphics);
        }

        private void DrawCurves(Graphics graphics)
        {
            graphics.DrawRectangle(Pen, BoxLeft, BoxTop, BoxRight, BoxBottom);
            DrawCurve(FadeIs.In, (CurveType)this.comboBoxFadeInCurve.SelectedValue, graphics);
            DrawCurve(FadeIs.Out, (CurveType)this.comboBoxFadeOutCurve.SelectedValue, graphics);
        }

        enum FadeIs
        {
            In,
            Out
        }

        void DrawCurve(FadeIs fadeIs, CurveType curve, Graphics graphics)
        {
            Point p1 = new Point();
            Point c1 = new Point();
            Point c2 = new Point();
            Point p2 = new Point();

            Point FadeInLeftBottom = new Point(BoxLeft, BoxBottom);
            Point FadeInRightTop = new Point(Convert.ToInt32(0.25 * Box.Width), BoxTop);

            Point FadeOutLeftTop = new Point(Convert.ToInt32(0.75 * Box.Width), BoxTop);
            Point FadeOutRightBottom = new Point(Box.Width, BoxBottom);

            int FadeLength = FadeInRightTop.X;

            if (fadeIs == FadeIs.In)
            {
                switch (curve)
                {
                    case CurveType.Fast:
                        // In Fast Curve
                        p1 = FadeInLeftBottom;   // Start point
                        c1 = new Point(BoxLeft, Convert.ToInt32(BoxBottom * 0.5));   // First control point
                        c2 = new Point(Convert.ToInt32(FadeInRightTop.X * 0.5), BoxTop);  // Second control point
                        p2 = FadeInRightTop;  // Endpoint
                        break;
                    case CurveType.Linear:
                        // In Linear Curve
                        p1 = FadeInLeftBottom;   // Start point
                        c1 = FadeInLeftBottom;   // First control point
                        c2 = FadeInRightTop;  // Second control point
                        p2 = FadeInRightTop;  // Endpoint
                        break;
                    case CurveType.Sharp:
                        // In Sharp Curve
                        p1 = FadeInLeftBottom;   // Start point
                        c1 = new Point(BoxLeft, Convert.ToInt32(BoxBottom * 0.33));   // First control point
                        c2 = new Point(FadeInRightTop.X, Convert.ToInt32(BoxBottom * 0.66));  // Second control point
                        p2 = FadeInRightTop;  // Endpoint
                        break;
                    case CurveType.Slow:
                        // In Slow Curve
                        p1 = FadeInLeftBottom;   // Start point
                        c1 = new Point(Convert.ToInt32(FadeInRightTop.X * 0.5), BoxBottom);   // First control point
                        c2 = new Point(FadeInRightTop.X, Convert.ToInt32(BoxBottom * 0.5));  // Second control point
                        p2 = FadeInRightTop;  // Endpoint
                        break;
                    case CurveType.Smooth:
                        // In Smooth Curve
                        p1 = FadeInLeftBottom;   // Start point
                        c1 = new Point(Convert.ToInt32(FadeInRightTop.X * 0.66), BoxBottom);   // First control point
                        c2 = new Point(Convert.ToInt32(FadeInRightTop.X * 0.33), BoxTop);  // Second control point
                        p2 = FadeInRightTop;  // Endpoint
                        break;
                }
            }
            else // Out
            {
                switch (curve)
                {
                    case CurveType.Fast:
                        // Out Fast Curve
                        p1 = FadeOutLeftTop;   // Start point
                        c1 = new Point(FadeOutLeftTop.X, Convert.ToInt32(BoxBottom * 0.5));   // First control point
                        c2 = new Point(Convert.ToInt32(BoxRight - FadeLength * 0.5), BoxBottom);  // Second control point
                        p2 = FadeOutRightBottom;  // Endpoint
                        break;
                    case CurveType.Linear:
                        // Out Linear Curve
                        p1 = FadeOutLeftTop;   // Start point
                        c1 = FadeOutLeftTop;   // First control point
                        c2 = FadeOutRightBottom;  // Second control point
                        p2 = FadeOutRightBottom;  // Endpoint
                        break;
                    case CurveType.Sharp:
                        // Out Sharp Curve
                        p1 = FadeOutLeftTop;   // Start point
                        c1 = new Point(FadeOutLeftTop.X, Convert.ToInt32(BoxBottom * 0.66));   // First control point
                        c2 = new Point(BoxRight, Convert.ToInt32(BoxBottom * 0.33));  // Second control point
                        p2 = new Point(BoxRight, BoxBottom);  // Endpoint
                        break;
                    case CurveType.Slow:
                        // Out Slow Curve
                        p1 = FadeOutLeftTop;   // Start point
                        c1 = new Point(FadeOutLeftTop.X + Convert.ToInt32(FadeLength * 0.5), BoxTop);   // First control point
                        c2 = new Point(BoxRight, Convert.ToInt32(BoxBottom * 0.5));  // Second control point
                        p2 = FadeOutRightBottom;  // Endpoint
                        break;
                    case CurveType.Smooth:
                        // Out Smooth Curve
                        p1 = FadeOutLeftTop;   // Start point
                        c1 = new Point(FadeOutLeftTop.X + Convert.ToInt32(FadeLength * 0.66), BoxTop);   // First control point
                        c2 = new Point(FadeOutLeftTop.X + Convert.ToInt32(FadeLength * 0.33), BoxBottom);  // Second control point
                        p2 = FadeOutRightBottom;  // Endpoint
                        break;
                }
            }
            graphics.DrawBezier(Pen, p1, c1, c2, p2);
        }

        private void checkBoxChangeCurveType_CheckedChanged(object sender, EventArgs e)
        {
            FadeComboboxesEnableUpdate();
        }

        private void comboBoxFadeInCurve_SelectedIndexChanged(object sender, EventArgs e)
        {
            Box.Invalidate(); // Clear draw area
        }

        private void comboBoxFadeOutCurve_SelectedIndexChanged(object sender, EventArgs e)
        {
            Box.Invalidate(); // Clear draw area
        }

        private void checkBoxFadeOut_CheckedChanged(object sender, EventArgs e)
        {

            FadeComboboxesEnableUpdate();
        }

        private void checkBoxFadeIn_CheckedChanged(object sender, EventArgs e)
        {

            FadeComboboxesEnableUpdate();
        }

        void FadeComboboxesEnableUpdate()
        {
            if (this.checkBoxFadeIn.Checked && this.checkBoxChangeCurveType.Checked)
                this.comboBoxFadeInCurve.Enabled = true;
            else
                this.comboBoxFadeInCurve.Enabled = false;

            if (this.checkBoxFadeOut.Checked && this.checkBoxChangeCurveType.Checked)
                this.comboBoxFadeOutCurve.Enabled = true;
            else
                this.comboBoxFadeOutCurve.Enabled = false;
        }

        private void comboBoxScriptMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Settings.ScriptMode)
            {
                case ScriptMode.AddFades:
                    this.numericUpDownFadeTime.Enabled = true;
                    this.comboBoxTimeUnit.Enabled = true;
                    break;
                case ScriptMode.ChangeFades:
                    this.numericUpDownFadeTime.Enabled = false;
                    this.comboBoxTimeUnit.Enabled = false;
                    this.checkBoxChangeCurveType.Checked = true;
                    break;
                case ScriptMode.RemoveFades:
                    this.numericUpDownFadeTime.Enabled = false;
                    this.comboBoxTimeUnit.Enabled = false;
                    this.checkBoxChangeCurveType.Checked = false;
                    this.checkBoxChangeCurveType.Enabled = false;
                    break;
            }
        }

        private void editScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fullPath = Settings.Vegas.InstallationDirectory + "\\Script Menu" + "\\" + Settings.ScriptFileName; ;
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = "notepad.exe";
                proc.StartInfo.Arguments = fullPath;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
                proc.Start();
                this.Close();
            }
            catch (Exception ex)
            {
                if (ex.Message != "The operation was canceled by the user")
                    MessageBox.Show(
                        string.Format("Failed to open {0} in Notepad.", fullPath) + Environment.NewLine + Environment.NewLine + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
        }
    }
}
