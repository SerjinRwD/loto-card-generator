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

        public GeneratorView()
        {
            InitializeComponent();

            _writer = new Utils.TextBoxStreamWriter(txtConsole);
            Console.SetOut(_writer);

            Console.WriteLine($"Задайте \"{lblBatchSize.Text}\", чтобы указать количество карт в партии.");
            Console.WriteLine($"Нажмите \"{btnMakeBatch.Text}\", чтобы создать партию карт.");
        }

        private void btnMakeBatch_Click(object sender, EventArgs e)
        {
            var size = (int)nudBatchSize.Value;

            savePdfDialog.FileName = $"batch_{DateTime.Now:yyyyMMddHHmmss}_{size}x{lblPageCount.Text}.pdf";

            if (savePdfDialog.ShowDialog() != DialogResult.OK)
            {
                Console.WriteLine("Операция отменена");
                return;
            }

            try
            {
                var b = new Models.CardBatchBuilder();

                var doc = new PdfSharp.Pdf.PdfDocument();
                var cardRender = new Renders.PdfCardRender();

                var batchRender = new Renders.PdfBatchCardRender
                {
                    CardRender = cardRender,
                    Document = doc
                };

                var cards = b.Build(size);

                Console.WriteLine($"Сгенерировано {cards.Count()} карт.");
                Console.WriteLine($"Сбросов из-за дублей: {b.DoublesOccurs}");

                Console.WriteLine($"Начата отрисовка карт...");
                batchRender.Render(cards);

                Console.WriteLine($"Начато сохранение карт в файл...");
                doc.Save(savePdfDialog.FileName);

                Console.WriteLine($"Готово. Партия сохранена в файл \"{savePdfDialog.FileName}\". Страниц: {doc.PageCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Что-то пошло не так: {ex.Message}");
                return;
            }
        }

        private void nudBatchSize_ValueChanged(object sender, EventArgs e)
        {
            var size = (int)nudBatchSize.Value;

            lblPageCount.Text = Math.Ceiling(size / (double)Renders.PdfBatchCardRender.CARDS_PER_PAGE).ToString();
        }
    }
}
