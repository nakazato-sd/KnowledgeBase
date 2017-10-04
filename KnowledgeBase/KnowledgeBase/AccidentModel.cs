using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase
{
    [Serializable]
    public class AccidentModel
    {
        string version = "";
        string date1 = "";
        string writer = "";
        string date2 = "";

        public AccidentModel(string version, string date1, string writer, string date2)
        {
            this.version = version;
            this.date1 = date1;
            this.writer = writer;
            this.date2 = date2;
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string Date1
        {
            get
            {
                return date1;
            }

            set
            {
                date1 = value;
            }
        }

        public string Writer
        {
            get
            {
                return writer;
            }

            set
            {
                writer = value;
            }
        }

        public string Date2
        {
            get
            {
                return date2;
            }

            set
            {
                date2 = value;
            }
        }
    }
}
