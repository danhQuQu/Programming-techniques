/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
        }
    }
}*/
using schedule;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.Sql;

namespace LogIn
{
    class Program
    {
        public bool check = false;
        scheduleEntities1 SE = new scheduleEntities1();
        List<Chromosome> dnaChain = new List<Chromosome>();
        private string[] giaoVien = new string[100];
        int dem = 0;

        public void tenGv(string gv)
        {
            giaoVien[dem] = gv;
            dem++;
        }

        static List<String> Professor = new List<string>()
        {
            "Nguyen B",
            "tran van C",
            "dang tran D",
            "dang tam E",
            "Nguyen thien tam",
            "tran van A",
            "Nguyen tran thanh A",
        };
        public void loadGV()
        {   
            var result = from c in SE.Lecturers select new { name = c.Name };
            var data = result.ToList();
            for (int i = 0; i < data.Count; i++)
            {
                giaoVien[i] = data[i].name;
                Professor.Add(giaoVien[i]);
            }
        }
        static Course Course1 = new Course(1, 3, "Monday");
        static Course Course2 = new Course(7, 9, "Thursday");
        static Course Course3 = new Course(1, 3, "Monday");
        static Course Course4 = new Course(7, 9, "Thursday");

        static Course Course5 = new Course(1, 3, "Monday");
        static Course Course6 = new Course(9, 11, "Monday");
        static Course Course7 = new Course(1, 3, "Friday");

        static Course Course8 = new Course(1, 3, "Tuesday");
        static Course Course9 = new Course(1, 3, "Tuesday");
        static Course Course10 = new Course(10, 12, "Tuesday");
        static Course Course11 = new Course(1, 3, "Saturday");

        static Course Course12 = new Course(4, 6, "Tuesday");
        static Course Course13 = new Course(4, 6, "Tuesday");
        static Course Course14 = new Course(4, 6, "Friday");

        static Course Course15 = new Course(7, 9, "Wednesday");
        static Course Course16 = new Course(7, 9, "Monday");

        static Course Course17 = new Course(3, 4, "Wednesday");
        static Course Course18 = new Course(3, 4, "Saturday");

        static Course Course19 = new Course(5, 6, "Wednesday");
        static Course Course20 = new Course(5, 6, "Thursday");
        static Course Course21 = new Course(5, 6, "Friday");

        static Course Course22 = new Course(1, 4, "Wednesday");
        static Course Course23 = new Course(1, 4, "Thursday");

        static Course Course24 = new Course(4, 6, "Friday");


        static List<Course> Courses = new List<Course>()
        {
           Course1,
           Course2,
           Course3,
           Course4,
           Course5,
           Course6,
           Course7,
           Course8,
           Course9,
            Course10,
            Course11,
            Course12,
            Course13,
            Course14,
            Course15,
            Course16,
            Course17,
            Course18,
            Course19,
            Course20,
            Course21,
            Course22,
            Course23,
            Course24,


        };

        static List<String> Rooms = new List<string>()
        {   "A3-101",
            "A2-102",
            "A4-303",
            "A5-404",
            "A2-605",
            "A2-306"
        };



        static List<Population>[,] hourrio = new List<Population>[5, 5];

