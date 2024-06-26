﻿using GourmetGame.Controllers;
using GourmetGame.Helpers;

namespace GourmetGame.Forms;

public partial class GiveUpForm : Form
{
    private bool HasProcessedAlready { get; set; } = false;

    public GiveUpForm()
    {
        InitializeComponent();
        FormBorderStyle = FormBorderStyle.FixedSingle;
        ControlBox = true;
        MinimizeBox = false;
        MaximizeBox = false;
        ShowIcon = false;

        FormsResizeHelper.CenterControlHorizontal(this, actualFoodInputText);
        FormsResizeHelper.CenterControlsHorizontally(this, confirmNewFoodButton, cancelNewFoodButton);

        FormClosing += Event_FormClosing;
    }

    public void GiveUpForm_Load(object sender, EventArgs e)
    {
    }

    public void CancelNewFoodButton_Click(object sender, EventArgs e)
    {
        Hide();

        ProcessInput("null");

        Close();
    }

    public void ConfirmNewFoodButton_Click(object sender, EventArgs e)
    {
        var newFood = actualFoodInputText.Text;

        if (newFood == string.Empty)
        {
            newFood = "null";
        }

        Hide();

        ProcessInput(newFood);

        Close();
    }

    private void Event_FormClosing(object? sender, FormClosingEventArgs e)
    {
        if (HasProcessedAlready)
        {
            return;
        }

        ProcessInput("null");
    }

    private void ProcessInput(string newFood)
    {
        HasProcessedAlready = true;

        var failedFood = GourmetGameController.Handler.GetCurrentNode().Name;

        var nextForm = new CompleteForm(newFood, failedFood);

        nextForm.ShowDialog();
    }
}
