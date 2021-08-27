<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550433/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4704)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/Sample/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/Sample/Controllers/HomeController.vb))
* [Person.cs](./CS/Sample/Models/Person.cs) (VB: [Person.vb](./VB/Sample/Models/Person.vb))
* [PersonsList.cs](./CS/Sample/Models/PersonsList.cs) (VB: [PersonsList.vb](./VB/Sample/Models/PersonsList.vb))
* **[GridViewEditingPartial.cshtml](./CS/Sample/Views/Home/GridViewEditingPartial.cshtml)**
* [Index.cshtml](./CS/Sample/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to keep EditForm always visible and close it on demand only
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4704/)**
<!-- run online end -->


<p>- Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewScriptsASPxClientGridView_BeginCallbacktopic"><u>ASPxClientGridView.BeginCallback</u></a> event;<br />
- Specify a custom argument that handles whether the EditForm should be visible after Insert/Update operations;<br />
- Handle the GridViewSettings <strong>SettingsEditing.AddNewRowRouteValues/SettingsEditing.UpdateRowRouteValues</strong> Action methods and retrieve the custom argument value. Pass this value and edited row's keyValue to the grid's PartialView via the ViewData;<br />
- Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebMvcGridViewSettings_BeforeGetCallbackResulttopic"><u>GridViewSettings.BeforeGetCallbackResult</u></a> event and check the custom parameter value. If the EditForm should stay visible, do the following:<br />
  - Retrieve the edited row's visibleIndex via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_FindVisibleIndexByKeyValuetopic"><u>MVCxGridView.FindVisibleIndexByKeyValue</u></a>;<br />
  - Start editing the just updated row via the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewASPxGridView_StartEdittopic"><u>MVCxGridView.StartEdit</u></a> method.</p>

<br/>


