namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string condicao = "";
            while (condicao != "SIM")
            {
                Console.WriteLine("[1] Aprovar alunos com base na média\n" +
                                  "[2] Filtrar por média\n" +
                                  "[3] Filtar todos\n" +
                                  "[4] Filtrar Aprovados\n" +
                                  "[5] Filtrar Reprovados\n" +
                                  "[6] Filtrar Maior e Menor nota\n" +
                                  "[7] Sair do programa\n"
                                  );
                var opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        AprovarAlunosComBaseNaMedia(85);
                        break;
                    case 2:
                        FiltrarMaiorMedia();
                        break;
                    case 3:
                        FiltrarTodosAlunos();
                        break;
                    case 4:
                        FiltrarAlunosAprovados();
                        break;
                    case 5:
                        FiltrarAlunosReprovados();
                        break;
                    case 6:
                        FiltrarMaiorEMenorNota();
                        break;
                    case 7:
                        condicao = "SIM";
                        break;
                    default:
                        break;
                }

            }
            static void AprovarAlunosComBaseNaMedia(int media)
            {
                var query = from student in Student.students
                            where student.Scores.Average() > media
                            select student;

                foreach (var student in query)
                {
                    student.Aprovado = true;
                }
                Console.WriteLine($"{query.Count()} Alunos aprovados!");
            }

            static void FiltrarAlunosAprovados()
            {
                var query = Student.students.Where(student => student.Aprovado);

                foreach (var student in query)
                {
                    Console.WriteLine(student);
                }
            }
            static void FiltrarAlunosReprovados()
            {
                var query = Student.students.Where(student => !student.Aprovado);

                foreach (var student in query)
                {
                    Console.WriteLine(student);
                }
            }

            static void FiltrarMaiorMedia()
            {
                var query = from student in Student.students
                                             let media = student.Scores.Average()
                                             select media;
                Console.WriteLine(query.Max());
            }

            static void FiltrarMaiorEMenorNota()
            {
                var query  = from student in Student.students
                             let m = student.Scores.Max()
                             select m;
                Console.WriteLine($"Maior nota: {query.Max()}");

                var queryMin = from student in Student.students
                            let m = student.Scores.Min()
                            select m;
                Console.WriteLine($"Menor nota: {queryMin.Min()}");

            }

            static void FiltrarTodosAlunos()
            {
                var query = from student in Student.students
                            orderby student.Scores.Average() descending
                            select student;

                foreach (var s in query)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}