using System.ComponentModel;
using wpfApp1.Core.Workers;

namespace wpfApp1.Core.ViewModel
{
    public class StudentWorker : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string StudentName { get; set; } = "aa";
        public void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void SetStudentName()
        {
            StudentName = StudentWorkerProgress.GetStudentName();
        }


        public void ShowUserMessage(string messageText)
        {
            MessageBox.Show(messageText);
        }

    }
}
