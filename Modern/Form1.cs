using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

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
            panelMenu.Controls.Add(leftBoarderBtn);
        }

        //structure

        private struct RGBColors
        {

            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95,77,221);
            public static Color color5 = Color.FromArgb(249,88,155);
            public static Color color6 = Color.FromArgb(24,161,251);
            







        }
















        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb (37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                // left boarder
                leftBoarderBtn.BackColor = color;
                leftBoarderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBoarderBtn.Visible = true;
                leftBoarderBtn.BringToFront();
            }

        }


        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
               //  currentBtn.ForeColor = Color.Nintend;
                currentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
             //   currentBtn.IconColor = Color.Nintend;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;

            }



        }
       
         
            



        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
