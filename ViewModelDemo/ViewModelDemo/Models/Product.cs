using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModelDemo.Models
{
    //public partial class Product : IValidatableObject
    //{
    //    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    //    {
    //        List<ValidationResult> errors = new List<ValidationResult>();

    //        if (string.IsNullOrEmpty(name))
    //        {
    //            errors.Add(new ValidationResult("(SELF)Please enter a product name",
    //                new List<string> { "name" }));
    //        }

    //        if (string.IsNullOrEmpty(description))
    //        {
    //            errors.Add(new ValidationResult("(SELF)Please enter a product description",
    //                new List<string> { "description" }));
    //        }

    //        if (string.IsNullOrEmpty(price.ToString()))
    //        {
    //            errors.Add(new ValidationResult("(SELF)Please enter a price",
    //                new List<string> { "price" }));
    //        }

    //        if (string.IsNullOrEmpty(categoryID.ToString()))
    //        {
    //            errors.Add(new ValidationResult("(SELF)Please select a catagory",
    //                new List<string> { "categoryID" }));
    //        }

    //        if (categoryID == 3 && price > 10)
    //        {
    //            errors.Add(new ValidationResult("Thingies can't cost more that £10"));
    //        }

    //        return errors;
    //    }
    //}


    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }

    public class ProductMetaData
    {
        [DisplayName("Product ID")]
        public object productID { get; set; }

        [Required(ErrorMessage = "Please enter a product name")]
        [DisplayName("Product Name")]
        public object name { get; set; }

        [Required(ErrorMessage = "Please enter a product description")]
        [DisplayName("Product Description")]
        public object description { get; set; }

        [Range(0.00, 999.00, ErrorMessage =
            "Price should be between £0 and £1000")]
        [Required(ErrorMessage = "Please enter a price")]
        [DisplayName("Product Price")]
        public object price { get; set; }

        [Required(ErrorMessage = "Please select a category")]
        [DisplayName("Category")]
        public object categoryID { get; set; }
    }
}