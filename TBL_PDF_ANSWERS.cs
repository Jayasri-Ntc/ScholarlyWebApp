//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Scholarly_Web_book
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_PDF_ANSWERS
    {
        public int ANSWER_ID { get; set; }
        public string ANSWER { get; set; }
        public Nullable<int> QUESTION_ID { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<bool> IS_FROM_PDF { get; set; }
        public string START_INDEX { get; set; }
        public string END_INDEX { get; set; }
        public string HORIZONTAL_SCROLL { get; set; }
        public string VERTICAL_SCROLL { get; set; }
    
        public virtual TBL_PDF_QUESTION_TAGS TBL_PDF_QUESTION_TAGS { get; set; }
    }
}
