/*
 Name: Brody Dentinger 
File: Form1.cs
Description: This is the main class file, which will provide functionality to the form.
Date: Nov. 28, 2023
 */


using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Json;
using System.Net.Http.Headers;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace COSC2100Assignment5BrodyDentinger
{
    public partial class Form1 : Form
    {

        // Define a public list of student objects.
        internal List<StudentClass> studentObjectList = new List<StudentClass>();

        // Define a public campus list - Populate with campus objects.
        internal List<CampusClass> campusList = new List<CampusClass>();

        // Defining a constant for tax rate.
        double tax = 0.13;

        /* 
         PopuLateCampusLocation() 
        check if the student is eligible to be admitted to one or more campuses, if yes(true) then activate the “campuses” combobox lists these campuses.
        If (false) an error message should be displayed to inform the employee that the student application is rejected,
        and reset the compoboxes(High school grade and Admission test score) input fields to their default state
        */
        public void PopulateCampusLocation()
        {   

            // Gather the scores.
            int.TryParse(admissonScoreComboBox.Text, out int admissionTSint);
            int.TryParse(highSchoolGradeComboBox.Text, out int highSchoolGradeInt);

            // Initialize an admission counter.
            int admissionCounter = 0;

            // Loop through the campus list, and check if any of the score and grade match the admissionTSReq, and HSGradeReq from each.
            foreach (CampusClass campus in campusList)
            {

                // If both HS grade and admission scores are >= requirements
                if (admissionTSint >= campus.GetAdmissionTSReq() && highSchoolGradeInt >= campus.GetHSGradeReq())
                {
                    // Then add to the drop down.
                    campusLocationComboBox.Items.Add(campus.GetLocation());
                    // Increment counter
                    admissionCounter++;
                }
            }
            // If student has been admitted to at least 1 school.
            if (admissionCounter > 0)
            {
                // Enable the location combo box
                campusLocationComboBox.Enabled = true;
            }
            // Else meets no requirements. 
            // If (false) an error message should be displayed to inform the employee that the student application is rejected,
            // and reset the compoboxes(High school grade and Admission test score) input fields to their default state
            else
            {
                MessageBox.Show("Sorry, but your application has been rejected.");
                admissonScoreComboBox.SelectedIndex = -1;
                highSchoolGradeComboBox.SelectedIndex = -1;
            }
        }

        /*
            SIN Exists In Combo Box.
        This function will check if the student SIN is in the combobox.
        Returns true if exists, false if not.
         */
        private bool SinExistsInComboBox(string searchValue)
        {
            foreach (var sin in sinComboBox.Items)
            {
                if (sin.ToString() == searchValue)
                {
                    return true;
                }
            }
            return false;
        }

        /*
            SIN Exists In Data grid View.
        This function will check if the student SIN is in the data grid view.
        Returns true if exists, false if not.
         */
        private bool SinExistsInDataGridView(string searchValue)
        {
            // For each row in the student grid view.
            foreach (DataGridViewRow row in studentGridView.Rows)
            {
                // Check if the cell value is not null and has a value.
                if (row.Cells[2].Value != null && !string.IsNullOrEmpty(row.Cells[2].Value.ToString()))
                {
                    // If the row has a matching SIN.
                    if (row.Cells[2].Value.ToString().Equals(searchValue))
                    {
                        // Return true
                        return true;
                    }
                }
            }
            // We have checked all rows, and none have provided a match, therefore SIN does not exist.
            return false;
        }


        /* 
         * Validation should take place in a Method that takes the input fields - from section one “Student Information” - as parameters, this function will be triggered when check button is pressed. 
             For each field that is invalid or empty when the Validation Method is called,
                 an error message specific to that field should be displayed and highlighted the field by red colour.
             The Validation method should also check if the student is eligible to be admitted to one or more campuses,
                 if yes(true) then activate the “campuses” combobox lists these campuses.
                 If (false) an error message should be displayed to inform the employee that the student application is rejected,
                     and reset the compoboxes(High school grade and Admission test score) input fields to their default state
        */
        public bool IsValid(string firstName, string lastName, string SINstring, string email)
        {

            // Set a bool value to track validation 
            bool isValid = true;

            // Reset all color fields to white
            firstNameTextBox.BackColor = Color.White;
            lastNameTextBox.BackColor = Color.White;
            emailTextBox.BackColor = Color.White;
            sinTextBox.BackColor = Color.White;
            admissonScoreComboBox.BackColor = Color.White;
            highSchoolGradeComboBox.BackColor = Color.White;    

            //	For each field that is invalid or empty when the Validation Method is called, an error message specific to that
            //	field should be displayed and highlighted the field by red colour.
            if (string.IsNullOrWhiteSpace(firstName))
            {
                // change field to red 
                firstNameTextBox.BackColor = Color.Red;
                // Error Message
                MessageBox.Show("First name must not be empty.");
                // return false
                isValid = false;

            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                // change field to red 
                lastNameTextBox.BackColor = Color.Red;
                // Error Message
                MessageBox.Show("Last name must not be empty.");
                // return false
                isValid = false;
            }

            if (!int.TryParse(SINstring, out int SINint) || SINstring.Length != 9)
            {
                // change field to red 
                sinTextBox.BackColor = Color.Red;
                // Error message
                MessageBox.Show("SIN field must not be empty and must be a number 9 digits in length.");
                // return false
                isValid = false;
            }
            // Else, Sin is able to be converted to a numeric value, so we can check for it's existence in the JSON file.
            else
            {
                IsSinUnique(SINint);
            }

            if (SinExistsInComboBox(SINstring) || SinExistsInDataGridView(SINstring))
            {
                // change field to red 
                sinTextBox.BackColor = Color.Red;
                // Error message
                MessageBox.Show("SIN found in the system. Student cannot be enrolled in more programs. Would the student like to update or delete their admission?");
                // return false
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !(email.ToLower().EndsWith(".com") || email.ToLower().EndsWith(".ca")))
            {
                // change field to red 
                emailTextBox.BackColor = Color.Red;
                // Error message
                MessageBox.Show("Email must not be empty, must contain '@', and must end with '.ca' or '.com'");
                // return false
                isValid = false;
            }

            if (admissonScoreComboBox.SelectedIndex == -1)
            {
                // change field to red 
                admissonScoreComboBox.BackColor = Color.Red;
                // Error Message
                MessageBox.Show("An admission test score must be selected.");
                // return false
                isValid = false;
            }

            if (highSchoolGradeComboBox.SelectedIndex == -1)
            {
                // change field to red 
                highSchoolGradeComboBox.BackColor = Color.Red;
                // Error Message
                MessageBox.Show("A highschool grade must be selected.");
                // return false
                isValid = false;
            }

            // If all is valid
            if(isValid == true)
            {   
                // Loop through campus objects and populate drop down based on grades entered.
                PopulateCampusLocation();

                return true;
            }
            // Else there is an invalid entry somewhere.
            else
            {
                return false;
            }

        }

        /*
         ConvertToJson()
         when "Load records to Server" is pressed call function (method), this function takes an ArrayList of students as a parameter, 
            which does a loop to pass all items in this ArrayList, this function call “SerializeObject(studentObj)” 
            located under JsonConvert class is used to convert object data to special string format, this format is used to write in JSON format as showed below.    
         */
        internal void ConvertToJSON(List<StudentClass> studentList)
        {

            // Specify the relative path to the JSON file. (So it works on any machine)
            string relativePath = "studentData.json";

            // Specify the file path
            string filePath = Path.Combine(Environment.CurrentDirectory, relativePath);

            foreach (StudentClass student in studentList)
                {
                    // Serialize it to the JSON format.
                    string json = student.SerializeStudent(student);

                    // Try to open and append it to the JSON file. 
                    try
                    {
                        File.AppendAllText(filePath, json + Environment.NewLine);
                        // Successful message.
                        MessageBox.Show("Data saved to JSON file.");
                    }
                    // Catch exception if unable.
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error writing to file: {ex.Message}");
                    }
                }
        }
        /*
         
         IsSinUnqiue()
        This function reads from the JSON and checks for the existence of a SIN.
        Returns true if SIN is unique.
         */
        internal bool IsSinUnique(int sinToCheckInt)
        {
            try
            {
                // Specify the relative path to the JSON file. (So it works on any machine).
                string relativePath = "studentData.json";

                // Specify the file path.
                string filePath = Path.Combine(Environment.CurrentDirectory, relativePath);

                // Check if the file exists before attempting to read it.
                if (!File.Exists(filePath))
                {
                    // Handle the case where the file doesn't exist.
                    MessageBox.Show("JSON file not found.");
                    // Assuming it's unique if the file doesn't exist.
                    return true; 
                }

                // Read all lines from the JSON file
                string[] jsonLines = File.ReadAllLines(filePath);

                // Loop through each line (each student record in JSON format)
                foreach (string json in jsonLines)
                {
                    try
                    {
                        // Deserialize the JSON string back to a StudentClass object
                        StudentClass student = JsonConvert.DeserializeObject<StudentClass>(json);

                        // Check if the SIN value matches the one to be checked
                        if (student != null && student.SIN == sinToCheckInt)
                        {
                            // If it matches, display a message and return false (not unique)
                            sinTextBox.BackColor = Color.Red;
                            MessageBox.Show("SIN value already exists in the system. Please Update or Delete the existing Record.");
                            return false;
                        }
                    }
                    catch (JsonException ex)
                    {
                        // Handle JSON deserialization exception for a specific record
                        Debug.WriteLine($"Error deserializing JSON for a record: {ex.Message}");
                    }
                }

                // If no match is found, return true (unique)
                return true;
            }
            catch (Exception ex)
            {
                // Handle general exceptions (e.g., file not readable)
                Debug.WriteLine($"Error reading from file: {ex.Message}");
                MessageBox.Show("Error reading from JSON file.");
                return false;
            }
        }



        /*
         Reset Form.
        Resets all input controls to their blank initial state.
         */
        public void ResetInputFields()
        {
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            sinTextBox.Text = string.Empty;
            admissonScoreComboBox.SelectedIndex = -1;
            highSchoolGradeComboBox.SelectedIndex = -1;
            studyPeriodTextBox.Text = string.Empty;
            totalCostTextBox.Text = string.Empty;
            campusLocationComboBox.SelectedIndex = -1;
            programsComboBox.SelectedIndex = -1;
            registerButton.Enabled = false;
            registerToolStripMenuItem.Enabled = false;
            campusLocationComboBox.Enabled = false;
            programsComboBox.Enabled = false;
        }


        /*
            Main Class.
         */
        public Form1()
        {
            InitializeComponent();

            // Instantiate programs to be used to popualte the list of programs for campus objects. ------------------------

            SchoolProgramClass computerProgrammingProgram = new SchoolProgramClass("Computer Programming", 8000, 4);

            SchoolProgramClass networkSecurityProgram = new SchoolProgramClass("Network Security", 9000, 3);

            SchoolProgramClass webDevelopmentProgram = new SchoolProgramClass("Engineering", 20000, 6);

            SchoolProgramClass dataScienceProgram = new SchoolProgramClass("Data Science", 10000, 4);

            SchoolProgramClass artificialIntelligenceProgram = new SchoolProgramClass("Artificial Intelligence", 9500, 3);

            SchoolProgramClass mobileAppDevelopmentProgram = new SchoolProgramClass("Criminology", 12000, 4);

            SchoolProgramClass databaseManagementProgram = new SchoolProgramClass("Database Management", 8800, 3);

            SchoolProgramClass softwareEngineeringProgram = new SchoolProgramClass("Software Engineering", 8500, 4);

            SchoolProgramClass graphicDesignProgram = new SchoolProgramClass("Graphic Design", 7500, 2);

            SchoolProgramClass environmentalScienceProgram = new SchoolProgramClass("Environmental Science", 11000, 4);

            SchoolProgramClass culinaryArtsProgram = new SchoolProgramClass("Culinary Arts", 9500, 2);


            // Create list of programs for each campus --------------------------------------------------------------------------

            List<SchoolProgramClass> ontarioPrograms = new List<SchoolProgramClass> 
            { computerProgrammingProgram, networkSecurityProgram, webDevelopmentProgram, dataScienceProgram, graphicDesignProgram };

            List<SchoolProgramClass> quebecPrograms = new List<SchoolProgramClass> 
            { networkSecurityProgram, dataScienceProgram, artificialIntelligenceProgram, graphicDesignProgram, culinaryArtsProgram };

            List<SchoolProgramClass> novaScotiaPrograms = new List<SchoolProgramClass> 
            { webDevelopmentProgram, dataScienceProgram, mobileAppDevelopmentProgram, databaseManagementProgram, environmentalScienceProgram };

            List<SchoolProgramClass> newBrunswickPrograms = new List<SchoolProgramClass> 
            { computerProgrammingProgram, networkSecurityProgram, mobileAppDevelopmentProgram, softwareEngineeringProgram, culinaryArtsProgram };

            List<SchoolProgramClass> manitobaPrograms = new List<SchoolProgramClass> 
            { computerProgrammingProgram, databaseManagementProgram, softwareEngineeringProgram, environmentalScienceProgram, culinaryArtsProgram };

            List<SchoolProgramClass> britishColumbiaPrograms = new List<SchoolProgramClass> 
            { webDevelopmentProgram, artificialIntelligenceProgram, mobileAppDevelopmentProgram, databaseManagementProgram, environmentalScienceProgram };

            List<SchoolProgramClass> peiPrograms = new List<SchoolProgramClass> 
            { networkSecurityProgram, artificialIntelligenceProgram, databaseManagementProgram, graphicDesignProgram, culinaryArtsProgram };

            List<SchoolProgramClass> saskatchewanPrograms = new List<SchoolProgramClass> 
            { computerProgrammingProgram, networkSecurityProgram, mobileAppDevelopmentProgram, softwareEngineeringProgram, environmentalScienceProgram };

            List<SchoolProgramClass> albertaPrograms = new List<SchoolProgramClass> 
            { webDevelopmentProgram, dataScienceProgram, artificialIntelligenceProgram, mobileAppDevelopmentProgram, softwareEngineeringProgram };

            List<SchoolProgramClass> newfoundlandPrograms = new List<SchoolProgramClass> 
            { computerProgrammingProgram, networkSecurityProgram, webDevelopmentProgram, dataScienceProgram, databaseManagementProgram };

            List<SchoolProgramClass> labradorPrograms = new List<SchoolProgramClass> 
            { networkSecurityProgram, mobileAppDevelopmentProgram, databaseManagementProgram, graphicDesignProgram, culinaryArtsProgram };


            // Create the campus objects and fill them with data and program lists -------------------------------------------------

            CampusClass ontarioCampus = new CampusClass(70, 85, 250, "Ontario", ontarioPrograms);

            CampusClass quebecCampus = new CampusClass(80, 85, 150, "Quebec", quebecPrograms);

            CampusClass novaScotiaCampus = new CampusClass(65, 65, 50, "Nova Scotia", novaScotiaPrograms);

            CampusClass newBrunswickCampus = new CampusClass(60, 65, 85, "New Brunswick", newBrunswickPrograms);

            CampusClass manitobaCampus = new CampusClass(70, 75, 75, "Manitoba", manitobaPrograms);

            CampusClass britishColumbiaCampus = new CampusClass(85, 90, 500, "British Columbia", britishColumbiaPrograms);

            CampusClass PEICampus = new CampusClass(80, 80, 150, "Prince Edward Island", peiPrograms);

            CampusClass saskatchewanCampus = new CampusClass(70, 65, 125, "Saskatchewan", saskatchewanPrograms);

            CampusClass albertaCampus = new CampusClass(50, 55, 100, "Alberta", albertaPrograms);

            CampusClass newfoundlandCampus = new CampusClass(60, 65, 50, "Newfoundland", newfoundlandPrograms);

            CampusClass labradorCampus = new CampusClass(50, 50, 25, "Labrador", labradorPrograms);

            // Add the campuses to the campus list ----------------------------------------------------------------------------------
            campusList.AddRange(new List<CampusClass>
            {
                ontarioCampus,
                quebecCampus,
                novaScotiaCampus,
                newBrunswickCampus,
                manitobaCampus,
                britishColumbiaCampus,
                PEICampus,
                saskatchewanCampus,
                albertaCampus,
                newfoundlandCampus,
                labradorCampus
            });
        }

        /* Form 1 Load 
         * Campus location and programs start disabled.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            campusLocationComboBox.Enabled = false;
            programsComboBox.Enabled = false;
            registerButton.Enabled = false;
            registerToolStripMenuItem.Enabled = false;
        }
        /*
         Check Button
        Check button will take all "student information" section values, validate them, and populate the campus location drop down menu
        if student has high enough grades.
         */
        private void checkButton_Click(object sender, EventArgs e)
        {   

            // Clear the campus location list, program list, cost and duration of program.
            campusLocationComboBox.Items.Clear();
            programsComboBox.Items.Clear();
            totalCostTextBox.Text = string.Empty;
            studyPeriodTextBox.Text = string.Empty;

            // Disable Programs and registration button
            programsComboBox.Enabled = false;
            registerButton.Enabled = false;
            registerToolStripMenuItem.Enabled = false;

            // Validate and popualte the campuses based on grades.
            if (!IsValid(firstNameTextBox.Text, lastNameTextBox.Text, sinTextBox.Text, emailTextBox.Text)) 
            { campusLocationComboBox.Enabled = false; }

            // Else the information is valid, so we disable the first section.
            else 
            {
                // Disable student information section
                foreach (Control control in studentInformationGroupBox.Controls)
                {
                    control.Enabled = false;
                }
            }
        }

        /*
         Campus Location Combo Box - Selected Index is Changed
        Create an event handler “SelectedIndexChanged” for the “campuses” combobox, once the employee selects the campus, 
        activate the “Programs” combobox and add the available programs in the selected campus, displays the program’s duration of study, 
        and the total cost plus registration fees.
         */
        private void campusLocationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
            // Re-Disable the register button because items have changed.
            registerButton.Enabled = false;
            registerToolStripMenuItem.Enabled = false;

            // Clear the program cost, duration, and programs combo box.
            programsComboBox.Items.Clear();
            studyPeriodTextBox.Text = String.Empty;
            totalCostTextBox.Text = String.Empty;

            // Reset the program combo box.
            programsComboBox.Text = String.Empty;

            // Activate the programs combo box.
            programsComboBox.Enabled = true;

            // Get the value that is selected from the campus location combo box.
            string selectedLocation = campusLocationComboBox.Text;

            // Loop through the campus objects for a matching campus location property (campus.getLocation())
            foreach(CampusClass campus in campusList)
            {
                // If a match is found:
                if (campus.GetLocation() == selectedLocation)
                {   
                    // For each item in the school program list of that campus object, add it to the program combo box.
                    foreach (SchoolProgramClass program in campus.GetSchoolPrograms())
                    {
                        programsComboBox.Items.Add(program.GetProgramName());
                    }
                }
            }
            
        }

        /*
         Programs Combo Box - Index Changed.
        This means the user has selected a program, and thus, this will populate the cost and program duration text boxes with that programs info.   
         */
        private void programsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the value that is selected from the program combo box.
            string selectedProgram = programsComboBox.Text;
            string selectedLocation = campusLocationComboBox.Text; 

            // Loop through the selected campus's program list.
            foreach (CampusClass campus in campusList) 
            {   
                // if the selected campus matches the campus object location.
                if (campus.GetLocation() == selectedLocation)
                {
                    
                    // Then loop through that campus' object's program list.
                    foreach (SchoolProgramClass program in campus.GetSchoolPrograms())
                    {
                        // if the program name in the program list matches the selected Program.
                            // Grab it's cost and length and set the textboxes to them.
                        if (program.GetProgramName() == selectedProgram)
                        {

                            // Calculate the total cost of the program + campus registration fees + tax.
                            double totalCost = program.GetProgramFees() + campus.GetRegFees();
                            double totalCostPlusTax = totalCost + (totalCost * tax);
                            
                            studyPeriodTextBox.Text = program.GetProgramDuration().ToString("F2");
                            totalCostTextBox.Text = totalCostPlusTax.ToString("C2");

                            // Enable the register button now that we have all required information.
                            registerButton.Enabled = true;
                            registerToolStripMenuItem.Enabled = true;
                        }
                    }
                }
            }
        }

        /*
         Register Student
            When Click on the Register button:
            Add the student data to DataGridView as one Record (Row).
            Add the student’s SIN to the SIN Combobox that appears bottom of the form.
         */
        private void registerButton_Click(object sender, EventArgs e)
        {

            // Create a new row object with data from text boxes.
            object[] newStudentRow = {firstNameTextBox.Text, lastNameTextBox.Text, sinTextBox.Text, emailTextBox.Text, highSchoolGradeComboBox.Text, 
                                      admissonScoreComboBox.Text, campusLocationComboBox.Text, programsComboBox.Text};

            // Add that row to the data grid view.
            studentGridView.Rows.Add(newStudentRow);

            // Convert string data to needed data types to match student object.
            int.TryParse(sinTextBox.Text, out int sinInt);
            int.TryParse(highSchoolGradeComboBox.Text, out int HSGradeInt);
            int.TryParse(admissonScoreComboBox.Text, out int admissionTSInt);

            // Instantiate a new student object with valid data.
            StudentClass newStudentObject = new StudentClass(firstNameTextBox.Text, lastNameTextBox.Text, sinInt, emailTextBox.Text, 
                                                            HSGradeInt, admissionTSInt, campusLocationComboBox.Text, 
                                                            programsComboBox.Text);
            // Add the student objecto the student list.
            studentObjectList.Add(newStudentObject);

            // Add the student's SIN to the SIN combobox.
            sinComboBox.Items.Add(sinTextBox.Text);

            // Reset student input fields.
            ResetInputFields();

            // Unlock the student input fields.
            foreach (Control control in studentInformationGroupBox.Controls)
            {
                control.Enabled = true;
            }

        }

        /*
         Load Records Button click
            When Click on “Load Records to Server” button: 
            Upload the records to the (.JSON) file.
            All Students and Program information will be removed.
            All records in DataGrid View will be removed
            All input controls will clear or be set to their default state
            Show a message that inform the employee that the data successfully loaded

            when "Load records to Server" is pressed call function (method), this function takes an ArrayList of students as a parameter, 
            which does a loop to pass all items in this ArrayList, this function call “SerializeObject(studentObj)” 
            located under JsonConvert class is used to convert object data to special string format, this format is used to write in JSON format as showed below. 
        */
        private void loadRecordsButton_Click(object sender, EventArgs e)
        {
            
            // Convert all student objects from the list to JSON formatting, and append to the JSON File.
            ConvertToJSON(studentObjectList);

            // Reset student information section, reset student and program info, remove all data grid view items, all reset to default state.
            ResetInputFields();

            // Clear Data grid view.
            studentGridView.Rows.Clear();

            // Clear the student list and SIN combo box.
            studentObjectList.Clear();
            sinComboBox.Items.Clear();
        }

        /*
         Row Header (Whole row highlighter on the left) is double clicked.
            Populates the sutdent information section with corresponding data.
         */
        private void studentGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs row)
        {
            // Re-enable student information section.
            foreach (Control control in studentInformationGroupBox.Controls)
            {
                control.Enabled = true;
            }

            // Get the selected row
            int selectedRow = row.RowIndex;

            // Assign the values of the columns of the selected row to objects.
            object firstNameValue = studentGridView.Rows[selectedRow].Cells[0].Value;
            object lastNameValue = studentGridView.Rows[selectedRow].Cells[1].Value;
            object sinValue = studentGridView.Rows[selectedRow].Cells[2].Value;
            object emailValue = studentGridView.Rows[selectedRow].Cells[3].Value;
            object admissionTSValue = studentGridView.Rows[selectedRow].Cells[4].Value;
            object highSchoolGradeValue = studentGridView.Rows[selectedRow].Cells[5].Value;

            // If the selected values are not null.
            if (firstNameValue != null && lastNameValue != null && sinValue != null &&
                emailValue != null && admissionTSValue != null && highSchoolGradeValue != null)
            {
                // Populate the student information fields.
                firstNameTextBox.Text = firstNameValue.ToString();
                lastNameTextBox.Text = lastNameValue.ToString();
                sinTextBox.Text = sinValue.ToString();
                emailTextBox.Text = emailValue.ToString();
                admissonScoreComboBox.Text = admissionTSValue.ToString();
                highSchoolGradeComboBox.Text = highSchoolGradeValue.ToString();
            }
            // Else the user has double clicked an empty row.
            else
            {
                MessageBox.Show("Error: You must select a populated row.");
            }
        }

        /*
         Edit Student Information Button
        Unlocks student information for editing. 
        To do this, we must disable section 2, and the register button
         */
        private void editStudentInfoButton_Click(object sender, EventArgs e)
        {

            // Reset section 2 inputs.
            campusLocationComboBox.SelectedIndex = -1;
            programsComboBox.SelectedIndex = -1;
            campusLocationComboBox.Enabled = false;
            programsComboBox.Enabled = false;
            studyPeriodTextBox.Text = string.Empty;
            totalCostTextBox.Text = string.Empty;

            // Disable the register button.
            registerButton.Enabled = false;
            registerToolStripMenuItem.Enabled = false;

            // Re-enable student information controls.
            foreach (Control control in studentInformationGroupBox.Controls)
            {
                control.Enabled = true;
            }

        }

        /*
            Delete Record Button.
        A Registration employee can Delete the student’s Record that corresponds with the SIN selected from ComboBox that appears in the form.
        The application should ask to select the SIN that needs to be Deleted.
        delete button is pressed the application should ask the employee to select the Student’s SIN from SIN’s Combobox then delete the student’ 
        record from DataGrid View, delete this object from student array list, and delete the SIN from SIN’s Combobox
         */
        private void deleteRecordButton_Click(object sender, EventArgs e)
        {

            // Check if a SIN is selected from the combo box.
            if (sinComboBox.SelectedIndex >= 0)
            {
                // For each row in the student grid view.
                foreach (DataGridViewRow row in studentGridView.Rows)
                {   
                    // If the row has a matching SIN.
                    if (row.Cells[2].Value.ToString().Equals(sinComboBox.Text))
                    {
                        // Delete the cooresponding row.
                        studentGridView.Rows.Remove(row);

                        // Delete the SIN from the SIN combobox.
                        sinComboBox.Items.Remove(sinComboBox.Text);

                        // Message that deletion was successful.
                        MessageBox.Show("Record was deleted successfully.");

                        // Break, because there will only ever be 1 of this SIN in the DGV.
                        break;
                    }
                }
            }
            // Message the user to select a SIN to be deleted if none is selected.
            else 
            {
                MessageBox.Show("Please select a SIN from the drop down menu, then press delete.");
            }


        }

        /*
         Update Button.
        The application should ask to select the SIN that needs to be updated.
        Update student information from new entries from section one "Student Information".
        Update button is pressed the application should ask the employee to select the Student’s SIN from SIN’s Combobox 
            then based on the student’s SIN, retrieve the student’s information from DataGrid View to the section one "Student information" 
                (except campus location and program) 
            and return the comboboxes (Campuses and Programs) to their inactivate status, 
            delete this object from student array list, 
            and start from the beginning to double check if the student still eligible to be admitted with new entries.
         */
        private void updateRecordButton_Click(object sender, EventArgs e)
        {
            
            // Check if a SIN is selected from the combobox.
            if (sinComboBox.SelectedIndex >= 0)
            {
                // For each row in the student grid view.
                foreach (DataGridViewRow row in studentGridView.Rows)
                {
                    // If the row has a matching SIN.
                    if (row.Cells[2].Value.ToString().Equals(sinComboBox.Text))
                    {
                        // Give the SIN a variable for use in removal from student object list.
                        string sin = sinComboBox.Text;
                        
                        // Populate the student information section with the data.
                        firstNameTextBox.Text = row.Cells[0].Value.ToString();
                        lastNameTextBox.Text = row.Cells[1].Value.ToString();
                        sinTextBox.Text = row.Cells[2].Value.ToString();
                        emailTextBox.Text = row.Cells[3].Value.ToString();
                        admissonScoreComboBox.Text = row.Cells[4].Value.ToString();
                        highSchoolGradeComboBox.Text = row.Cells[5].Value.ToString();

                        // Delete the row from the student grid view.
                        studentGridView.Rows.Remove(row);

                        // Set a variable to hold the student to remove.
                        StudentClass studentToRemove = null;
                        // Delete the student from the student object list.
                        foreach (StudentClass student in studentObjectList)
                        {
                            if (student.SIN.ToString() == sin)
                            {
                                studentToRemove = student; 
                            }
                        }
                        // Remove the student from the student array.
                        studentObjectList.Remove(studentToRemove);

                        // Remove the SIN from the SIN combo box.
                        sinComboBox.Items.Remove(sin);

                        // Break, since only 1 SIN of that will exist in the DGV.
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a SIN from the drop down menu, then press update.");
            }
        }

        /*
         Remove All Button.
        Removes all students from the data grid view, and resets all input controls to their default state.
         */
        private void removeAllRecordsButton_Click(object sender, EventArgs e)
        {
            // Reset form.
            ResetInputFields();
            // Reset DGV.
            studentGridView.Rows.Clear();
            //Clear the SIN Combo box.
            sinComboBox.Items.Clear();
        }

        /*
         Exit Button.
        Closes application.
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            // End the application.
            Application.Exit();
        }

        /*
         Register button in menu.
        Performs the same function as the register button.
         */
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (registerButton.Enabled == true)
            {
                registerToolStripMenuItem.Enabled = true;
                registerButton_Click(sender, e);
            }

        }

        /*
         Update button in menu strip.
        Tied to the functionality of the update button.
         */
        private void updateRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateRecordButton_Click(sender, e);
        }

        /*
         Delete Record in menu strip.
        Tied to the functionality of the delete record button. 
         */
        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteRecordButton_Click(sender, e);
        }

        /*
         Load records to server menu strip item.
        Tied to the functionality of the Load records to server button.     
         */
        private void loadRecordsToServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadRecordsButton_Click(sender, e);
        }

        /*
        Remove All Records menu strip item.
        Tied to the functionality of the remove all button.
        */
        private void removeAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeAllRecordsButton_Click(sender, e);
        }

        /*
         Exit menu strip item.
        Tied to the functionality of the exit button.
         */
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exitButton_Click(sender, e);
        }

        /*
         Read Help Menu strip item.
            “Read Help” opens a new form that displays all the details of controls and their functionalities, and this form has its exit button. 
         */
        private void readHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the HelpForm
            ReadHelpForm readHelpForm = new ReadHelpForm();

            // Show the HelpForm
            readHelpForm.Show();
        }

        /*
         Technical Support menu strip item.
            Technical Support” opens a new form that displays all your details your name, ID, and DC email, and this form has its exit button. 
         */
        private void technicalSupportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the tech support form.
            TechSupportForm techSupportForm = new TechSupportForm();

            // Show it.
            techSupportForm.Show();
        }

        /*
         About DC Registration App menu strip item.
            “About DC- Registration App” opens a new form that displays a simple description of your application, and this form has its exit button.     
         */
        private void aboutDCRegistrationAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create an instance of the about app form.
            AboutDCAppForm aboutDCAppForm = new AboutDCAppForm();

            // Show it.
            aboutDCAppForm.Show();
        }

    }
}
