using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;
using Microsoft.Maui.Controls.Shapes;

namespace DiceRolder
{
    public partial class MainPage : ContentPage
    {
        Random random = new Random();
        public MainPage()
        {
            InitializeComponent();
        }
        public virtual int Next { get; }

        private void RollDiceButton_Clicked(object sender, EventArgs e)
        {
            int selectedSides = Convert.ToInt32(SidesPicker.SelectedItem);
            int drawnNumber = random.Next(1, selectedSides + 1);
            DADOS.Text = drawnNumber.ToString();
       
        }
      
        
    }
}