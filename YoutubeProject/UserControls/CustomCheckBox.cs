using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace YoutubeProject
{
    class CustomCheckBox : Control
    {
        #region Private Members
        private Label CheckBoxLabel;
        private PictureBox CheckBoxPicture;
        private Rectangle CheckBoxRectangle;

        #region Private Members [Picture]
        private int CheckBoxImageWidthValue = 0;
        private Image CheckBoxImageValue;
        #endregion

        #region Private Members [Rectangle]
        private Color CheckBoxFrameColorValue = Color.FromArgb(0, 0, 0);
        private Color CheckBoxFrameHighlightColorValue = Color.FromArgb(0, 120, 215);
        private Color CheckBoxBackColorValue = Color.FromArgb(255, 255, 255);
        private Color CheckBoxBackHighlightColorValue = Color.FromArgb(255, 255, 255);
        private Color CheckBoxCheckedBackColorValue = Color.FromArgb(0, 0, 255);
        private int CheckBoxFrameStrengthValue = 1;
        private int CheckBoxSizeValue = 14;
        #endregion

        #region Private Members [Label]
        private Font CheckBoxFontValue;
        private Color CheckBoxForeColorValue = Color.FromArgb(0, 0, 0);
        private Color CheckBoxForeHighlightColorValue = Color.FromArgb(0, 0, 0);
        private string CheckBoxTextValue = "Max Korzh";
        #endregion

        #region Private Members [Check Mark]
        private Color CheckBoxCharColorValue = Color.FromArgb(255,255,255);
        private Color CheckBoxCharHighlightColorValue = Color.FromArgb(255,255,255);
        private string CheckBoxCharValue = "\u221A";
        private Font CheckBoxCharFontValue;
        #endregion

        /// <summary>
        /// Check if mouse is over the control
        /// </summary>
        private bool MouseOver = false;
        /// <summary>
        /// CheckBox checker
        /// </summary>
        private bool IsChecked = false;
        #endregion

        #region Attributes
        #region Attributes [Picture]
        public Image CheckBoxImage
        {
            get { return CheckBoxImageValue; }
            set
            {
                if (CheckBoxImage != value)
                {
                    CheckBoxImageValue = value;

                    RefreshImage();
                    RefreshLabel();
                }
            }
        }
        public int CheckBoxImageWidth
        {
            get { return CheckBoxImageWidthValue; }
            set
            {
                if (CheckBoxImageWidth != value)
                {
                    CheckBoxImageWidthValue = value;

                    RefreshImage();
                    RefreshLabel();
                }
            }
        }
        #endregion

        #region Attributes [Rectangle]
        /// <summary>
        /// Image for the checkbox
        /// </summary>
        public int CheckBoxFrameStrength
        {
            get { return CheckBoxFrameStrengthValue; }
            set
            {
                if (CheckBoxFrameStrength != value)
                {
                    CheckBoxFrameStrengthValue = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Size of the rectangle of the checkbox
        /// </summary>
        public int CheckBoxSize
        {
            get { return CheckBoxSizeValue; }
            set
            {
                if (CheckBoxSize != value)
                {
                    CheckBoxSizeValue = value;

                    Invalidate();
                    RefreshImage();
                    RefreshLabel();
                }
            }
        }
        /// <summary>
        /// Frame color for the checkbox
        /// </summary>
        public Color CheckBoxFrameColor
        {
            get { return CheckBoxFrameColorValue; }
            set
            {
                if (CheckBoxFrameColor != value)
                {
                    CheckBoxFrameColorValue = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Frame highlight color for the checkbox
        /// </summary>
        public Color CheckBoxFrameHighlightColor
        {
            get { return CheckBoxFrameHighlightColorValue; }
            set
            {
                if (CheckBoxFrameHighlightColor != value)
                {
                    CheckBoxFrameHighlightColorValue = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Back color for the checkbox
        /// </summary>
        public Color CheckBoxBackColor
        {
            get { return CheckBoxBackColorValue; }
            set
            {
                if (CheckBoxBackColor != value)
                {
                    CheckBoxBackColorValue = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Back highlight color for the checkbox
        /// </summary>
        public Color CheckBoxBackHighlightColor
        {
            get { return CheckBoxBackHighlightColorValue; }
            set
            {
                if (CheckBoxBackHighlightColor != value)
                {
                    CheckBoxBackHighlightColorValue = value;
                    Invalidate();
                }
            }
        }
        public Color CheckBoxCheckedBackColor
        {
            get { return CheckBoxCheckedBackColorValue ; }
            set
            {
                if(CheckBoxCheckedBackColor != value)
                {
                    CheckBoxCheckedBackColorValue = value;
                    Invalidate();
                }
            }
        }
        #endregion

        #region Attributes [Label]
        /// <summary>
        /// Label text font
        /// </summary>
        public Font CheckBoxFont
        {
            get { return CheckBoxFontValue; }
            set
            {
                if (CheckBoxFont != value)
                {
                    CheckBoxFontValue = value;
                    RefreshLabel();
                }
            }
        }
        /// <summary>
        /// Label text of the checkbox
        /// </summary>
        public string CheckBoxText
        {
            get { return CheckBoxTextValue; }
            set
            {
                if (CheckBoxText != value)
                {
                    CheckBoxTextValue = value;
                    RefreshLabel();
                }
            }
        }
        /// <summary>
        /// Fore color for the checkbox
        /// </summary>
        public Color CheckBoxForeColor
        {
            get { return CheckBoxForeColorValue; }
            set
            {
                if (CheckBoxForeColor != value)
                {
                    CheckBoxForeColorValue = value;
                    RefreshLabel();
                }
            }
        }
        /// <summary>
        /// Fore highlight color for the checkbox
        /// </summary>
        public Color CheckBoxForeHighlightColor
        {
            get { return CheckBoxForeHighlightColorValue; }
            set
            {
                if (CheckBoxForeHighlightColor != value)
                {
                    CheckBoxForeHighlightColorValue = value;
                    RefreshLabel();
                }
            }
        }
        #endregion

        #region Attributes [Check Mark]
        /// <summary>
        /// Char/Symbol/Icon for checkbox arrow 
        /// </summary>
        public string CheckBoxChar
        {
            get { return CheckBoxCharValue; }
            set
            {
                if (CheckBoxChar != value)
                {
                    CheckBoxCharValue = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Font for checkbox arrow char 
        /// </summary>
        public Font CheckBoxCharFont
        {
            get { return CheckBoxCharFontValue; }
            set
            {
                if (CheckBoxCharFont != value)
                {
                    CheckBoxCharFontValue = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Color for the checkbox arrow char
        /// </summary>
        public Color CheckBoxCharColor
        {
            get { return CheckBoxCharColorValue; }
            set
            {
                if (CheckBoxCharColor != value)
                {
                    CheckBoxCharColorValue = value;
                    Invalidate();
                }
            }
        }
        /// <summary>
        /// Highlight color for the checkbox arrow char
        /// </summary>
        public Color CheckBoxCharHighlightColor
        {
            get { return CheckBoxCharHighlightColorValue; }
            set
            {
                if (CheckBoxCharHighlightColor != value)
                {
                    CheckBoxCharHighlightColorValue = value;
                    Invalidate();
                }
            }
        }
        #endregion
        #endregion

        #region Constructor
        public CustomCheckBox()
        {
            DoubleBuffered = true;

            //Default size
            Size = new Size(200, 100);

            //Set font
            CheckBoxFont = this.Font;
            CheckBoxCharFont = this.Font;

            //Create the pictureBox
            CheckBoxPicture = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.CenterImage,
                Location = new Point(CheckBoxSize + 1, 0),
                Size = new Size(CheckBoxImageWidth, this.Height)
            };

            //Create the label
            var midHeightLabel = Height / 2 - Font.Height / 2;
            CheckBoxLabel = new Label()
            {
                Font = CheckBoxFont,
                Size = new Size(this.Width - CheckBoxSize - CheckBoxImageWidth, this.Height),
                Location = new Point(CheckBoxSize + 2 + CheckBoxImageWidth, midHeightLabel),
                Text = CheckBoxText
            };

            //Add label to control
            Controls.Add(CheckBoxLabel);
            //Add pictureBox to control
            Controls.Add(CheckBoxPicture);

            //Create events
            CreateMouseEvents();
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //Paint checkbox rectangle
            PaintRectangle(e);

            //Paint checkbox arrow
            if (IsChecked)
                PaintArrowChar(e);
        }
        /// <summary>
        /// Paint the checkbox rectangle
        /// </summary>
        /// <param name="e"></param>
        private void PaintRectangle(PaintEventArgs e)
        {
            //Create checkbox rectangle
            var midHeight = Height / 2 - CheckBoxSize / 2;
            CheckBoxRectangle = new Rectangle(0, midHeight, CheckBoxSize, CheckBoxSize);

            //Set color
            Color fillColor; 

            if (IsChecked)
            {
                fillColor = CheckBoxCheckedBackColor;
            }
            else
                fillColor = MouseOver ? CheckBoxBackHighlightColor : CheckBoxBackColor;
            var frameColor = MouseOver ? CheckBoxFrameHighlightColor : CheckBoxFrameColor;


            //Draw rectangle frame
            using (var pen = new Pen(frameColor, CheckBoxFrameStrength))
            {
                var brush = new SolidBrush(fillColor);
                e.Graphics.FillRectangle(brush, CheckBoxRectangle);
                e.Graphics.DrawRectangle(pen, CheckBoxRectangle);
            }
        }
        /// <summary>
        /// Paint char for the checkbox arrow type
        /// </summary>
        /// <param name="e"></param>
        private void PaintArrowChar(PaintEventArgs e)
        {
            //Get color for char
            var charColor = MouseOver ? CheckBoxCharHighlightColor : CheckBoxCharColor;

            //Position 
            var midX = CheckBoxSize / 2 - 3;
            var midY = Height / 2 - CheckBoxCharFont.Height / 2;

            //Draw string
            using (var brush = new SolidBrush(charColor))
            {
                e.Graphics.DrawString(CheckBoxChar, CheckBoxCharFont, brush, new Point(midX, midY));
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            RefreshImage();
            RefreshLabel();
        }
        private void RefreshLabel()
        {
            if (CheckBoxLabel == null) return;

            //Set label font
            CheckBoxLabel.Font = CheckBoxFont;
            //Set label text
            CheckBoxLabel.Text = CheckBoxText;
            //Set fore color
            CheckBoxLabel.ForeColor = MouseOver ? CheckBoxForeHighlightColor : CheckBoxForeColor;

            //Get and set new size
            var offsetWidth = Width - CheckBoxSize - CheckBoxImageWidth;
            CheckBoxLabel.Size = new Size(offsetWidth, Height);
            
            var offsetX = CheckBoxSize + CheckBoxImageWidth;
            var midHeight = Height / 2 - CheckBoxFont.Height / 2;
            CheckBoxLabel.Location = new Point(offsetX, midHeight);
        }
        private void RefreshImage()
        {
            if (CheckBoxImage == null) return;

            //Set image
            CheckBoxPicture.Image = CheckBoxImage;

            //Get and set new size
            CheckBoxPicture.Size = new Size(CheckBoxImageWidth, CheckBoxImage.Height);

            //Position
            var offsetX = CheckBoxSize + 3;
            var midHeight = Height / 2 - CheckBoxImage.Height / 2;
            CheckBoxPicture.Location = new Point(offsetX, midHeight);
        }

        #region MouseEvents

        private void CreateMouseEvents()
        {
            //CONTROL

            MouseEnter += (sender, e) =>
            {
                OnCustomMouseEnter(e);
            };

            MouseLeave += (sender, e) =>
            {
                OnCustomMouseLeave(e);
            };

            MouseDown += (sender, e) =>
            {
                OnCustomMouseDown(e);
            };

            //LABEL

            CheckBoxLabel.MouseEnter += (sender, e) =>
            {
                OnCustomMouseEnter(e);
            };
            CheckBoxLabel.MouseLeave += (sender, e) =>
            {
                OnCustomMouseLeave(e);
            };
            CheckBoxLabel.MouseDown += (sender, e) =>
            {
                OnCustomMouseDown(e);
            };

            //RECTANGLE

            //CheckBoxRectangle.MouseEnter += (sender, e) =>
            //{
            //    OnCustomMouseEnter(e);
            //};
            //CheckBoxRectangle.MouseLeave += (sender, e) =>
            //{
            //    OnCustomMouseLeave(e);
            //};
        }
        /// <summary>
        /// Mouse enter event
        /// </summary>
        /// <param name="e"></param>
        private void OnCustomMouseEnter(EventArgs e)
        {
            //Set mouse over effect
            if (!MouseOver)
            {
                MouseOver = true;

                //Force repaint
                Invalidate();

                //Force refresh
                RefreshImage();
                RefreshLabel();
            }

        }
        /// <summary>
        /// Mouse leave event
        /// </summary>
        /// <param name="e"></param>
        private void OnCustomMouseLeave(EventArgs e)
        {
            //Set mouse over effect
            if (MouseOver)
            {
                MouseOver = false;

                //Force repaint
                Invalidate();

                //Force refresh
                RefreshImage();
                RefreshLabel();
            }

        }
        /// <summary>
        /// Mouse down event
        /// </summary>
        /// <param name="e"></param>
        private void OnCustomMouseDown(EventArgs e)
        {
            //Switch
            IsChecked = !IsChecked;

            //Force redraw
            Invalidate();
        }

        #endregion
    }
}
