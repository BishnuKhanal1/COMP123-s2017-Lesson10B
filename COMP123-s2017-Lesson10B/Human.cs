using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the abstract human class
 * Version:0.1 - Created the Abstract Human class
 * 
 *  GitHub Link: https://github.com/BishnuKhanal1/COMP123_s2017_Lesson10B/commits/master
 */
namespace COMP123_s2017_Lesson10B
{
    /// <summary>
    /// This is the Human class
    /// </summary>
    public abstract class Human
    {
        //Private instant variables
        private string _name;

        //Public properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        //Constructors
        /// <summary>
        /// This is the main constructor for the Human class.
        /// It takes one parameter -name(string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }
        //public abstracts methods
        public abstract void DisplaySkills();

    }
}