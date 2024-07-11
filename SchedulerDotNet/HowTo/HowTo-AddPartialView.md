# HowTo-AddPartialView

## Summary
This HowTo is designated to showing how to setup a partial view which can be reused across
different views.

## Important Note:
All partial views shall be placed in _SchedulerDotNet/Views/Shared_. The associated styles shall 
be placed in _SchedulerDotNet/wwwroot/css_ and the assocaited view models shall be placed in
_SchedulerDotNet/Models_.

## Content
- Setup the Styles with css
- Setup the View Model for the Partial View
- Setup the Partial View
- Using the Partial View in a View without a Model
- Using the Partial View in a View with a Model

## Setup the Styles with css
In this project, each partial view shall have an associated style even if it does not need it. 
Name the style after the partial view, for example, if the partial view is called _IconInfoBox_, the 
file holding the style shall be *iconInfoBox.css*. All styles within this file shall start with the
prefix _.icon-info-box_ to keep a structured approach. The style can be linked to the partial view
by adding a link to the view, for example:
```
<link ref="stylesheet" href="~/css/iconInfoBox.css" />
```

## Setup the View Model for the Partial View
The next step is to setup the view model for this partial view, similarly, the partial view shall
have an associated view model regardless if it is needed or not, this means the view model can be just 
an empty class if needed. The naming convention is similar to that of the styles with the word _ViewModel_
at the end to distinguish it. For example, if our partial view is _IconInfoBox_, the associated view model
would be _IconInfoBoxViewModel_.

## Setup the Partial View
The partial views for this project shall always start with an underscore (_), for example, if the
partial view is _IconInfoBox_, the name of the partial view's file would be *_IconInfoBox.cshtml*.
Linking the partial view's view model to the view itself can be done as for example with the line:
```
@model SchedulerDotNot.Models.IconInfoBoxViewModel
```
This example shows that the view model for this partial view is the IconInfoBoxViewModel.

## Using the Partial View in a View without a Model
If the view being used does not have it's own view model, then the partial view's view model
can be used instead. The following would be added to the view where you want to use the 
partial view. It is better to always create a view model for every view so this is not necessary.
```
@model SchedulerDotNot.Models.IconInfoBoxViewModel
```

## Using the Partial View in a View with a Model
If the view veing used does have it's own view model, then the partial view's view model
needs to be added to the view model for the view where it is being used. For example, 
if I want to use the _ProfileStamp_ partial view in my _Team_ view, I would need to add
the _ProfileStampViewModel_ to the _TeamViewModel_. This can be done for example by:
```
class TeamViewModel 
{
    ...
    public ProfileStampViewModel ProfileStamp { get; set; }
    ...
}
```