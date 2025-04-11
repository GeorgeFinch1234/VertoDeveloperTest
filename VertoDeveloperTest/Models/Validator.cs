using System.Text.RegularExpressions;

namespace VertoDeveloperTest.Models
{
    public class Validator : IValidator
    {
        public String ValidateTitle(String? title)
        {


            if (String.IsNullOrEmpty(title))
            {
                
                return "title must be a string";
            } else if (!Regex.IsMatch(title, "^[0-9A-Za-z.,? ]*$"))
            {
                return "only A-z 0-9 , . ? allowed";
            }
            else if (title.Length > 50)
            {
                return "Title is too long max length is 50 charcter";
            }
            else
            {
                return "";
            }
        }
        public String ValidateImage(IFormFile? image)
        {
            if (image == null)
            {
                return "Image is required";
            }
            else if (image.ContentType != "image/jpeg" && image.ContentType != "image/png")
            {
                return "Image must be a jpeg or png";
            }
            else
            {
                return "";
            }
        }
        public String ValidateOptionalImage(IFormFile? image)
        {
            if (image != null)
            {
                if (image.ContentType != "image/jpeg" && image.ContentType != "image/png")
                {
                    return "Image must be a jpeg or png";
                }
                else
                {
                    return "";
                }
            }
            else
            {
                return "";
            }
           
        }
    }
}
