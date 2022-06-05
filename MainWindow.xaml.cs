using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;

namespace Test_Wpf2_SQL
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WorkBaze wb;
        Phone ph2;

        public MainWindow()
        {
            InitializeComponent();
           
            wb = new WorkBaze();

        }

        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {

            Phone ph;
            ph = wb.Phones.Find(Convert.ToInt32(this.textBoxID.Text));
            
            if (ph != null) {
                this.textBoxNAME.Text = ph.Name;
                this.textBoxNAMBER.Text = ph.Naber.ToString();
                MessageBox.Show("Абонент найден, успешно.");
            }
            else MessageBox.Show("Данный номер не существует, в базе.");

        }

        private void buttonOpen_Copy_Click(object sender, RoutedEventArgs e)
        {

            int num = Convert.ToInt32(textBoxNAMBER.Text);
            string nname = textBoxNAME.Text;


            ph2 = new Phone(num, nname);
            ph2.id = Convert.ToInt32(textBoxID.Text);
         

            wb.Phones.Add(ph2);
            wb.SaveChanges();
            

            MessageBox.Show("Абонент добавлен, успешно.");

          
        }


        private void Del_Click(object sender, RoutedEventArgs e)
        {
            wb.Phones.RemoveRange(wb.Phones);
            wb.SaveChanges();
            MessageBox.Show("Все контакты удалены, успешно.");
        }

    }
}
