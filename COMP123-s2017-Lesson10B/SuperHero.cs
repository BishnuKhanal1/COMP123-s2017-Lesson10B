using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the SuperHero class
 * Version:0.1 - Created the SuperHero class
 * 
 *  GitHub Link: https://github.com/BishnuKhanal1/COMP123_s2017_Lesson10B/commits/master
 */
namespace COMP123_s2017_Lesson10B
{
    /// <summary>
    /// This is SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //Private fields
        private int _karma;

        //public properties
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }
        //constructrors
        /// <summary>
        /// This is the main constructor for SuperVillian class
        /// It taked one argument-name(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="karma"></param>

        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }
        //private methods

        //public methods
    }
}