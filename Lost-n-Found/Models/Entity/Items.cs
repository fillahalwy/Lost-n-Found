using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_n_Found.Models.Entity
{
    internal class Items
    {
        public int Id_item { get; set; }
        public int Id_user { get; set; }
        public int Id_category { get; set; }
        public string Item_name { get; set; }
        public string Item_img { get; set; }
        public string Item_description { get; set; }
        public DateTime Item_date { get; set; }
        public string Item_location { get; set; }
        public string Item_note { get; set; }
        public string Item_type { get; set; }
        public string Item_status { get; set; }
        public string Created_at { get; set; }
        public string Updated_at { get; set; }
    }
}
