namespace VertoDeveloperTest.Models
{
    public interface IValidator
    {
        public String ValidateTitle(String? title);
        public String ValidateImage(IFormFile? image);

        public String ValidateOptionalImage(IFormFile? image);
    }
}
