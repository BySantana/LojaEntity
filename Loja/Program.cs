using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GravarUsandoAdoNte();
            GravarUsandoEntity();
            //RecuperarProdutos();
            //ExcluirProdutos();
            //RecuperarProdutos();
            //AtualizarProduto();
        }

        private static void AtualizarProduto()
        {
            using (var repo = new ProdutoDaoEntity())
            {
                Produto primeiro = repo.Produtos().First();
                primeiro.Nome = "Top Gun 3 - Modificado";
                repo.Atualizar(primeiro);
                //repo.SaveChanges();
            }
        }

        private static void ExcluirProdutos()
        {
            
            using (var repo = new LojaContexto())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    repo.Produtos.Remove(item);
                }
                repo.SaveChanges();
            }
        }

        private static void RecuperarProdutos()
        {
            using (var repo = new LojaContexto())
            {
                IList<Produto> produtos = repo.Produtos.ToList();
                foreach (var item in produtos)
                {
                    Console.WriteLine(item.Nome);
                }
            }
        }

        private static void GravarUsandoEntity()
        {
            Produto p = new Produto();
            p.Nome = "Teste";
            p.Categoria = "Teste";
            p.Preco = 0.0;
            using (var contexto = new ProdutoDaoEntity())
            {
                contexto.Adicionar(p);
                //contexto.SaveChanges();
            }
        }

        private static void GravarUsandoAdoNte()
        {
            Produto p = new Produto();
            p.Nome = "The Breaking Bad";
            p.Categoria = "Séries";
            p.Preco = 27.65;

            using (var repo = new ProdutoDAO())
            {
                repo.Adicionar(p);
            }
        }
    }
}
