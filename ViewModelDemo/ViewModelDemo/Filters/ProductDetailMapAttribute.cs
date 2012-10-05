using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ViewModelDemo.Models;
using ViewModelDemo.ViewModels;

namespace ViewModelDemo.Filters
{
    public class ProductDetailMapAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var model = (Product)filterContext.Controller.ViewData.Model;
            var viewModel = Mapper.Map<Product, ProductDetailViewModel>(model);
            filterContext.Controller.ViewData.Model = viewModel;
        }
    }
}