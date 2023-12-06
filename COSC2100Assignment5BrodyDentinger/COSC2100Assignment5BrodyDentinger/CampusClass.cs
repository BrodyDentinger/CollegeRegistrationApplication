/*
 Name: Brody Dentinger 
File: CampusClass.cs
Description: Represents an indiviudal campus with grade requirements, fees, and list of available programs.
Date: Nov. 28, 2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100Assignment5BrodyDentinger
{
    internal class CampusClass
    {

        // Properties
        private int HSGradeReq;
        private int admissionTSReq;
	    private int regFees;
        private string location;
	    private List<SchoolProgramClass> listOfPrograms = new List<SchoolProgramClass>();

        // Parameterized Constructor
        public CampusClass(int HSGradeReqParam, int admissionTSReqParam, int regFeesParam, string locationParam ,List<SchoolProgramClass> listOfProgramsParam)
        {
            this.HSGradeReq = HSGradeReqParam;
            this.admissionTSReq = admissionTSReqParam;
            this.regFees = regFeesParam;
            this.location = locationParam;
            this.listOfPrograms = listOfProgramsParam;
        }

        // Getters.
        public int GetHSGradeReq()
        {
            return HSGradeReq;
        }

        public int GetAdmissionTSReq()
        {
            return admissionTSReq;
        }

        public int GetRegFees()
        {
            return regFees;
        }
        public string GetLocation()
        {
            return location;
        }
        public List<SchoolProgramClass> GetSchoolPrograms()
        {
            return listOfPrograms;
        }

    }
}
