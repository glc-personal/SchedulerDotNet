# HowTo-AddNewView

## Summary
This HowTo goes over how to add a new view to this project.

## Content
- Notes
- Create a View
- Create a Controller
- Add New Item to NavBar
- Create a Style

## Notes
In this project all views are accessible from the NavBar which is located in the Shared *_Layout.cshtml* source code. Therefore
each view will be on the NavBar itself.

## 1. Create a View
In this project, the practice is to use the most minimally concise word or words (a single word is highly prefered) as the name 
for the view. Once the name is chosen, create a folder in *SchedulerDotNet/Views* by that name. For example, if I want to create
a view that presents metrics, I might call the view *Metrics*. Then I would create a new folder *SchedulerDotNet/Views/Metrics*.
Within this folder the view can be created as an empty view called *Index.cshtml*. Replace any boilerplate with the following:
```
@{
    ViewData["Title"] = "Metrics";
}
```
Where in this example we used the *Metrics* view. This will provide at a minimum the name of the view on the browser tab when the
view is selected.

## 2. Create a Controller
In this project, the practice is to add the new controller to *SchedulerDotNet/Controllers*. The naming convention is to take the name
of the created view and append it to the word "Controller".

## 3. Add New Item to NavBar
The first modification that must be made is to the NavBar located in *_Layout.cshtml*, this can be found in _SchedulerDotNet/Views/Shared_.
Within the NavBar add a new item, for example:
```
<li class="nav-item">
    <a class="nav-link text-light" asp-area="" asp-controller="ControllerName" asp-action="Index">ViewName</a>
</li>
```
In this example *ControllerName* is the prefix to the controller, so if my view is *Home*, my controller would be called 
*HomeController*, therefore what I replace *ControllerName* with would be just *Home*. *ViewName* on the other hand can be
anything, it is what will show up as text on the NavBar, however, for this project we will use the convention of using the 
views's name. For example, if the view is called *Metrics*, we will use the *ViewName* as *Metrics*.

## 4. Create a Style
For this project, a style is prefered for each view. Therefore, once the view is created add a style guide to 
*SchedulerDotNet/wwwroot/css*, usee the name of the view to create the css file. For example, for the *Metrics* view 
the file would be *metrics.css*. Once the file is created it must be added to the *_Layout.cshtml* header. For example,
```
<link rel="stylesheet" href="~/css/metrics.css" />
```