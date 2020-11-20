using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;


namespace Tasks
{
    public class Task7
    {
        /*
         * Desenvolma um método que retorne o nome dos produtos que estão com estoque zerado
         * Dica: A classe Repository possui as informções dos Products
         */
        public static List<string> GetProductsOutOfStock() {
            List<string> produtosZerados = new List<string>();
            Repository repository = new Repository();
            var produtos2 = from Name in repository.Products.Where(a => a.Stock.Quantity == 0) select Name;
            foreach(var p in produtos2)
            {
                produtosZerados.Add(p.Name);
            }
            return produtosZerados;
        }

        /*
        * Desenvolma um método que retorne a soma total das quantidades de estoque dos itens
        * Dica: A classe Repository possui as informções dos Products
        */
        public static int GetSumStock() {
            Repository repository = new Repository();
            int total = repository.Products.Sum(a => a.Stock.Quantity);
            return total;
        }

        /*
         * Crie um método que verifique, dado Id e quantidade solicitada do produto
         * se o mesmo possui quantidade em estoque para venda
         * Dica: A classe Repository possui as informções dos Products
         * 
         */
        public static bool IsSalePossible(int productId, int orderQuantity) {
            Repository repository = new Repository();
            bool teste = repository.Products.Any(product => product.Stock.ProductId == productId && product.Stock.Quantity >= orderQuantity);
            if (teste)
                return true;
            else
                return false;
        }
    }
}
