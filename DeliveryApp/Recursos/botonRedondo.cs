using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DeliveryApp.Recursos
{
    class botonRedondo : Button
    {
        //we can use this to modify the color of the border 
        public Color BorderColor = Color.LightGray;
        //we can use this to modify the border size
        public int BorderSize = 0;

        private Color _borderColor = Color.Silver;
        private Color _onHoverBorderColor = Color.Gray;
        private Color _buttonColor = Color.Red;
        private Color _onHoverButtonColor = Color.Yellow;
        private Color _textColor = Color.White;
        private Color _onHoverTextColor = Color.Gray;

        private bool _isHovering;
        private int _borderThickness = 6;
        private int _borderThicknessByTwo = 3;
        public botonRedondo()
        {
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                _isHovering = true;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                _isHovering = false;
                Invalidate();
            };
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Aqua, Color.Blue, 90);

            using (GraphicsPath gp = new GraphicsPath())
            {
                AddRoundedRectangle(gp, new Point(1, 1), new Size(this.Size.Width - 2, Size.Height - 2));
                e.Graphics.FillPath(brush, gp);
            }

            using (GraphicsPath gp = new GraphicsPath())
            {
                AddRoundedRectangle(gp, new Point(0, 0), this.Size);
                this.Region = new Region(gp);
            }

            base.OnPaint(e);


        }

        private void AddRoundedRectangle(GraphicsPath gp, Point upperLeft, Size size)
        {
            gp.AddArc(new Rectangle(upperLeft, new Size(size.Height, size.Height)), 90, 180);
            gp.AddLine(new Point(size.Height / 2, upperLeft.Y), new Point(size.Width - (size.Height / 2), upperLeft.Y));
            gp.AddArc(new Rectangle(new Point(size.Width - size.Height, upperLeft.Y), new Size(size.Height, size.Height)), -90, 180);
            gp.CloseFigure();
        }

        public Color OnHoverBorderColor
        {
            get => _onHoverBorderColor;
            set
            {
                _onHoverBorderColor = value;
                Invalidate();
            }
        }

        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                _buttonColor = value;
                Invalidate();
            }
        }

        public Color OnHoverButtonColor
        {
            get => _onHoverButtonColor;
            set
            {
                _onHoverButtonColor = value;
                Invalidate();
            }
        }

        public Color TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Invalidate();
            }
        }

        public Color OnHoverTextColor
        {
            get => _onHoverTextColor;
            set
            {
                _onHoverTextColor = value;
                Invalidate();
            }
        }
    }
}
