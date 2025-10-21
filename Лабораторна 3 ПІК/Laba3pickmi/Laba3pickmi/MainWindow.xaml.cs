using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba3pickmi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ListItem> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Items = new ObservableCollection<ListItem>
            {
                new ListItem { Name = "Файл", Icon = "image/file.png" },
                new ListItem { Name = "Папка", Icon = "image/folder.png" },
                new ListItem { Name = "Налаштування", Icon = "image/settings.png" },
                new ListItem { Name = "Календар", Icon = "image/calendar.png" },
                new ListItem { Name = "Пошта", Icon = "image/mail.png" },
                new ListItem { Name = "Контакти", Icon = "image/contacts.png" },
                new ListItem { Name = "Завдання", Icon = "image/tasks.png" },
                new ListItem { Name = "Фото", Icon = "image/photo.png" },
                new ListItem { Name = "Музика", Icon = "image/music.png" },
                new ListItem { Name = "Відео", Icon = "image/video.png" },
                new ListItem { Name = "Документ", Icon = "image/document.png" },
                new ListItem { Name = "Завантаження", Icon = "image/downloads.png" },
                new ListItem { Name = "Хмара", Icon = "image/cloud.png" },
                new ListItem { Name = "Браузер", Icon = "image/browser.png" },
                new ListItem { Name = "Безпека", Icon = "image/security.png" }
            };

            DataContext = this;
        }

        public class ListItem
        {
            public string Name { get; set; }
            public string Icon { get; set; }
        }
    }
}