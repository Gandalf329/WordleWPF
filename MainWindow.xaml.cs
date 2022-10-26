using System;
using System.Collections;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            GetDict();
            
            InitializeComponent();
            
        }
        int num = 0;
        string result = "";
        string check = "";
        string path = "D:\\progVis\\Test6\\en_five.txt";
        Dictionary<int, string> dict_counts = new Dictionary<int, string>();

        public void GetWord()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, dict_counts.Count);
            result = dict_counts[random];
            TextBlock1.Text = result;
        }
        
        async Task GetDict()
        {
            
            int number = 0;
            
            using (StreamReader reader = new StreamReader(path))
            {
                //var dict_counts = new Dictionary<int, string>();
                string? line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    dict_counts.Add(number, line);
                    number += 1;
                }
            }
            GetWord();
        }
        public void Check(int number)
        {

            switch (number)
            {
                case 0:
                    if(result[0].ToString() == Cell1.Text)
                    {
                        Cell1.Background = Brushes.Green;
                    }else if (result.Contains(Cell1.Text))
                    {
                        Cell1.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell1.Background = Brushes.Gray;
                    }
                    if (result[1].ToString() == Cell2.Text)
                    {
                        Cell2.Background = Brushes.Green;
                    }else if (result.Contains(Cell2.Text))
                    {
                        Cell2.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell2.Background = Brushes.Gray;
                    }
                    if (result[2].ToString() == Cell3.Text)
                    {
                        Cell3.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell3.Text))
                    {
                        Cell3.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell3.Background = Brushes.Gray;
                    }
                    if (result[3].ToString() == Cell4.Text)
                    {
                        Cell4.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell4.Text))
                    {
                        Cell4.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell4.Background = Brushes.Gray;
                    }
                    if (result[4].ToString() == Cell5.Text)
                    {
                        Cell5.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell5.Text))
                    {
                        Cell5.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell5.Background = Brushes.Gray;
                    }

                    Cell1.IsEnabled = false;
                    Cell2.IsEnabled = false;
                    Cell3.IsEnabled = false;
                    Cell4.IsEnabled = false;
                    Cell5.IsEnabled = false;
                    break;
                case 1:
                    if (result[0].ToString() == Cell6.Text)
                    {
                        Cell6.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell6.Text))
                    {
                        Cell6.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell6.Background = Brushes.Gray;
                    }

                    if (result[1].ToString() == Cell7.Text)
                    {
                        Cell7.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell7.Text))
                    {
                        Cell7.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell7.Background = Brushes.Gray;
                    }

                    if (result[2].ToString() == Cell8.Text)
                    {
                        Cell8.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell8.Text))
                    {
                        Cell8.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell8.Background = Brushes.Gray;
                    }

                    if (result[3].ToString() == Cell9.Text)
                    {
                        Cell9.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell9.Text))
                    {
                        Cell9.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell9.Background = Brushes.Gray;
                    }

                    if (result[4].ToString() == Cell10.Text)
                    {
                        Cell10.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell10.Text))
                    {
                        Cell10.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell10.Background = Brushes.Gray;
                    }

                    Cell6.IsEnabled = false;
                    Cell7.IsEnabled = false;
                    Cell8.IsEnabled = false;
                    Cell9.IsEnabled = false;
                    Cell10.IsEnabled = false;
                    break;
                case 2:
                    if (result[0].ToString() == Cell11.Text)
                    {
                        Cell11.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell11.Text))
                    {
                        Cell11.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell11.Background = Brushes.Gray;
                    }

                    if (result[1].ToString() == Cell12.Text)
                    {
                        Cell12.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell12.Text))
                    {
                        Cell12.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell12.Background = Brushes.Gray;
                    }

                    if (result[2].ToString() == Cell13.Text)
                    {
                        Cell13.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell13.Text))
                    {
                        Cell13.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell13.Background = Brushes.Gray;
                    }

                    if (result[3].ToString() == Cell14.Text)
                    {
                        Cell14.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell14.Text))
                    {
                        Cell14.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell14.Background = Brushes.Gray;
                    }

                    if (result[4].ToString() == Cell15.Text)
                    {
                        Cell15.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell15.Text))
                    {
                        Cell15.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell15.Background = Brushes.Gray;
                    }

                    Cell11.IsEnabled = false;
                    Cell12.IsEnabled = false;
                    Cell13.IsEnabled = false;
                    Cell14.IsEnabled = false;
                    Cell15.IsEnabled = false;
                    break;
                case 3:
                    if (result[0].ToString() == Cell16.Text)
                    {
                        Cell16.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell16.Text))
                    {
                        Cell16.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell16.Background = Brushes.Gray;
                    }

                    if (result[1].ToString() == Cell17.Text)
                    {
                        Cell17.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell17.Text))
                    {
                        Cell17.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell17.Background = Brushes.Gray;
                    }

                    if (result[2].ToString() == Cell18.Text)
                    {
                        Cell18.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell18.Text))
                    {
                        Cell18.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell18.Background = Brushes.Gray;
                    }
                    if (result[3].ToString() == Cell19.Text)
                    {
                        Cell19.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell19.Text))
                    {
                        Cell19.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell19.Background = Brushes.Gray;
                    }

                    if (result[4].ToString() == Cell20.Text)
                    {
                        Cell20.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell20.Text))
                    {
                        Cell20.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell20.Background = Brushes.Gray;
                    }

                    Cell16.IsEnabled = false;
                    Cell17.IsEnabled = false;
                    Cell18.IsEnabled = false;
                    Cell19.IsEnabled = false;
                    Cell20.IsEnabled = false;
                    break;
                case 4:
                    if (result[0].ToString() == Cell21.Text)
                    {
                        Cell21.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell21.Text))
                    {
                        Cell21.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell21.Background = Brushes.Gray;
                    }

                    if (result[1].ToString() == Cell22.Text)
                    {
                        Cell22.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell22.Text))
                    {
                        Cell22.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell22.Background = Brushes.Gray;
                    }

                    if (result[2].ToString() == Cell23.Text)
                    {
                        Cell23.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell23.Text))
                    {
                        Cell23.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell23.Background = Brushes.Gray;
                    }

                    if (result[3].ToString() == Cell24.Text)
                    {
                        Cell24.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell24.Text))
                    {
                        Cell24.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell24.Background = Brushes.Gray;
                    }
                    if (result[4].ToString() == Cell25.Text)
                    {
                        Cell25.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell25.Text))
                    {
                        Cell25.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell25.Background = Brushes.Gray;
                    }
                    Cell21.IsEnabled = false;
                    Cell22.IsEnabled = false;
                    Cell23.IsEnabled = false;
                    Cell24.IsEnabled = false;
                    Cell25.IsEnabled = false;
                    break;
                case 5:
                    if (result[0].ToString() == Cell26.Text)
                    {
                        Cell26.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell26.Text))
                    {
                        Cell26.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell26.Background = Brushes.Gray;
                    }

                    if (result[1].ToString() == Cell27.Text)
                    {
                        Cell27.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell27.Text))
                    {
                        Cell27.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell27.Background = Brushes.Gray;
                    }

                    if (result[2].ToString() == Cell28.Text)
                    {
                        Cell28.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell28.Text))
                    {
                        Cell28.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell28.Background = Brushes.Gray;
                    }

                    if (result[3].ToString() == Cell29.Text)
                    {
                        Cell29.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell29.Text))
                    {
                        Cell29.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell29.Background = Brushes.Gray;
                    }

                    if (result[4].ToString() == Cell30.Text)
                    {
                        Cell30.Background = Brushes.Green;
                    }
                    else if (result.Contains(Cell30.Text))
                    {
                        Cell30.Background = Brushes.Yellow;
                    }
                    else
                    {
                        Cell30.Background = Brushes.Gray;
                    }
                    Cell26.IsEnabled = false;
                    Cell27.IsEnabled = false;
                    Cell28.IsEnabled = false;
                    Cell29.IsEnabled = false;
                    Cell30.IsEnabled = false;
                    break;
                default:
                    break;
            }
            if(number == 5 && check != result)
            {
                MessageBox.Show("End!\n You LOSER!!!");
            }else if(number == 5 && check == result)
            {
                MessageBox.Show("End!\n You Win!!!");

            }else if(check == result)
            {
                MessageBox.Show("You Win!!!");
                Cell1.IsEnabled = false;
                Cell2.IsEnabled = false;
                Cell3.IsEnabled = false;
                Cell4.IsEnabled = false;
                Cell5.IsEnabled = false;
                Cell6.IsEnabled = false;
                Cell7.IsEnabled = false;
                Cell8.IsEnabled = false;
                Cell9.IsEnabled = false;
                Cell10.IsEnabled = false;
                Cell11.IsEnabled = false;
                Cell12.IsEnabled = false;
                Cell13.IsEnabled = false;
                Cell14.IsEnabled = false;
                Cell15.IsEnabled = false;
                Cell16.IsEnabled = false;
                Cell17.IsEnabled = false;
                Cell18.IsEnabled = false;
                Cell19.IsEnabled = false;
                Cell20.IsEnabled = false;
                Cell21.IsEnabled = false;
                Cell22.IsEnabled = false;
                Cell23.IsEnabled = false;
                Cell24.IsEnabled = false;
                Cell25.IsEnabled = false;
                Cell26.IsEnabled = false;
                Cell27.IsEnabled = false;
                Cell28.IsEnabled = false;
                Cell29.IsEnabled = false;
                Cell30.IsEnabled = false;
            }
        }
        static string GetText(string a1, string a2, string a3, string a4, string a5)
        {
            string text = "";
            text += a1 + a2 + a3 + a4 + a5;
            return text;
        }
        private void Cell1_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell1.Text.Length == Cell1.MaxLength)
            {
                Cell2.Focus();
            }
        }

        private void Cell2_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell2.Text.Length == Cell2.MaxLength)
            {
                Cell3.Focus();
            }
        }

        private void Cell3_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell3.Text.Length == Cell3.MaxLength)
            {
                Cell4.Focus();
            }
        }

        private void Cell4_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell4.Text.Length == Cell4.MaxLength)
            {
                Cell5.Focus();
            }
        }

        private void Cell6_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell6.Text.Length == Cell6.MaxLength)
            {
                Cell7.Focus();
            }
        }

        private void Cell7_KeyUp(object sender, KeyEventArgs e)
        {
             if (Cell7.Text.Length == Cell7.MaxLength)
            {
                Cell8.Focus();
            }
        }

        private void Cell8_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell8.Text.Length == Cell8.MaxLength)
            {
                Cell9.Focus();
            }
        }

        private void Cell9_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell9.Text.Length == Cell9.MaxLength)
            {
                Cell10.Focus();
            }
        }

        private void Cell11_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell11.Text.Length == Cell11.MaxLength)
            {
                Cell12.Focus();
            }
        }

        private void Cell12_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell12.Text.Length == Cell12.MaxLength)
            {
                Cell13.Focus();
            }
        }

        private void Cell13_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell13.Text.Length == Cell13.MaxLength)
            {
                Cell14.Focus();
            }
        }

        private void Cell14_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell14.Text.Length == Cell14.MaxLength)
            {
                Cell15.Focus();
            }
        }

        private void Cell16_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell16.Text.Length == Cell16.MaxLength)
            {
                Cell17.Focus();
            }
        }

        private void Cell17_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell17.Text.Length == Cell17.MaxLength)
            {
                Cell18.Focus();
            }
        }

        private void Cell18_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell18.Text.Length == Cell18.MaxLength)
            {
                Cell19.Focus();
            }
        }

        private void Cell19_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell19.Text.Length == Cell19.MaxLength)
            {
                Cell20.Focus();
            }
        }

        private void Cell21_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell21.Text.Length == Cell21.MaxLength)
            {
                Cell22.Focus();
            }
        }

        private void Cell22_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell22.Text.Length == Cell22.MaxLength)
            {
                Cell23.Focus();
            }
        }

        private void Cell23_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell23.Text.Length == Cell23.MaxLength)
            {
                Cell24.Focus();
            }
        }

        private void Cell24_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell24.Text.Length == Cell24.MaxLength)
            {
                Cell25.Focus();
            }
        }

        private void Cell26_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell26.Text.Length == Cell26.MaxLength)
            {
                Cell27.Focus();
            }
        }

        private void Cell27_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell27.Text.Length == Cell27.MaxLength)
            {
                Cell28.Focus();
            }
        }

        private void Cell28_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell28.Text.Length == Cell28.MaxLength)
            {
                Cell29.Focus();
            }
        }

        private void Cell29_KeyUp(object sender, KeyEventArgs e)
        {
            if (Cell29.Text.Length == Cell29.MaxLength)
            {
                Cell30.Focus();
            }
        }

        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            switch (num)
            {
                
                case 0:
                    check = GetText(Cell1.Text,Cell2.Text,Cell3.Text, Cell4.Text, Cell5.Text);
                    if (dict_counts.ContainsValue(check) != true)
                    {
                        num -= 1;
                        MessageBox.Show("Not in word list");
                    }
                    break;
                case 1:
                    check = GetText(Cell6.Text, Cell7.Text, Cell8.Text, Cell9.Text, Cell10.Text);
                    if (dict_counts.ContainsValue(check) != true)
                    {
                        num -= 1;
                        MessageBox.Show("Not in word list");
                    }
                    break;
                case 2:
                    check = GetText(Cell11.Text, Cell12.Text, Cell13.Text, Cell14.Text, Cell15.Text);
                    if (dict_counts.ContainsValue(check) != true)
                    {
                        num -= 1;
                        MessageBox.Show("Not in word list");
                    }
                    break;
                case 3:
                    check = GetText(Cell16.Text, Cell17.Text, Cell18.Text, Cell19.Text, Cell20.Text);
                    if (dict_counts.ContainsValue(check) != true)
                    {
                        num -= 1;
                        MessageBox.Show("Not in word list");
                    }
                    break;
                case 4:
                    check = GetText(Cell21.Text, Cell22.Text, Cell23.Text, Cell24.Text, Cell25.Text);
                    if (dict_counts.ContainsValue(check) != true)
                    {
                        num -= 1;
                        MessageBox.Show("Not in word list");
                    }
                    break;
                case 5:
                    check = GetText(Cell26.Text, Cell27.Text, Cell28.Text, Cell29.Text, Cell30.Text);
                    if (dict_counts.ContainsValue(check) != true)
                    {
                        num -= 1;
                        MessageBox.Show("Not in word list");
                    }
                    break;
                default:
                    break;

            }
            MessageBox.Show(check);
            Check(num);
            num += 1;
            switch (num)
            {
                case 1:
                    Cell6.Focus();
                    break;
                case 2:
                    Cell11.Focus();
                    break;
                case 3:
                    Cell16.Focus();
                    break;
                case 4:
                    Cell21.Focus();
                    break;
                case 5:
                    Cell26.Focus();
                    break;
                default:
                    break;
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)

        {
            GetWord();
            num = 0;
            Cell1.Background = Brushes.White;
            Cell2.Background = Brushes.White;
            Cell3.Background = Brushes.White;
            Cell4.Background = Brushes.White;
            Cell5.Background = Brushes.White;
            Cell6.Background = Brushes.White;
            Cell7.Background = Brushes.White;
            Cell8.Background = Brushes.White;
            Cell9.Background = Brushes.White;
            Cell10.Background = Brushes.White;
            Cell11.Background = Brushes.White;
            Cell12.Background = Brushes.White;
            Cell13.Background = Brushes.White;
            Cell14.Background = Brushes.White;
            Cell15.Background = Brushes.White;
            Cell16.Background = Brushes.White;
            Cell17.Background = Brushes.White;
            Cell18.Background = Brushes.White;
            Cell19.Background = Brushes.White;
            Cell20.Background = Brushes.White;
            Cell21.Background = Brushes.White;
            Cell22.Background = Brushes.White;
            Cell23.Background = Brushes.White;
            Cell24.Background = Brushes.White;
            Cell25.Background = Brushes.White;
            Cell26.Background = Brushes.White;
            Cell27.Background = Brushes.White;
            Cell28.Background = Brushes.White;
            Cell29.Background = Brushes.White;
            Cell30.Background = Brushes.White;
            Cell1.Text = "";
            Cell2.Text = "";
            Cell3.Text = "";
            Cell4.Text = "";
            Cell5.Text = "";
            Cell6.Text = "";
            Cell7.Text = "";
            Cell8.Text = "";
            Cell9.Text = "";
            Cell10.Text = "";
            Cell11.Text = "";
            Cell12.Text = "";
            Cell13.Text = "";
            Cell14.Text = "";
            Cell15.Text = "";
            Cell16.Text = "";
            Cell17.Text = "";
            Cell18.Text = "";
            Cell19.Text = "";
            Cell20.Text = "";
            Cell21.Text = "";
            Cell22.Text = "";
            Cell23.Text = "";
            Cell24.Text = "";
            Cell25.Text = "";
            Cell26.Text = "";
            Cell27.Text = "";
            Cell28.Text = "";
            Cell29.Text = "";
            Cell30.Text = "";
            Cell1.IsEnabled = true;
            Cell2.IsEnabled = true;
            Cell3.IsEnabled = true;
            Cell4.IsEnabled = true;
            Cell5.IsEnabled = true;
            Cell6.IsEnabled = true;
            Cell7.IsEnabled = true;
            Cell8.IsEnabled = true;
            Cell9.IsEnabled = true;
            Cell10.IsEnabled = true;
            Cell11.IsEnabled = true;
            Cell12.IsEnabled = true;
            Cell13.IsEnabled = true;
            Cell14.IsEnabled = true;
            Cell15.IsEnabled = true;
            Cell16.IsEnabled = true;
            Cell17.IsEnabled = true;
            Cell18.IsEnabled = true;
            Cell19.IsEnabled = true;
            Cell20.IsEnabled = true;
            Cell21.IsEnabled = true;
            Cell22.IsEnabled = true;
            Cell23.IsEnabled = true;
            Cell24.IsEnabled = true;
            Cell25.IsEnabled = true;
            Cell26.IsEnabled = true;
            Cell27.IsEnabled = true;
            Cell28.IsEnabled = true;
            Cell29.IsEnabled = true;
            Cell30.IsEnabled = true;


        }

        private void remove_word_Click(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = " ";
        }

        private void show_word_Click(object sender, RoutedEventArgs e)
        {
            TextBlock1.Text = result;
        }
    }
}
