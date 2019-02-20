using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_dynamically_find_property
{
    /// <summary>
    /// The model with multiple raw data
    /// </summary>
    class Model
    {
        public double NamedProperty1 { get=>.33f; set { } }

        public float NamedProperty2 { get=>0.88f; set { } }

        public int NamedProperty3 { get=>int.MaxValue; set { } }

        public string NamedProperty4 { get=>DateTime.Now.ToString(); set { } }
    }
}
