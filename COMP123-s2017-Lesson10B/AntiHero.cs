using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: COMP123 Lesson09 Lab 24
 *  * version:0.1- This is an antihero class
 *  * Version:0. - Created anti hero class implementing IhasKarma, IhasMalice
 */
namespace COMP123_s2017_Lesson10B
{
    public class AntiHero:SuperHuman, IHasKarma, IHasMalice
    {
        //Private fields
        private int _karma;
        private int _malice;

        //private properties
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
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;

            }
        }

        

        //Constructors
        public AntiHero(string name, int karma, int malice):base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }

    }
}