using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{

    // Simple business object. A PartId is used to identify the type of part
    // but the part name can change.
    public class Info : IEquatable<Info>, IComparable<Info>
    {
        public string InfoName { get; set; }

        public int InfoId { get; set; }

        public override string ToString()
        {
            return "Info Id: " + InfoId + " Info Name: " + InfoName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Info objAsPart = obj as Info;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public int SortByNameAscending(string name1, string name2)
        {

            return name1.CompareTo(name2);
        }

        // Default comparer for Part type.
        public int CompareTo(Info comparePart)
        {
            // A null value means that this object is greater.
            if (comparePart == null)
                return 1;

            else
                return this.InfoId.CompareTo(comparePart.InfoId);
        }
        public override int GetHashCode()
        {
            return InfoId;
        }
        public bool Equals(Info other)
        {
            if (other == null) return false;
            return (this.InfoId.Equals(other.InfoId));
        }
        // Should also override == and != operators.
    }
}
