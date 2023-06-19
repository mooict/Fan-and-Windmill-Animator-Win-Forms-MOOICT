namespace Fan_and_Windmill_Animator_Win_Forms_MOOICT
{
    // Made by MOO ICT
    // For educational purpose only
    public partial class Form1 : Form
    {

        Image Fan;
        Image WindMill;


        public Form1()
        {
            InitializeComponent();
            LoadImages();
        }

        private void DrawAnimationsPaintEvent(object sender, PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(Fan);
            ImageAnimator.UpdateFrames(WindMill);
            

            e.Graphics.DrawImage(Fan, new Point(50, 0));
            e.Graphics.DrawImage(WindMill, new Point(300, 200));

        }

        private void LoadImages()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);

            Fan = Properties.Resources.Fan;

            ImageAnimator.Animate(Fan, this.OnFrameChangedHandler);

            WindMill = Properties.Resources.Windmill;

            ImageAnimator.Animate(WindMill, this.OnFrameChangedHandler);

        }

        private void OnFrameChangedHandler(object? sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}