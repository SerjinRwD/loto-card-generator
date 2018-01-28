using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoCardGenerator.Renders
{
    public interface ICardRender
    {
        void Render(Models.Card card);
    }
}
