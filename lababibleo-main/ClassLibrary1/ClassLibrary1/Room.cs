using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Room
    {
        double roomLength; //длина
        double roomWidth;  //ширина

        public double RoomLength
        {
            get { return roomLength; }
            set { roomLength = value;}
        }

        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value;} 
        }

        /// <summary>
        /// метдо выч. периметр комнаты
        /// </summary>
        /// <returns>возвращ. значение периметра</returns>
        public double RoomPerimeter()
        {
          return 2 * (RoomLength + RoomWidth);
        }

        /// <summary>
        /// метод выч. площадь комнаты
        /// </summary>
        /// <returns>возвращ. значение площади</returns>
        public double RoomArea()
        {
            return roomLength * roomWidth;
        }

        /// <summary>
        /// метод выч. кол-во кв.метров на 1 человека
        /// </summary>
        /// <param name="np"></param>
        /// <returns>возвращ. число кв метров</returns>
        public double  PersonArea(int np)
        {
            return RoomArea() / np;
        }

    
    }
}
