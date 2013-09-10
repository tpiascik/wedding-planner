using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wedding_Planner
{ 
        public enum Group
        {
            Friends,
            Family,
            Work,
            Forced,
            FriendofFriend,
            ExtraFamliy
        };
        public enum Food
        {
            Beef,
            Chicken,
            Fish,
            Vegitarian
        };

    public partial class Form1 : Form
    {
        List<Guest> guestList;
        int guestNum;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            guestList = new List<Guest>();
            guestNum = 0;
            groupChoice.SelectedIndex = 0;
            foodChoice.SelectedIndex = 0;
            foodChoicePlusOne.SelectedIndex = 0;
            plusOneChoice.SelectedIndex = 0;
        }

        private void showNames()
        {
            
            listGuests.Items.Clear();
            for (int i = 0; i < guestList.Count; i++)
            {
                listGuests.Items.Add(guestList[i].giveName());
            }
            numGuestLabel.Text = "Guests: " + guestList.Count;
        }
        private void showGuestsByGroup()
        {
            listGuests.Items.Clear();
            for (int g = 0; g < 6; g++)
            {
                for (int i = 0; i < guestList.Count; i++)
                {
                    if (guestList[i].getGroup()==g)
                    {
                        listGuests.Items.Add(guestList[i].giveName());
                    }
                }
            }
            //showNames();
        }
        private void addGuestButton_Click(object sender, EventArgs e)
        {
            if (nameBox.Text == null)
                return;
            if (plusOneChoice.SelectedIndex == 1 && plusOneName.Text == null)
                return;

            Guest tempGuest = new Guest(nameBox.Text,groupChoice.SelectedIndex,foodChoice.SelectedIndex,guestNum);
            guestList.Add(tempGuest);
            guestNum++;
            if (plusOneChoice.SelectedIndex == 1)
            {
                guestList[guestNum-1].addGuest(guestNum);
                tempGuest = new Guest(plusOneName.Text, groupChoice.SelectedIndex, foodChoicePlusOne.SelectedIndex, guestNum);
                tempGuest.addGuest(guestNum-1);
                guestList.Add(tempGuest);
                guestNum++;
                
            }
            nameBox.Text = null;
            plusOneName.Text = null;
            plusOneChoice.SelectedIndex = 0;
            plusOneChoice_SelectedIndexChanged(sender, e);
            groupChoice.SelectedIndex = 0;
            foodChoicePlusOne.SelectedIndex = 0;

            showNames();
            nameBox.Focus();
        }

        private void plusOneChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (plusOneChoice.SelectedIndex == 0)
            {
                plusOneLabel.Visible = false;
                plusOneName.Visible = false;
                foodLabel2.Visible = false;
                foodChoicePlusOne.Visible = false;
            }
            else 
            {
                plusOneLabel.Visible = true;
                plusOneName.Visible = true;
                foodLabel2.Visible = true;
                foodChoicePlusOne.Visible = true;
            }
        }

        private void byGroup_Click(object sender, EventArgs e)
        {
            showGuestsByGroup();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (guestList.Count == 0 || listGuests.SelectedIndex < 0)
                return;
            int kickEm = selectedID();

            for (int i = 0; i < guestList.Count; i++)
            {
                if (kickEm == guestList[i].getID())
                {
                    if (guestList[i].getP1() > 0)
                    {
                        if (guestList[i + 1].getID() == guestList[i].getP1())
                        {
                            guestList.RemoveAt(i + 1);

                        }
                    }
                    guestList.RemoveAt(i);
                }
            }
            showNames();
        }

        private int selectedID()
        {
            for (int index = 0; index < guestList.Count; index++)
            {
                if (guestList[index].giveName() == listGuests.SelectedItem.ToString())
                {
                    return index;
                }
            }
            return -1;

        }

        private void listGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            int guestNum = guestList[listGuests.SelectedIndex].getID();
            //string compare to get correct item to id pair
            infoLabel.Text = "";

            guestNum = selectedID();

            infoLabel.Text += guestList[guestNum].giveName();
            infoLabel.Text += System.Environment.NewLine;
            infoLabel.Text += (Food)guestList[guestNum].getFood();
            infoLabel.Text += System.Environment.NewLine;
            infoLabel.Text += (Group)guestList[guestNum].getGroup();
            if(guestList[guestNum].getTable()>0)//only show table info if assigned
            {
                infoLabel.Text += System.Environment.NewLine;
                infoLabel.Text += "Table " +guestList[guestNum].getTable().ToString();
            }

            SeatGuest.Visible = true;
            seatGuestatTable.Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string lines = null;

            System.IO.StreamWriter file = new System.IO.StreamWriter("guests.txt");
            file.WriteLine("ID Name Group Food P1");
            foreach( Guest g in guestList)
            {
                lines += g.getID().ToString()+" ";
                lines += g.giveName() + " ";
                lines += g.getGroup().ToString() + " ";
                lines += g.getFood().ToString() + " ";
                lines += g.getP1().ToString()+ " ";
                lines += g.getTable();
                file.WriteLine(lines);
                lines = null;
            }
            

            file.Close();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("Guests.txt"))
                {
                    reset();
                    String line= sr.ReadLine();
                    while(line!=null)
                    {
                        line = sr.ReadLine();
                        String[] data =  line.Split(' ');
                        guestList.Add(new Guest(data[1],Convert.ToInt32(data[2]),Convert.ToInt32(data[3]),Convert.ToInt32(data[0])));
                        guestList[Convert.ToInt32(data[0])].addGuest(Convert.ToInt32(data[4]));
                        guestList[Convert.ToInt32(data[0])].placeAtTable(Convert.ToInt32(data[5]));
                        guestNum++;
                    }

                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
            showNames(); 
        }

        private void SeatGuest_Click(object sender, EventArgs e)
        {
            if (seatGuestatTable.SelectedIndex >= 0)
            {
                guestList[listGuests.SelectedIndex].placeAtTable(seatGuestatTable.SelectedIndex+1);
                if (guestList[listGuests.SelectedIndex].getP1() != -1)
                    guestList[guestList[listGuests.SelectedIndex].getP1()].placeAtTable(seatGuestatTable.SelectedIndex+1);
            }
        }

        private void tablePic_Click(object sender, EventArgs e)
        {
            if (MousePosition.X > tablePic.Location.X && MousePosition.Y > tablePic.Location.Y)
            { 

            }
        }

        private void billButton_Click(object sender, EventArgs e)
        {
            if (guestList.Count <= 0)
                return;
            this.Hide();
            this.AddOwnedForm(new Form2(guestList));
            this.OwnedForms[0].Show();
        }
    }
}
