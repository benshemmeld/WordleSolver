namespace WordleSolver.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtPosition1.KeyUp += TextboxKeyUp;
            txtPosition2.KeyUp += TextboxKeyUp;
            txtPosition3.KeyUp += TextboxKeyUp;
            txtPosition4.KeyUp += TextboxKeyUp;
            txtPosition5.KeyUp += TextboxKeyUp;

            txtPosition1.Click += TextBoxClick;
            txtPosition2.Click += TextBoxClick;
            txtPosition3.Click += TextBoxClick;
            txtPosition4.Click += TextBoxClick;
            txtPosition5.Click += TextBoxClick;
        }

        private void TextBoxClick(object? sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.BackColor == Color.Gray)
            {
                textbox.BackColor = Color.Goldenrod;
            }
            else if (textbox.BackColor == Color.Goldenrod)
            {
                textbox.BackColor = Color.ForestGreen;
            }
            else if (textbox.BackColor == Color.ForestGreen)
            {
                textbox.BackColor = Color.Gray;
            }
        }

        private void TextboxKeyUp(object? sender, KeyEventArgs e)
        {
            var textbox = (TextBox) sender;
            textbox.Text = textbox.Text.ToUpper();

            var tabIndex = textbox.TabIndex;
            var nextTextBox = this.Controls.OfType<TextBox>().FirstOrDefault(x => x.TabIndex == tabIndex + 1);
            if (nextTextBox != null)
            {
                nextTextBox.Focus();
            }
        }
    }
}