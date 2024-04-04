using GourmetGame.Controllers;
using GourmetGame.Domain.Enums;

namespace GourmetGame.Forms;

public partial class ConfirmDenayForm : Form
{
    public ConfirmDenayForm()
    {
        InitializeComponent();
        AutoSize = true;
    }

    private bool IsFoodAttempt { get; set; } = false;

    private void ConfirmDenayForm_Load(object sender, EventArgs e)
    {
        var currentNode = GourmetGameController.Handler.GetCurrentNode();

        // Check if the current node is a food
        IsFoodAttempt = currentNode.IsFood;

        Question.Text = $"O prato que você pensou é {currentNode.Name}?";

        Question.TextAlign = ContentAlignment.MiddleCenter;
    }

    private void ButtonNoClick(object sender, EventArgs e)
    {
        Form nextForm;

        // If tried to attempt a food and failed
        if (IsFoodAttempt)
        {
            nextForm = new GiveUpForm();
        }
        else // Navigate to the next
        {
            GourmetGameController.Handler.HandleNavigation(NavigationCase.No);

            nextForm = new ConfirmDenayForm();
        }

        Hide();

        nextForm.ShowDialog();

        Close();
    }

    private void ButtonYesClick(object sender, EventArgs e)
    {
        Form nextForm;
        // If tried to attempt a food and failed
        if (IsFoodAttempt)
        {
            nextForm = new WinForm();
        }
        else // Navigate to the next
        {
            GourmetGameController.Handler.HandleNavigation(NavigationCase.Yes);

            nextForm = new ConfirmDenayForm();
        }

        Hide();

        nextForm.ShowDialog();
        
        Close();
    }
}
