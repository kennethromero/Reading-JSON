using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TVLICT201.JSONReader.Windows.Macros
{
    /// <summary>
    /// Interaction logic for MacrosWindow.xaml
    /// </summary>
    public partial class MacrosWindow : Window
    {
        public MacrosWindow()
        {
            InitializeComponent();
            Macros macros = new Macros();

            using (StreamReader r = new StreamReader("data\\macros.json"))
            {
                string json = r.ReadToEnd();
                macros = JsonConvert.DeserializeObject<Macros>(json);
            }

            lblMacrosId.Content = "id :" + macros.Id;
            lblMacrosName.Content = "name :" + macros.Name;
            lblMacrosCalories.Content = "calories :" + macros.Calories;
            lblMacrosFat.Content = "fat :" + macros.Fat;
            lblMacrosCarbohydrates.Content = "carbohydrates :" + macros.Carbohydrates;
            lblMacrosProtein.Content = "protein :" + macros.Protein;

        }
    }
}