        public static void initializeDimentions()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    hourrio[i, j] = new List<Population>();
                }
            }
        }
        public static Chromosome initializeChromosome(Chromosome child)
        {
            int l = 1;
            Random rnd = new Random();
            while (l <= 24)
            {

                int date = rnd.Next(0, 5);
                int hour = rnd.Next(0, 5);
                string profe = Professor.ElementAt(rnd.Next(0, Professor.Count));
                Course Course = Courses.ElementAt(rnd.Next(0, Courses.Count));
                Courses.Remove(Course);
                string room = Rooms.ElementAt(rnd.Next(0, Rooms.Count));
                Population generation = new Population(profe, Course, room);
                child.dnaChain.Add(generation);
                l++;

            }
            Courses = new List<Course>()
            {
            Course1,
            Course2,
            Course3,
            Course4,
            Course5,
            Course6,
            Course7,
            Course8,
            Course9,
            Course10,
            Course11,
            Course12,
            Course13,
            Course14,
            Course15,
            Course16,
            Course17,
            Course18,
            Course19,
            Course20,
            Course21,
            Course22,
            Course23,
            Course24,
            };
            return child;
        }
        public static List<Chromosome> createFirstGeneration(int cantProfes, int cantCourses, int cantRooms, int cantsemester)
        {
            List<Chromosome> solutions = new List<Chromosome>();

            int p = 1;
            Random rnd = new Random();
            int l = 1;
            while (p <= 6)
            {
                Chromosome crom = new Chromosome();
                while (l <= cantCourses)
                {


                    string profe = Professor.ElementAt(rnd.Next(0, Professor.Count));
                    Course Course = Courses.ElementAt(rnd.Next(0, Courses.Count));
                    Courses.Remove(Course);
                    string room = Rooms.ElementAt(rnd.Next(0, Rooms.Count));
                    Population generation = new Population(profe, Course, room);
                    crom.dnaChain.Add(generation);
                    l++;

                }
                solutions.Add(crom);
                Courses = new List<Course>()
                    {
                      Course1,
                       Course2,
                       Course3,
                       Course4,
                       Course5,
                       Course6,
                       Course7,
                       Course8,
                       Course9,
                       Course10,
                       Course11,
                       Course12,
                       Course13,
                       Course14,
                       Course15,
                       Course16,
                       Course17,
                       Course18,
                       Course19,
                       Course20,
                       Course21,
                       Course22,
                       Course23,
                       Course24,

                      };
                l = 1;
                p++;
            }
            return solutions;


        }

        public static List<Chromosome> getParents(List<Chromosome> chromosomes)
        {
            List<Chromosome> parents = new List<Chromosome>();
            List<int> scores = new List<int>();
            int size = chromosomes.Count;
            for (int i = 0; i < size; i++)
            {
                Chromosome chromosome = chromosomes.ElementAt(i);
                scores.Add(chromosome.score);
            }
            scores.Sort();
            while (parents.Count <= 2)
            {
                for (int i = 0; i < chromosomes.Count; i++)
                {
                    Chromosome cromo = chromosomes.ElementAt(i);
                    if (cromo.score == scores[0])
                    {
                        parents.Add(cromo);
                    }
                    else if (cromo.score == scores[1])
                    {
                        parents.Add(cromo);
                    };
                }
            }


            return parents;


        }

        public static void Evaluate(Chromosome chromosome)
        {
            int k = chromosome.dnaChain.Count;
            int score = 0;
            for (int i = 0; i < k; i++)
            {
                Population temp = chromosome.dnaChain.ElementAt(i);
                for (int j = i + 1; j < k; j++)
                {
                    Population evaluated = chromosome.dnaChain.ElementAt(j);
                    if (evaluated != temp)
                    {

                        if (temp.course.date == evaluated.course.date && temp.course.start < evaluated.course.end && evaluated.course.start < temp.course.end)
                        {
                            if (temp.professor == evaluated.professor)
                            {
                                score += 1;
                            }
                            if (temp.room == evaluated.room)
                            {
                                score += 1;
                            }

                        }


                    }
                }
            }
            chromosome.score = score;

        }
        public static Chromosome add(int i, Chromosome parent, Chromosome child)
        {

            child.dnaChain.ElementAt(i).course = parent.dnaChain.ElementAt(i).course;
            child.dnaChain.ElementAt(i).professor = parent.dnaChain.ElementAt(i).professor;
            child.dnaChain.ElementAt(i).room = parent.dnaChain.ElementAt(i).room;

            return child;
        }

        public static Chromosome addmutated(int i, Chromosome child)
        {
            Random rnd = new Random();

            child.dnaChain.ElementAt(i).course = Courses.ElementAt(rnd.Next(0, 12));
            child.dnaChain.ElementAt(i).professor = Professor.ElementAt(rnd.Next(0, Professor.Count));
            child.dnaChain.ElementAt(i).room = Rooms.ElementAt(rnd.Next(0, Rooms.Count));
            return child;
        }
        public static Chromosome Laitao(Chromosome parent1, Chromosome parent2)
        {
            Random rd = new Random();
            Chromosome child_chromosome = new Chromosome();
            child_chromosome = initializeChromosome(child_chromosome);

            for (int i = 0; i < parent1.dnaChain.Count; i++)
            {

                int p = rd.Next(0, 11);
                if (p <= 4)
                    child_chromosome = add(i, parent1, child_chromosome);


                else if (p <= 9)
                    child_chromosome = add(i, parent2, child_chromosome);

                else
                    child_chromosome = addmutated(i, child_chromosome);

            }
            Evaluate(child_chromosome);

            return child_chromosome;
        }
        public static void xuatTKB(Chromosome crom)
        {
            for (int i = 0; i < crom.dnaChain.Count; i++)
            {

                Console.WriteLine(" professor: " + crom.dnaChain.ElementAt(i).professor + " room: " +
                                        crom.dnaChain.ElementAt(i).room + " Tiet: " + crom.dnaChain.ElementAt(i).course.start +
                                        "-" + crom.dnaChain.ElementAt(i).course.end + "  date: " + crom.dnaChain.ElementAt(i).course.date);

            }
            Console.WriteLine("Score: " + crom.score);
            if (crom.score == 0)
            {
                Console.WriteLine("End");
            }
        }

        [STAThread]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
            Program pr = new Program();
                int dem = 1;
                Console.WriteLine("***************************Create first generation*************************************");
                Console.WriteLine("");
                initializeDimentions();
                List<Chromosome> solution = createFirstGeneration(10, 24, 6, 1);


                for (int i = 0; i < solution.Count; i++)
                {
                    Chromosome cromo = solution.ElementAt(i);
                    Evaluate(cromo);
                    xuatTKB(cromo);


                    Console.WriteLine("");
                    if (cromo.score == 0)
                    {
                        Console.WriteLine("Đã tìm thấy");
                        Console.ReadKey();

                    }
                }
                List<Chromosome> parents = getParents(solution);
                Console.WriteLine("");
                Console.WriteLine("*****************************************phu huynh...*********************************");
                Console.WriteLine("");

                for (int i = 0; i < 2; i++)
                {
                    Chromosome cromosoma = parents.ElementAt(i);

                    xuatTKB(cromosoma);
                }

                bool found = false;
                while (!found)
                {
                    parents = getParents(solution);
                    Chromosome parent1 = parents.ElementAt(0);
                    Chromosome parent2 = parents.ElementAt(1);
                    Console.WriteLine("**************************Generation: " + dem++ + " ********************************");
                    xuatTKB(parent1);

                    Chromosome child = Laitao(parent1, parent2);
                    Evaluate(child);
                    solution.Add(child);



                    if (child.score == 0)
                    {
                        Console.WriteLine($"****************Result: Generation {dem++} *******************");
                        xuatTKB(child);
                        found = true;
                        Console.ReadKey();
                }

            }
        }
    }
}

