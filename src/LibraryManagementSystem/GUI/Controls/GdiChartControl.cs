using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace LibraryManagementSystem.UI.Controls;

public enum ChartType
{
    Pie,
    Bar
}

public class ChartDataPoint
{
    public string Label { get; set; } = string.Empty;
    public double Value { get; set; }
    public Color Color { get; set; }

    public ChartDataPoint(string label, double value, Color color)
    {
        Label = label;
        Value = value;
        Color = color;
    }
}

public class GdiChartControl : UserControl
{
    private List<ChartDataPoint> _dataPoints = new();
    private ChartType _chartType = ChartType.Pie;
    private string _chartTitle = "Library Statistics";
    private int _hoveredIndex = -1;

    private static readonly Color[] ModernPalette = new[]
    {
        Color.FromArgb(99, 102, 241),   // Indigo
        Color.FromArgb(14, 165, 233),   // Sky Blue
        Color.FromArgb(16, 185, 129),   // Emerald Green
        Color.FromArgb(245, 158, 11),   // Amber
        Color.FromArgb(239, 68, 68),    // Red/Rose
        Color.FromArgb(168, 85, 247),   // Purple
        Color.FromArgb(20, 184, 166),   // Teal
        Color.FromArgb(236, 72, 153),   // Pink
        Color.FromArgb(100, 116, 139)   // Slate
    };

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public ChartType ChartType
    {
        get => _chartType;
        set { _chartType = value; Invalidate(); }
    }

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string ChartTitle
    {
        get => _chartTitle;
        set { _chartTitle = value; Invalidate(); }
    }

    public GdiChartControl()
    {
        DoubleBuffered = true;
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = Color.White;
        MouseMove += GdiChartControl_MouseMove;
        MouseLeave += (s, e) => { _hoveredIndex = -1; Invalidate(); };
    }

    public void SetData(Dictionary<string, int> data)
    {
        _dataPoints = data.Select((kvp, index) => new ChartDataPoint(
            kvp.Key,
            kvp.Value,
            ModernPalette[index % ModernPalette.Length]
        )).ToList();

        Invalidate();
    }

    public void SetData(IEnumerable<(string label, double value)> data)
    {
        _dataPoints = data.Select((item, index) => new ChartDataPoint(
            item.label,
            item.value,
            ModernPalette[index % ModernPalette.Length]
        )).ToList();

        Invalidate();
    }

