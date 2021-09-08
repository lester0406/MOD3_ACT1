using System;
using System.Collections.Generic;
using System.Text;
using MOD3_ACT1.Model;
using Xamarin.Forms;
using System.ComponentModel;

namespace MOD3_ACT1.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }

        public Command SubmitEntry { get; set; }
        public string StudentIdEntry { get; set; }
        public string StudentIdDisplay { get; set; }

        public string StudentNameEntry { get; set; }
        public string StudentNameDisplay { get; set; }

        public string StudentCodeEntry { get; set; }
        public string StudentCodeDisplay { get; set; }

        public string StudentTitleEntry { get; set; }
        public string StudentTitleDisplay { get; set; }

        public string StudentUnitsEntry { get; set; }
        public string StudentUnitsDisplay { get; set; }

        public string StudentDateEntry { get; set; }
        public string StudentDateDisplay { get; set; }



        public StudentViewModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student()
                {
                    Name = StudentNameEntry,
                };

                StudentIdDisplay = StudentIdEntry;
                StudentNameDisplay = StudentNameEntry;
                StudentCodeDisplay = StudentCodeEntry;
                StudentTitleDisplay = StudentTitleEntry;
                StudentUnitsDisplay = StudentUnitsEntry;
                StudentDateDisplay = StudentDateEntry;



                OnPropertyChanged(nameof(StudentIdDisplay));
                OnPropertyChanged(nameof(StudentNameDisplay));
                OnPropertyChanged(nameof(StudentCodeDisplay));
                OnPropertyChanged(nameof(StudentTitleDisplay));
                OnPropertyChanged(nameof(StudentUnitsDisplay));
                OnPropertyChanged(nameof(StudentDateDisplay));

                OnPropertyChanged(nameof(StudentIdEntry));
                OnPropertyChanged(nameof(StudentNameEntry));
                OnPropertyChanged(nameof(StudentCodeEntry));
                OnPropertyChanged(nameof(StudentTitleEntry));
                OnPropertyChanged(nameof(StudentUnitsEntry));
                OnPropertyChanged(nameof(StudentDateEntry));

            });
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
