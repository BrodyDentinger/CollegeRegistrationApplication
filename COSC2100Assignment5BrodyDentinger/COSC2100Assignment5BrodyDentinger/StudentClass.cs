/*
 Name: Brody Dentinger 
File: StudentClass.cs
Description: Represents a full student registration record. (Including school and program)
Date: Nov. 28, 2023
 */


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COSC2100Assignment5BrodyDentinger
{
    internal class StudentClass
    {

        // Properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int SIN { get; set; }
        public string Email { get; set; }
        public int highSchoolGrade { get; set; }
        public int admissionTestScore { get; set; }
        public string campusLocation { get; set; }
        public string programName { get; set; }

        // Parameterized constructor
        public StudentClass(string firstNameParam, string lastNameParam, int sinParam, string emailParam, int highSchoolGradeParam, 
                            int admissionTestScoreParam, string campusLocationParam, string programNameParam)
        {
            this.firstName = firstNameParam;
            this.lastName = lastNameParam;
            this.SIN = sinParam;
            this.Email = emailParam;
            this.highSchoolGrade = highSchoolGradeParam;
            this.admissionTestScore = admissionTestScoreParam;
            this.campusLocation = campusLocationParam;
            this.programName = programNameParam;
        }

        // Methods

        /*
         SerializeStudent
        Takes a list of student objects from the student class, and creates a JSON string by using the SerializeObject() function on each student object.
        Creates a compatible JSON array format for writing to the JSON file.
         */
        public string SerializeStudent(StudentClass student)
        {
            // Serialize it to the JSON format.
            string json = JsonConvert.SerializeObject(student);

            return json;
        }
    }
}

