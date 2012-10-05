using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ViewModelDemo.ViewModels
{
    public class MappedProductViewModel
    {
        [DisplayName("Product ID")]
        [HiddenInput(DisplayValue=false)]
        public int productID { get; set; }

        [Required(ErrorMessage = "Silly! - forgot the product name")]
        [DisplayName("What it's called")]
        public string name { get; set; }

        [Required(ErrorMessage = "Silly! - forgot the product description")]
        [DisplayName("What it's like")]
        public string description { get; set; }

        [Range(0.00, 999.00, ErrorMessage = "Price should be between £0 and £1000")]
        [Required(ErrorMessage = "Silly! - forgot the price")]
        [DisplayName("How much it costs")]
        public decimal? price { get; set; }   // try mapping this from currency formatted string to decimal!

        [Required(ErrorMessage = "Silly! - forgot the category")]
        [DisplayName("What kind it is")]
        public int categoryID { get; set; }

        public SelectList CategoryList { get; set; }
    }
}