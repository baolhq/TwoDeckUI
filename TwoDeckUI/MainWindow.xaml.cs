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

namespace TwoDeckUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CardList leftCards;
        private CardList rightCards;

        public MainWindow()
        {
            InitializeComponent();

            leftCards = new CardList();
            rightCards = new CardList();
            SetUpDeck();
        }

        /// <summary>
        /// Initialize left deck items
        /// </summary>
        private void SetUpDeck()
        {
            leftCards.CreateNewDeck();

            leftDeck.ItemsSource = leftCards.Cards;
            rightDeck.ItemsSource = rightCards.Cards;
        }

        private void leftDeck_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Card card = listBox.SelectedItem as Card;

            // Add card to right deck
            rightCards.Cards.Add(card);

            // Remove card from left deck
            leftCards.Remove(card);

            leftDeck.Items.Refresh();
            rightDeck.Items.Refresh();
        }

        private void rightDeck_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            Card card = listBox.SelectedItem as Card;

            // Add card to left deck
            leftCards.Cards.Add(card);

            // Remove card from right deck
            rightCards.Remove(card);
            
            leftDeck.Items.Refresh();
            rightDeck.Items.Refresh();
        }

        private void shuffleBtn_Click(object sender, RoutedEventArgs e)
        {
            RandomCardComparer comparer = new RandomCardComparer();
            leftCards.Cards.Sort(comparer);
            leftDeck.Items.Refresh();
        }

        private void sortBtn_Click(object sender, RoutedEventArgs e)
        {
            leftCards.Cards.Sort();
            leftDeck.Items.Refresh();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            rightCards.Cards.Clear();
            rightDeck.Items.Refresh();
        }

        private void resetBtn_Click(object sender, RoutedEventArgs e)
        {
            rightCards.Cards.Clear();
            rightDeck.Items.Refresh();

            leftCards.Cards.Clear();
            leftCards.CreateNewDeck();
            leftDeck.Items.Refresh();
        }
    }
}
