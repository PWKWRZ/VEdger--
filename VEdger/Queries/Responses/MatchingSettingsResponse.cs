using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace VEdger.Responses
{
    public class MatchingSettingsResponse
    {
        public int maximumDistance  { get; set; }
        public int ageRange { get; set; }
        public IList<SelectListItem> fpe { get; set; }
    }
}