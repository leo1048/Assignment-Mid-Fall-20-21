﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Management_System
{
    class Section : Course
    {
        private string sectionName;

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }
        public Section() { }
        public Section(string sectionName, string courseName, int courseId, int courseCredit, double courseTeachingHours)
            : base(courseName, courseId, courseCredit, courseTeachingHours)
        {
            this.sectionName = sectionName;
        }
         public void ShowSectionInfo()
        {
            Console.WriteLine("Section Name : " + sectionName);

        }
    }
}