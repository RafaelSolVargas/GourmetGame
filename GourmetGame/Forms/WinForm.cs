using GourmetGame.Controllers;

namespace GourmetGame.Forms;

public partial class WinForm : Form
{
    public WinForm()
    {
        InitializeComponent();
    }

    private void CloseWinButton_Click(object sender, EventArgs e)
    {
        GourmetGameController.Handler.RestartNavigation();

        Close();
    }
}
