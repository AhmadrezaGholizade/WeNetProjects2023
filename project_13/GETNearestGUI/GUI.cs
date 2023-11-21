using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace GETNearestGUI
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();

            // Subscribe event handlers to KeyPress events
            XBOX.KeyPress += XBOX_KeyPress;
            YBOX.KeyPress += YBOX_KeyPress;

            // Disable the maximize and minimize buttons
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Set the form border style to FixedDialog or FixedSingle
            this.FormBorderStyle = FormBorderStyle.FixedDialog;


            // Set the start position to manual
            this.StartPosition = FormStartPosition.Manual;

            // Set the location to the desired coordinate (e.g., x=100, y=100)
            this.Location = new Point(10, 10);
        }

        private void XBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter key pressed, simulate a button click
                button_search.PerformClick();
                // Prevent the system beep
                e.Handled = true;
            }
        }

        private void YBOX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Enter key pressed, simulate a button click
                button_search.PerformClick();
                // Prevent the system beep
                e.Handled = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GUI_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Button click event handler
        private void Button1_Click(object sender, EventArgs e)
        {
            bool v = TryConvertToFloat(XBOX.Text, YBOX.Text, out float xValue, out float yValue);
            if (v)
            {
                GeoService.ArchitecturalFirmsWebService Wservice = new GeoService.ArchitecturalFirmsWebService();

                GeoService.architectural_firms res = Wservice.GetNearestArchitecturalFirm(float.Parse(XBOX.Text), float.Parse(YBOX.Text));

                // showing Result page and hidden Error page
                result_group.Visible = true;
                error_group.Visible = false;

                X_label.Text = "X: " + res.X.ToString();
                FOUNDER_label.Text = "Founder: " + res.Founder.ToString();
                COUNTRY_label.Text = "Country: " + res.Country.ToString();
                NAME_label.Text = "Name: " + res.Name.ToString();
                Y_label.Text = "Y: " + res.Y.ToString();
                PROJECTS_label.Text = "Projects: " + res.Projects[0].ToString() + ", " + res.Projects[1].ToString();
                ID_label.Text = "ID: " + res.ID.ToString();
            }
            else
            {
                // hidden Result page and show Error page
                result_group.Visible = false;
                error_group.Visible = true;
            }
        }

        public static bool TryConvertToFloat(string str1, string str2, out float result1, out float result2)
        {
            result1 = result2 = 0.0f; // Default values in case of failure

            if (float.TryParse(str1, out result1) && float.TryParse(str2, out result2))
            {
                // Conversion successful
                return true;
            }

            // Conversion failed
            return false;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }
    }
}
