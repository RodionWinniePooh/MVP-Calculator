

namespace MVP_Project
{
    public partial class Form1 : Form, ICalculatorView
    {
        private readonly CalculatorPresenter _presenter;
        private const string FileName = "calculator-state.txt";

        public Form1()
        {
            InitializeComponent();
            _presenter = new CalculatorPresenter(this, new CalculatorModel());
            LoadState();
        }

        private void LoadState()
        {
            if (File.Exists(FileName))
            {
                string input = File.ReadAllText(FileName);
                txtInput.Text = input;
            }
        }

        private void SaveState()
        {
            File.WriteAllText(FileName, txtInput.Text);
        }


        public string Input
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }

        public event EventHandler Calculate;

        public void ShowResult(string result)
        {
            txtInput.Text = result;
        }

        public void ShowError(string message)
        {
            lblError.Text = message;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculate?.Invoke(this, EventArgs.Empty);
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '+' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                ShowError("Invalid input format. Please enter two valid numbers separated by a plus sign.");
            }
            else
            {
                lblError.Text = "";
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            SaveState();
        }
    }
}