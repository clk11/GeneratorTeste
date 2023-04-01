using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class LollipopButton : Button
{
    #region Variables
    Timer AnimationTimer = new Timer { Interval = 1 };
    FontManager font = new FontManager();
    StringFormat SF = new StringFormat();
    Rectangle R;
    bool done = false;
    bool reverse = false;
    Color AnimColor = ColorTranslator.FromHtml("#1aff8c");
    bool AnimationStatusActive = false;
    int xx;
    int yy;
    float SizeAnimation = 0;
    Color EnabledBGColor = ColorTranslator.FromHtml("#1a53ff");//#0c0007
    Graphics G;
    Color StringColor;
    #endregion
    #region Events
    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        //this.EnabledBGColor = ColorTranslator.FromHtml("#808080");
        this.AnimationStatusActive = true;
        AnimationTimer.Start();
        Invalidate();
        this.Invalidate();
    }
    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        this.AnimationStatusActive = false;
        this.reverse = true;
    }
    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        R = new Rectangle(0, 0, Width, Height);
    }
    public void MaintainTheGraphics()
    {
        G.SmoothingMode = SmoothingMode.AntiAlias;
        G.TextRenderingHint = TextRenderingHint.AntiAlias;
        G.InterpolationMode = InterpolationMode.HighQualityBilinear;

        var BG = DrawHelper.CreateRoundRect(1, 1, Width, Height, 1);
        G.FillPath(new SolidBrush(Enabled ? EnabledBGColor : Color.Brown), BG);
        G.DrawPath(new Pen(Enabled ? Color.Ivory : Color.Brown), BG);
        Region region = new Region(BG);

        G.SetClip(region, CombineMode.Replace);
        G.DrawString(Text, base.Font, new SolidBrush(Color.White), R, SF);
    }
    protected override void OnPaint(PaintEventArgs e)
    {
        //G.Clear(Parent.BackColor);
        base.OnPaint(e);
        G = e.Graphics;
        if (done == false)
        {
            done = true;
            StringColor = Color.Black;
            //EnabledBGColor = Color.DodgerBlue;
        }
        this.MaintainTheGraphics();
        //
        if (this.reverse == true)
        {
            G.FillRectangle(new SolidBrush(Color.FromArgb(100, this.AnimColor)), (this.Width - this.Width), this.Height - this.Height, SizeAnimation - 34, SizeAnimation - 34);
        }
        else
        {
            G.FillRectangle(new SolidBrush(Color.FromArgb(100, this.AnimColor)), (this.Width - this.Width), this.Height - this.Height, SizeAnimation, SizeAnimation);
        }
        //G.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), xx - (SizeAnimation / 3), yy - (SizeAnimation / 3), SizeAnimation, SizeAnimation);
        //G.FillEllipse(new SolidBrush(Color.FromArgb(100, Color.Red)), xx - (SizeAnimation / 2), yy - (SizeAnimation / 5), SizeAnimation, SizeAnimation);
    }
    protected void AnimationTick(object sender, EventArgs e)
    {
        if (AnimationStatusActive)
        {
            if (SizeAnimation < Width + 300)
            {
                SizeAnimation += Width / 34;
                this.Invalidate();
            }
            else
            {
                this.AnimationStatusActive = false;
            }
        }
        if (reverse == true)
        {
            if (SizeAnimation != 0)
            {
                SizeAnimation -= Width / 34;
                this.Invalidate();
            }
            else
            {
                this.reverse = false;
            }
        }
    }
    #endregion
    #region Contructor
    public LollipopButton()
    {
        SetStyle((ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint), true);
        DoubleBuffered = true;
        Size = new Size(143, 41);

        //String format variable is populated with the align and linealign 
        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;
        //-end of the cometary

        AnimationTimer.Tick += new EventHandler(AnimationTick);
    }
    #endregion
}

