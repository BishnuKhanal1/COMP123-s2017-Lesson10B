using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the Power class
 * Version:0.0.3 - Overloaded the Power operators < and > in power class
 * 
 *  GitHub Link: https://github.com/BishnuKhanal1/COMP123_s2017_Lesson10B/commits/master
 */
namespace COMP123_s2017_Lesson10B
{
    /// <summary>
    /// This is the Power class which will be used as a Date type
    /// </summary>

    public class Power
    {
        //Public properties
        public string Name { get; set; }
        public int Rank { get; set; }

        //Public properties

        /// <summary>
        /// This is a main constructor for the Power class
        /// It takes two arguments - name(string) -rank(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }
        //public overloaded operators
        /// <summary>
        /// this method overloads the > for use with the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank > rhs.Rank</returns>
        public static bool operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank);
        }
        //public overloaded operators
        /// <summary>
        /// this method overloads the < for use with the power class
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>Returns true if lhs.Rank < rhs.Rank</returns>
        public static bool operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank);
        }
    }
}