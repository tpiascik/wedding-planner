using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wedding_Planner
{

    public class Guest
    {
        String name;
        Group inGroup;
        Food food;
        int table;
        int seatNum;
        int id;
        int idPlusOne;
        public Guest(String n,int g,int f,int i)
        {
            table = -1;
            seatNum = -1;
            id = i;
            food = (Food)f;
            inGroup = (Group)g;
            name = n;
            idPlusOne = -1;
        }
        public void addGuest(int ip)
        {
            idPlusOne = ip;
        }
        public void placeAtTable(int t)
        {
            table = t;
            seatNum = 1;
        }
        public void placeAtTable(int t, int s)
        {
            table = t;
            seatNum = s;
        }
        public int getTable()
        {
            return table;
        }
        public string giveName()
        {
            return name;
        }
        public int getGroup()
        {
            return (int)inGroup;
        }
        public void changeGroup(int g)
        {
            inGroup = (Group)g;
        }
        public int getFood()
        {
            return (int)food;
        }
        public void changeFood(int f)
        {
            food = (Food)f;
        }
        public int getID()
        {
            return id;
        }
        public int getP1()
        {
            return idPlusOne;
        }
    }
}
