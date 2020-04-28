using System;
using System.Collections.Generic;
using System.Text;

namespace HealthApp
{
    class HeartRates
    {
        private string firstName;
        private string lastName;
        private int yearOfBirth;
        private int currentYear;
        private int age;
        private int maxHeartRate;
        private int minTarget;
        private int maxTarget;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                yearOfBirth = value;
            }
        }
        public int CurrentYear
        {
            get
            {
                return currentYear;
            }
            set
            {
                currentYear = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int FindAge()
        {
            age = currentYear - yearOfBirth;
            return age;
        }
        public int MaxHeartRate()
        {
            maxHeartRate = 220 - age;
            return maxHeartRate; 
        }
        public int MinTargetHeartRate()
        {
            minTarget = Convert.ToInt32(maxHeartRate * .50);
            return minTarget;
        }
        public int MaxTargetHeartRate()
        {
            maxTarget = Convert.ToInt32(maxHeartRate * .85);
            return maxTarget;
        }

        public HeartRates(string fName, string lName, int yOBirth, int cYear)
        {
            FirstName = fName;
            LastName = lName;
            YearOfBirth = yOBirth;
            CurrentYear = cYear;
        }
    }
}
