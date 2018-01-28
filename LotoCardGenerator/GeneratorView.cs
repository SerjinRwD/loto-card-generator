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

        Models.NumbersPool NumbersPool;
        Models.NumberSet NumberSet;
        Models.Card Card;
        Renders.ICardRender Render;

        int currentValue;

        public GeneratorView()
        {
            InitializeComponent();

            _writer = new Utils.TextBoxStreamWriter(txtConsole);
            Console.SetOut(_writer);

            NumberSet = new Models.NumberSet(10, 19);
            NumbersPool = new Models.NumbersPool();
        }

        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            currentValue = NumberSet.GetNextNumber();
            lblLastNumber.Text = currentValue.ToString();

            Console.WriteLine(currentValue);
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            NumberSet.MarkValue(currentValue, true);

            Console.WriteLine("\r\n------------\r\n");
        }

        private void btnRenderCard_Click(object sender, EventArgs e)
        {
            var cb = new Models.CardBuilder();
            var sb = new StringBuilder();

            Card = cb.Build(NumbersPool);

            Render = new Renders.TextCardRender()
            {
                builder = sb
            };

            Render.Render(Card);

            Console.WriteLine(sb.ToString());
        }

        private void btnResetSet_Click(object sender, EventArgs e)
        {
            NumberSet.Reset();
            Console.WriteLine("\r\n--- (NumberSet перезагружен) ---\r\n");
        }

        private void btnResetPool_Click(object sender, EventArgs e)
        {
            NumbersPool.Reset();
            Console.WriteLine("\r\n--- (NumbersPool перезагружен) ---\r\n");
        }

        private void btnMakeBatch_Click(object sender, EventArgs e)
        {
            var b = new Models.CardBatchBuilder();

            var size = (int)nudBatchSize.Value;


            List<Models.Card> cards = null;

            try
            {
                cards = b.Build(size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Что-то пошло не так.");
                return;
            }

            lblDoublesOccurs.Text = b.DoublesOccurs.ToString();

            var sb = new StringBuilder();
            Render = new Renders.TextCardRender()
            {
                builder = sb
            };

            sb.AppendLine("====== (( Новая партия )) ======");

            for (var i = 0; i < cards.Count; i++)
            {
                var card = cards[i];
                sb.AppendLine($"--- ( Карта #{i + 1} ) ---");

                Render.Render(card);
            }

            sb.AppendLine("====== (( Конец партии )) ======");

            Console.Write(sb.ToString());
        }
    }
}
