using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using TextBox = System.Windows.Forms.TextBox;

namespace GeometryUI
{
    public partial class MainForm : Form
    {
        public MainForm() {
            InitializeComponent();
        }

        public void clearWindowsForms() {
            txtCubeSide.Clear();
            txtPyrSide.Clear();
            txtPyrHeight.Clear();
            txtCylRadius.Clear();
            txtCylHeight.Clear();
            txtConeRadius.Clear();
            txtConeHeight.Clear();
            txtSphere.Clear();
            lblS.Text = "";
            lblV.Text = "";
            lblConeS.Text = "";
            lblConeV.Text = "";
            labelSCyl.Text = "";
            labelVCyl.Text = "";
            lblPyrS.Text = "";
            lblPyrV.Text = "";
            labelCubeS.Text = "";
            labelCubeV.Text = "";
        }

        public void raiseSyntaxError() {
            DialogResult dr = MessageBox.Show("An error has occured.", "Syntax error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            clearWindowsForms();
        }

        private void btnCube_Click(object sender, EventArgs e) {
            clearWindowsForms();
            panelCube.Visible = true;
            panelPyr.Visible = false;
            panelCyl.Visible = false;
            panelCone.Visible = false;
            panelSphere.Visible = false;
            WelcomePanel.Visible = false;
            btnCube.BackColor = Color.FromArgb(26, 20, 21);
            btnPyr.BackColor = Color.FromArgb(115, 16, 24);
            btnCyl.BackColor = Color.FromArgb(115, 16, 24);
            btnCone.BackColor = Color.FromArgb(115, 16, 24);
            btnSph.BackColor = Color.FromArgb(115, 16, 24);
        }

        private void btnCubeCalc_Click(object sender, EventArgs e) {
            var isNumeric = double.TryParse(txtCubeSide.Text, out _);
            if (string.IsNullOrEmpty(txtCubeSide.Text) || isNumeric == false) {
                raiseSyntaxError();
            }
            else {
                double CubeSide = double.Parse(txtCubeSide.Text);
                double S;
                double V;
                if (CubeSide > 0) {
                    S = 6 * Math.Pow(CubeSide, 2);
                    V = Math.Pow(CubeSide, 3);
                    labelCubeS.Text = String.Format("{0:0.00}", S).ToString() + " cm²";
                    labelCubeV.Text = String.Format("{0:0.00}", V).ToString() + " cm³";
                }
                else {
                    raiseSyntaxError();
                }
            }
        }

        private void btnPyr_Click(object sender, EventArgs e) {
            clearWindowsForms();
            panelPyr.Visible = true;
            panelCube.Visible = false;
            panelCyl.Visible = false;
            panelCone.Visible = false;
            panelSphere.Visible = false;
            WelcomePanel.Visible = false;
            btnCube.BackColor = Color.FromArgb(115, 16, 24);
            btnPyr.BackColor = Color.FromArgb(26, 20, 21);
            btnCyl.BackColor = Color.FromArgb(115, 16, 24);
            btnCone.BackColor = Color.FromArgb(115, 16, 24);
            btnSph.BackColor = Color.FromArgb(115, 16, 24);    
        }

        private void button1_Click(object sender, EventArgs e) {
            var isNumericSide = double.TryParse(txtPyrSide.Text, out _);
            var isNumericHeight = double.TryParse(txtPyrHeight.Text, out _);
            if ((string.IsNullOrEmpty(txtPyrSide.Text) || string.IsNullOrEmpty(txtPyrHeight.Text))
                || (isNumericSide == false || isNumericHeight == false)) { 
                raiseSyntaxError();
            }
            else {
                double PyrSide = double.Parse(txtPyrSide.Text);
                double PyrHeight = double.Parse(txtPyrHeight.Text);
                double S;
                double V;
                if (PyrSide > 0 && PyrHeight > 0) {
                    S = Math.Pow(PyrSide, 2) + 2 * PyrSide * Math.Sqrt((Math.Pow(PyrSide, 2) / 4) + Math.Pow(PyrHeight, 2));
                    V = (Math.Pow(PyrSide, 2) * PyrHeight) / 3;
                    lblPyrS.Text = String.Format("{0:0.00}", S).ToString() + " cm²";
                    lblPyrV.Text = String.Format("{0:0.00}", V).ToString() + " cm³";
                }
                else {
                    raiseSyntaxError();
                }
            }
        }

        private void CylCalc_Click(object sender, EventArgs e) {
            var isNumericRadius = double.TryParse(txtCylRadius.Text, out _);
            var isNumericHeight = double.TryParse(txtCylHeight.Text, out _);
            if ((string.IsNullOrEmpty(txtCylRadius.Text) || string.IsNullOrEmpty(txtCylHeight.Text)) 
                || (isNumericRadius == false || isNumericHeight == false)) {
                raiseSyntaxError();
            }
            else {
                double CylRadius = double.Parse(txtCylRadius.Text);
                double CylHeight = double.Parse(txtCylHeight.Text);
                double S;
                double V;
                if (CylRadius > 0 && CylHeight > 0) {
                    S = 2 * Math.PI * CylRadius * (CylHeight + CylRadius);
                    V = Math.PI * Math.Pow(CylRadius, 2) * CylHeight;
                    labelSCyl.Text = String.Format("{0:0.00}", S).ToString() + " cm²";
                    labelVCyl.Text = String.Format("{0:0.00}", V).ToString() + " cm³";
                }
                else {
                    raiseSyntaxError();
                }
            }
        }

        private void btnCyl_Click(object sender, EventArgs e) {
            clearWindowsForms();
            panelCyl.Visible = true;
            panelCube.Visible = false;
            panelPyr.Visible = false;
            panelCone.Visible = false;
            panelSphere.Visible = false;
            WelcomePanel.Visible = false;
            btnCube.BackColor = Color.FromArgb(115, 16, 24);
            btnPyr.BackColor = Color.FromArgb(115, 16, 24);
            btnCyl.BackColor = Color.FromArgb(26, 20, 21);
            btnCone.BackColor = Color.FromArgb(115, 16, 24);
            btnSph.BackColor = Color.FromArgb(115, 16, 24);
        }

        private void btnCone_Click(object sender, EventArgs e) {
            clearWindowsForms();
            panelCone.Visible = true;
            panelCube.Visible = false;
            panelCyl.Visible = false;
            panelPyr.Visible = false;
            panelSphere.Visible = false;
            WelcomePanel.Visible = false;
            btnCube.BackColor = Color.FromArgb(115, 16, 24);
            btnPyr.BackColor = Color.FromArgb(115, 16, 24);
            btnCyl.BackColor = Color.FromArgb(115, 16, 24);
            btnCone.BackColor = Color.FromArgb(26, 20, 21);
            btnSph.BackColor = Color.FromArgb(115, 16, 24);
        }

        private void calcCone_Click(object sender, EventArgs e) {
            var isNumericRadius = double.TryParse(txtConeRadius.Text, out _);
            var isNumericHeight = double.TryParse(txtConeHeight.Text, out _);
            if ((string.IsNullOrEmpty(txtConeRadius.Text) || string.IsNullOrEmpty(txtConeHeight.Text)) 
                || (isNumericRadius == false || isNumericHeight == false)) {
                raiseSyntaxError();
            }
            else {
                double ConeRadius = double.Parse(txtConeRadius.Text);
                double ConeHeigth = double.Parse(txtConeHeight.Text);
                double S;
                double V;
                if (ConeRadius > 0 && ConeHeigth > 0) {
                    S = Math.PI * ConeRadius * (ConeRadius + Math.Sqrt(Math.Pow(ConeHeigth, 2) + Math.Pow(ConeRadius, 2)));
                    V = (Math.PI * Math.Pow(ConeRadius, 2) * ConeHeigth) / 3;
                    lblConeS.Text = String.Format("{0:0.00}", S).ToString() + " cm²";
                    lblConeV.Text = String.Format("{0:0.00}", V).ToString() + " cm³";
                }
                else {
                    raiseSyntaxError();
                }
            }
        }

        private void btnSph_Click(object sender, EventArgs e) {
            clearWindowsForms();
            panelCube.Visible = false;
            panelPyr.Visible = false;
            panelCyl.Visible = false;
            panelCone.Visible = false;
            panelSphere.Visible = true;
            WelcomePanel.Visible= false;
            btnCube.BackColor = Color.FromArgb(115, 16, 24);
            btnPyr.BackColor = Color.FromArgb(115, 16, 24);
            btnCyl.BackColor = Color.FromArgb(115, 16, 24);
            btnCone.BackColor = Color.FromArgb(115, 16, 24);
            btnSph.BackColor = Color.FromArgb(26, 20, 21);
        }

        private void buttonexit_Click(object sender, EventArgs e) {
            buttonexit.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            DialogResult dr= MessageBox.Show("Do you really want to exit Geometry UI?", "Exit?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e) {
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            MessageBox.Show("Created By Ivaylo Georgiev \nTU-Varna © 2023", "About",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e) {
            buttonHome.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            panelCube.Visible = false;
            panelPyr.Visible = false;
            panelCyl.Visible = false;
            panelCone.Visible = false;
            panelSphere.Visible = false;
            WelcomePanel.Visible = true;
            btnCube.BackColor = Color.FromArgb(115, 16, 24);
            btnPyr.BackColor = Color.FromArgb(115, 16, 24);
            btnCyl.BackColor = Color.FromArgb(115, 16, 24);
            btnCone.BackColor = Color.FromArgb(115, 16, 24);
            btnSph.BackColor = Color.FromArgb(115, 16, 24);
        }

        private void sphCalc_Click(object sender, EventArgs e) {
            var isNumeric = double.TryParse(txtSphere.Text, out _);
            if (string.IsNullOrEmpty(txtSphere.Text) || isNumeric == false) {
                raiseSyntaxError();
            }
            else {
                double sphereRadius = double.Parse(txtSphere.Text);
                double S;
                double V;
                if (sphereRadius > 0) {
                    S = 4 * Math.PI * Math.Pow(sphereRadius, 2);
                    V = (4 * Math.PI * Math.Pow(sphereRadius, 3)) / 3;
                    lblS.Text = String.Format("{0:0.00}", S).ToString() + " cm²";
                    lblV.Text = String.Format("{0:0.00}", V).ToString() + " cm³";
                }
                else {
                    raiseSyntaxError();
                }
            }
        }
    }
}
