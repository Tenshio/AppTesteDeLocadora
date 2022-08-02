namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string holdName;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, EventArgs e)
        {
            holdName = textBox1.Text;
            var ab = new Album();
            ab.Name = holdName;
            //ListAlbum.AddAlbum(ab);
            ab.AddAlbum();
        }
    }
}