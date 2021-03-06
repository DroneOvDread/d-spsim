﻿using SpSim.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSim.Util
{
    public class ActorUtil
    {

        public static Room GetRoomById(List<Room> rooms, long targetId){
            foreach(Room r in rooms){
                if(r.Id == targetId){
                    return r;
                }
            }

            return new Room();
        }

        public static Girl GetGirlById(List<Girl> girls, long targetId)
        {
            foreach (Girl g in girls)
            {
                if (g.Id == targetId)
                {
                    return g;
                }
            }

            return girls[0];
        }

        public static Implement GetImplementById(List<Implement> implements, long targetId)
        {
            foreach (Implement i in implements)
            {
                if (i.Id == targetId)
                {
                    return i;
                }
            }

            return new Implement();
        }

        public static List<Implement> GetImplementsByRoom(List<Implement> implements, long roomId){
            List<Implement> output = new List<Implement>();

            foreach (Implement i in implements)
            {
                if (i.CurrentRoom == roomId)
                {
                    output.Add(i);
                }
            }

            return output;
        }

        public static List<Girl> GetGirlsByRoom(List<Girl> girls, long roomId)
        {
            List<Girl> output = new List<Girl>();

            foreach (Girl girl in girls)
            {
                if (girl.CurrentRoom == roomId)
                {
                    output.Add(girl);
                }
            }

            return output;
        }

        public static Clothing GetClothingById(List<Clothing> clothes, long id)
        {

            foreach (Clothing c in clothes)
            {
                if (c.Id == id)
                {
                    return c;
                }
            }

            return new Clothing();
        }

        public static Holding GetHoldingById(List<Holding> holdings, long id)
        {

            foreach (Holding h in holdings)
            {
                if (h.Id == id)
                {
                    return h;
                }
            }

            return new Holding();
        }

        public static List<Clothing> GetClothesByRoom(List<Clothing> clothes, long roomId)
        {
            List<Clothing> output = new List<Clothing>();

            foreach (Clothing c in clothes)
            {
                if (c.CurrentRoom == roomId)
                {
                    output.Add(c);
                }
            }

            return output;
        }

        public static List<long> GetClothesByTypeAndRoom(List<Clothing> clothes, ClothingType type, long roomId)
        {
            List<long> output = new List<long>();

            foreach (Clothing c in clothes)
            {
                if (c.CurrentRoom == roomId && type == c.Type)
                {
                    output.Add(c.Id);
                }
            }

            return output;
        }

        public static List<Clothing> GetClothesByTypesAndRoom(List<Clothing> clothes, List<ClothingType> types, long roomId)
        {
            List<Clothing> output = new List<Clothing>();

            foreach (Clothing c in clothes)
            {
                if (c.CurrentRoom == roomId && types.Contains(c.Type))
                {
                    output.Add(c);
                }
            }

            return output;
        }

        public static ClothingType GetClothingTypeByInt(int input)
        {
            switch (input)
            {
                case 1:
                    return ClothingType.TOP;
                    break;
                case 2:
                    return ClothingType.BOTTOM;
                    break;
                case 3:
                    return ClothingType.ONEPIECE;
                    break;
                case 4:
                    return ClothingType.BRA;
                    break;
                case 5:
                    return ClothingType.PANTIES;
                    break;
                case 6:
                    return ClothingType.SOCKS;
                    break;
                case 7:
                    return ClothingType.SHOES;
                    break;
            }

            return ClothingType.TOP;
        }

        public static UndressType GetUndressTypeByInput(string input)
        {
            switch (input)
            {
                case "down":
                    return UndressType.DOWN;
                case "off":
                    return UndressType.OFF;
                case "up":
                    return UndressType.UP;
                default: break;
            }

            return UndressType.DOWN;
        }

    }
}
