using System;

namespace Member
{
    public class memberLogin
    {
        public memberLogin()
        {
            // Default 

        }


        #region User provided information


        /// <summary>
        /// member_id: 
        /// </summary>
        public string member_id { get; set; }

        /// <summary>
        /// name/nick name
        /// </summary>
        public string member_name { get; set; }

        /// <summary>
        /// email
        /// </summary>
        public string member_email { get; set; }

        /// <summary>
        /// the site user registered member
        /// </summary>
        public string member_site { get; set; }

        /// <summary>
        /// password
        /// </summary>
        public string member_pwd { get; set; }

        /// <summary>
        /// member location
        /// </summary>
        public string member_location { get; set; }

        #endregion

    }
}

