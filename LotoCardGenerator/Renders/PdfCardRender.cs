using LotoCardGenerator.Models;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoCardGenerator.Renders
{
    public class PdfCardRender : ICardRender
    {
        public const double WIDTH_FULL = 595.267;
        public const double WIDTH_INNER = 586.772;
        public const double WIDTH_OFFSET = 4.252;
        public const double WIDTH_CELL = 65.197;
        public const double HEIGHT_FULL = 209.764;
        public const double HEIGHT_INNER = 204.094;
        public const double HEIGHT_OFFSET = 2.835;
        public const double HEIGHT_CELL = 68.031;
        public const double SIZE_FONT = 3.0 * (HEIGHT_CELL / 4.0);

        public PdfPage Page { get; set; }
        public double PageOffsetX { get; set; }
        public double PageOffsetY { get; set; }

        public void Render(Card card)
        {
            using (var gfx = XGraphics.FromPdfPage(Page))
            {
                var font = new XFont(
                    "Times New Roman",
                    SIZE_FONT,
                    XFontStyle.Bold);

                // Рамки карточки
                gfx.DrawRectangles(XBrushes.Gray, new XRect[]
                    {
                    // top
                    new XRect(
                        0.0,        PageOffsetY + 0.0,
                        WIDTH_FULL, HEIGHT_OFFSET),

                    // right
                    new XRect(
                        WIDTH_FULL - WIDTH_OFFSET, PageOffsetY + 0.0,
                        WIDTH_OFFSET,              HEIGHT_FULL),

                    // bottom
                    new XRect(
                        0.0,        PageOffsetY + HEIGHT_FULL - HEIGHT_OFFSET,
                        WIDTH_FULL, HEIGHT_OFFSET),

                    // left
                    new XRect(
                        0.0,          PageOffsetY + 0.0,
                        WIDTH_OFFSET, HEIGHT_FULL)
                    });

                // Ячейки карточки
                for (var row = Card.MIN_ROW_ID; row <= Card.MAX_ROW_ID; row++)
                {
                    for (var column = Card.MIN_COLUMN_ID; column <= Card.MAX_COLUMN_ID; column++)
                    {
                        var value = card[row, column];

                        if (value == Card.NO_VALUE || value == Card.EMPTY_VALUE)
                        {
                            continue;
                        }

                        gfx.DrawString(
                            value.ToString(),
                            font,
                            XBrushes.Black,
                            new XRect
                            {
                                X = WIDTH_OFFSET + WIDTH_CELL * (column - 1),
                                Y = PageOffsetY + HEIGHT_OFFSET + HEIGHT_CELL * (row - 1),
                                Width = WIDTH_CELL,
                                Height = HEIGHT_CELL
                            },
                            XStringFormats.Center);

                        // линии-разделители столбцов
                        if (column < Card.MAX_COLUMN_ID)
                        {
                            gfx.DrawLine(
                                XPens.Black,
                                new XPoint(WIDTH_OFFSET + WIDTH_CELL * column, PageOffsetY + HEIGHT_OFFSET),
                                new XPoint(WIDTH_OFFSET + WIDTH_CELL * column, PageOffsetY + HEIGHT_FULL - HEIGHT_OFFSET));
                        }
                    }

                    // линии-разделители строк
                    if (row < Card.MAX_ROW_ID)
                    {
                        gfx.DrawLine(
                            XPens.Black,
                            new XPoint(WIDTH_OFFSET,              PageOffsetY + HEIGHT_OFFSET + HEIGHT_CELL * row),
                            new XPoint(WIDTH_FULL - WIDTH_OFFSET, PageOffsetY + HEIGHT_OFFSET + HEIGHT_CELL * row));
                    }
                }

                // линия-разделитель карточек
                gfx.DrawLine(
                    XPens.Black,
                    new XPoint(0.0,        PageOffsetY + HEIGHT_FULL),
                    new XPoint(WIDTH_FULL, PageOffsetY + HEIGHT_FULL));
            }
        }
    }
}

