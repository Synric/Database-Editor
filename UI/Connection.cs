using System;
using System.Windows.Forms;

namespace DatabaseEditor
{
    public partial class Connection : Form
    {
        Properties.Settings settings;

        public Connection()
        {
            InitializeComponent();

            settings = new Properties.Settings();
        }

        void Connection_Load(object sender, EventArgs e)
        {
            if (settings.IPAdress != null)
                IPBox.Text = settings.IPAdress;
            if (settings.User != null)
                UserBox.Text = settings.User;
            if (settings.Store_Pass && settings.Pass != null)
            {
                StorePassBox.Checked = true;
                PassBox.Text = settings.Pass;
            }
            if (settings.Port != 0)
                PortBox.Text = Convert.ToString(settings.Port);
            if (settings.Char_DB != null)
                CharBox.Text = settings.Char_DB;
            if (settings.World_DB != null)
                WorldBox.Text = settings.World_DB;
            if (settings.Auth_DB != null)
                AuthBox.Text = settings.Auth_DB;
        }

        void ConnectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(IPBox.Text))
                MessageBox.Show("IP Adress Text box is empty! Please enter IP Adress for connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (string.IsNullOrWhiteSpace(UserBox.Text))
                MessageBox.Show("User Text box is empty! Please enter User for connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (string.IsNullOrWhiteSpace(PassBox.Text))
                MessageBox.Show("Pass Text box is empty! Please enter Pass for connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (string.IsNullOrWhiteSpace(PortBox.Text))
                MessageBox.Show("Port Text box is empty! Please enter Port for connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (string.IsNullOrWhiteSpace(CharBox.Text))
                MessageBox.Show("CharDB Text box is empty! Please enter CharDB for connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (string.IsNullOrWhiteSpace(WorldBox.Text))
                MessageBox.Show("WorldDB Text box is empty! Please enter WorldDB for connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (string.IsNullOrWhiteSpace(AuthBox.Text))
                MessageBox.Show("AuthDB Text box is empty! Please enter AuthDB for connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            ////////// CONNECTING /////////////////
            try
            {
                WorldDatabase world = new WorldDatabase($"metadata=res://*/Database.csdl|res://*/Database.ssdl|res://*/Database.msl;provider=MySql.Data.MySqlClient;provider connection string=\";server={IPBox.Text};user id={UserBox.Text};password={PassBox.Text};database={WorldBox.Text};persistsecurityinfo=True\"");
                world.Database.Connection.Open();

                settings.IPAdress = IPBox.Text;
                settings.User = UserBox.Text;
                settings.Pass = PassBox.Text;
                settings.Port = Convert.ToInt32(PortBox.Text);
                settings.Char_DB = CharBox.Text;
                settings.World_DB = WorldBox.Text;
                settings.Auth_DB = AuthBox.Text;
                settings.Store_Pass = true;

                settings.Save();

                world.Database.Connection.Close();

                MessageBox.Show("You has been successfull logged!", "Connect successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();

                MainForm main = new MainForm();
                main.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open MySQL: " + ex.GetType().Name, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
