ViewModelDemo

summary of validation behaviour when Product domain class is self-validating, no metadata (need to uncomment that version of class in Product.cs and comment out the EF/Metadata injection class version to see this):

Create (no view model)
No HTML data attributes rendered as these depend on metadata, so client-side validation does not work for required properties, server-side validation is done, and messages shown in view after form is POSTed
However, HTMl data attribute is rendered for data type (number) of price field, so client-side validation does work when non-numeric value entered
If we violate model rule (thingy can't cost > £10) validated on server and validation summary shown

Create (embedded view model)
No HTML data attributes rendered as these depend on metadata, so client-side validation does not work for required properties, server-side validation is done, and messages shown in view after form is POSTed
However, HTMl data attribute is rendered for data type (number) of price field, so client-side validation does work when non-numeric value entered
If we violate model rule (thingy can't cost > £10) validated on server, but no validation summary shown as this is associated with Product class, not view model class. 
Can show model validation error from Product with @Html.ValidationMessageFor(model => model.Product) - have put this in instead of validation summary in this version of the view.

Create (mapped view model)
Client-side validation works as metadata for validation attributes comes from view model
Model error is not checked, so can submit and store data which violates rule (unless that rule is validated further down the layers before storing, which is not the case in sample code)