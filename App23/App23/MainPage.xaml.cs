using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App23
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddOrUpdateStudent(object sender, EventArgs e)
        {
           
            string studentNumber = StudentNumberEntry.Text;
            string programCourse = ProgramCoursePicker.SelectedItem?.ToString();
            int yearLevel = GetSelectedYearLevel();
            double numberOfUnits = Convert.ToDouble(NumberOfUnitsEntry.Text);

            
            double ratePerUnit = GetRatePerUnit(yearLevel);
            double tuitionFee = numberOfUnits * ratePerUnit;

           
            double downPayment = tuitionFee * 0.3;

            
            double balance = tuitionFee - downPayment;

            
            DisplayAlert("Student Information", $"Tuition Fee: {tuitionFee}\nDown Payment: {downPayment}\nBalance: {balance}", "OK");
        }

        private int GetSelectedYearLevel()
        {
            if (YearLevelRadio1.IsChecked)
                return 1;
            else if (YearLevelRadio2.IsChecked)
                return 2;
            else if (YearLevelRadio3.IsChecked)
                return 3;
            else
                return 4;
        }

        private double GetRatePerUnit(int yearLevel)
        {
            switch (yearLevel)
            {
                case 1:
                    return 1500;
                case 2:
                    return 1800;
                case 3:
                    return 2000;
                case 4:
                    return 2300;
                default:
                    return 0;
            }
        }
    }
}
