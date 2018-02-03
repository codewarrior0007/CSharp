using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeFinal
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();


            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HightestGrade = Math.Max(grade, stats.HightestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                sum += grade;

            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if(String.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

        private string _name; 
        public List<float> grades;
    }
}
