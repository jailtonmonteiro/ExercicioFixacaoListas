using System;

namespace ExercicioFixacaoListas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            int id, qt, src;
            double salary, percentage;
            string name;

            Console.Write("QUANTOS FUNCIONARIOS REGISTRADOS: ");
            qt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qt; i++)
            {
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());

                Console.Write("NOME: ");
                name = Console.ReadLine();

                Console.Write("SALARIO: ");
                salary = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                employees.Add(new Employee(id, name, salary));

            }

            Console.WriteLine("Digite o ID para buscar: ");
            src = int.Parse(Console.ReadLine());



            foreach (Employee e in employees)
            {
                if(e.Id == src)
                {
                    Console.WriteLine("INSIRA O PERCENTUAL DE AUMENTO: ");
                    percentage = double.Parse(Console.ReadLine());

                    e.increaseSalary(percentage);
                }
            }
            
            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.Id}, {e.Name}, {e.Salary}");
            }
        }
    }
}