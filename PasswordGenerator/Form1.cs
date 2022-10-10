namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public static bool uppercaseChecked;
        public static bool lowercaseChecked;
        public static bool numbersChecked;
        public static bool symbolsChecked;
        public static int passwordLength = 0;

        private static string passwordCharsString = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            passwordLength = int.Parse(numericUpDown1.Text);
            PasswordShowLabel.Text = generatePassword(passwordLength);

            if(passwordLength == 6)
            {
                numericUpDown1.Text = "20";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uppercaseChecked = UppercaseCheck.Checked ? true : false;
            lowercaseChecked = LowercaseCheck.Checked ? true : false;
            numbersChecked = NumbersCheck.Checked ? true : false;
            symbolsChecked = SymbolsCheck.Checked ? true : false;   
        }

        private static string returnUpperCaseCharacters()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, chars.Length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string returnLowercaseCharacters()
        {
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, chars.Length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string returnNumbers()
        {
            Random random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, chars.Length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string returnSymbols()
        {
            Random random = new Random();
            const string chars = "@!#$%&/()=?»«@£§€{}.-;'<>_,";
            return new string(Enumerable.Repeat(chars, chars.Length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string generatePassword(int length)
        {
            string passwordChars = "";

            if (uppercaseChecked)
            {
                passwordChars += returnUpperCaseCharacters();
            }

            if (lowercaseChecked)
            {
                passwordChars += returnLowercaseCharacters();
            }

            if (numbersChecked)
            {
                passwordChars += returnNumbers();
            }

            if (symbolsChecked)
            {
                passwordChars += returnSymbols();
            }

            Random random = new Random();

            if(passwordChars != String.Empty && length > 0)
            {
                var chars = Enumerable.Range(0, length-1)
         .Select(x => passwordChars[random.Next(0, passwordChars.Length)]);
                return new string(chars.ToArray());
            } else
            {
                return "Check a box!";
            }
            
        }

        private void UppercaseCheck_CheckedChanged(object sender, EventArgs e)
        {
            uppercaseChecked = UppercaseCheck.Checked ? true : false;

        }

        private void LowercaseCheck_CheckedChanged(object sender, EventArgs e)
        {
            lowercaseChecked = LowercaseCheck.Checked ? true : false;
        }

        private void NumbersCheck_CheckedChanged(object sender, EventArgs e)
        {
            numbersChecked = NumbersCheck.Checked ? true : false;
        }

        private void SymbolsCheck_CheckedChanged(object sender, EventArgs e)
        {
            symbolsChecked = SymbolsCheck.Checked ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(PasswordShowLabel.Text);
        }
    }

}