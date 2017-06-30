using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class WorkMaterial: IModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public MaterialType Type { get; set; }
        public string ReferenceNo { get ; set; }
    }
}
