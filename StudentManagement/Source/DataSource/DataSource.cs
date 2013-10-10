using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace StudentManagement.Source.DataSource
{
    public class DataSource
    {
        private XDocument _src;

        public DataSource()
        {
            _src = XDocument.Load("SampleDatabase\\sample.xml");
        }

        public DataSource(String URL)
        {
            _src = XDocument.Load(URL);
        }

        public int CoursesCount()
        {
            return 3;
        }

    }
}
