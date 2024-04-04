using GourmetGame.Controllers;

namespace GourmetGame.Forms
{
    public partial class CompleteForm : Form
    {
        private string NewFood { get; set; }
        private string FailedFood { get; set; }

        public CompleteForm(string newFood, string failedFood)
        {
            InitializeComponent();

            NewFood = newFood;
            FailedFood = failedFood;
            completeQuestion.Text = $"{newFood} é ______ mas {FailedFood} não.";
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            ProceedAnyway();
        }

        private void CompleteForm_Load(object sender, EventArgs e)
        {
        }

        private void ProceedAnyway()
        {
            var newQualityName = newQualityInput.Text;

            GourmetGameController.Handler.InsertNewFood(newQualityName, NewFood);

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ProceedAnyway();
        }
    }
}
