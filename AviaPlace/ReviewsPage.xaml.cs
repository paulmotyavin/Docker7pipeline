using AviaPlace.AviaPlaceDataSetTableAdapters;
using AviaPlace.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AviaPlace
{
    /// <summary>
    /// Логика взаимодействия для ReviewsPage.xaml
    /// </summary>
    public partial class ReviewsPage : Page
    {
        ReviewsTableAdapter reviewsAdapter = new ReviewsTableAdapter();
        UsersTableAdapter usersAdapter = new UsersTableAdapter();
        public ReviewsPage()
        {
            InitializeComponent();
            LoadReviews();
            var parentWindow = Window.GetWindow(this);
        }

        private void ReviewsPage_Loaded(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this);
            if (parentWindow is ClientWindow)
            {
                DeleteBtn.Visibility = Visibility.Hidden;
                TitleTbk.Text = "Мои отзывы";
            }
        }

        private void LoadReviews()
        {
            var parentWindow = Window.GetWindow(this);
            IEnumerable<AviaPlaceDataSet.ReviewsRow> reviews;
            if (parentWindow is ClientWindow)
            {
                reviews = reviewsAdapter.GetData().Where(x => x.id_users == Convert.ToInt32(Settings.Default.userId));
            }
            else
            {
                reviews = reviewsAdapter.GetData();
            }
            var reviewsList = new List<ReviewControl>();
            foreach (var r in reviews)
            {
                var user = usersAdapter.GetData().FirstOrDefault(x => x.id == r.id_users);
                var reviewControl = new ReviewControl(r, user);
                reviewsList.Add(reviewControl);
            }
            ReviewsList.ItemsSource = reviewsList;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (ReviewsList.SelectedItem != null && ReviewsList.SelectedItem is ReviewControl review)
            {
                reviewsAdapter.DeleteQuery(review.id);
                App.WriteLog($"Удален {review.id} отзыв");
                LoadReviews();
            }
            else MessageBox.Show("Выберите отзыв для удаления");
        }

        private void ReviewsList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var parentWindow = Window.GetWindow(this);
            if (parentWindow is ClientWindow)
            {
                if (ReviewsList.SelectedItem is ReviewControl review)
                {
                    var airlineId = reviewsAdapter.GetData().FirstOrDefault(x => x.id == review.id).id_airlines;
                    ClientWindow.pageFrame.Content = new AirlineInfoPage(airlineId);
                }

            }
        }
    }
}
