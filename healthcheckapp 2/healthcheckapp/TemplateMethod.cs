using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace healthcheckapp
{

    public abstract class PageTemplate
    {

        protected void showHeader(MenuStrip menuStrip)
        {
            menuStrip.Visible = true;
        }

        protected void showNavigation()
        {

        }

        protected void showFooter(MenuStrip menuStrip)
        {
            menuStrip.Visible = true;
        }

        protected abstract void showImage(PictureBox pictureBox);

        public void showPage(MenuStrip menuStrip, MenuStrip menuStrip1, PictureBox pictureBox)
        {
            showHeader(menuStrip);
            showNavigation();
            showImage(pictureBox);
            showFooter(menuStrip1);
        }
    }
    public class DietImage : PageTemplate
    {


        protected override void showImage(PictureBox pictureBox)
        {
            pictureBox.Visible = true;
            pictureBox.BringToFront();
        }
    }

    public class HomeImage : PageTemplate
    {
        protected override void showImage(PictureBox pictureBox)
        {
            pictureBox.Visible = true;
            pictureBox.BringToFront();
        }
    }
}