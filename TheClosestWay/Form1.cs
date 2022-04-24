using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheClosestWay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool click = false;
        Button[,] kat1 = new Button[10, 10];
        Button[,] kat2 = new Button[10, 10];
        string[] letter = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        List<Mall> Places = new List<Mall>
            {
               new Mall
                {
                   PlaceName="Lift",
                   Color=Color.DarkBlue,
                   Coordinate="5,5",
                   Floor=1
                },
                new Mall
                {
                   PlaceName="Lift",
                   Color=Color.DarkBlue,
                   Coordinate="5,5",
                   Floor=2
                },
               new Mall
                {
                   PlaceName="Kiosk1",
                   Color=Color.Red,
                   Coordinate="1,6",
                   Floor=1
                },
                new Mall
                {
                   PlaceName="Kiosk2",
                   Color=Color.Red,
                   Coordinate="5,10",
                   Floor=1
                },
                 new Mall
                {
                   PlaceName="Kiosk3",
                   Color=Color.Red,
                   Coordinate="10,6",
                   Floor=1
                },
                new Mall
                {
                   PlaceName="Stairs",
                   Color=Color.Green,
                   Coordinate="5,1",
                   Floor=1
                },
                 new Mall
                {
                   PlaceName="Stairs",
                   Color=Color.Green,
                   Coordinate="5,1",
                   Floor=2
                },
                new Mall
                {
                   PlaceName="STB",
                   Color=Color.DarkGreen,
                   Coordinate="3,4",
                   Floor=1
                },
                new Mall
                {
                   PlaceName="LCW",
                   Color=Color.Blue,
                   Coordinate="7,2",
                   Floor=1
                },
                new Mall
                {
                   PlaceName="KTN",
                   Color=Color.Black,
                   Coordinate="7,8",
                   Floor=1
                },
                new Mall
                {
                   PlaceName="BGR",
                   Color=Color.Red,
                   Coordinate="6,3",
                   Floor=2
                }
            };
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Kat 1 oluşturuluyor...
            int top = 40;
            int left = 0;
            for (int i = 0; i < 11; i++)
            {
                left = 40;
                Button button = new Button();
                for (int j = 0; j < 11; j++)
                {
                    if (i != 0 && j != 0)
                    {
                        button = new Button();
                        button.Click += Button_Click_Floor1;
                        kat1[i - 1, j - 1] = button;
                        button.Name = (i).ToString() + "." + (j).ToString();
                        foreach (var place in Places.Where(x => x.Floor == 1))
                        {
                            if ((i + "," + j).ToString() == place.Coordinate)
                            {

                                button.Text = place.PlaceName;
                                button.BackColor = place.Color;
                                button.ForeColor = Color.White;
                            }
                        }
                        button.Size = new Size(40, 40);
                        left += button.Width;
                        button.Location = new Point(left, top);
                        this.Controls.Add(button);
                    }
                    else
                    {
                        button = new Button();
                        if (j == 0)
                        {
                            button.Text = i.ToString();
                        }
                        else if (i == 0)
                        {
                            button.Text = letter[j - 1];
                        }
                        button.Size = new Size(40, 40);
                        left += button.Width;
                        button.Location = new Point(left, top);
                        this.Controls.Add(button);
                    }
                }
                top += button.Height;

            }
            #endregion
            #region Kat 2 oluşturuluyor...
            top = 40;
            for (int i = 0; i < 11; i++)
            {

                left = 500;
                Button button = new Button();
                for (int j = 0; j < 11; j++)
                {
                    if (i != 0 && j != 0)
                    {
                        button = new Button();
                        button.Click += Button_Click_Floor2; ;
                        kat1[i - 1, j - 1] = button;
                        button.Name = (i).ToString() + "." + (j).ToString();
                        foreach (var place in Places.Where(x => x.Floor == 2))
                        {
                            if ((i + "," + j).ToString() == place.Coordinate)
                            {

                                button.Text = place.PlaceName;
                                button.BackColor = place.Color;
                                button.ForeColor = Color.White;
                            }
                        }
                        button.Size = new Size(40, 40);
                        left += button.Width;
                        button.Location = new Point(left, top);
                        this.Controls.Add(button);
                    }
                    else
                    {
                        button = new Button();
                        if (j == 0)
                        {
                            button.Text = i.ToString();
                        }
                        else if (i == 0)
                        {
                            button.Text = letter[j - 1];
                        }
                        button.Size = new Size(40, 40);
                        left += button.Width;
                        button.Location = new Point(left, top);
                        this.Controls.Add(button);
                    }
                }
                top += button.Height;

            }
            #endregion
        }

        private void Button_Click_Floor2(object sender, EventArgs e)
        {
            lblClosestWay.Text = "";
            lblClosestWay2.Text = "";
            lblF.Text = "";
            if (!click)
            {
                click = true;
                lblS.Text = ((Button)sender).Name;
            }
            else
            {
                click = false;
                lblF2.Text = ((Button)sender).Name;
            }
        }

        private void Button_Click_Floor1(object sender, EventArgs e)
        {
            lblClosestWay.Text = "";
            lblClosestWay2.Text = "";
            lblF2.Text = "";
            if (!click)
            {
                click = true;
                lblS.Text = ((Button)sender).Name;
            }
            else
            {
                click = false;
                lblF.Text = ((Button)sender).Name;
            }
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                string[] finish;
                int fi = 0;
                int fj = 0;
                var start = lblS.Text.Split('.');
                int si = Convert.ToInt32(start[0]);
                int sj = Convert.ToInt32(start[1]);
                lblClosestWay.Text += "[";
                if (String.IsNullOrEmpty(lblS.Text))
                {
                    MessageBox.Show("Başlangıç noktası kat1'den seçilmelidir");
                }
                if (String.IsNullOrEmpty(lblF.Text))
                {
                    finish = lblF2.Text.Split('.');
                    fi = Convert.ToInt32(finish[0]);
                    fj = Convert.ToInt32(finish[1]);

                    var liftCoord = Places.FirstOrDefault(x => x.PlaceName == "Lift").Coordinate.Split(',');
                    int liftCoordi = Convert.ToInt32(liftCoord[0]);
                    int liftCoordj = Convert.ToInt32(liftCoord[1]);
                    var stairsCoord = Places.FirstOrDefault(x => x.PlaceName == "Stairs").Coordinate.Split(',');
                    int stairsCoordi = Convert.ToInt32(stairsCoord[0]);
                    int stairsCoordj = Convert.ToInt32(stairsCoord[1]);
                    int diffLift = Math.Abs(si - liftCoordi) + Math.Abs(sj - liftCoordj);
                    int diffStairs = Math.Abs(si - stairsCoordi) + Math.Abs(sj - stairsCoordj);
                    if (diffStairs >= diffLift)
                    {

                        FindClosest1(si, sj, liftCoordi, liftCoordj);
                        lblClosestWay.Text += "Asansör Kullanınız, " + letter[liftCoordj - 1] + "" + liftCoordi + ", ";
                        FindClosest1(liftCoordi, liftCoordj, fi, fj);
                    }
                    else
                    {

                        FindClosest1(si, sj, stairsCoordi, stairsCoordj);
                        lblClosestWay.Text += "Merdiven Kullanınız, " + letter[stairsCoordj - 1] + "" + stairsCoordi + ", ";
                        FindClosest1(stairsCoordi, stairsCoordj, fi, fj);
                    }


                }
                else
                {
                    finish = lblF.Text.Split('.');
                    fi = Convert.ToInt32(finish[0]);
                    fj = Convert.ToInt32(finish[1]);
                    FindClosest1(si, sj, fi, fj);


                }

                lblClosestWay.Text += "]";
            }
            catch (Exception)
            {

                MessageBox.Show("Seçimleri doğru yaptığınızdan emin olun!");
            }

        }
        private void btnCal2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] finish;
                int fi = 0;
                int fj = 0;
                var start = lblS.Text.Split('.');
                int si = Convert.ToInt32(start[0]);
                int sj = Convert.ToInt32(start[1]);
                lblClosestWay2.Text += "[";
                if (String.IsNullOrEmpty(lblS.Text))
                {
                    MessageBox.Show("Başlangıç noktası kat1'den seçilmelidir");
                }
                if (String.IsNullOrEmpty(lblF.Text))
                {
                    finish = lblF2.Text.Split('.');
                    fi = Convert.ToInt32(finish[0]);
                    fj = Convert.ToInt32(finish[1]);

                    var liftCoord = Places.FirstOrDefault(x => x.PlaceName == "Lift").Coordinate.Split(',');
                    int liftCoordi = Convert.ToInt32(liftCoord[0]);
                    int liftCoordj = Convert.ToInt32(liftCoord[1]);
                    var stairsCoord = Places.FirstOrDefault(x => x.PlaceName == "Stairs").Coordinate.Split(',');
                    int stairsCoordi = Convert.ToInt32(stairsCoord[0]);
                    int stairsCoordj = Convert.ToInt32(stairsCoord[1]);
                    int diffLift = Math.Abs(si - liftCoordi) + Math.Abs(sj - liftCoordj);
                    int diffStairs = Math.Abs(si - stairsCoordi) + Math.Abs(sj - stairsCoordj);
                    if (diffStairs >= diffLift)
                    {

                        FindClosest2(si, sj, liftCoordi, liftCoordj);
                        lblClosestWay2.Text += "Asansör Kullanınız, " + letter[liftCoordj - 1] + "" + liftCoordi + ", ";
                        FindClosest2(liftCoordi, liftCoordj, fi, fj);
                    }
                    else
                    {

                        FindClosest2(si, sj, stairsCoordi, stairsCoordj);
                        lblClosestWay2.Text += "Merdiven Kullanınız, " + letter[stairsCoordj - 1] + "" + stairsCoordi + ", ";
                        FindClosest2(stairsCoordi, stairsCoordj, fi, fj);
                    }


                }
                else
                {
                    finish = lblF.Text.Split('.');
                    fi = Convert.ToInt32(finish[0]);
                    fj = Convert.ToInt32(finish[1]);
                    FindClosest2(si, sj, fi, fj);


                }

                lblClosestWay2.Text += "]";

            }
            catch (Exception)
            {

                MessageBox.Show("Seçimleri doğru yaptığınızdan emin olun!");
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            lblS.Text = "";
            lblF.Text = "";
            lblF2.Text = "";
        }

        private void FindClosest1(int si, int sj, int fi, int fj)
        {
            while (si < fi)
            {
                si += 1;
                lblClosestWay.Text += letter[sj - 1] + "" + si + ", ";
            }
            while (sj < fj)
            {
                sj += 1;
                lblClosestWay.Text += letter[sj - 1] + "" + si + ", ";
            }
            while (si > fi)
            {
                si -= 1;
                lblClosestWay.Text += letter[sj - 1] + "" + si + ", ";
            }
            while (sj > fj)
            {
                sj -= 1;
                lblClosestWay.Text += letter[sj - 1] + "" + si + ", ";
            }

        }
        private void FindClosest2(int si, int sj, int fi, int fj)
        {
            while (si > fi)
            {
                si -= 1;
                lblClosestWay2.Text += letter[sj - 1] + "" + si + ", ";
            }
            while (sj > fj)
            {
                sj -= 1;
                lblClosestWay2.Text += letter[sj - 1] + "" + si + ", ";
            }
            while (si < fi)
            {
                si += 1;
                lblClosestWay2.Text += letter[sj - 1] + "" + si + ", ";
            }
            while (sj < fj)
            {
                sj += 1;
                lblClosestWay2.Text += letter[sj - 1] + "" + si + ", ";
            }



        }


    }
}
