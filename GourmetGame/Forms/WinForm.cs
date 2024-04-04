using GourmetGame.Controllers;

namespace GourmetGame.Forms;

public partial class WinForm : Form
{
    private bool HasProcessed { get; set; } = false;
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
        if (HasProcessed)
        {
            return;
        }

        Hide();

        ProcessInput();
    }


    private void CloseWinButton_Click(object sender, EventArgs e)
    {
        ProcessInput();

        Close();
    }

    private void ProcessInput()
    {
        HasProcessed = true;

        GourmetGameController.Handler.RestartNavigation();
    }

    private void WinForm_Load(object sender, EventArgs e) { }
}
