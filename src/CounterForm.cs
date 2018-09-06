using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;

namespace AlwaysOnTopTest {
    public partial class CounterForm : Form {

        public class Information {
            public int mapCounter = 0;
            public int doctorCounter = 0;
        }

        private Information info;

        #region Rounded Borders Window

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        #endregion

        #region Overlay Window

        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private const string SAVE_PATH = "data.xml";

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        #endregion

        #region Draggable Window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        #endregion

        public CounterForm() {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
        }

        private void CounterForm_Load(object sender, EventArgs e) {
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            info = new Information();
            if (File.Exists(SAVE_PATH)) {
                info = (Information)LoadData(SAVE_PATH);
                counter1Label.Text = info.mapCounter.ToString();
                counter2Label.Text = info.doctorCounter.ToString();
            }
        }

        private void CounterForm_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #region UI FUNCTIONS

        private void bcMapButton_Click(object sender, EventArgs e) {
            info.mapCounter++;
            counter1Label.Text = info.mapCounter.ToString();
            SaveData(info, SAVE_PATH);
        }

        private void reset1Button_Click(object sender, EventArgs e) {
            info.mapCounter = 0;
            counter1Label.Text = info.mapCounter.ToString();
            SaveData(info, SAVE_PATH);
        }

        private void doctorCardButton_Click(object sender, EventArgs e) {
            info.doctorCounter++;
            counter2Label.Text = info.doctorCounter.ToString();
            SaveData(info, SAVE_PATH);
        }

        private void reset2Button_Click_1(object sender, EventArgs e) {
            info.doctorCounter = 0;
            counter2Label.Text = info.doctorCounter.ToString();
            SaveData(info, SAVE_PATH);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        #endregion

        #region SERIALIZATION FUNCTIONS

        private void SaveData(object obj, string fileName) {
            XmlSerializer sr = new XmlSerializer(obj.GetType());
            TextWriter writer = new StreamWriter(fileName);
            sr.Serialize(writer, obj);
            writer.Close();
        }

        private object LoadData(string fileName) {
            XmlSerializer xs = new XmlSerializer(typeof(Information));
            FileStream read = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            object result = xs.Deserialize(read);
            read.Close();
            return result;
        }

        #endregion

  
    }
}
