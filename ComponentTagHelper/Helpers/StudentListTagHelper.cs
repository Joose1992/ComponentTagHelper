using ComponentTagHelper.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;
using TechGems.RazorComponentTagHelpers;

namespace ComponentTagHelper.Helpers
{
    [HtmlTargetElement("student-information")]
    public class StudentListTagHelper : RazorComponentTagHelper
    {
        public StudentViewModel Students { get; set; }
        
        //Here i am overriding the default rendering root
        public StudentListTagHelper() : base("~/Views/Student/Index")
        {

        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "section";
            output.Content.SetHtmlContent(
                $@"<ul><li><strong>Student Id:</strong> {Students.ID}</li>
                       <li><strong>Student Name:</strong> {Students.StudentName}</li>
                       <li><strong>Student LastName:</strong> {Students.StudentLastName}</li></ul>");
        }
    }
}
