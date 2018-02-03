using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoCardGenerator.Renders
{
    public class PdfBatchCardRender
    {
        public PdfCardRender CardRender { get; set; }
        public PdfDocument Document { get; set; }

        public const int CARDS_PER_PAGE = 4;

        public void Render(IEnumerable<Models.Card> batch)
        {
            if(CardRender == null)
            {
                throw new InvalidOperationException("Необходимо назначить CardRender");
            }

            if(Document == null)
            {
                throw new InvalidOperationException("Необходимо назначить Document");
            }

            if(batch == null || batch.Count() == 0)
            {
                throw new ArgumentNullException(nameof(batch));
            }

            var counter = 0;
            var batchSize = batch.Count();

            CardRender.Page = Document.AddPage();

            foreach(var card in batch)
            {
                if(counter > 0 && counter % CARDS_PER_PAGE == 0)
                {
                    CardRender.Page = Document.AddPage();
                    counter = 0;
                }

                CardRender.PageOffsetY = PdfCardRender.HEIGHT_FULL * counter;
                CardRender.Render(card);

                counter++;
            }
        }
    }
}
