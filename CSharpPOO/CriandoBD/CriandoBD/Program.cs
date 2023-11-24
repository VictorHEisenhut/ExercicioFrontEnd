using CriandoBD.Dao;
using CriandoBD.Entidades;
using CriandoBD.Utilities;

namespace CriandoBD
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string condicao = "";
            while (condicao != "SIM")
            {
                Console.Clear();
                Console.WriteLine("[1] Criar contato\n" +
                                  "[2] Listar contatos\n" +
                                  "[3] Atualizar contatos\n" +
                                  "[4] Deletar contato");
                                  
                var opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        AddCtt();
                        break;
                    case 2:
                        Consultar();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Deletar();
                        break;
                    
                    default:
                        break;
                }

                Console.WriteLine("Deseja encerrar o programa? (SIM)");
                condicao = Console.ReadLine();
            }
            Console.ReadKey();
        }

        static void AddCtt()
        {
            DaoContatoMySql dao = new(Connect.Conectar());
            Contato ctt = new();
           
            Console.WriteLine("Digite o nome do contato:");
            ctt.Nome = Console.ReadLine();
            Console.WriteLine("Digite o email do contato:");
            ctt.Email = Console.ReadLine();
            Console.WriteLine("Digite o telefone do contato:");
            ctt.Telefone = Console.ReadLine();

            if (dao.Salvar(ctt))
            {
                Console.WriteLine("Contato salvo!");
            }


        }
        static void Consultar()
        {
            DaoContatoMySql dao = new(Connect.Conectar());
            var ctts = dao.Consultar();
            foreach (var contato in ctts)
            {
                Console.WriteLine(contato);
            }
        }

        static void Update()
        {
            DaoContatoMySql dao = new(Connect.Conectar());
            dao.Consultar();
            Console.WriteLine("Digite o ID a atualizar:");
            var id = Convert.ToInt32(Console.ReadLine());
            Contato ctt = dao.ConsultarPorId(id);

            Console.WriteLine("Digite o novo nome:");
            ctt.Nome = Console.ReadLine();
            Console.WriteLine("Digite o novo email:");
            ctt.Email = Console.ReadLine();
            Console.WriteLine("Digite o novo telefone");
            ctt.Telefone = Console.ReadLine();

            if (dao.Atualizar(ctt))
            {
                Console.WriteLine("Contato atualizado!");
            }
        }

        static void Deletar()
        {
            DaoContatoMySql dao = new(Connect.Conectar());
            Consultar();

            Console.WriteLine("Digite o ID do contato a ser excluido:");
            var id = Convert.ToInt32(Console.ReadLine());

            var ctt = dao.ConsultarPorId(id);

            if (dao.Deletar(ctt))
            {
                Console.WriteLine("Contato excluído!");
            }
        }
    }
}