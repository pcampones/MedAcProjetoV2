using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOT
{
    class SearchTerm
    {
        private int rank;
        private String title;
        private String organizationName;
        private List<String> altTitles;
        private String fullSummary;

        public SearchTerm()
        {
            altTitles = new List<String>();
        }

        public int Rank
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string OrganizationName
        {
            get
            {
                return organizationName;
            }

            set
            {
                organizationName = value;
            }
        }

        public List<string> AltTitles
        {
            get
            {
                return altTitles;
            }

            set
            {
                altTitles = value;
            }
        }

        public string FullSummary
        {
            get
            {
                return fullSummary;
            }

            set
            {
                fullSummary = value;
            }
        }
    }
}
