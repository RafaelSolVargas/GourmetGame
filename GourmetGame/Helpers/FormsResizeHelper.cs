namespace GourmetGame.Helpers;

public static class FormsResizeHelper
{
    public static void CenterControlHorizontal(Control parent, Control control)
    {
        int xCenter = (parent.ClientSize.Width - control.Width) / 2;
        control.Location = new Point(xCenter, control.Location.Y);
    }

    public static void CenterControlsHorizontally(Control parent, params Control[] controls)
    {
        int totalWidth = 0;
        foreach (Control control in controls)
        {
            totalWidth += control.Width;
        }

        // Calcula a distância entre os controles
        int spacing = (parent.ClientSize.Width - totalWidth) / (controls.Length + 1);

        int x = spacing;
        foreach (Control control in controls)
        {
            control.Location = new Point(x, control.Location.Y);
            x += control.Width + spacing; // Incrementa x para o próximo controle
        }
    }
}
