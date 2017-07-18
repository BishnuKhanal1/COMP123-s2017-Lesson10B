using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* Name: Bishnu Khanal
 * Date: July 13, 2017
 * Description: This is the SuperHuman class
 * Version:0.8 - Added private _getPowerIndex methos 
 * 
 *  GitHub Link: https://github.com/BishnuKhanal1/COMP123_s2017_Lesson10B/commits/master           
 */
namespace COMP123_s2017_Lesson10B
{
    /// <summary>
    /// This s the SuperHuman class
    /// </summary>
    public class SuperHuman : Human
    {
        //Private instant variables
        private List<Power> _powers;
        //Public properties
        public List<Power> Powers
        {
            get
            {
                return this._powers;
            }
        }
        //Constructor
        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialized();
        }
        //Private Methods
        /// <summary>
        /// This method initializes, instantiates and assigns values to class properties
        /// </summary>
        private void _initialized()
        {
            this._powers = new List<Power>();//creates an empty list
        }
        /// <summary>
        /// This private method returns the index of the Power in the Power List
        /// if not found it returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int _getPowerIndex(string name)
        {
            int index = 0;
            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;
                if (this.Powers.Count==index)
                {
                    index = -1; //this means we did not find the power in the list
                }
            }
            return index;
        }
        //Public Methods

        /// <summary>
        /// This method adds a power to the power list
        /// It takes two parameters- name(string)- rank(int) 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }
        /// <summary>
        /// This method displays each of the power listed in Power list
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + "Rank: " + power.Rank);
            }
        }
        /// <summary>
        /// Overridden the built-in ToString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputstring = "";
            outputstring += "======================================\n";
            outputstring += "SuperHuman Name: " + this.Name + "\n";
            outputstring += "=======================================\n";
            foreach (Power power in this.Powers)
            {
                outputstring += "Power: " + power.Name + " Rank: " + power.Rank + "\n";

            }
            outputstring += "=======================================\n";
            return outputstring;
        }
        /// <summary>
        /// This is the Displayskill method
        /// Needs to be implemented
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented");
        }
    }
}