using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventController
{
    internal class ImgGrid
    {
        public static void drawImages(
           Form sender, int numPics = 15, int x = 0, int y = 0, int imgheight = 180, int imagewidth = 160,
           string url = "https://scontent.fdac157-1.fna.fbcdn.net/v/t39.30808-6/342845967_786978879720519_8379071672964433227_n.jpg?_nc_cat=108&ccb=1-7&_nc_sid=8bfeb9&_nc_eui2=AeH58pc5i-NEfwcuaJgTsVuHw6dBQ83txnnDp0FDze3GeYaJJfh5aae1KKr3xrA7Coff3LJ2UIEldagEBRmbCxR6&_nc_ohc=MRw1EzNCkFIAX-VPbjR&_nc_ht=scontent.fdac157-1.fna&oh=00_AfD-a3F_YMU2-Do07wUhwDKoKtjx5aW6JvLVzLH2BpgBQQ&oe=644ECEB2",
           string name = "hello world", int SpaceBeforeLabel = 3, bool hasLottery = false, bool fromTeam = false
           )
        {


            PictureBox pictureBox = new PictureBox();



            url += ".png";

            pictureBox = new PictureBox();
            pictureBox.Size = new Size(imgheight, imagewidth);
            pictureBox.Location = new Point(x, y);
            pictureBox.ImageLocation = url;
            //pictureBox.UseTransparentBackground = true;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            sender.Controls.Add(pictureBox);
            pictureBox.BringToFront();
            int centerX;
            //if (!hasLottery)
            {
                Label label1 = new Label();
                label1.Text = name;
                label1.MaximumSize = new Size(160, 30);
                label1.Font = new Font("Poppins", 11, FontStyle.Bold);
                label1.AutoSize = true;

                label1.BackColor = Color.Transparent;
                label1.BorderStyle = System.Windows.Forms.BorderStyle.None;

                //if (!fromTeam)
                //{
                //    label1.ForeColor = Color.White;
                //    centerX = x + (pictureBox.Width / 2);
                //    label1.Location = new Point(centerX - (label1.Width / 2), pictureBox.Bottom + SpaceBeforeLabel);
                //}
                //else
                {
                    label1.Font = new Font("Poppins", 16, FontStyle.Bold);
                    label1.ForeColor = Color.FromArgb(151, 18, 121);
                    label1.BackColor = Color.Transparent;
                    centerX = x + (pictureBox.Width / 2);
                    label1.Location = new Point(centerX - (label1.Width / 2), pictureBox.Bottom - label1.Height + 30);
                }
                // label1.TextAlign = ContentAlignment.MiddleCenter;

                sender.Controls.Add(label1);
                label1.BringToFront();
            }


            //else
            //{

            //    if (!name.Equals(""))
            //    {
            //        PictureBox pb = new PictureBox();

            //        if (name.Equals("1"))
            //            pb.Image = Properties.Resources._1;
            //        if (name.Equals("2"))
            //            pb.Image = Properties.Resources._2;
            //        if (name.Equals("3"))
            //            pb.Image = Properties.Resources._3;
            //        if (name.Equals("4"))
            //            pb.Image = Properties.Resources._4;

            //        pb.SizeMode = PictureBoxSizeMode.StretchImage;
            //        pb.Width = 50;
            //        pb.Height = 50;
            //        pb.BackColor = Color.Transparent;
            //        pb.Location = new Point(x, y);

            //        centerX = x + (pictureBox.Width / 2);
            //        pb.Width = 100;
            //        pb.Height = 100;
            //        pb.BackColor = Color.Transparent;
            //        pb.Location = new Point(centerX - (pb.Width / 2), pictureBox.Bottom);
            //        sender.Controls.Add(pb); // add the picture box to the form

            //        pb.BringToFront();
            //    }




            //}
        }





        public static int[][] getImageGrid(
                                            int numPics = 15, int paddingX = 30, int paddingY = 90,
                                            int ImageWidth = 160, int ImageHeight = 180,
                                            int xOffset = 0, int yOffset = 0,
                                            int _xOffset = 1880, int _yOffset = 967,
                                            int rowLength = 6
                )
        {

            if (numPics > 18)
            {
                ImageWidth = 150; ImageHeight = 150;
                paddingX = 60; paddingY = 40;
            }






            int centerWidth = (_xOffset - xOffset) / 2 + xOffset, centerHeight = (_yOffset - yOffset) / 2 + yOffset;
            int rx, y = centerHeight, lx, counter = 0;
            int rows = (int)Math.Ceiling((double)numPics / rowLength);

            int[][] arr = new int[numPics][];
            y = y - ImageHeight - paddingY;
            if (rows == 2)
                y = y - ImageWidth * 1 - paddingY;
            else if (rows == 3)
                y = y - (int)(ImageWidth * 1.5) - paddingY;
            else if (rows == 4)
                y = y - (int)(ImageWidth * 2.1) - paddingY;


            for (int i = 0; i < rows; i++)
            {

                // Console.WriteLine("row {0}: ", i + 1);
                rx = centerWidth - ImageWidth - paddingX / 2;
                lx = centerWidth + paddingX / 2;
                y = y + ImageHeight + paddingY;


                for (int j = 0; j < rowLength / 2; j++)
                {
                    int index = i * rowLength + j * 2;
                    if (index < arr.Length)
                    {
                        if ((arr.Length % rowLength) % 2 == 1 && i == rows - 1 && j == 0)
                        {
                            rx = rx + ImageWidth / 2;
                            arr[counter] = new int[] { rx, y };
                            counter++;

                            rx = rx - ImageWidth - paddingX;
                            lx = lx + ImageWidth / 2;
                        }
                        else
                        {
                            arr[counter] = new int[] { rx, y };
                            counter++;
                            //Console.Write("left{2}({0}, {1})     ", lx, y, j);
                            arr[counter] = new int[] { lx, y };
                            counter++;
                            rx = rx - ImageWidth - paddingX;
                            lx = lx + ImageWidth + paddingX;

                        }
                    }

                }
                //Console.WriteLine();
            }


            return arr;
        }



    }
}
