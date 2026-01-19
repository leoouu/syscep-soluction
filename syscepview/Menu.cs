using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using syscepmodel;
using syscepcontroller;

namespace syscepview_csa
{
    public class Menu
    {
        private Periodo periodo = new Periodo();
        private Periodos periodos;

        Curso curso = new Curso();
        Cursos cursos;

        DisciplinaCursos disciplinacursos = new DisciplinaCursos();
        DisciplinaCurso disciplinaCurso;

        Disciplina disciplina = new Disciplina();
        Disciplinas disciplinas;




        private void exibirSubMenuPeriodos()
        {
            int supopcao = 0;

            while (supopcao != 19)
            {
                Console.WriteLine("PERIODOS");
                Console.WriteLine("10. INSERIR");
                Console.WriteLine("11. ALTERAR");
                Console.WriteLine("12. EXCLUIR");
                Console.WriteLine("13. PESQUISAR SIGLA");
                Console.WriteLine("14. EXIBIR");
                Console.WriteLine("19. SAIR");
                Console.WriteLine("Digite a opcao: ");
                supopcao = int.Parse(Console.ReadLine());


                if (supopcao == 10)
                {
                    periodos = new Periodos();
                    periodo.inserir(periodos);

                }

                else if (supopcao == 11)
                {

                    String perSigla = Console.ReadLine();
                    periodos = new Periodos();
                    periodo.alterar(perSigla, periodos);
                }

                else if (supopcao == 12)
                {
                    String perSigla = Console.ReadLine();
                    periodos = new Periodos();
                    periodo.excluir(perSigla);
                }

                else if (supopcao == 13)
                {

                    String perSigla = Console.ReadLine();
                    periodos = new Periodos();
                    periodo.pesquisar(perSigla);

                }

                else if (supopcao == 14)
                {
                    periodos = new Periodos();
                    periodo.exibirTodos();

                }



            }
        }

        private void exibirSubMenuCursos() 
        {
            int supopcao = 0;

            while (supopcao != 19)
            {
                Console.WriteLine("CURSOS");
                Console.WriteLine("10. INSERIR");
                Console.WriteLine("11. ALTERAR");
                Console.WriteLine("12. EXCLUIR");
                Console.WriteLine("13. PESQUISAR SIGLA");
                Console.WriteLine("14. EXIBIR");
                Console.WriteLine("19. SAIR");
                Console.WriteLine("Digite a opcao: ");
                supopcao = int.Parse(Console.ReadLine());

                if (supopcao == 10)
                {
                    cursos = new Cursos();

                    curso.inserir(cursos);
                }
                else if (supopcao == 11)
                {
                    String curSigla = Console.ReadLine();
                    cursos = new Cursos();
                    curso.alterar(curSigla, cursos);
                }
                else if (supopcao == 12)
                {
                    String curSigla = Console.ReadLine();
                    cursos = new Cursos();
                    curso.excluir(curSigla);
                }
                else if (supopcao == 13)
                {
                    String curSigla = Console.ReadLine();
                    cursos = new Cursos();
                    curso.pesquisar(curSigla);
                }
                else if (supopcao == 14)
                {
                    cursos = new Cursos();
                    curso.exibirTodos();
                }
            }
        }

        private void exibirSubMenuDisCus()
        {
            int supopcao = 0;

            while (supopcao != 19)
            {
                Console.WriteLine("DISCIPLINA-CURSO");
                Console.WriteLine("10. INSERIR");
                Console.WriteLine("11. ALTERAR");
                Console.WriteLine("12. EXCLUIR");
                Console.WriteLine("13. PESQUISAR");
                Console.WriteLine("14. EXIBIR TODOS");
                Console.WriteLine("19. SAIR");
                Console.WriteLine("Digite a opção: ");
                supopcao = int.Parse(Console.ReadLine());

                if (supopcao == 10)
                {
                    disciplinaCurso = new DisciplinaCurso();
                    disciplinacursos.Inserir(disciplinaCurso);
                }
                else if (supopcao == 11)
                {

                    int cursoID = int.Parse(Console.ReadLine());
                    int disciplinaID = int.Parse(Console.ReadLine());
                    disciplinacursos.Alterar(cursoID, disciplinaID);
                }
                else if (supopcao == 12)
                {

                    int cursoID = int.Parse(Console.ReadLine());
                    int disciplinaID = int.Parse(Console.ReadLine());
                    disciplinacursos.Excluir(cursoID, disciplinaID);
                }
                else if (supopcao == 13)
                {

                    int cursoID = int.Parse(Console.ReadLine());
                    int disciplinaID = int.Parse(Console.ReadLine());
                    disciplinacursos.Pesquisar(cursoID, disciplinaID);
                }
                else if (supopcao == 14)
                {

                    disciplinacursos.ExibirTodos();
                }
            }
        }

        private void exibirSubMenuDisciplina()
        {
            int supopcao = 0;

            while (supopcao != 19)
            {
                Console.WriteLine("DISCIPLINAS");
                Console.WriteLine("10. INSERIR");
                Console.WriteLine("11. ALTERAR");
                Console.WriteLine("12. EXCLUIR");
                Console.WriteLine("13. PESQUISAR");
                Console.WriteLine("14. EXIBIR TODOS");
                Console.WriteLine("19. SAIR");
                Console.WriteLine("Digite a opcao: ");
                supopcao = int.Parse(Console.ReadLine());

                if (supopcao == 10)
                {
                    disciplina.Inserir(); // Inserir 
                }

                else if (supopcao == 11)
                {
                    int disID = int.Parse(Console.ReadLine());
                    disciplina.Alterar(disID); // Alterar 
                }

                else if (supopcao == 12)
                {
                    int disID = int.Parse(Console.ReadLine());
                    disciplina.Excluir(disID); // Excluir 
                }

                else if (supopcao == 13)
                {

                    int disID = int.Parse(Console.ReadLine());
                    disciplina.Pesquisar(disID); // Pesquisar 
                }

                else if (supopcao == 14)
                {
                    disciplina.ExibirTodos(); // Exibir 
                }
            }
        }








        public void exibir()
        {
            int opcao = 0;

            while (opcao != 9)
            {
                Console.WriteLine("\n");
                Console.WriteLine("SYSCEP");
                Console.WriteLine("1. PERIODOS");
                Console.WriteLine("2. CURSOS");
                Console.WriteLine("3. DISCIPLINAS CURSO");
                Console.WriteLine("4. DISCIPLINAS");
                Console.WriteLine("9. SAIR");
                Console.WriteLine("Digite a opcao: ");
                opcao = int.Parse(Console.ReadLine());


                if (opcao == 1)
                {
                    exibirSubMenuPeriodos();
                }
                

                if (opcao == 2) 
                {
                   exibirSubMenuCursos();
                }
                

                else if (opcao == 3) 
                {
                    exibirSubMenuDisCus();
                }


                else if (opcao == 4)
                {
                    exibirSubMenuDisciplina();
                }


            }
            periodo.SalvarPeriodosEmArquivoCsv();
            curso.SalvarCursosEmArquivoCsv();
            disciplinacursos.SalvarDisciplinaCursoEmArquivoCsv();
            disciplina.SalvarDisciplinasEmArquivoCsv();
            ;
        }
    }
    
}