    private void GdiChartControl_MouseMove(object? sender, MouseEventArgs e)
    {
        int prev = _hoveredIndex;
        if (prev != _hoveredIndex)
        {
            Invalidate();
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

        // Draw title
        using var titleFont = new Font("Segoe UI", 11, FontStyle.Bold);
        using var titleBrush = new SolidBrush(Color.FromArgb(30, 41, 59));
        g.DrawString(_chartTitle, titleFont, titleBrush, new PointF(15, 12));

        if (_dataPoints.Count == 0)
        {
            using var emptyFont = new Font("Segoe UI", 9, FontStyle.Italic);
            using var emptyBrush = new SolidBrush(Color.Gray);
            g.DrawString("No data available to display.", emptyFont, emptyBrush, new PointF(Width / 2 - 70, Height / 2 - 10));
            return;
        }

        if (_chartType == ChartType.Pie)
        {
            DrawDonutChart(g);
        }
        else
        {
            DrawBarChart(g);
        }
    }

    private void DrawDonutChart(Graphics g)
    {
        var total = _dataPoints.Sum(p => p.Value);
        if (total <= 0) return;

        int legendWidth = Math.Max(210, (int)(Width * 0.42));
        int chartAreaWidth = Math.Max(50, Width - legendWidth - 30);
        int chartAreaHeight = Height - 50;
        int diameter = Math.Min(chartAreaWidth, chartAreaHeight) - 30;
        if (diameter <= 20) return;

        int x = 20;
        int y = 45 + (chartAreaHeight - diameter) / 2;
        var pieRect = new Rectangle(x, y, diameter, diameter);

        float startAngle = -90f;
        for (int i = 0; i < _dataPoints.Count; i++)
        {
            var p = _dataPoints[i];
            float sweepAngle = (float)(p.Value / total * 360.0);
            if (sweepAngle <= 0) continue;

            using (var brush = new SolidBrush(p.Color))
            {
                g.FillPie(brush, pieRect, startAngle, sweepAngle);
            }

            // Outline
            using (var borderPen = new Pen(Color.White, 2f))
            {
                g.DrawPie(borderPen, pieRect, startAngle, sweepAngle);
            }

            startAngle += sweepAngle;
        }

        // Draw center hole for modern Donut style
        int holeDiameter = (int)(diameter * 0.55);
        int hx = x + (diameter - holeDiameter) / 2;
        int hy = y + (diameter - holeDiameter) / 2;
        using (var holeBrush = new SolidBrush(BackColor))
        {
            g.FillEllipse(holeBrush, hx, hy, holeDiameter, holeDiameter);
        }

        // Center text (Total count)
        using var centerFontBold = new Font("Segoe UI", 12, FontStyle.Bold);
        using var centerFontSmall = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        using var textBrush = new SolidBrush(Color.FromArgb(51, 65, 85));
        var totalStr = total.ToString("N0");
        var labelStr = "Total Items";

        var totalSize = g.MeasureString(totalStr, centerFontBold);
        var labelSize = g.MeasureString(labelStr, centerFontSmall);

        g.DrawString(totalStr, centerFontBold, textBrush, hx + (holeDiameter - totalSize.Width) / 2, hy + (holeDiameter / 2) - totalSize.Height + 2);
        using var centerLabelBrush = new SolidBrush(Color.Gray);
        g.DrawString(labelStr, centerFontSmall, centerLabelBrush, hx + (holeDiameter - labelSize.Width) / 2, hy + (holeDiameter / 2) + 2);

        // Draw Legend
        int legendX = x + diameter + 20;
        int legendY = 48;
        using var legendFont = new Font("Segoe UI", 9.0f, FontStyle.Regular);
        using var legendBrush = new SolidBrush(Color.FromArgb(51, 65, 85));

        for (int i = 0; i < _dataPoints.Count && legendY < Height - 18; i++)
        {
            var dp = _dataPoints[i];
            double pct = dp.Value / total * 100.0;

            // Color box
            using (var boxBrush = new SolidBrush(dp.Color))
            {
                g.FillRectangle(boxBrush, legendX, legendY + 2, 13, 13);
            }
            g.DrawRectangle(Pens.Gray, legendX, legendY + 2, 13, 13);

            // Label & percentage (bounded with ellipsis, no hardcoded truncation)
            string text = $"{dp.Label} ({dp.Value:N0} - {pct:F1}%)";
            float availTextW = Math.Max(60f, Width - (legendX + 22) - 8f);
            using var sfLegend = new StringFormat
            {
                Trimming = StringTrimming.EllipsisCharacter,
                FormatFlags = StringFormatFlags.NoWrap
            };
            g.DrawString(text, legendFont, legendBrush, new RectangleF(legendX + 20, legendY, availTextW, 20), sfLegend);

            legendY += 22;
        }
    }

    private void DrawBarChart(Graphics g)
    {
        var maxVal = _dataPoints.Max(p => p.Value);
        if (maxVal <= 0) maxVal = 1;

        int marginL = 45;
        int marginR = 25;
        int marginT = 50;
        int marginB = 45;

        int plotW = Width - marginL - marginR;
        int plotH = Height - marginT - marginB;
        if (plotW <= 20 || plotH <= 20) return;

        // Draw subtle grid lines
        using var gridPen = new Pen(Color.FromArgb(241, 245, 249), 1f) { DashStyle = DashStyle.Dash };
        using var axisFont = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        using var axisBrush = new SolidBrush(Color.Gray);

        for (int step = 0; step <= 4; step++)
        {
            double val = maxVal * step / 4.0;
            int y = marginT + plotH - (int)(step / 4.0 * plotH);

            g.DrawLine(gridPen, marginL, y, marginL + plotW, y);
            g.DrawString(val.ToString("0"), axisFont, axisBrush, new PointF(10, y - 6));
        }

        // Draw Baseline
        using var basePen = new Pen(Color.FromArgb(203, 213, 225), 1.5f);
        g.DrawLine(basePen, marginL, marginT + plotH, marginL + plotW, marginT + plotH);

        // Draw Bars
        int count = _dataPoints.Count;
        int barSlotWidth = plotW / Math.Max(1, count);
        int barWidth = Math.Max(8, (int)(barSlotWidth * 0.55));

        using var labelFont = new Font("Segoe UI", 8.5f, FontStyle.Regular);
        using var valFont = new Font("Segoe UI", 9f, FontStyle.Bold);
        using var textBrush = new SolidBrush(Color.FromArgb(71, 85, 105));

        for (int i = 0; i < count; i++)
        {
            var dp = _dataPoints[i];
            int barH = (int)(dp.Value / maxVal * plotH);
            int barX = marginL + (i * barSlotWidth) + (barSlotWidth - barWidth) / 2;
            int barY = marginT + plotH - barH;

            var barRect = new Rectangle(barX, barY, barWidth, barH);

            // Fill bar with gradient
            if (barH > 0)
            {
                using var barBrush = new LinearGradientBrush(
                    barRect,
                    dp.Color,
                    Color.FromArgb(Math.Min(255, dp.Color.R + 30), Math.Min(255, dp.Color.G + 30), Math.Min(255, dp.Color.B + 30)),
                    LinearGradientMode.Vertical);
                g.FillRectangle(barBrush, barRect);
                using var barOutline = new Pen(dp.Color, 1f);
                g.DrawRectangle(barOutline, barRect);
            }

            // Draw Value on top
            var valStr = dp.Value.ToString("0");
            var valSize = g.MeasureString(valStr, valFont);
            g.DrawString(valStr, valFont, textBrush, barX + (barWidth - valSize.Width) / 2, barY - valSize.Height - 2);

            // Draw X-axis label (centered in slot with ellipsis)
            string lbl = dp.Label;
            float lblBoxW = Math.Max(barSlotWidth, 30f);
            float lblBoxX = marginL + (i * barSlotWidth);
            using var sfAxis = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Near,
                Trimming = StringTrimming.EllipsisCharacter,
                FormatFlags = StringFormatFlags.NoWrap
            };
            g.DrawString(lbl, labelFont, textBrush, new RectangleF(lblBoxX, marginT + plotH + 5, lblBoxW, 20), sfAxis);
        }
    }
}
