using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bt_12_10_4._6
{
    public class Student : INotifyPropertyChanged
    {
        private string studentId;
        private string fullName;
        private int age;
        private string gender;
        private string avatarPath;

        public string StudentId
        {
            get => studentId;
            set { studentId = value; OnPropertyChanged(); }
        }

        public string FullName
        {
            get => fullName;
            set { fullName = value; OnPropertyChanged(); }
        }

        public int Age
        {
            get => age;
            set { age = value; OnPropertyChanged(); }
        }

        public string Gender
        {
            get => gender;
            set { gender = value; OnPropertyChanged(); }
        }

        public string AvatarPath
        {
            get => avatarPath;
            set { avatarPath = value; OnPropertyChanged(); }
        }

        public Student() { }

        public Student(string studentId, string fullName, int age, string gender, string avatarPath)
        {
            StudentId = studentId;
            FullName = fullName;
            Age = age;
            Gender = gender;
            AvatarPath = avatarPath;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}