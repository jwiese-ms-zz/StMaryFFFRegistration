using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2

{
    public class FormInfo
    {
        public string FamilyName { get; set; }
        public string YoungestChildName { get; set; }
        public bool SMPSFamily { get; set; }
        public string TeachersName { get; set; }
        public int TicketOrder { get; set; }
        public int TicketOrderCost { get; set; }

        public int VIP3rdAndUp { get; set; }
        public int VIP3rdAndUpCost { get; set; }

        public int VIP2ndAndUnder { get; set; }
        public int VIP2ndAndUnderCost { get; set; }

        public int YouthXSPink { get; set; }
        public int YouthXSBlue { get; set; }

        public int YouthSPink { get; set; }
        public int YouthSBlue { get; set; }

        public int YouthMPink { get; set; }
        public int YouthMBlue { get; set; }

        public int YouthLPink { get; set; }
        public int YouthLBlue { get; set; }

        public int YouthXLPink { get; set; }
        public int YouthXLBlue { get; set; }

        public int YouthShirtCost { get; set; }

        public int AdultSPink { get; set; }
        public int AdultSBlue { get; set; }

        public int AdultMPink { get; set; }
        public int AdultMBlue { get; set; }

        public int AdultLPink { get; set; }
        public int AdultLBlue { get; set; }


        public int AdultXLPink { get; set; }
        public int AdultXLBlue { get; set; }


        public int Adult2XLPink { get; set; }
        public int Adult2XLBlue { get; set; }

        public int Adult3XLPink { get; set; }
        public int Adult3XLBlue { get; set; }

        public int AdultShirtCost { get; set; }
        
        public int SponsorCost { get; set; }



    }

}