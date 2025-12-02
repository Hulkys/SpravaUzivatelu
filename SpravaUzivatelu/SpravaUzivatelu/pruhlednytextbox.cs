using System;
using System.Drawing;
using System.Windows.Forms;

public class PrůhlednýTextBox : TextBox
{
    public PrůhlednýTextBox()
    {
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
        BorderStyle = BorderStyle.None;
    }

    protected override void OnPaintBackground(PaintEventArgs pevent)
    {
        // Nic – tím se zajistí průhlednost
    }
}