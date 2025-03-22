using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media;
using FontAwesome.Sharp;

namespace Modern
{
    public partial class Form1: Form
    {

        // Fields
        private IconButton currentBtn;
        private Panel leftBoarderBtn;


        //constructor


        public Form1()
        {
            InitializeComponent();
            leftBoarderBtn = new Panel();
            leftBoarderBtn.Size = new Size(7,60);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {


                //buttons
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb (37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                // left boarder
                leftBoarderBtn.BackColor = color;
                leftBoarderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
            }

        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = color.
                currentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

            }



        }
       
         
            



        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
