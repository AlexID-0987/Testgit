using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Name_random_a
{
    class MainViewMod : INotifyPropertyChanged
    {
        private ObservableCollection<Student> students;
        private Student selectedStudetn;
        public ObservableCollection<Student> Students 
        {
            get => students;
            set
            {
                students = value;
                NotifyOfPropertyChanged();
            }
        } 
        public Student SelectedStudent 
        {
            get => selectedStudetn;
            set
            {
                selectedStudetn = value;
                NotifyOfPropertyChanged();
            }
        }
        public MainViewMod()
        {
            Students = new ObservableCollection<Student>();
            InitCommands();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyOfPropertyChanged([CallerMemberName]string propertyName=" ")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void InitCommands()
        {
            AddStudentCommand = new NewCommand(x =>
             {
                 Students.Add(new Student
                 {
                     Name=RandomNameGenerator.NameGenerator.GenerateFirstName(RandomNameGenerator.Gender.Female),
                     Lastname = RandomNameGenerator.NameGenerator.GenerateLastName()
                 });
             });
            RemoweStudentCommand = new NewCommand(x =>
             {
                 Students.Remove(SelectedStudent);
             });
            ChangeCommand = new NewCommand(x =>
            {
                SelectedStudent.Color = "Blue";
                
            });
            ChangeCollectCommand = new NewCommand(x =>
              {
                  Students = new ObservableCollection<Student>
                  {
                new Student{Name="Coco",Lastname="Klec"},
                  };
  
              });
        }
        public ICommand AddStudentCommand { get; set; }
        public ICommand RemoweStudentCommand { get; set; }
        public ICommand ChangeCommand { get; set; }
        public ICommand ChangeCollectCommand { get; set; }
    }
}
