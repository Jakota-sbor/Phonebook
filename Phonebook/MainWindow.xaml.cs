using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
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

namespace Phonebook
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SearchPersonResult searchQuery = new SearchPersonResult();

        public SearchPersonResult SearchQuery
        {
            get
            {
                return searchQuery;
            }

            set
            {
                searchQuery = value;
            }
        }

        public bool EditMode
        {
            get
            {
                return editMode;
            }

            set
            {
                editMode = value;
            }
        }

        bool editMode = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            using (PhoneBookDataContext db = new PhoneBookDataContext())
            {
                if (!EditMode)
                {
                    try
                    {
                        var result = db.SearchPerson(SearchQuery.LastName, SearchQuery.FirstName, SearchQuery.MiddleName, SearchQuery.City, SearchQuery.Street, SearchQuery.House, SearchQuery.Flat, !string.IsNullOrEmpty(SearchQuery.Phonenumber) ? System.Text.RegularExpressions.Regex.Replace(SearchQuery.Phonenumber, @"[^0-9.]", "") : SearchQuery.Phonenumber);
                        personGrid.ItemsSource = result.ToList();
                        result_Text.Text = personGrid.Items.Count == 0 ? string.Format("Ничего не найдено") : string.Format("Найдено {0} человек", personGrid.Items.Count);
                    }
                    catch (Exception exc)
                    {
                        Trace.WriteLine(exc.ToString());
                        result_Text.Text = "Произошла ошибка при поиске";
                    }
                }
                else
                {
                    try
                    {
                        db.InsertPerson(SearchQuery.LastName, SearchQuery.FirstName, SearchQuery.MiddleName, SearchQuery.BornDate, SearchQuery.City, SearchQuery.Street, SearchQuery.House, SearchQuery.Flat, System.Text.RegularExpressions.Regex.Replace(SearchQuery.Phonenumber, @"[^0-9.]", ""));
                        result_Text.Text = string.Format("{0} {1} {2} был добавлен в базу", SearchQuery.LastName, SearchQuery.FirstName, SearchQuery.MiddleName);

                        SearchQuery.MiddleName = null;
                        SearchQuery.FirstName = null;
                        SearchQuery.City = null;
                        SearchQuery.Street = null;
                        SearchQuery.House = null;
                        SearchQuery.Flat = null;
                        SearchQuery.Phonenumber = null;
                        textbox_BirthDate.Text = null;

                        textbox_Phonenumber.Focus();
                    }
                    catch
                    {
                        result_Text.Text = "Не удалось добавить в базу, проверьте поля";
                    }
                }
            }
        }
    }

    public class NullableConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? string.Empty : String.Format(culture, "{0}", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return string.IsNullOrEmpty(String.Format(culture, "{0}", value)) ? null : value;
        }
    }

    public class DateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var nullable = (Nullable<DateTime>)value;
            if (nullable.HasValue && nullable.Value > DateTime.MinValue)
                return nullable.Value.ToShortDateString();
            return String.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string strValue = value.ToString();
            DateTime resultDateTime;
            return DateTime.TryParse(strValue, out resultDateTime) ? resultDateTime : value;
        }
    }
}
