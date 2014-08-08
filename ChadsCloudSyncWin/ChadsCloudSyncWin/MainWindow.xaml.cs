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

namespace ChadsCloudSyncWin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            using (var sqlConn = new System.Data.SQLite.SQLiteConnection(@"Data Source=G:\workspaces_git\ChadsCloudSyncWin\sync.db;Version=3;"))
            {
                sqlConn.Open();

                var setups = Dapper.SqlMapper.Query<SyncSetup>(sqlConn, "select * from SyncSetups");

                Console.WriteLine("count = " + setups.Count());
            }
        }


    }
}
