using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExercicioDictionary.Entities
{
    internal class NumberVoto
    {

        public int Number { get; set; }
        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NameVoto))
            {
                return false;
            }
            NumberVoto other = obj as NumberVoto;
            return Number.Equals(other.Number);
        }
    }
}
