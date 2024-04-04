using GourmetGame.Controllers;
using GourmetGame.Domain.Enums;
using GourmetGame.Helpers;

namespace GourmetGame.Forms;

public partial class ConfirmDenayForm : Form
{
    public ConfirmDenayForm()
    {
        InitializeComponent();
        AutoSize = true;
        Resize += ConfirmDenayForm_Resize;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        ControlBox = true;
        MinimizeBox = false;
        MaximizeBox = false;
        ShowIcon = false;

        FormClosing += Event_FormClosing;
    }

    private bool IsFoodAttempt { get; set; } = false;
    private bool HasProcessedAlready { get; set; } = false;

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
        ProcessToNoOption();

        Close();
    }

    private void Event_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (HasProcessedAlready)
        {
            return;
        }

        ProcessToNoOption();
    }

    private void ProcessToNoOption()
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

        HasProcessedAlready = true;

        nextForm.ShowDialog();
    }

    private void ButtonYesClick(object sender, EventArgs e)
    {
        ProcessToYesOption();

        Close();
    }

    private void ProcessToYesOption()
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

        HasProcessedAlready = true;

        nextForm.ShowDialog();
    }

    private void ConfirmDenayForm_Resize(object? sender, EventArgs e)
    {
        FormsResizeHelper.CenterControlHorizontal(this, Question, 30);
        FormsResizeHelper.CenterControlsHorizontally(this, confirmYes, confirmNo);
    }
}
