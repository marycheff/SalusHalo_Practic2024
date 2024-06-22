using System.Drawing;
using System.Windows.Forms;

public class BorderedPanel : Panel
{
    private readonly Color borderColor = Color.FromArgb(6, 123, 196);
    private readonly int borderWidth = 3;

    public BorderedPanel()
    {
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        using (Pen pen = new Pen(borderColor, borderWidth))
        {
            e.Graphics.DrawRectangle(pen, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }
    }
}
