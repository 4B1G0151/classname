using classname;
using System;
using System.Collections.ObjectModel;

namespace classname
{
    internal class Teacher
    {
        public String TeacherName { get; set; }
        public ObservableCollection<Course> TeachingCourses { get; set; }

        public Teacher()
        {
            this.TeachingCourses = new ObservableCollection<Course>();
        }

        public override string ToString()
        {
            return $"{TeacherName}";
        }
    }
}