using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotations_And_Garbage_Collection
{
    class Students
    {
        string name;
        int id;
        public Students(string stuName, int stuid)
        {
            this.name = stuName;
            this.id = stuid;
        }
        [NewAtteribute("Accessor","Given Student Name")]
        public string getName()
        {
            return name;
        }
        [NewAtteribute("Accessor", "Given Student Id")]
        public int getId()
        {
            return id;
        }
    }
    class Terachers
    {
        string name;
        int id;
        public Terachers(string staffName, int staffId)
        {
            this.name=staffName;
            this.id = staffId;
        }
        [NewAtteribute("Accessor", "Given Staffs Name")]
        public string getName()
        {
            return name;
        }
        [NewAtteribute("Accessor", "Given Staffs Id")]
        public int getId()
        {
            return id;
        }
    }
}
