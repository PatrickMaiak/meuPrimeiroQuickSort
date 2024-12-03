namespace Revisao_de_listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FAZER UM QUICK SORT


            //int[] listaDesordenada = new int[] { 32, 23, 46, 88, 51, 91, 87, 11, 16 };

            //int[] listaDesordenada20 = new int[] { 98, 23, 11, 54, 76, 88, 32, 91, 43, 65, 19, 87, 39, 24, 46, 72, 51, 81, 16, 33 };
            //int[] listaDesordenada30 = new int[] { 45, 23, 11, 32, 54, 76, 33, 88, 39, 65, 98, 43, 19, 46, 91, 87, 24, 72, 51, 16, 81, 12, 66, 77, 89, 15, 92, 38, 60, 34 };
            //int[] listaDesordenada40 = new int[] { 45, 23, 54, 76, 33, 88, 39, 65, 98, 43, 11, 32, 91, 87, 24, 72, 51, 16, 81, 12, 66, 77, 89, 15, 92, 38, 60, 34, 74, 25, 19, 18, 42, 84, 93, 36, 48, 67, 78, 49 };
            int[] listaDesordenada = new int[] {23, 54, 76, 33, 88, 39, 65, 98, 43, 11, 32, 91, 87, 24, 72, 51, 16, 81, 12, 66, 77, 89, 15, 92, 38, 60, 34, 74, 25, 19, 18, 42, 84, 93, 36, 48, 67, 78, 49, 55, 29, 31, 63, 80, 22, 94, 17, 37, 50 };


        
            quicksort(listaDesordenada);
        }

        public static void quicksort(int[] lista)
        {
           

            List<int> antes = new List<int>();
            List<int> depois = new List<int>();


            List<int> jaOrganizados = new List<int>();

            for (int i = 0; i < lista.Length; i++)
            {
                int indexJafoi = 0;

                int pivo = lista[indexJafoi];

                
                while(jaOrganizados.Contains(pivo))
                {
                    indexJafoi++;
                    if (indexJafoi == lista.Length)
                    {
                        break;
                    }
                    pivo = lista[indexJafoi];
                }
               

                foreach (int num in lista)
                {
                    if (num > pivo)
                    {
                        depois.Add(num);
                    }
                    else if (num < pivo)
                    {
                        antes.Add(num);
                    }
                }

                int index = antes.Count;

                int trocaPosicao = lista[index];
                lista[indexJafoi] = trocaPosicao;

                lista[index] = pivo;
                
                jaOrganizados.Add(pivo);

                antes.Clear();
                depois.Clear();

            
                

            }
            foreach (var item in lista)
            {
                Console.Write("" + item +" ");
            }
           
            Console.WriteLine();
      
        }

        public static void listar(int[] lista)
        {


            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
        }




















        //    public static void funcao()
        //    {

        //        DateTime dateTime = DateTime.Now;

        //        while ((DateTime.Now - dateTime).TotalSeconds < 3) { }
        //        Console.Clear();
        //        Console.WriteLine("==============-=-=-=- BEM VINDO AO GERENCIADOR DE TAREFAS -=-=-=-==============");
        //        Console.WriteLine();
        //        Console.WriteLine("   escolha uma opção :");
        //        Console.WriteLine();
        //        Console.WriteLine("[ 1 ]PARA LISTAR TAREFAS [ 2 ] PARA ADICIONAR TAREFA");

        //        int opcao = Convert.ToInt32(Console.ReadLine());

        //        while (opcao != 1 && opcao != 2)
        //        {
        //            Console.WriteLine("A OPÇÃO: " + opcao + " NÃO É VALIDA" );
        //            Console.WriteLine("[ 1 ]PARA LISTAR TAREFAS [ 2 ] PARA ADICIONAR TAREFA");

        //            opcao = Convert.ToInt32(Console.ReadLine());
        //            Console.Clear();
        //        }

        //        switch (opcao)
        //        {
        //            case 1:  Console.WriteLine("==============-=-=-=- LISTAR TAREFAS -=-=-=-==============");
        //                break;
        //            case 2:
        //                Console.WriteLine("==============-=-=-=- ADICIONAR TAREFA -=-=-=-==============");
        //                break;
        //            default:
        //                break;
        //        }

        //    }

        //    public static void criarLista()
        //    {
        //        string nome = Convert.ToString(Console.ReadLine());

        //        Console.WriteLine(nome);
        //    }
    }
}
