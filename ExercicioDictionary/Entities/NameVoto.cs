using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDictionary.Entities
{
    internal class NameVoto
    {
        public string Name
        {
            get; set;
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is NameVoto))
            {
                return false;
            }
            NameVoto other = obj as NameVoto;
            return Name.Equals(other.Name);
        }
    }
}
