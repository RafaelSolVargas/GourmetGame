using GourmetGame.Controllers;

namespace GourmetGame.Forms;

public partial class GiveUpForm : Form
{
    public GiveUpForm()
    {
        InitializeComponent();
    }

    public void GiveUpForm_Load(object sender, EventArgs e)
    {
    }

    public void CancelNewFoodButton_Click(object sender, EventArgs e)
    {
        ProceedAnyway("null");
    }

    public void ConfirmNewFoodButton_Click(object sender, EventArgs e)
    {
        var newFood = actualFoodInputText.Text;

        ProceedAnyway(newFood);
    }

    private void ProceedAnyway(string newFood)
    {
        var failedFood = GourmetGameController.Handler.GetCurrentNode().Name;

        var nextForm = new CompleteForm(newFood, failedFood);

        Hide();

        nextForm.ShowDialog();

        Close();
    }
}
