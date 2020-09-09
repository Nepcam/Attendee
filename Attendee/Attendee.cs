using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendee
{
    class Attendee
    {
        #region Fields
        private int _id;
        private string _firstname;
        private string _surnname;
        private string _school;
        private int _yearLevel;
        private bool _attended;
        #endregion

        #region Constructor
        /// <summary>
        /// Initialises the object to the values passed in
        /// </summary>
        /// <param name="id">The id number of the attendee</param>
        /// <param name="firstname">The firstname of the attendee</param>
        /// <param name="surname">The surname of the attendee</param>
        /// <param name="school">The school of the attendee</param>
        /// <param name="yearLevel">The year level of the attendee</param>
        public Attendee(int id, string firstname, string surname, string school, int yearLevel)
        {
            _id = id;
            _firstname = firstname;
            _surnname = surname;
            _school = school;
            _yearLevel = yearLevel;
            _attended = false;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the id of the attendee 
        /// </summary>
        public int ID
        {
            get { return _id; }
        }

        /// <summary>
        /// Gets whether the attendee attended the event
        /// </summary>
        public bool Attended
        {
            get { return _attended; }
        }

        /// <summary>
        /// Gets and sets the surname of the attendee
        /// </summary>
        public string Surname
        {
            get { return _surnname; }
            set { _surnname = value; }
        }

        /// <summary>
        /// Gets and sets the firstname of the attendee
        /// </summary>
        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        /// <summary>
        /// Gets and sets the year level of the attendee
        /// </summary>
        public int YearLevel
        {
            get { return _yearLevel; }
            set { _yearLevel = value; }
        }

        /// <summary>
        /// Gets and sets the school of the attendee
        /// </summary>
        public string School
        {
            get { return _school; }
            set { _school = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns back all information about an attendee.
        /// </summary>
        /// <returns>All information in a neatly padded out string</returns>
        public override string ToString()
        {
            return ID.ToString().PadRight(5) + Firstname.PadRight(10) + Surname.PadRight(10) + School.PadRight(20) + YearLevel.ToString().PadRight(5) + Attended.ToString().PadRight(8) + CalcFee().ToString("c");
        }

        /// <summary>
        /// Sets the attended value to true
        /// </summary>
        public void Register()
        {
            _attended = true;
        }

        /// <summary>
        /// Gets the fee for the attendee
        /// </summary>
        /// <returns>The fees the attendee has to pay</returns>
        public decimal CalcFee()
        {
            if(_yearLevel >= 12)
            {
                return 25;
            }
            else
            {
                return 15;
            }
        }
        #endregion
    }
}
