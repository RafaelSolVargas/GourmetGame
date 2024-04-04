using GourmetGame.Controllers;
using GourmetGame.Helpers;

namespace GourmetGame.Forms
{
    public partial class CompleteForm : Form
    {
        private string NewFood { get; set; }
        private string FailedFood { get; set; }
        private bool HasProceed { get; set; } = false;
        public CompleteForm(string newFood, string failedFood)
        {
            InitializeComponent();

            NewFood = newFood;
            FailedFood = failedFood;
            completeQuestion.Text = $"{newFood} é ___________ mas {FailedFood} não.";

            FormBorderStyle = FormBorderStyle.FixedSingle;
            ControlBox = true;
            MinimizeBox = false;
            MaximizeBox = false;
            ShowIcon = false;

            FormsResizeHelper.CenterControlHorizontal(this, completeQuestion);
            FormsResizeHelper.CenterControlHorizontal(this, newQualityInput);
            FormsResizeHelper.CenterControlsHorizontally(this, confirmCompleteButton, cancelCompleteButton);

            FormClosing += Event_FormClosing;
        }

        private void ConfirmClick(object sender, EventArgs e)
        {
            var newQualityName = newQualityInput.Text;

            if (newQualityName == string.Empty)
            {
                newQualityName = "null";
            }

            ProcessInput(newQualityName);

            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ProcessInput("null");

            Close();
        }

        private void Event_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (HasProceed)
            {
                return;
            }

            ProcessInput("null");
        }

        private void ProcessInput(string newQualityName)
        {
            HasProceed = true;

            GourmetGameController.Handler.InsertNewFood(newQualityName, NewFood);
        }

        private void CompleteForm_Load(object sender, EventArgs e)
        {
        }
    }
}
