using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaManager.ViewModels
{
    class MainHomepageViewModel
    {
        private string _string = "Khaidepzai";

        public string khaiDepZai {
            get
            {
                return _string;

            }
            set
            {
                _string = value;
            }
        }
    }
}
