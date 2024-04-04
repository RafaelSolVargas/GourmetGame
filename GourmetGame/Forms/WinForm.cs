using GourmetGame.Controllers;

namespace GourmetGame.Forms;

public partial class WinForm : Form
{
    public WinForm()
    {
        InitializeComponent();

        FormBorderStyle = FormBorderStyle.FixedSingle;
        ControlBox = true;
        MinimizeBox = false;
        MaximizeBox = false;
        ShowIcon = false;

        FormClosing += Event_FormClosing;
    }

    private void Event_FormClosing(object? sender, FormClosingEventArgs e)
    {
        ProcessInput();
    }


    private void CloseWinButton_Click(object sender, EventArgs e)
    {
        ProcessInput();

        Close();
    }

    private void ProcessInput()
    {
        GourmetGameController.Handler.RestartNavigation();
    }

    private void WinForm_Load(object sender, EventArgs e) { }
}
