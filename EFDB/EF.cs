using System;
using System.Collections.Generic;
using System.Text;

namespace EFDB
{
    class EF
    {
        public int id;
        public int id_view;

        public string submit_name;
        public string submit_country;
        public string submit_contact;
        public string date_calculated;
        public string date_received;
        public string date_published;
        public List<string> gases = new List<string>();
        public List<string> ipcc1996 = new List<string>();
        public List<string> ipcc2006 = new List<string>();
        public short mi_id;
        public string mi_key;
        public short mi_id_06;
        public string mi_key_06;    
        public string prop_tech;
        public string prop_param;
        public string prop_regional;
        public string prop_control;
        public string prop_other;
        public string ef_desc;
        public string ef_value;
        public string uni_name;
        public string ef_value_cu;
        public string ef_com_unit_name;
        public string ef_equation;
        public string ipcc_sheet;
        public string source_data;
        public string tref_fullref;
        public string tref_language;
        public string tref_abstract;
        public string conf_upper;
        public string conf_lower;
        public string data_quality;
        public short distrib_id;
        public string dq_ref;
        public string dq_other_info;
        public short ef_type_id;
        public string meas_standard;
        public string meas_freq;
        public string meas_ext_qual_control;
        public string meas_date;
        public string comments_provider;
        public string comments_others;
        public string url;

        public bool skip;
    }
}
