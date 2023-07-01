﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// unique identifier for person
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The first name of the person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the person
        /// </summary>
        public string LastName { get; set; }


        /// <summary>
        /// The primary email of the person
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// the primary phone of the person
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
