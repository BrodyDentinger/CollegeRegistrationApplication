/*
 Name: Brody Dentinger 
File: SchoolProgramClass.cs
Description: Represents a program object, with fees, and program duration.
Date: Nov. 28, 2023
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100Assignment5BrodyDentinger
{
    internal class SchoolProgramClass
    {

        // Properties
        private string programName { get; set; }
        private int programFees { get; set; }
        private int programDuration { get; set; }


        // Parameterized constructor
        public SchoolProgramClass(string programNameParam, int programFeesParam, int programDurationParam)
        {
            // Set the properties using the constructor parameters
            this.programName = programNameParam;
            this.programFees = programFeesParam;
            this.programDuration = programDurationParam;
        }

        // Getters
        public string GetProgramName() 
        { 
            return programName;
        }
        public int GetProgramFees()
        {
            return programFees;
        }
        public int GetProgramDuration()
        {
            return programDuration;
        }
    }
}
