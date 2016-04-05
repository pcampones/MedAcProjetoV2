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
        private string title;
        private string organizationName;
        private List<string> altTitles;
        private string fullSummary;

        public SearchTerm()
        {
            altTitles = new List<String>();

        }

        public SearchTerm(int rank, string title, string organizationName, List<string> altTitles, string fullSummary)
        {
            this.altTitles = new List<String>();
            this.rank = rank;
            this.title = title;
            this.organizationName = organizationName;
            this.fullSummary = fullSummary;
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
