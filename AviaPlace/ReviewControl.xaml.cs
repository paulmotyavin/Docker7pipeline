using System;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace AviaPlace
{
    public partial class ReviewControl : UserControl
    {
        public int id { get; set; }
        public string avatar { get; set; }
        public string username { get; set; }
        public int rating { get; set; }
        public ReviewControl(AviaPlaceDataSet.ReviewsRow review, AviaPlaceDataSet.UsersRow user)
        {
            InitializeComponent();
            id = review.id;
            AvatarImg.Source = new BitmapImage(new Uri(user.avatar));
            UsernameTbk.Text = $"{user.surname} {user.name}";
            RatingTbk.Text = review.rating.ToString();
            TextTbk.Text = review.text;
            TimeTbk.Text = review.date.ToString("HH:mm, dd MMMM yyyy", new System.Globalization.CultureInfo("ru-RU"));
        }
    }
}
