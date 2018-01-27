using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoCardGenerator
{
    public partial class GeneratorView : Form
    {
        private Utils.TextBoxStreamWriter _writer;

        Models.NumberSet NumberSet;

        int currentValue;

        public GeneratorView()
        {
            InitializeComponent();

            _writer = new Utils.TextBoxStreamWriter(txtConsole);
            Console.SetOut(_writer);

            NumberSet = new Models.NumberSet(10, 19);
        }

        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            currentValue = NumberSet.GetNextNumber();

            Console.WriteLine(currentValue);
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            NumberSet.MarkValue(currentValue, true);

            Console.WriteLine("\r\n------------\r\n");
        }
    }
}
