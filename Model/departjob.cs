using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class departjob
    {
        private int jobid;

        public int Jobid
        {
            get { return jobid; }
            set { jobid = value; }
        }
        private int did;

        public int Did
        {
            get { return did; }
            set { did = value; }
        }
        private String jobname;

        public String Jobname
        {
            get { return jobname; }
            set { jobname = value; }
        }
        private int dx;

        public int Dx
        {
            get { return dx; }
            set { dx = value; }
        }

    }
}
