using System.Diagnostics;

namespace assignment_2
{
    public partial class MainPage : ContentPage
    {


        List<double> hours = new List<double>
        {
            1,
            2,
            3,
            1,
            3,
            2,
            2,
            2,
            1,
            2
        };
        List<string> itemnames = new List<string>
        {
           "CITA 245 Homework",
           "Class",
           "Lab",
           "Call Parents",
           "CITA 255 Project",
           "CITA 200 Class",
           "CITA 300 Homework",
           "COMP 310 Homework",
           "COMP 310 Project",
           "Lacrosee Practice"
        };

        public MainPage()
        {
            InitializeComponent();
            hoursList.ItemsSource = hours;
            itemNamesList.ItemsSource = itemnames;
            titleLabel.Text = "To Do List";
            hoursLabel.Text = "Hours";

        }
        private void OnTotalClicked(object sender, EventArgs e)
        {
            double total = 0;
            foreach (double hour in hours)
              
            {
                
                total = total + hour;
                Debug.WriteLine(hour);

               
            }
            totalLabel.Text = $"Total: {total}"; 
        }


    }
}
