using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace PhotoChange
{
    public partial class MainFormStyle : Component
    {
        #region -- Свойства --

        // Форма
        public Form Form { get; set; }
        public Style FormStyle
        {
            get => Style.None;
            set
            {
                Sign();
            }
        }
        public enum Style 
        {
            None
        }
        public bool AllowUserResize { get; set; }
        public Color BackColor { get; set; } = Color.Gray;
        public ContextMenuStrip ContextMenuForm { get; set; }

        // Кнопки
        public int ControlBoxButtonsWidth { get; set; } = 40;

        // Заголовок
        public int HeaderHeight { get; set; } = 28;
        public Color HeaderColor { get; set; } = Color.Gray;
        public Font HeaderTextFont { get; set; } = new Font("Arial", 8.75F, FontStyle.Regular);
        public Color HeaderTextColor { get; set; } = Color.White;
        public int BorderWidth { get; set; } = 4;
        public Color BorderColor { get; set; } = Color.Gray;
        public Image IconImage { get; set; }

        #endregion

        #region -- Поля --

        private List<Control> FormControls = new List<Control>();
        private Panel? MainContainer = null;

        private Size IconSize = new Size(14,14);
        private Rectangle RectangleIcon = new Rectangle();
        private Rectangle RectangleIconImage = new Rectangle();
        private bool IconHovered = false;

        private StringFormat SF = new StringFormat();
        
        private bool MousePressed = false;
        private bool CanDragForm = false;
        private Point ClickPosition;
        private Point MoveStartPosition;
        private MouseButtons LastClickedMouseButton;

        private Rectangle RectangleButtonClose = new Rectangle();
        private Rectangle RectangleButtonMax = new Rectangle();
        private Rectangle RectangleButtonMin = new Rectangle();

        private Rectangle RectangleCrosshair = new Rectangle();
        private Rectangle RectangleSquare = new Rectangle();
        private Rectangle RectangleLine = new Rectangle();

        private bool ButtonCLoseHovered = false;
        private bool ButtonMaxHovered = false;
        private bool ButtonMinHovered = false;

        private Rectangle RectangleHeader = new Rectangle();
        private Rectangle RectangleBorder = new Rectangle();
        private Rectangle RectangleTitleText = new Rectangle();

        private int ResizeStartRight = 0;
        private int ResizeStartBottom = 0;
        private int ResizeBorderSize = 4;
        private int ResizeAngleBorderOffset = 16;
        private bool IsResizing = false;
        private bool FormNeedReposition = false;

        private BorderHoverPositionEnum BorderHoverPosition = BorderHoverPositionEnum.None;
        private enum BorderHoverPositionEnum
        {
            None,
            Left, Top, Right, Bottom,
            TopLeft, TopRight, BottomLeft, BottomRight
        }

        #endregion

        public MainFormStyle()
        {
            InitializeComponent();
        }

        public MainFormStyle(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void Sign()
        {
            if (Form != null)
            {
                Form.HandleCreated += Form_HandleCreated;
            }
        }      

        private void Apply()
        {
            MigrateControls();

            SF.Alignment = StringAlignment.Near;
            SF.LineAlignment = StringAlignment.Center;

            Form.FormBorderStyle = FormBorderStyle.None;

            SetDoubleBuffered(Form);

            OffsetControls();

            Form.Paint += Form_Paint;
            Form.MouseUp += Form_MouseUp;
            Form.MouseDown += Form_MouseDown;   
            Form.MouseMove += Form_MouseMove;
            Form.MouseLeave += Form_MouseLeave;
            Form.SizeChanged += Form_SizeChanged;
            Form.DoubleClick += Form_DoubleClick;
            Form.Click += Form_Click;
        }

        private void OffsetControls()
        {
            Form.Height += HeaderHeight;
            foreach(Control control in Form.Controls)
            {
                control.Location = new Point(control.Location.X, control.Location.Y + HeaderHeight);
                control.Refresh();
            }
        }

        private void MigrateControls()
        {
            MainContainer = new Panel();
            MainContainer.BackColor = Form.BackColor;
            MainContainer.Location = new Point(BorderWidth + 1, 1);
            ChangeMainContainerSize();

            if (FormControls.Count == 0)
                FormControls.AddRange(Form.Controls.OfType<Control>());

            Form.Controls.Clear();

            if (FormControls.Count > 0)
                MainContainer.Controls.AddRange(FormControls.ToArray());

            Form.Controls.Add(MainContainer);
        }

        private void ChangeMainContainerSize()
        {
            MainContainer.Size = new Size(Form.Width - 2 * BorderWidth, Form.Height - HeaderHeight - BorderWidth);
        }

        #region -- Form Events --

        private void Form_HandleCreated(object? sender, EventArgs e)
        {
            Apply();
        }

        private void Form_Paint(object? sender, PaintEventArgs e)
        {
            DrawStyle(e.Graphics);
        }

        private void Form_SizeChanged(object? sender, EventArgs e)
        {
            Form.Refresh();
            ChangeMainContainerSize();
        }

        private void Form_MouseUp(object? sender, MouseEventArgs e)
        {
            MousePressed = false;
            CanDragForm = false;
            IsResizing = false;

            if (AllowUserResize && BorderHoverPosition != BorderHoverPositionEnum.None)
                return;

            if (Cursor.Position.Y == Screen.FromHandle(Form.Handle).WorkingArea.Y 
                && Form.WindowState == FormWindowState.Normal)
            {
                Form.WindowState = FormWindowState.Maximized;
                FormNeedReposition = true;
            }

            if (Form.Location.Y < Screen.FromHandle(Form.Handle).WorkingArea.Y)
            {
                Form.Location = new Point(Form.Location.X, Screen.FromHandle(Form.Handle).WorkingArea.Y);
            }

            if (e.Button == MouseButtons.Left && Form.ControlBox == true)
            {
                // Кнопка Close
                if (RectangleButtonClose.Contains(e.Location))
                {
                    Form.Close();
                }

                // Кнопка Max
                if (RectangleButtonMax.Contains(e.Location) && Form.MaximizeBox == true)
                {
                    if (Form.WindowState == FormWindowState.Maximized)
                    {
                        Form.WindowState = FormWindowState.Normal;

                        if (FormNeedReposition)
                        {
                            FormNeedReposition = false;
                            Form.Location = MoveStartPosition;
                        }
                    }
                    else if (Form.WindowState == FormWindowState.Normal)
                    {
                        Form.WindowState = FormWindowState.Maximized;
                    }
                }

                // Кнопка Min
                if (RectangleButtonMin.Contains(e.Location) && Form.MinimizeBox == true)
                {
                    Form.WindowState = FormWindowState.Minimized;
                }
            }

            // Контекстное меню при нажатии на иконку
            if (e.Button == MouseButtons.Right && IconHovered)
            {
                if (ContextMenuForm != null)
                {
                    ContextMenuForm.Show(Cursor.Position);
                }
            }
        }

        private void Form_MouseDown(object? sender, MouseEventArgs e)
        {
            MousePressed = true;

            if (AllowUserResize && BorderHoverPosition != BorderHoverPositionEnum.None)
            {
                if (e.Button == MouseButtons.Left)
                {
                    IsResizing = true;
                    ResizeStartRight = Form.Right;
                    ResizeStartBottom = Form.Bottom;
                    return;
                }
            }

            if (e.Location.Y <= HeaderHeight 
                && !RectangleButtonClose.Contains(e.Location)
                && !RectangleButtonMax.Contains(e.Location)
                && !RectangleButtonMin.Contains(e.Location))
            {
                CanDragForm = true;
                ClickPosition = Cursor.Position;
                MoveStartPosition = Form.Location;
            }

            LastClickedMouseButton = e.Button;
        }

        private void Form_MouseMove(object? sender, MouseEventArgs e)
        {
            // Перетаскивание формы
            if (CanDragForm && e.Button == MouseButtons.Left)
            {
                if (Form.WindowState == FormWindowState.Maximized)
                {
                    float maxWidth = Form.Width;
                    float cursosOnMaxPosition = e.X;
                    float coeff = cursosOnMaxPosition / (maxWidth / 100f) / 100f;

                    Form.WindowState = FormWindowState.Normal;

                    int XFormOffset = (int)(Form.Width * coeff);

                    Form.Location = new Point(Cursor.Position.X - XFormOffset, Cursor.Position.Y - HeaderHeight / 2);
                    MoveStartPosition = Form.Location;
                    ClickPosition = Cursor.Position;
                }
                else
                {
                    Size formOffset = new Size(Point.Subtract(Cursor.Position, new Size(ClickPosition)));
                    Form.Location = Point.Add(MoveStartPosition, formOffset);
                }
            }

            // Наведение на кнопки 
            else
            {
                if (RectangleButtonClose.Contains(e.Location))
                {
                    if (ButtonCLoseHovered == false)
                    {
                        ButtonCLoseHovered = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (ButtonCLoseHovered == true)
                    {
                        ButtonCLoseHovered = false;
                        Form.Invalidate();
                    }
                }

                if (RectangleButtonMax.Contains(e.Location))
                {
                    if (ButtonMaxHovered == false)
                    {
                        ButtonMaxHovered = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (ButtonMaxHovered == true)
                    {
                        ButtonMaxHovered = false;
                        Form.Invalidate();
                    }
                }

                if (RectangleButtonMin.Contains(e.Location))
                {
                    if (ButtonMinHovered == false)
                    {
                        ButtonMinHovered = true;
                        Form.Invalidate();
                    }
                }
                else
                {
                    if (ButtonMinHovered == true)
                    {
                        ButtonMinHovered = false;
                        Form.Invalidate();
                    }
                }

                if (RectangleIcon.Contains(e.Location))
                {
                    IconHovered = true;
                }
                else
                {
                    IconHovered = false;
                }
            }

            // Наведение на край
            if (AllowUserResize && IsResizing == false && Form.WindowState == FormWindowState.Normal)
            {
                if (RectangleBorder.Top + ResizeBorderSize >= e.Location.Y)
                {
                    // Левый верхний угол
                    if (e.Location.X <= ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        BorderHoverPosition = BorderHoverPositionEnum.TopLeft;
                    }
                    // Правый верхний угол
                    else if (e.Location.X >= RectangleBorder.Width - ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        BorderHoverPosition = BorderHoverPositionEnum.TopRight;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeNS;
                        BorderHoverPosition = BorderHoverPositionEnum.Top;
                    }
                }
                else if (RectangleBorder.Bottom - ResizeBorderSize <= e.Location.Y)
                {
                    // Левый нижний угол
                    if (e.Location.X <= ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        BorderHoverPosition = BorderHoverPositionEnum.BottomLeft;
                    }
                    // Правый нижний угол
                    else if (e.Location.X >= RectangleBorder.Width - ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        BorderHoverPosition = BorderHoverPositionEnum.BottomRight;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeNS;
                        BorderHoverPosition = BorderHoverPositionEnum.Bottom;
                    }
                }
                else if (RectangleBorder.Left + ResizeBorderSize >= e.Location.X)
                {
                    // Левый верхний угол
                    if (e.Location.Y <= ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        BorderHoverPosition = BorderHoverPositionEnum.TopLeft;
                    }
                    // Левый нижний угол
                    else if (e.Location.Y >= RectangleBorder.Height - ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        BorderHoverPosition = BorderHoverPositionEnum.BottomLeft;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeWE;
                        BorderHoverPosition = BorderHoverPositionEnum.Left;
                    }
                }
                else if (RectangleBorder.Right - ResizeBorderSize <= e.Location.X)
                {
                    // Правый верхний угол
                    if (e.Location.Y <= ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNESW;
                        BorderHoverPosition = BorderHoverPositionEnum.TopRight;
                    }
                    // Правый нижний угол
                    else if (e.Location.Y >= RectangleBorder.Height - ResizeAngleBorderOffset)
                    {
                        Form.Cursor = Cursors.SizeNWSE;
                        BorderHoverPosition = BorderHoverPositionEnum.BottomRight;
                    }
                    else
                    {
                        Form.Cursor = Cursors.SizeWE;
                        BorderHoverPosition = BorderHoverPositionEnum.Right;
                    }
                }
                else if (Form.Cursor != Cursors.Default)
                {
                    Form.Cursor = Cursors.Default;
                    BorderHoverPosition = BorderHoverPositionEnum.None;
                }
            }

            // Изменение размера
            else if (AllowUserResize && IsResizing && Form.WindowState == FormWindowState.Normal)
            {                
                switch (BorderHoverPosition)
                {
                    // Стороны 
                    case BorderHoverPositionEnum.Left:
                        Form.Location = new Point(Cursor.Position.X, Form.Location.Y);
                        Form.Width = Form.Width - (Form.Right - ResizeStartRight);
                        break;

                    case BorderHoverPositionEnum.Top:
                        Form.Location = new Point(Form.Location.X, Cursor.Position.Y);
                        Form.Height = Form.Height - (Form.Bottom - ResizeStartBottom);
                        break;

                    case BorderHoverPositionEnum.Right:
                        Form.Width = Cursor.Position.X - Form.Left;
                        break;

                    case BorderHoverPositionEnum.Bottom:
                        Form.Height = Cursor.Position.Y - Form.Top;
                        break;


                    // Углы 
                    case BorderHoverPositionEnum.TopLeft:
                        Form.Location = new Point(Form.Location.X, Cursor.Position.Y);
                        Form.Height = Form.Height - (Form.Bottom - ResizeStartBottom);

                        Form.Location = new Point(Cursor.Position.X, Form.Location.Y);
                        Form.Width = Form.Width - (Form.Right - ResizeStartRight);
                        break;

                    case BorderHoverPositionEnum.TopRight:
                        Form.Location = new Point(Form.Location.X, Cursor.Position.Y);
                        Form.Height = Form.Height - (Form.Bottom - ResizeStartBottom);

                        Form.Width = Cursor.Position.X - Form.Left;
                        break;

                    case BorderHoverPositionEnum.BottomLeft:
                        Form.Height = Cursor.Position.Y - Form.Top;

                        Form.Location = new Point(Cursor.Position.X, Form.Location.Y);
                        Form.Width = Form.Width - (Form.Right - ResizeStartRight);
                        break;

                    case BorderHoverPositionEnum.BottomRight:
                        Form.Height = Cursor.Position.Y - Form.Top;
                        Form.Width = Cursor.Position.X - Form.Left;
                        break;
                }
            }
        }

        private void Form_MouseLeave(object? sender, EventArgs e)
        {
            ButtonCLoseHovered = false;
            ButtonMaxHovered = false;
            ButtonMinHovered = false;
            Form.Invalidate();
        }

        private void Form_DoubleClick(object? sender, EventArgs e)
        {
            if (BorderHoverPosition != BorderHoverPositionEnum.None)
                return;

            if (MousePressed && LastClickedMouseButton == MouseButtons.Left && RectangleHeader.Contains(Form.PointToClient(Cursor.Position)))
            {
                if (Form.WindowState == FormWindowState.Maximized)
                {
                    Form.WindowState = FormWindowState.Normal;
                }
                else if (Form.WindowState == FormWindowState.Normal)
                {
                    Form.WindowState = FormWindowState.Maximized;
                }
            }
        }

        private void Form_Click(object? sender, EventArgs e)
        {
            Form.Focus();
        }

        #endregion

        private void DrawStyle(Graphics graphics)
        {
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            #region -- Определения структур --

            // Шапка
            RectangleHeader = new Rectangle(0,0, Form.Width - 1, HeaderHeight);
            RectangleBorder = new Rectangle(0, 0, Form.Width - 1, Form.Height - 1);
            RectangleTitleText = new Rectangle(RectangleHeader.X + IconSize.Width * 2, RectangleHeader.Y, RectangleHeader.Width,RectangleHeader.Height);

            // Иконка
            RectangleIcon = new Rectangle(
                RectangleHeader.Height / 2 - IconSize.Width / 2,
                RectangleHeader.Height / 2 - IconSize.Height / 2,
                IconSize.Width, IconSize.Height);
            if (IconImage != null)
            {
                int imageHeight = (int)(HeaderHeight * 0.9f); 
                int imageWidth = IconImage.Width / (IconImage.Height / imageHeight);
                RectangleIconImage = new Rectangle(RectangleIcon.Left, HeaderHeight / 2 - imageHeight / 2, imageWidth, imageHeight);
            }

            // Кнопка Close
            RectangleButtonClose = new Rectangle(RectangleHeader.Width - ControlBoxButtonsWidth, RectangleHeader.Y, ControlBoxButtonsWidth, RectangleHeader.Height);
            RectangleCrosshair = new Rectangle(
                RectangleButtonClose.X + RectangleButtonClose.Width / 2 - 5,
                RectangleButtonClose.Height / 2 - 5,
                10, 10);

            // Кнопка Max
            RectangleButtonMax = new Rectangle(RectangleButtonClose.X - ControlBoxButtonsWidth - 1, RectangleHeader.Y, ControlBoxButtonsWidth, RectangleHeader.Height);
            RectangleSquare = new Rectangle(
                RectangleButtonMax.X + RectangleButtonMax.Width / 2 - 5,
                RectangleButtonMax.Height / 2 - 5,
                10, 10);

            // Кнопка Min
            RectangleButtonMin = new Rectangle(RectangleButtonMax.X - ControlBoxButtonsWidth - 1, RectangleHeader.Y, ControlBoxButtonsWidth, RectangleHeader.Height);
            RectangleLine = new Rectangle(
                RectangleButtonMin.X + RectangleButtonMin.Width / 2 - 5,
                RectangleButtonMin.Height / 2 - 5,
                10, 10);

            #endregion

            #region -- Рисование --

            // Шапка
            graphics.DrawRectangle(new Pen(HeaderColor), RectangleHeader);
            graphics.FillRectangle(new SolidBrush(HeaderColor), RectangleHeader);
            graphics.DrawRectangle(new Pen(BorderColor, BorderWidth), RectangleBorder);


            if (IconImage != null)
            {
                graphics.DrawImage(IconImage, RectangleIconImage);
            }
            else
            {
                graphics.DrawString(Form.Text, HeaderTextFont, new SolidBrush(HeaderTextColor), RectangleTitleText, SF);

                if (Form.ShowIcon)
                {
                    graphics.DrawImage(Form.Icon.ToBitmap(), RectangleIcon);
                }
            }
            
            // Кнопка Close
            graphics.DrawRectangle(new Pen(ButtonCLoseHovered ? Color.White : Color.Gray), RectangleButtonClose);
            graphics.DrawLine(new Pen(Color.White), 
                RectangleCrosshair.X, RectangleCrosshair.Y, 
                RectangleCrosshair.X + RectangleCrosshair.Width, RectangleCrosshair.Y + RectangleCrosshair.Height);
            graphics.DrawLine(new Pen(Color.White),
                RectangleCrosshair.X + RectangleCrosshair.Width, RectangleCrosshair.Y,
                RectangleCrosshair.X, RectangleCrosshair.Y + RectangleCrosshair.Height);

            // Кнопка Max
            graphics.DrawRectangle(new Pen(ButtonMaxHovered ? Color.White : Color.Gray), RectangleButtonMax);
            graphics.DrawRectangle(new Pen(Color.White), RectangleSquare);

            // Кнопка Min
            graphics.DrawRectangle(new Pen(ButtonMinHovered ? Color.White : Color.Gray), RectangleButtonMin);
            graphics.DrawLine(new Pen(Color.White),
                RectangleLine.X, RectangleLine.Y + RectangleLine.Height / 2,
                RectangleLine.X + RectangleLine.Width, RectangleLine.Y + RectangleLine.Height / 2);

            #endregion
        }

        public static void SetDoubleBuffered(Control control)
        {
            if (SystemInformation.TerminalServerSession)
                return;

            System.Reflection.PropertyInfo pDoubleBuffered =
                typeof(Control).GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance);
            pDoubleBuffered.SetValue(control, true, null);   
        }
    }
}
