namespace TickTimestampConverter
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void uxConvertTimeButton_Click(object sender, EventArgs e)
        {
            var text = uxInsertTimestamp.Text;
            long number;
            var success = long.TryParse(text, out number);
            if (success)
            {
                errorLabel.Visible = false;
                var datetime = new DateTime(number);
                //Reverse datetime, good for sorting in filenames.
                var formattedDateTime = datetime.ToString("yyMMdd-Hmmss");
                uxOutputDateTime.Text = formattedDateTime;
            }
            else
            {
                errorLabel.Visible = true;
            }
        }
    }
}