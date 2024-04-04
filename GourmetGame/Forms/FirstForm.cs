using GourmetGame.Controllers;
using GourmetGame.Forms;

namespace GourmetGame
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            GourmetGameController.Handler.RestartNavigation();

            var questionForm = new ConfirmDenayForm();

            questionForm.ShowDialog();
        }
    }
}
