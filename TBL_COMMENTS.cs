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
    
    public partial class TBL_COMMENTS
    {
        public int COMMENTS_ID { get; set; }
        public string COMMENT { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public Nullable<int> ANSWER_ID { get; set; }
        public Nullable<int> QUESTION_ID { get; set; }
        public string CREATED_BY { get; set; }
        public Nullable<System.DateTime> CREATION_DATE { get; set; }
        public Nullable<bool> IS_SEEN { get; set; }
    }
}