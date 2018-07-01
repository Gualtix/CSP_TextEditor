using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP_Text_Editor
{

    
    public partial class frmEditor : Form
    {
        

        public frmEditor()
        {
            InitializeComponent();

            lblNums.Font = new Font(tboxCode.Font.FontFamily, tboxCode.Font.Size);
        }

        private void tboxCode_TextChanged(object sender, EventArgs e)
        {
            
            updateNumberLabel();
        }

        private void updateNumberLabel()
        {
            //we get index of first visible char and 
            //number of first visible line

            
            Point pos = new Point(0,0);
            int firstIndex = tboxCode.GetCharIndexFromPosition(pos);
            int firstLine = tboxCode.GetLineFromCharIndex(firstIndex);

            //now we get index of last visible char 
            //and number of last visible line
            pos.X = ClientRectangle.Width;
            pos.Y = ClientRectangle.Height;
            int lastIndex = tboxCode.GetCharIndexFromPosition(pos);
            int lastLine = tboxCode.GetLineFromCharIndex(lastIndex);

            //this is point position of last visible char, we'll 
            //use its Y value for calculating lblNums size
            pos = tboxCode.GetPositionFromCharIndex(lastIndex);

            //finally, renumber label
            //lblNums.Text = "";
            //for (int i = firstLine; i <= lastLine + 1; i++)
            //{
            //    lblNums.Text += i + 1 + "\n";
            //}
           
            lblNums.Text = "";
            int cnt = firstLine;
            int lmt = lastLine + 1;
            while(cnt <= lmt){
                lblNums.Text += cnt + 1 + "\n";
                cnt++;
            }
        }

        private void tboxCode_VScroll(object sender, EventArgs e)
        {
            //move location of lblNums for amount 
            //of pixels caused by scrollbar
            int d = tboxCode.GetPositionFromCharIndex(0).Y % (tboxCode.Font.Height + 1);
            lblNums.Location = new Point(0, d);

            updateNumberLabel();
        }

        private void tboxCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Do what you have to do
                updateNumberLabel();
                //e.Handled = true;
            }
        }
    }
}
