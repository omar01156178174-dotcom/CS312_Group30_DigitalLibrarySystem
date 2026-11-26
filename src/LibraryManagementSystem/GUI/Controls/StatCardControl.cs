using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.Controls;

public class StatCardControl : UserControl
{
    private string _title = "STAT TITLE";
    private string _value = "0";
    private string _subtitle = "";
    private Color _accentColor = Color.FromArgb(99, 102, 241);

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Title
    {
        get => _title;
        set { _title = value; Invalidate(); }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Value
    {
        get => _value;
        set { _value = value; Invalidate(); }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Subtitle
    {
        get => _subtitle;
        set { _subtitle = value; Invalidate(); }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color AccentColor
    {
        get => _accentColor;
        set { _accentColor = value; Invalidate(); }
    }

    public StatCardControl()
    {
        DoubleBuffered = true;
        Size = new Size(210, 118);
        MinimumSize = new Size(150, 108);
        BackColor = Color.White;
        Margin = new Padding(8);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        // Card Border and Background
        var rect = new Rectangle(0, 0, Width - 1, Height - 1);
        using (var borderPen = new Pen(Color.FromArgb(226, 232, 240), 1f))
        {
            g.DrawRectangle(borderPen, rect);
        }

        // Left accent bar
        using (var accentBrush = new SolidBrush(_accentColor))
        {
            g.FillRectangle(accentBrush, 0, 0, 5, Height);
        }

        float contentX = 18f;
        float maxContentW = Math.Max(50f, Width - contentX - 12f);

        using var sf = new StringFormat
        {
            Trimming = StringTrimming.EllipsisCharacter,
            FormatFlags = StringFormatFlags.NoWrap
        };

        // 1. Title (Uppercase, crisp slate color, 9.0pt Bold)
        float titleY = 12f;
        using var titleFont = new Font("Segoe UI", 9.0f, FontStyle.Bold);
        using var titleBrush = new SolidBrush(Color.FromArgb(71, 85, 105));
        var titleSize = g.MeasureString(_title.ToUpper(), titleFont, (int)maxContentW, sf);
        g.DrawString(_title.ToUpper(), titleFont, titleBrush, new RectangleF(contentX, titleY, maxContentW, titleSize.Height), sf);

        // 2. Metric Value (Deep dark, high visibility, 19pt or 16pt Bold)
        float valY = Math.Max(35f, Height * 0.30f);
        float valFontSize = _value.Length > 8 ? 16f : 19f;
        using var valFont = new Font("Segoe UI", valFontSize, FontStyle.Bold);
        using var valBrush = new SolidBrush(Color.FromArgb(15, 23, 42));
        var valSize = g.MeasureString(_value, valFont, (int)maxContentW, sf);
        g.DrawString(_value, valFont, valBrush, new RectangleF(contentX, valY, maxContentW, valSize.Height), sf);

        // 3. Subtitle / Description (Comfortable 9.0pt, high contrast slate, plenty of room from bottom)
        if (!string.IsNullOrEmpty(_subtitle))
        {
            float subY = Math.Min(Height - 30f, Math.Max(80f, Height * 0.68f));
            using var subFont = new Font("Segoe UI", 9.0f, FontStyle.Regular);
            using var subBrush = new SolidBrush(Color.FromArgb(100, 116, 139));
            g.DrawString(_subtitle, subFont, subBrush, new RectangleF(contentX, subY, maxContentW, 22f), sf);
        }
    }
}
