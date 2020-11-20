using System.Collections.Generic;
using System.Linq;
using Tasks.HelpClasses;

namespace Tasks
{
    public class Task4
    {
        /*
         * Desenvolva um método que retorne todos os estudantes do Repositório que nasceram em 2020      
         * Dica: A classe Repository possui as informções dos Students
         */
        public static List<Student> GetStudentsByBirth() {
            List<Student> estudantes2020 = new List<Student>();
            Repository repository = new Repository();
            return  estudantes2020 = repository.Students.Where(a => a.Birth.Year == 2020).ToList();
        }
    }
}
