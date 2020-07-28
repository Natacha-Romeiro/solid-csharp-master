using Alura.LeilaoOnline.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Leilao> BuscarLeiloes();

        IEnumerable<Categoria> BuscarCategorias();

        Leilao BuscarPorId(int id);

        void Incluir(Leilao leilao);
        void Alterar(Leilao model);
        void Excluir(Leilao model);
        }
    }

}
}
